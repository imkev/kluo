using System.Collections.Generic;
using kluo.Models;

namespace kluo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<kluo.Models.kluoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(kluo.Models.kluoDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Restaurant
                    {
                        Name = "Smaka",
                        City = "Gothenburg",
                        Country = "Sweden",
                        Reviews = new List<RestaurantReview>
                            {
                                new RestaurantReview { Rating = 9, Body = "Great Food!", ReviewerName = "Scott"}
                            }
                    },
               new Restaurant
               {
                   Name = "Smakia",
                   City = "Gothenburg",
                   Country = "Sweden",
                   Reviews = new List<RestaurantReview>
                            {
                                new RestaurantReview { Rating = 9, Body = "Great Food!", ReviewerName = "Scott"}
                            }
               },
               new Restaurant
               {
                   Name = "Kevin",
                   City = "Zhuhai",
                   Country = "China",
                   Reviews = new List<RestaurantReview>
                            {
                                new RestaurantReview { Rating = 8, Body = "Great Food!", ReviewerName = "Scott"}
                            }

               });
        }
    }
}
