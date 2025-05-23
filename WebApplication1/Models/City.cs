namespace WebApplication1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public int Population { get; set; }
        public string Description { get; set; } = string.Empty;
        public string History { get; set; } = string.Empty;
        public string CoatOfArmsPath { get; set; } = string.Empty; // Путь к изображению герба
        public string PhotoPath { get; set; } = string.Empty; // Путь к фотографии города
        public List<Attraction> Attractions { get; set; } = new List<Attraction>(); // Связь с достопримечательностями
    }
}

