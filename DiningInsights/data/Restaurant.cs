using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiningInsights
{
    public class Restaurant
    {
        [Required, StringLength(100)]
        [Key]
        public string Name { get; set; }

        public string FoodType { get; set; }

        public bool isFavorite { get; set; }

        public Cafes Cafe { get; set; }

        //public List<Entree> Entrees { get; set; }

        // Restaurant will be at different cafes, depends on current day of week.
        //public int[] Locations { get; set; }
    }

    public enum DayOfWeek {Mon, Tue, Wed, Thu, Fri, Sat, Sun};

    public enum Cafes {Cafe4, Cafe9, Cafe16, Cafe25, Cafe26, Cafe31, Cafe34, 
        Cafe36, Cafe37, Cafe40_41, Cafe43, Cafe50, Cafe83, Cafe86, Cafe92, 
        Cafe99, Cafe109, Cafe112, Cafe121, CafeAdvantaA, CafeBravern1, CafeBravern2, 
        CafeCCP, CafeLS, CafeME, CafeRedwF, CafeRTC5, CafeSammC, CafeH, CafeX};
}
