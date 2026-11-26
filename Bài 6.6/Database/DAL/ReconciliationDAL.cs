using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ReconciliationDAL
    {
        public void SaveReconciliationLog(ReconciliationResultDTO log)
        {
            string query = @"
                INSERT INTO ReconciliationLogs (ReconcileDate, TotalTransactions, MatchedCount, DiscrepancyCount, Status)
                VALUES (@Date, @Total, @Matched, @Discrepancy, @Status)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", log.ReconcileDate);
                    cmd.Parameters.AddWithValue("@Total", log.TotalTransactions);
                    cmd.Parameters.AddWithValue("@Matched", log.MatchedCount);
                    cmd.Parameters.AddWithValue("@Discrepancy", log.DiscrepancyCount);
                    cmd.Parameters.AddWithValue("@Status", log.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}