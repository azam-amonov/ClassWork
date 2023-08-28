// See https://aka.ms/new-console-template for more information

using Dars_33_C29_2.Class;
using Dars_33_C29_2.Practice;

Console.WriteLine("Is running!");

#region Practice
// var youTubeDownloader = new YouTubeVideoDownloaderAsync();
// await youTubeDownloader.DownloadVideo("hhttps://youtube.com/shorts/ublPpbU1_74?si=tSIYA9ZZWZT1YUzI");
#endregion
//              
// var customers = new List<Customer>();
// customers.Add(new(20, "John", "Smith", Country.Uzbekistan));
// customers.Add(new(10, "Jane", "Johnson", Country.USA));
// customers.Add(new(30, "Michael", "Brown", Country.UK));
// customers.Add(new(16, "David", "Lee", Country.Germany));
//
// var orders = new List<Order>();
//
// orders.Add(new(0, 20, 5890, new DateTime(2023, 4, 17)));
// orders.Add(new(1, 16, 9947, new DateTime(2023, 7, 3)));
// orders.Add(new(2, 30, 8054, new DateTime(2023, 2, 22)));
// orders.Add(new(3, 20, 8054, new DateTime(2023, 2, 22)));

// var grouped = customers.GroupJoin(orders, 
//                 client => client.Id,
//                 order => order.CustomerId,
//                 (customer, ordersB) => new 
//                 { 
//                     CustomerId = customer.Id,
//                     CustomerFirsName = customer.FirstName,
//                     CustomerLastName = customer.LastName,
//                     CustomerCountry = customer.Country,
//                     OrderId = ordersB.Where(e => e.CustomerId == customer.Id),
//                     OrderAmount = ordersB.Where(e => e.Amount >= 5000),
//                     OrdaredLalsMonth = ordersB.Where(e => e.OrderDate <= DateTime.Now.AddDays(-30))
//                                 
//                 });
//
// var countryGroup = grouped.GroupBy(c => 
//                 c.CustomerCountry).AsQueryable();
//
// var filter = countryGroup.Where(g =>
//                 g.All(b => b.CustomerCountry == Country.UK));
//

var result = new CustomerAndOrder(); 
result.Filtered();        