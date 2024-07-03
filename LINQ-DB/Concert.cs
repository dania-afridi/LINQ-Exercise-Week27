using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DB
{
    public class Concert
    {
        public int Id { get; set; }
        public bool ReducedVenue { get; set; }
        public DateTime Date {  get; set; }
        public string Performer { get; set; }
        public int BeginsAt { get; set; }
        public int FullCapacitySales { get; set; }
        
        public Concert(int id, bool reducedVenue, DateTime date, string performer, int beginsAt, int fullCapacitySales) {
            Id = id;
            ReducedVenue = reducedVenue;
            Date = date;
            Performer = performer;
            BeginsAt = beginsAt;
            FullCapacitySales = fullCapacitySales;
        }
    }
}
