using System.ComponentModel.DataAnnotations;

namespace PortfolioCore.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IconClass { get; set; } // Örnek: "bi bi-activity"

        public string ShapeColor { get; set; } // Örnek: "#f5f5f5" veya "cyan"
    }
}
