using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LINQ_DB
{
    public class Queries
    { 
        public static List<Concert> orderedBy_Date(List<Concert> concerts) {
            return concerts 
                .OrderBy(concert => concert.Date)
                .ToList();
        }

        public static List<Concert> reducedVenue_Concerts(List<Concert> concerts)
        {
            return concerts
                .Where(concert => concert.ReducedVenue = true)
                .ToList();
        }

        public static List<Concert> concerts_2024(List<Concert> concerts)
        {
            return concerts
                .Where(concert => concert.Date.Year == 2024)
                .ToList();
        }

        public static List<Concert> biggest_ProtectedSales(List<Concert> concerts)
        {
            return concerts
                .OrderByDescending(concert => concert.FullCapacitySales)
                .Take(5)
                .ToList();
        }

        public static List<Concert> friday_Concerts(List<Concert> concerts)
        {
            return concerts
                .Where(concert => concert.Date.DayOfWeek == DayOfWeek.Friday)
                .ToList();
        }

    }

}
