namespace WebApplication1.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string History { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty; // Путь к фотографии
        public string OperatingHours { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty; // Стоимость посещения
        public int CityId { get; set; } // Внешний ключ
        public City? City { get; set; } // Навигационное свойство
    }
}
