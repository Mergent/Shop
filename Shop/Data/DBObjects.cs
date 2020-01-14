using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Очень удобная",
                        longDesc = "Красивый и быстрый. Но главное - очень тихий автомобиль",
                        img = "/img/tes;a.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихая и спокойная",
                        longDesc = "Действительно очень удобно для городской жизни",
                        img = "/img/ford.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Тепло как дома, не тесно",
                        img = "/img/mercedez.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзский и стильный",
                        longDesc = "Очень дерзкий и очень стильный",
                        img = "/img/bmv.jpg",
                        price = 50000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Toyota Camry",
                        shortDesc = "Не Очень Удобная",
                        longDesc = "Сложно кататься",
                        img = "/img/netesla.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    });
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
