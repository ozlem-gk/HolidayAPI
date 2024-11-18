namespace HolidayAPI
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public List<string> States { get; set; }
        public string Type { get; set; } // Type of the holiday
    }
}
