using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public static class TravelGuideContextSeed
    {
        public static void Seed(TravelGuideContext context)
        {
            if (!context.Cities.Any())
            {
                var cities = new List<City>
                {
                    // Москва
                    new City
                    {
                        Name = "Москва",
                        Region = "Центральный регион",
                        Population = 12655050,
                        Description = "Столица России, культурный и политический центр.",
                        History = "Основана в 1147 году.",
                        CoatOfArmsPath = "/images/moscow_coat.png",
                        PhotoPath = "/images/moscow.jpg",
                        Attractions = new List<Attraction>
                        {
                            new Attraction
                            {
                                Name = "Красная площадь",
                                Description = "Исторический центр Москвы.",
                                History = "Создана в XV веке.",
                                PhotoPath = "/images/red_square.jpg",
                                OperatingHours = "Круглосуточно",
                                Cost = "Бесплатно"
                            },
                            new Attraction
                            {
                                Name = "Кремль",
                                Description = "Историческая крепость и резиденция президента.",
                                History = "Построен в XIV-XV веках.",
                                PhotoPath = "/images/kremlin.jpg",
                                OperatingHours = "10:00-17:00",
                                Cost = "500 рублей"
                            },
                            new Attraction
                            {
                                Name = "Большой театр",
                                Description = "Один из ведущих театров оперы и балета в мире.",
                                History = "Основан в 1776 году.",
                                PhotoPath = "/images/bolshoi.jpg",
                                OperatingHours = "10:00-20:00",
                                Cost = "1000 рублей"
                            },
                            new Attraction
                            {
                                Name = "Храм Христа Спасителя",
                                Description = "Главный православный храм России.",
                                History = "Построен в 1839-1883 годах, восстановлен в 1990-х.",
                                PhotoPath = "/images/christ_savior.jpg",
                                OperatingHours = "10:00-17:00",
                                Cost = "Бесплатно"
                            },
                            new Attraction
                            {
                                Name = "Парк Горького",
                                Description = "Популярный парк для отдыха и развлечений.",
                                History = "Открыт в 1928 году.",
                                PhotoPath = "/images/gorky_park.jpg",
                                OperatingHours = "Круглосуточно",
                                Cost = "Бесплатно"
                            }
                        }
                    },
                    // Санкт-Петербург
                    new City
                    {
                        Name = "Санкт-Петербург",
                        Region = "Северо-Западный регион",
                        Population = 5600044,
                        Description = "Культурная столица России, город каналов и дворцов.",
                        History = "Основан в 1703 году Петром I.",
                        CoatOfArmsPath = "/images/spb_coat.png",
                        PhotoPath = "/images/spb.jpg",
                        Attractions = new List<Attraction>
                        {
                            new Attraction
                            {
                                Name = "Эрмитаж",
                                Description = "Один из крупнейших музеев мира.",
                                History = "Основан в 1764 году.",
                                PhotoPath = "/images/hermitage.jpg",
                                OperatingHours = "10:30-18:00",
                                Cost = "700 рублей"
                            },
                            new Attraction
                            {
                                Name = "Петропавловская крепость",
                                Description = "Историческое ядро города.",
                                History = "Основана в 1703 году.",
                                PhotoPath = "/images/peter_paul.jpg",
                                OperatingHours = "10:00-19:00",
                                Cost = "550 рублей"
                            },
                            new Attraction
                            {
                                Name = "Исаакиевский собор",
                                Description = "Монументальный православный собор.",
                                History = "Построен в 1818-1858 годах.",
                                PhotoPath = "/images/isaac.jpg",
                                OperatingHours = "10:00-18:00",
                                Cost = "400 рублей"
                            }
                        }
                    },
                    // Краснодар
                    new City
                    {
                        Name = "Краснодар",
                        Region = "Южный регион",
                        Population = 1099244,
                        Description = "Крупный город на юге России, центр Краснодарского края.",
                        History = "Основан в 1793 году как Екатеринодар.",
                        CoatOfArmsPath = "/images/krasnodar_coat.png",
                        PhotoPath = "/images/krasnodar.jpg",
                        Attractions = new List<Attraction>
                        {
                            new Attraction
                            {
                                Name = "Парк Галицкого",
                                Description = "Современный парк с уникальным дизайном.",
                                History = "Открыт в 2017 году.",
                                PhotoPath = "/images/galitsky_park.jpg",
                                OperatingHours = "Круглосуточно",
                                Cost = "Бесплатно"
                            },
                            new Attraction
                            {
                                Name = "Краснодарский краевой художественный музей",
                                Description = "Музей с коллекцией русского искусства.",
                                History = "Основан в 1904 году.",
                                PhotoPath = "/images/krasnodar_museum.jpg",
                                OperatingHours = "10:00-18:00",
                                Cost = "200 рублей"
                            }
                        }
                    }
                };

                context.Cities.AddRange(cities);
                context.SaveChanges();
            }
        }
    }
}