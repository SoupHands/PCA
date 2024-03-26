namespace PCA.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hours { get; set; }
        public bool Approved { get; set; }
    }
}
