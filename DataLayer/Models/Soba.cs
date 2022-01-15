namespace DataLayer.Models
{
    public class Soba
    {
        public int BrojSobe { get; set; }
        public int BrojSprata { get; set; }
        public int BrojOsoba { get; set; }
        public int Kvadratura { get; set; }

        public Soba()
        {

        }

        public Soba(int BrojSobe, int BrojSprata, int BrojOsoba, int Kvadratura)
        {
            this.BrojSobe = BrojSobe;
            this.BrojSprata = BrojSprata;
            this.BrojOsoba = BrojOsoba;
            this.Kvadratura = Kvadratura;
        }

        public override string ToString()
        {
            return $"Broj sobe: {BrojSobe}, Broj sprata: {BrojSprata}, Broj osoba: {BrojOsoba}, Kvadratura: {Kvadratura}";
        }
    }
}
