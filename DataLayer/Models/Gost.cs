namespace DataLayer.Models
{
    public class Gost
    {
        public string BrojLicneKarte { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public int BrojSobe { get; set; }

        public Gost()
        {

        }

        public Gost(string BrojLicneKarte, string Ime, string Prezime, string BrojTelefona, int BrojSobe)
        {
            this.BrojLicneKarte = BrojLicneKarte;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.BrojTelefona = BrojTelefona;
            this.BrojSobe = BrojSobe;
        }

        public override string ToString()
        {
            return $"Broj lične karte: {BrojLicneKarte}, Ime: {Ime}, Prezime: {Prezime}, Broj telefona: {BrojTelefona}, Broj sobe: {BrojSobe}";
        }
    }
}
