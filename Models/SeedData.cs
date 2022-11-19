using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace finalproject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new RestaurantContext(serviceProvider.GetRequiredService<DbContextOptions<RestaurantContext>>()))
            {
                if (db.Restaurant.Any())
                {
                    return;
                }

                db.Restaurant.AddRange(
                    new Restaurant
                    {
                        Name = "Sascee's Southern Style Eatery",
                        Address = "719 S 11th St, Waco, TX 76706",
                        PhoneNumber = "(254) 339-1455",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Food for Thought",
                        Address = "1121 Speight Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 753-3998",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "George’s Restaurant Bar & Catering",
                        Address = "1925 Speight Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 753-1421",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Jakes Texas Tea House",
                        Address = "613 Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 756-2522",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Revival Eastside Eatery",
                        Address = "704 Elm Ave, Waco, TX 76704",
                        PhoneNumber = "(254) 339-1401",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Salty Dog Sports Bar And Grill",
                        Address = "2004 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 732-5161",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Secret Chef",
                        Address = "7723 Central Park Dr, Waco, TX 76712",
                        PhoneNumber = "(254) 772-2433",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "The Mix Cafe",
                        Address = "1700 S 5th St c, Waco, TX 76706",
                        PhoneNumber = "(254) 652-4300",
                        Cuisine = "American - Casual",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "135 Prime",
                        Address = "1201 Hewitt Dr Suite 110, Waco, TX 76712",
                        PhoneNumber = "(254) 666-3100",
                        Cuisine = "American - Sit Down",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "LongHorn Steakhouse",
                        Address = "4300 Franklin Ave, Waco, TX 76710",
                        PhoneNumber = "(254) 399-6903",
                        Cuisine = "American - Sit Down",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Saltgrass Steak House",
                        Address = "5600 Legend Lake Pkwy, Waco, TX 76712",
                        PhoneNumber = "(254) 420-0067",
                        Cuisine = "American - Sit Down",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Bangkok Royale",
                        Address = "215 S University Parks Dr, Waco, TX 76701",
                        PhoneNumber = "(254) 757-2741",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "The Blasian Asian ",
                        Address = "720 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 640-2940",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cathay House",
                        Address = "825 Wooded Acres Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 776-1072",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cha Community",
                        Address = "1001 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 327-7120",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Chopstix - Wooded Acres",
                        Address = "1101 Wooded Acres Dr # 101, Waco, TX 76710",
                        PhoneNumber = "(254) 751-9080",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Clay Pot",
                        Address = "416 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 756-2721",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Fortune Cookie Express",
                        Address = "723 S 6th St, Waco, TX 76706",
                        PhoneNumber = "(254) 732-0668",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Ichiban Japanese Steakhouse & Sushi Bar",
                        Address = "2501 S Jack Kultgen Expy, Waco, TX 76711",
                        PhoneNumber = "(254) 313-1063",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Happy Wok",
                        Address = "1910 Park Lake Dr, Waco, TX 76708",
                        PhoneNumber = "(254) 224-6936",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "J-Petal & Poke’ Waco",
                        Address = "315 S University Parks Dr #120, Waco, TX 76701",
                        PhoneNumber = "(254) 230-2244",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Kitok Restaraunt",
                        Address = "1815 N 18th St, Waco, TX 76707",
                        PhoneNumber = "(254) 754-1801",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "KoKo Ramen",
                        Address = "720 Franklin Ave Unit 230, Waco, TX 76701",
                        PhoneNumber = "(254) 401-1455",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Teriyaki Park",
                        Address = "220 S 2nd St, Waco, TX 76701",
                        PhoneNumber = "(254) 714-1416",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Vietnomz Mobile Cuisine",
                        Address = "820 E Waco Dr, Waco, TX 76704",
                        PhoneNumber = "(254) 294-7855",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Wacko Roll",
                        Address = "2804 W Loop 340, Waco, TX 76711",
                        PhoneNumber = "(254) 662-9335",
                        Cuisine = "Asian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Guess Family BBQ",
                        Address = "2803 Franklin Ave, Waco, TX 76710",
                        PhoneNumber = "(254) 313-3436",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Helberg BBQ",
                        Address = "8532 Hwy 6, Woodway, TX 76712",
                        PhoneNumber = "(254) 848-8200",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Jasper's BBQ",
                        Address = "105 Clifton St, Waco, TX 76704",
                        PhoneNumber = "(254) 732-0899",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Rudy's",
                        Address = "2510 Circle Rd, Waco, TX 76706",
                        PhoneNumber = "(254) 750-9995",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Tony Demario's BBQ",
                        Address = "1000 Elm Ave, Waco, TX 76704",
                        PhoneNumber = "(254) 755-8888",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Uncle Dans",
                        Address = "1001 Lake Air Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 772-3532",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Viteks",
                        Address = "1600 Speight Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 752-7591",
                        Cuisine = "BBQ",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Butter My Biscuit",
                        Address = "1427 S Valley Mills Dr, Waco, TX 76711",
                        PhoneNumber = "(254) 752-2333",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cafe Cappuccino",
                        Address = "1101 Richland Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 772-3739",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Coffee Shop Cafe",
                        Address = "1005 W McGregor Dr, McGregor, TX 76657",
                        PhoneNumber = "(254) 840-2027",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Harold Waites ",
                        Address = "941 Lake Air Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 772-9970",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Harvest on 25th",
                        Address = "112 N 25th St, Waco, TX 76710",
                        PhoneNumber = "(254) 313-7285",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Homestead Heritage",
                        Address = "608 Dry Creek Rd, Waco, TX 76705",
                        PhoneNumber = "(254) 754-9600",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Magnolia Table",
                        Address = "2132 S Valley Mills Dr, Waco, TX 76706",
                        PhoneNumber = "(254) 265-6859",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Milos",
                        Address = "1020 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 235-1243",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Olive Branch",
                        Address = " 215 S 2nd St, Waco, TX 76701",
                        PhoneNumber = "(254) 757-0885",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Our Breakfast Place",
                        Address = "4600 Franklin Ave #100, Waco, TX 76710",
                        PhoneNumber = "(254) 399-0886",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "William Hoytt Bagels",
                        Address = "1123 S 8th St, 2223 Austin Ave B, Waco, TX 76701",
                        PhoneNumber = "(469) 744-8515",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "World Cup Cafe",
                        Address = "1321 N 15th St, Waco, TX 76707",
                        PhoneNumber = "(254) 757-1748",
                        Cuisine = "Breakfast/Brunch",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Buzzard Billy's",
                        Address = "100 N Interstate 35 Frontage Rd, Waco, TX 76704",
                        PhoneNumber = "(254) 753-2778",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Friday's Seafood and More",
                        Address = "1308 New Dallas Hwy, Waco, TX 76705",
                        PhoneNumber = "(254) 867-1700",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Sam's Southern Eatery",
                        Address = "1824 W Waco Dr, Waco, TX 76701",
                        PhoneNumber = "(254) 754-9926",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Tejun Cajun",
                        Address = "711 Robinson Dr, Robinson, TX 76706",
                        PhoneNumber = "(254) 235-3100",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cajun Craft",
                        Address = "601 S 11th St, Waco, TX 76706",
                        PhoneNumber = "(254) 754-3869",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "The Catch",
                        Address = "1230 N Valley Mills Dr # 700, Waco, TX 76710",
                        PhoneNumber = "(254) 651-1161",
                        Cuisine = "Cajun",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Baked Bliss",
                        Address = "1114 N 15th St, Waco, TX 76707",
                        PhoneNumber = "(254) 214-9911",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "CakeAmor Bakery",
                        Address = "504 Lake Air Dr #5840, Waco, TX 76710",
                        PhoneNumber = "(254) 640-1456",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Helados De Azteca",
                        Address = "1500 Colcord Ave, Waco, TX 76707",
                        PhoneNumber = "(254) 313-1528",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Heritage Creamery",
                        Address = "1125 S 8th St, Waco, TX 76706",
                        PhoneNumber = "(254) 537-1352",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Hey Sugar",
                        Address = "324 S 6th St, Waco, TX 76701",
                        PhoneNumber = "(254) 339-1700",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Katie's Frozen Custard",
                        Address = "602 S Valley Mills Dr, Waco, TX 76711",
                        PhoneNumber = "(254) 754-5899",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "La Nueva Michoacana",
                        Address = "1205 N 25th St, Waco, TX 76707",
                        PhoneNumber = "NA",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Magnolia Bakery",
                        Address = "601 Webster Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 235-0603",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Milk Bottle Cookies",
                        Address = "218 S 11th St, Waco, TX 76701",
                        PhoneNumber = "(801) 921-0313",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Mo Cookies",
                        Address = "914 Lake Air Dr ste g, Waco, TX 76710",
                        PhoneNumber = "(254) 732-1136",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Nightlight Donuts and Coffee",
                        Address = "6500 Woodway Dr, Woodway, TX 76712",
                        PhoneNumber = "(254) 340-0306",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Off the Kob Popcorn",
                        Address = "5301 Bosque Blvd, Waco, TX 76710",
                        PhoneNumber = "(254) 776-7800",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Pokey O's",
                        Address = "NA",
                        PhoneNumber = "NA",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Simply Delicious Cupcakes",
                        Address = "200 Commerce St, Waco, TX 76710",
                        PhoneNumber = "(254) 732-5333",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Sugar Doodles",
                        Address = "NA",
                        PhoneNumber = "(254) 292-2155",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Sweetness Desserts",
                        Address = "2034 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 756-0590",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Tiffs Treats",
                        Address = "720 S 5th St #112, Waco, TX 76706",
                        PhoneNumber = "(254) 244-2500",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Violet Macaroons",
                        Address = "NA",
                        PhoneNumber = "NA",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "What About Cupcakes",
                        Address = "2709 Robinson Dr, Waco, TX 76706",
                        PhoneNumber = "(254) 224-6610",
                        Cuisine = "Desserts/Pastries/Snacks",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Be Kind Coffee",
                        Address = "425 Lake Air Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 294-4440",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Bru",
                        Address = "601 Franklin Ave #1st, Waco, TX 76701",
                        PhoneNumber = "(254) 495-1640",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Common Grounds",
                        Address = "1123 S 8th St, Waco, TX 76706",
                        PhoneNumber = "(254) 757-2957",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Heritage Coffee",
                        Address = "230 Halbert Ln, Waco, TX 76705",
                        PhoneNumber = "(254) 262-9062",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Lalo's Coffee and Pastries",
                        Address = "1500 Colcord Ave, Waco, TX 76707",
                        PhoneNumber = "(254) 300-5200",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Lighthouse",
                        Address = "624 Washington Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 339-1542",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Magnolia Press Coffee Co.",
                        Address = "418 S 8th St, Waco, TX 76706",
                        PhoneNumber = "(254) 235-0603",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Pinewood",
                        Address = "2223 Austin Ave B, Waco, TX 76701",
                        PhoneNumber = "(254) 262-6130",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Z's Brew Coffee & Crepes",
                        Address = "611 Washington Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 235-1757",
                        Cuisine = "Drinks (coffee shop)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Balcones Distilling",
                        Address = "225 S 11th St, Waco, TX 76701",
                        PhoneNumber = "(254) 755-6003",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Barnett's Pub",
                        Address = "420 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 714-1356",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Blue Dog Wine and Martini",
                        Address = "2004 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 732-5161",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Brotherwell Brewing",
                        Address = "400 E Bridge St, Waco, TX 76704",
                        PhoneNumber = "(254) 301-7152",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cricket's Grill & Drafthouse",
                        Address = "211 Mary Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 754-4677",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Daiquiri Fusion and Boozy Beans",
                        Address = "1717 S Valley Mills Dr, Waco, TX 76711",
                        PhoneNumber = "(254) 296-1327",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Dichotomy Coffee & Spirits",
                        Address = "508 Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 717-3226",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Fabled Bookshop & Café",
                        Address = "215 S 4th St, Waco, TX 76701",
                        PhoneNumber = "(254) 296-8143",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Hemingways Watering Hole",
                        Address = "4700 Bosque Blvd, Waco, TX 76710",
                        PhoneNumber = "NA",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Kissing Tree Vineyard",
                        Address = "109 W 3rd St, Eddy, TX 76524",
                        PhoneNumber = "(254) 859-8039",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Klassy Glass",
                        Address = "723 Austin Ave #1, Waco, TX 76701",
                        PhoneNumber = "(254) 300-4433",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Pinewood Public House",
                        Address = "2223 Austin Ave Suite D, Waco, TX 76701",
                        PhoneNumber = "(254) 224-6189",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Sloane’s",
                        Address = "110 N 25th St, Waco, TX 76710",
                        PhoneNumber = "NA",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Southern Roots Brewing Co.",
                        Address = "219 N 8th St, Waco, TX 76701",
                        PhoneNumber = "(254) 732-2309",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "The Backyard",
                        Address = "511 S 8th St, Waco, TX 76706",
                        PhoneNumber = "(254) 235-1151",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Dancing Bear Pub",
                        Address = "1117 Speight Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 235-2337",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Waco Ale Company",
                        Address = "806 Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 301-7777",
                        Cuisine = "Drinks (bars)",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Alpha Omega",
                        Address = "929 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 732-7506",
                        Cuisine = "Mediterranean",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "D's Mediterranean Grill",
                        Address = "1503 Colcord Ave, Waco, TX 76707",
                        PhoneNumber = "(254) 754-6709",
                        Cuisine = "Mediterranean",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Laziza",
                        Address = "579 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 313-1014",
                        Cuisine = "Mediterranean",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Stone Hearth",
                        Address = "506 Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 339-1706",
                        Cuisine = "Indian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Tru Jamica",
                        Address = "937 Taylor St, Waco, TX 76704",
                        PhoneNumber = "(254) 304-9288",
                        Cuisine = "Jamaican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Baris",
                        Address = "904 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 772-2900",
                        Cuisine = "Italian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Portafino's",
                        Address = "725 Austin Ave, Waco, TX 76708",
                        PhoneNumber = "(254) 753-8900",
                        Cuisine = "Italian",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Slow Rise Slice House",
                        Address = "7608 Woodway Dr, Woodway, TX 76712",
                        PhoneNumber = "(254) 235-0785",
                        Cuisine = "Pizza",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Bare Bucha",
                        Address = "1534 Washington, Waco, TX 76701",
                        PhoneNumber = "(254) 495-6961",
                        Cuisine = "Juice/Smoothies/Bowls",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "HTeaO",
                        Address = "820 S 7th St, Waco, TX 76706",
                        PhoneNumber = "(254) 296-8339",
                        Cuisine = "Juice/Smoothies/Bowls",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Luna Juice Bar",
                        Address = "1516 Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 498-5122",
                        Cuisine = "Juice/Smoothies/Bowls",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Mamaka Bowls",
                        Address = "215 S University Parks Dr, Waco, TX 76701",
                        PhoneNumber = "(254) 732-0838",
                        Cuisine = "Juice/Smoothies/Bowls",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Oh My Juice",
                        Address = "215 Mary Ave Ste 101, Waco, TX 76701",
                        PhoneNumber = "(254) 732-0516",
                        Cuisine = "Juice/Smoothies/Bowls",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Berthas",
                        Address = "2418 Grim Ave, Waco, TX 76707",
                        PhoneNumber = "(254) 755-7123",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Casa De Castillo",
                        Address = "4820 Sanger Ave, Waco, TX 76710",
                        PhoneNumber = "(254) 772-8246",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Dos Mundos",
                        Address = "2515 Clay Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 224-6522",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Fuzzy's Taco Shop",
                        Address = "215 S University Parks Dr Suite 107, Waco, TX 76701",
                        PhoneNumber = "(254) 732-1818",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Hecho En Waco",
                        Address = "300 S 6th St b, Waco, TX 76701",
                        PhoneNumber = "(254) 732-0147",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Jesse's Tortilla Factory",
                        Address = "1226 Webster Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 752-6286",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "La Fiesta",
                        Address = "3815 Franklin Ave, Waco, TX 76710",
                        PhoneNumber = "(254) 756-4701",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Leal's Mexican Restaraunt",
                        Address = "9000 Panther Dr, Woodway, TX 76712",
                        PhoneNumber = "(254) 772-8140",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Lolita's",
                        Address = "1911 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 755-8008",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Lupita's",
                        Address = "3600 N 19th St N, Waco, TX 76707",
                        PhoneNumber = "(254) 235-0813",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Martha's",
                        Address = "3616 N 19th St, Waco, TX 76708",
                        PhoneNumber = "(254) 732-1129",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Ninfa's",
                        Address = "220 S 3rd St, Waco, TX 76701",
                        PhoneNumber = "(254) 757-2050",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Rufi's Cocina",
                        Address = "1801 N 25th St, Waco, TX 76707",
                        PhoneNumber = "(254) 235-0892",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Sergio's",
                        Address = "608A Austin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 714-1297",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Taco Z",
                        Address = "2311 La Salle Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 753-1665",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Taqueria #9",
                        Address = "1420 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 776-0011",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Verónica's",
                        Address = "1618 Franklin Ave, Waco, TX 76701",
                        PhoneNumber = "(254) 714-2655",
                        Cuisine = "Mexican",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "900 Pizzeria",
                        Address = "315 S University Parks Dr #100, Waco, TX 76701",
                        PhoneNumber = "(254) 732-2323",
                        Cuisine = "Pizza",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Moroso Wood Fired Pizzeria",
                        Address = "4700 Bosque Blvd, Waco, TX 76710",
                        PhoneNumber = "(254) 235-6000",
                        Cuisine = "Pizza",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Poppa Rollo's Pizza",
                        Address = "703 N Valley Mills Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 776-6776",
                        Cuisine = "Pizza",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Shorty's Pizza Shack",
                        Address = "1712 S 12th St, Waco, TX 76706",
                        PhoneNumber = "(254) 235-2646",
                        Cuisine = "Pizza",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Billy Bob’s Burgers",
                        Address = "300 S 2nd St Suite 102, Waco, TX 76701",
                        PhoneNumber = "(254) 424-9262",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Club Sandwich",
                        Address = "601 Webster Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 304-9424",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cpt. Billy Whizzbangs",
                        Address = "901 Lake Air Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 776-4155",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Cups Drive In",
                        Address = "1424 Speight Ave, Waco, TX 76706",
                        PhoneNumber = "(254) 753-9364",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Double R Burgers",
                        Address = "1810 Herring Ave, Waco, TX 76708",
                        PhoneNumber = "(254) 753-1603",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Health Camp",
                        Address = "2601 Circle Rd, Waco, TX 76706",
                        PhoneNumber = "(254) 752-2186",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 4},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Kim's Hamburgers",
                        Address = "2600 W Waco Dr, Waco, TX 76710",
                        PhoneNumber = "(254) 753-1118",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 4}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Smaltchz Sandwich Shop",
                        Address = "1412 N Valley Mills Dr #136, Waco, TX 76710",
                        PhoneNumber = "(254) 776-3694",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 5},
                            new Review {ReviewNum = 5}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Tom’s Burger",
                        Address = "6818 Sanger Ave, Waco, TX 76710",
                        PhoneNumber = "(254) 751-0025",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 3},
                            new Review {ReviewNum = 3}
                        }
                    },

                    new Restaurant
                    {
                        Name = "Twisted Root",
                        Address = "801 S 2nd St, Waco, TX 76706",
                        PhoneNumber = "(254) 366-2888",
                        Cuisine = "Sandwiches and Burgers",
                        Reviews = new List<Review> {
                            new Review {ReviewNum = 2},
                            new Review {ReviewNum = 4}
                        }
                    }
                );

                db.SaveChanges(); 
            }
        }
    }
}