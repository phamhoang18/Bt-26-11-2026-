using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class AtmStationBUS
    {
        private readonly AtmStationDAL _dal = new AtmStationDAL();

        public List<AtmStationDTO> GetAll()
        {
            return _dal.GetAllStations();
        }

        public bool SaveStation(AtmStationDTO station, out string errorMsg)
        {
            if (string.IsNullOrWhiteSpace(station.StationCode))
            {
                errorMsg = "Mã trạm ATM không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(station.Address))
            {
                errorMsg = "Địa chỉ đặt máy không được để trống!";
                return false;
            }
            if (station.CurrentBalance < 0)
            {
                errorMsg = "Số tiền tồn quỹ không được âm!";
                return false;
            }

            errorMsg = string.Empty;
            return _dal.InsertOrUpdateStation(station);
        }
    }
}