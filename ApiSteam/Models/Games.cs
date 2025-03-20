using ApiSteam.Enum;

namespace ApiSteam.Models
{
    public class Games
    {
       public Guid Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public List<Genre> generos { get; set; }
       public List<ControllerSupport> controllerSupport { get; set; }

        // Datas dos Jogos tipo DateTime
        public DateTime DataCriacao { get; set; }
        public DateTime Release { get; set; }

        public long price { get; set; }

        // relacionamentos 
        public Guid DeveloperId {  get; set; }
        public Guid DlcId { get; set; }

        // Conquistas 
        public List<Achievement> Achievements { get; set; }

        //
        public Discount Discount { get; set; }
    }
}
