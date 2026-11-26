namespace DTO
{
    public class AtmStationDTO
    {
        public string StationCode { get; set; }
        public string Address { get; set; }
        public decimal CurrentBalance { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
    }
}