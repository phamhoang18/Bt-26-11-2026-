USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BankAtmDB')
BEGIN
    ALTER DATABASE BankAtmDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE BankAtmDB;
END
GO
CREATE DATABASE BankAtmDB;
GO
USE BankAtmDB;
GO

-- Bảng quản lý Trạm ATM
CREATE TABLE AtmStations (
    StationCode VARCHAR(20) PRIMARY KEY,
    Address NVARCHAR(255) NOT NULL,
    CurrentBalance DECIMAL(18, 2) NOT NULL DEFAULT 0,
    Status NVARCHAR(50) NOT NULL, -- 'Hoạt động', 'Bảo trì', 'Hết tiền'
    ImagePath NVARCHAR(500) NULL
);
GO

-- Bảng lưu lịch sử đối soát cuối ngày
CREATE TABLE ReconciliationLogs (
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    ReconcileDate DATETIME NOT NULL DEFAULT GETDATE(),
    TotalTransactions INT NOT NULL,
    MatchedCount INT NOT NULL,
    DiscrepancyCount INT NOT NULL,
    Status NVARCHAR(100) NOT NULL
);
GO

-- Dữ liệu mẫu
INSERT INTO AtmStations (StationCode, Address, CurrentBalance, Status, ImagePath) VALUES
('ATM-HN01', N'198 Trần Quang Khải, Hoàn Kiếm, Hà Nội', 1250000000, N'Hoạt động', NULL),
('ATM-HN02', N'54 Liễu Giai, Ba Đình, Hà Nội', 450000000, N'Hoạt động', NULL),
('ATM-HCM01', N'115 Nguyễn Huệ, Quận 1, TP.HCM', 50000000, N'Sắp hết tiền', NULL),
('ATM-DN01', N'36 Bạch Đằng, Hải Châu, Đà Nẵng', 0, N'Bảo trì', NULL);
GO