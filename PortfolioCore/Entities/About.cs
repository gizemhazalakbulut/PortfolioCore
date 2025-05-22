namespace PortfolioCore.Entities
{
    public class About
    {
        public int AboutId { get; set; }

        public string Title { get; set; }                // UI/UX Designer & Web Developer
        public string Description { get; set; }          // Alt açıklama (lorem ipsum)
        public string ImageUrl { get; set; }             // Sol taraftaki fotoğraf yolu

        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public string Degree { get; set; }
        public string Email { get; set; }
        public bool Freelance { get; set; }              // True = Available, False = Not Available

        public string FooterText { get; set; }           // Alt kısımdaki uzun açıklama metni
    }

}
