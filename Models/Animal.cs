namespace chdog.Models {
    public class Animal {
        public int Id { get; set; }

        public int Idade { get; set; }

        public string Porte { get; set; }

        public int IdRaca { get; set; }

        public Raca Raca { get; set; }

        public decimal Valor { get; set; }
    }
}