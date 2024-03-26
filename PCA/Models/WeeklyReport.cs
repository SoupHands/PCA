namespace PCA.Models
{
    public class WeeklyReport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalHours { get; set; }
        public bool Approved { get; set; }
    }
}
