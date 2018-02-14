using chdog.Models;

namespace chdog.Resources
{
    public class AnimalResource
    {
        public int Id { get; set; }

        public int Idade { get; set; }

        public string Porte { get; set; }

        public decimal Valor { get; set; }

        public RacaResource Raca {get;set;}
    }
}