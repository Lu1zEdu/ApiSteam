namespace ApiSteam.Models
{
    public class Requirements
    {
        public Guid IdRequirements { get; set; }
        public string OsVersion { get; set; }
        public string Processor { get; set; }
        public int Memory { get; set; }
        public string Graphics { get; set; }
        public string Store { get; set; }
        public string Recommended {  get; set; }

        public string DescripitonRequirements { get; set; }

    }
}
