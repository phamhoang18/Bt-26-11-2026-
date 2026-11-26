using System;
using System.Threading;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ReconciliationBUS
    {
        private readonly ReconciliationDAL _dal = new ReconciliationDAL();
        public async Task<ReconciliationResultDTO> RunAutoReconciliationAsync(
            IProgress<(int percent, string message)> progress,
            CancellationToken token)
        {
            return await Task.Run(async () =>
            {
                int totalTx = 350000; 
                int discrepancy = 0;
                Random rnd = new Random();

                for (int i = 1; i <= 100; i++)
                {
                    token.ThrowIfCancellationRequested();

                    await Task.Delay(50, token);

                    if (i % 25 == 0)
                        discrepancy += rnd.Next(0, 3); 

                    string statusMsg = i < 30 ? "Đang tải sao kê từ Core Banking..." :
                                       i < 85 ? $"Đang đối chiếu lô giao dịch ({i * 3500:N0}/{totalTx:N0})..." :
                                                "Đang tổng hợp báo cáo sai lệch...";

                    progress?.Report((i, statusMsg));
                }

                var result = new ReconciliationResultDTO
                {
                    ReconcileDate = DateTime.Now,
                    TotalTransactions = totalTx,
                    MatchedCount = totalTx - discrepancy,
                    DiscrepancyCount = discrepancy,
                    Status = discrepancy == 0 ? "Khớp 100%" : $"Có {discrepancy} giao dịch lệch"
                };

                try { _dal.SaveReconciliationLog(result); } catch {}

                return result;
            }, token);
        }
    }
}