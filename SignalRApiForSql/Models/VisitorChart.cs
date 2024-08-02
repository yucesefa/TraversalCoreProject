namespace SignalRApiForSql.Models
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Count = new List<int>();
        }
        public string VisitDate { get; set; }
        public List<int> Count { get; set; }
    }
}
