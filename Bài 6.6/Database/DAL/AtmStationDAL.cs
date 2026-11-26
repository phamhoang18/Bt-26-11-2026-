using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class AtmStationDAL
    {
        public List<AtmStationDTO> GetAllStations()
        {
            var list = new List<AtmStationDTO>();
            string query = "SELECT StationCode, Address, CurrentBalance, Status, ImagePath FROM AtmStations";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AtmStationDTO
                        {
                            StationCode = reader["StationCode"].ToString(),
                            Address = reader["Address"].ToString(),
                            CurrentBalance = Convert.ToDecimal(reader["CurrentBalance"]),
                            Status = reader["Status"].ToString(),
                            ImagePath = reader["ImagePath"] == DBNull.Value ? null : reader["ImagePath"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool InsertOrUpdateStation(AtmStationDTO station)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM AtmStations WHERE StationCode = @Code)
                    UPDATE AtmStations 
                    SET Address = @Address, CurrentBalance = @Balance, Status = @Status, ImagePath = @Img
                    WHERE StationCode = @Code
                ELSE
                    INSERT INTO AtmStations (StationCode, Address, CurrentBalance, Status, ImagePath)
                    VALUES (@Code, @Address, @Balance, @Status, @Img)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", station.StationCode);
                    cmd.Parameters.AddWithValue("@Address", station.Address);
                    cmd.Parameters.AddWithValue("@Balance", station.CurrentBalance);
                    cmd.Parameters.AddWithValue("@Status", station.Status);
                    cmd.Parameters.AddWithValue("@Img", (object)station.ImagePath ?? DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}