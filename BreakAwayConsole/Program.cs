using BreakAwayConsole.Models;
using BreakAwayConsole.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace BreakAwayConsole
{
    class Program
    {
        private static BreakAwayContext context = new BreakAwayContext();
        static void Main(string[] args)
        {
            InsertRelationalData();
            // DatabaseInfo();
            // InsertDestination();
        }

        private static void DatabaseInfo()
        {
            context.Database.EnsureCreated();
            Console.WriteLine("Database provider = {0}", context.Database.ProviderName);
            Console.WriteLine("can connect to database {0}", context.Database.CanConnect());
            var getannot = context.Model.GetAnnotations().ToList();
            foreach (var item in getannot)
            {
                Console.WriteLine(item.Name + " " + item.Value);
            }
        }

        private static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Baili",
                DestinationName = "Bali",
                Photo = new Byte[] { 0 }
            };
            using (var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }

        private static void InsertRelationalData()
        {
            Lodging[] lodgings = new Lodging[]
            {
                        new Lodging
                    {

                        LodgingName = "Grand Hotel",
                        Owner = "Marriot",
                        IsResort = true,
                        Destination = new Destination
                        {
                                DestinationName = "Bali",
                            Country = "Indonesia",
                            Description = "EcoTourism at its best in exquisite Baili",
                            Photo = new byte[] { 0 }
                        }
                    },
                    new Lodging
                    {                    
                        LodgingName = "Doubletree",
                        Owner = "Doubletree",
                        IsResort = false,
                        Destination = new Destination
                        {
                            Country = "France",
                            Description = "The City That Never Sleeps",
                            DestinationName = "Paris",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "Hotel Rouge",
                        Owner = "Hotel Rouge",
                        IsResort = false,
                        Destination = new Destination
                        {
                            Country = "USA",
                            Description = "The Big Apple",
                            DestinationName = "New York",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "Hotel Fisk",
                        Owner = "Hotel Fisk",
                        IsResort = true,
                        Destination = new Destination
                        {
                            Country = "London",
                            Description = "The Big City",
                            DestinationName = "England",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "French Resort",
                        Owner = "Hotel Indigo",
                        IsResort = true,
                        Destination = new Destination
                        {
                            Country = "France",
                            Description = "The City That Never Sleeps",
                            DestinationName = "Paris",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "Hotel Tuscany",
                        Owner = "Hotel Tuscany",
                        IsResort = true,
                        Destination = new Destination
                        {
                            Country = "Italy",
                            Description = "The Eternal City",
                            DestinationName = "Italy",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "Hotel Brazil",
                        Owner = "Hotel Brazil",
                        IsResort = false,
                        Destination = new Destination
                        {
                            Country = "Rio De Janeiro",
                            Description = "Paradise in the South of Brazil",
                            DestinationName = "Brazil",
                            Photo = new Byte[] { 0 }
                        }

                    },
                    new Lodging
                    {
                        LodgingName = "Hotel Istanbul",
                        Owner = "Hotel Istanbul",
                        IsResort = true,
                        Destination = new Destination
                        {
                            Country = "Turkey",
                            Description = "The City of Lights",
                            DestinationName = "Istanbul",
                            Photo = new Byte[] { 0 }
                        }

                    }
            };
            using (var context = new BreakAwayContext())
            {
                context.Lodgings.AddRange(lodgings);
                context.SaveChanges();
            }

        }
    }
}
