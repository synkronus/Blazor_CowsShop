using Microsoft.EntityFrameworkCore;
using CowsOnlineShop.Api.Entities;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Api.Data
{
    public static class SeedData
    {

        public static void Seed(ModelBuilder builder)
        {          
           

            //Products with category Holstein
            builder.Entity<Product>().HasData(new List<Product>
            {

                new Product
                {
                    Id = 1,
                    Name = "Holstein Friesian",
                    Description = "International breed or group of breeds of dairy cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Holstein/Holstein1.png",
                    Price = 100,
                    StockAvailable = 100,
                    BreedCategoryId = 1

                },
                new Product
                {
                    Id = 2,
                    Name = "Holstein Friesian",
                    Description = "International breed or group of breeds of dairy cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Holstein/Holstein2.png",
                    Price = 50,
                    StockAvailable = 45,
                    BreedCategoryId = 1

                },
                new Product
                {
                    Id = 3,
                    Name = "Holstein Friesian",
                    Description = "International breed or group of breeds of dairy cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Holstein/Holstein3.png",
                    Price = 20,
                    StockAvailable = 30,
                    BreedCategoryId = 1

                },
                new Product
                {
                    Id = 4,
                    Name = "Holstein Friesian",
                    Description = "International breed or group of breeds of dairy cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Holstein/Holstein4.png",
                    Price = 50,
                    StockAvailable = 60,
                    BreedCategoryId = 1

                },
                 new Product
                {
                    Id = 5,
                    Name = "Holstein Friesian",
                    Description = "International breed or group of breeds of dairy cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Holstein/Holstein4.png",
                    Price = 50,
                    StockAvailable = 60,
                    BreedCategoryId = 1

                }

            });

            //Products with category Hereford
            builder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                {
                    Id = 6,
                    Name = "Hereford cattle",
                    Description = "Originally from Herefordshire in the West Midlands of England",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Hereford/Hereford3.png",
                    Price = 70,
                    StockAvailable = 90,
                    BreedCategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Hereford cattle",
                    Description = "Originally from Herefordshire in the West Midlands of England",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Hereford/Hereford4.png",
                    Price = 120,
                    StockAvailable = 95,
                    BreedCategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Name = "Hereford cattle",
                    Description = "Originally from Herefordshire in the West Midlands of England",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Hereford/Hereford6.png",
                    Price = 15,
                    StockAvailable = 100,
                    BreedCategoryId = 2
                },
                new Product
                {
                    Id = 9,
                    Name = "Hereford cattle",
                    Description = "Originally from Herefordshire in the West Midlands of England",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Hereford/Hereford1.png",
                    Price = 50,
                    StockAvailable = 212,
                    BreedCategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Name = "Hereford cattle",
                    Description = "Originally from Herefordshire in the West Midlands of England",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Hereford/Hereford2.png",
                    Price = 50,
                    StockAvailable = 112,
                    BreedCategoryId = 2
                },

            });

            //Products with category Aberdeen
            builder.Entity<Product>().HasData(new List<Product>
            {

                new Product
                {
                    Id = 11,
                    Name = "Aberdeen Angus",
                    Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Aberdeen/Aberdeen2.png",
                    Price = 40,
                    StockAvailable = 200,
                    BreedCategoryId = 3

                },
                new Product
                {
                    Id = 12,
                    Name = "Aberdeen Angus",
                    Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Aberdeen/Aberdeen3.png",
                    Price = 40,
                    StockAvailable = 300,
                    BreedCategoryId = 3

                },
                new Product
                {
                    Id = 13,
                    Name = "Aberdeen Angus",
                    Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Aberdeen/Aberdeen4.png",
                    Price = 600,
                    StockAvailable = 20,
                    BreedCategoryId = 3

                },
                new Product
                {
                    Id = 14,
                    Name = "Aberdeen Angus",
                    Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Aberdeen/Aberdeen5.png",
                    Price = 500,
                    StockAvailable = 15,
                    BreedCategoryId = 3

                },
                new Product
                {
                    Id = 15,
                    Name = "Aberdeen Angus",
                    Description = "Sometimes simply Angus, is a Scottish breed of small beef cattle",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Aberdeen/Aberdeen1.png",
                    Price = 100,
                    StockAvailable = 120,
                    BreedCategoryId = 3

                }
            });

            //Products with category Belgian
            builder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                {
                    Id = 16,
                    Name = "Belgian Blue",
                    Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Belgian/Belgian2.png",
                    Price = 150,
                    StockAvailable = 60,
                    BreedCategoryId = 4
                },
                new Product
                {
                    Id = 17,
                    Name = "Belgian Blue",
                    Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Belgian/Belgian3.png",
                    Price = 200,
                    StockAvailable = 70,
                    BreedCategoryId = 4
                },
                new Product
                {
                    Id = 18,
                    Name = "Belgian Blue",
                    Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Belgian/Belgian4.png",
                    Price = 120,
                    StockAvailable = 120,
                    BreedCategoryId = 4
                },
                new Product
                {
                    Id = 19,
                    Name = "Belgian Blue",
                    Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Belgian/Belgian5.png",
                    Price = 200,
                    StockAvailable = 100,
                    BreedCategoryId = 4
                },

                new Product
                {
                    Id = 20,
                    Name = "Belgian Blue",
                    Description = " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil",
                    BirthDate = new DateTime(2018, 09, 08),
                    Sex = (int)SexGender.Male,
                    Status = (int)PublishStatus.Active,
                    ImageURL = "/Images/Belgian/Belgian1.png",
                    Price = 100,
                    StockAvailable = 50,
                    BreedCategoryId = 4
                },

            });

            //Add users
            builder.Entity<User>().HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    UserName = "User01"

                },
                new User
                {
                    Id = 2,
                    UserName = "User02"

                }

            });

            //Create Shopping Cart for Users
            builder.Entity<Cart>().HasData(new List<Cart>
            {
                new Cart
                {
                    Id = 1,
                    UserId = 1
                },
                new Cart
                {
                    Id = 2,
                    UserId = 2

                }
            });

            //Breed Categories
            builder.Entity<BreedCategory>().HasData(new List<BreedCategory> {
                new BreedCategory
                {
                    Id = 1,
                    Name = "Holstein",
                },
                new BreedCategory
                {
                    Id = 2,
                    Name = "Hereford",
                },
                new BreedCategory
                {
                    Id = 3,
                    Name = "Aberdeen",
                },
                new BreedCategory
                {
                    Id = 4,
                    Name = "Belgian",
                }

            });
        }
    }
}
