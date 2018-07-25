namespace DiningInsights
{
    public class Entree
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        // Bit map.
        public int DaysOfWeekAvailable { get; set; }
    }
}