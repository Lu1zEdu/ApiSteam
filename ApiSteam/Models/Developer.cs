namespace ApiSteam.Models
{
    public class Developer
    {
        public Guid IdDeveloper { get; set; }
        public string Name { get; set; }

        public Guid GamesId { get; set; }
    }
}
