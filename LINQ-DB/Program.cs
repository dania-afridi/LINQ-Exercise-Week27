﻿// See https://aka.ms/new-console-template for more information
using LINQ_DB;
using System.Text.Json;



internal class Program
{

    private static void Main(string[] args)
    {
        //---------------------------------JSON String Format Data Array---------------------//
        string concertData =
 """ 
    [{"Id":1,"ReducedVenue":false,"Date":"2022-10-16T00:00:00","Performer":"Ondricka, Walsh and Morissette","BeginsAt":18,"FullCapacitySales":1832880},
{"Id":2,"ReducedVenue":false,"Date":"2023-07-09T00:00:00","Performer":"Ryan-Lynch","BeginsAt":12,"FullCapacitySales":1365810},
{"Id":3,"ReducedVenue":false,"Date":"2023-06-19T00:00:00","Performer":"Williamson Group","BeginsAt":12,"FullCapacitySales":1691580},
{"Id":4,"ReducedVenue":false,"Date":"2023-09-23T00:00:00","Performer":"Collier-Witting","BeginsAt":10,"FullCapacitySales":1913370},
{"Id":5,"ReducedVenue":true,"Date":"2023-11-21T00:00:00","Performer":"Hettinger-Greenholt","BeginsAt":20,"FullCapacitySales":1089590},
{"Id":6,"ReducedVenue":true,"Date":"2025-04-18T00:00:00","Performer":"Hansen Group","BeginsAt":13,"FullCapacitySales":1076040},
{"Id":7,"ReducedVenue":true,"Date":"2022-10-15T00:00:00","Performer":"Schmidt, Witting and Skiles","BeginsAt":17,"FullCapacitySales":2713630},
{"Id":8,"ReducedVenue":false,"Date":"2023-05-16T00:00:00","Performer":"Gibson, Hintz and Hagenes","BeginsAt":15,"FullCapacitySales":2050350},
{"Id":9,"ReducedVenue":false,"Date":"2024-05-12T00:00:00","Performer":"Kirlin LLC","BeginsAt":19,"FullCapacitySales":1203390},
{"Id":10,"ReducedVenue":true,"Date":"2025-09-01T00:00:00","Performer":"Weimann-Rippin","BeginsAt":14,"FullCapacitySales":1267490},
{"Id":11,"ReducedVenue":true,"Date":"2025-09-21T00:00:00","Performer":"Hilll-Farrell","BeginsAt":19,"FullCapacitySales":979280},
{"Id":12,"ReducedVenue":false,"Date":"2023-01-02T00:00:00","Performer":"Kuvalis Group","BeginsAt":14,"FullCapacitySales":2210270},
{"Id":13,"ReducedVenue":false,"Date":"2025-02-13T00:00:00","Performer":"Jakubowski, Hagenes and Brekke","BeginsAt":14,"FullCapacitySales":2411540},
{"Id":14,"ReducedVenue":true,"Date":"2024-05-09T00:00:00","Performer":"Kozey-Cruickshank","BeginsAt":13,"FullCapacitySales":2420460},
{"Id":15,"ReducedVenue":false,"Date":"2023-03-07T00:00:00","Performer":"Green, Krajcik and Beahan","BeginsAt":12,"FullCapacitySales":3146700},
{"Id":16,"ReducedVenue":false,"Date":"2024-08-22T00:00:00","Performer":"Gusikowski, Kertzmann and Stamm","BeginsAt":10,"FullCapacitySales":770840},
{"Id":17,"ReducedVenue":false,"Date":"2023-09-11T00:00:00","Performer":"Prosacco Group","BeginsAt":15,"FullCapacitySales":3107510},
{"Id":18,"ReducedVenue":true,"Date":"2023-01-13T00:00:00","Performer":"Stokes, Hackett and Wiza","BeginsAt":11,"FullCapacitySales":2138240},
{"Id":19,"ReducedVenue":true,"Date":"2023-03-17T00:00:00","Performer":"Nolan-Stehr","BeginsAt":12,"FullCapacitySales":2319230},
{"Id":20,"ReducedVenue":true,"Date":"2023-05-22T00:00:00","Performer":"Swift-Prosacco","BeginsAt":13,"FullCapacitySales":1660550},
{"Id":21,"ReducedVenue":true,"Date":"2023-12-02T00:00:00","Performer":"Boehm, Mohr and Kohler","BeginsAt":10,"FullCapacitySales":1736830},
{"Id":22,"ReducedVenue":true,"Date":"2024-04-21T00:00:00","Performer":"Cartwright, McDermott and Stracke","BeginsAt":18,"FullCapacitySales":1862910},
{"Id":23,"ReducedVenue":false,"Date":"2024-06-25T00:00:00","Performer":"Wunsch-Becker","BeginsAt":18,"FullCapacitySales":1736780},
{"Id":24,"ReducedVenue":true,"Date":"2025-06-28T00:00:00","Performer":"Lehner-Crist","BeginsAt":13,"FullCapacitySales":827960},
{"Id":25,"ReducedVenue":false,"Date":"2024-04-15T00:00:00","Performer":"Kutch, Schmitt and Schmitt","BeginsAt":18,"FullCapacitySales":1138840}] 
""";

        //--------------------------------- DATA CONVERTED TO LIST ---------------------//

        List<Concert> concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);
        Console.WriteLine("-----*** DATA CONVERTED TO LIST ***-----\n");
        foreach(var concert in concerts)
        {
            Console.WriteLine(concert.Id +", "+ concert.ReducedVenue +", "+ concert.Date +", "
               + concert.Performer +", "+ concert.BeginsAt +", "+ concert.FullCapacitySales +"\n");
        }

        //--------------------------------- CONCERTS ORDERED BY DATE ---------------------//

        List<Concert> Concerts_OrderedByDate = Queries.orderedBy_Date(concerts);
        Console.WriteLine("-----*** CONCERTS ORDERED BY DATE ***-----\n");

        foreach (var concert in Concerts_OrderedByDate)
        {
            Console.WriteLine(concert.Id +", "+ concert.Performer +", "+ concert.Date +"\n");
        }

        //--------------------------------- CONCERTS HAVING REDUCED VENUE ---------------------//

        List<Concert> ReducedVenue_Concerts = Queries.reducedVenue_Concerts(concerts);
        Console.WriteLine("-----*** CONCERTS HAVING REDUCED VENUE ***-----\n");

        foreach (var concert in ReducedVenue_Concerts)
        {
            Console.WriteLine(concert.Id +", "+ concert.Performer +", "+ concert.ReducedVenue + "\n");
        }

        //--------------------------------- CONCERTS OF YEAR 2024 ---------------------//

        List<Concert> Year2024_Concerts = Queries.concerts_2024(concerts);
        Console.WriteLine("-----*** CONCERTS OF YEAR 2024 ***-----\n");

        foreach (var concert in Year2024_Concerts)
        {
            Console.WriteLine(concert.Id +", "+ concert.Performer +", "+ concert.Date +"\n");
        }

        //--------------------------------- CONCERTS HAVING BIGGEST PROTECTED SALES ---------------------//

        List<Concert> Biggest_Concerts = Queries.biggest_ProtectedSales(concerts);
        Console.WriteLine("-----*** CONCERTS HAVING BIGGEST PROTECTED SALES ***-----\n");

        foreach (var concert in Biggest_Concerts)
        {
            Console.WriteLine(concert.Id + ", " + concert.Performer + ", " + concert.FullCapacitySales + "\n");
        }
        
        //--------------------------------- FRIDAY CONCERTS ---------------------//

        List<Concert> Friday_Concerts = Queries.friday_Concerts(concerts);
        Console.WriteLine("-----*** CONCERTS HELD ON FRIDAY ***-----\n");

        foreach (var concert in Friday_Concerts)
        {
            Console.WriteLine(concert.Id + ", " + concert.Performer + ", " + concert.Date + "\n");
        }


    }
}