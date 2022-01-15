namespace DataLayer.Models
{
    public class Radnik
    {
        public string BrojLicneKarte { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string StrucnaSprema { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Radnik()
        {

        }

        public Radnik(string BrojLicneKarte, string Ime, string Prezime, string BrojTelefona, string StrucnaSprema, string Username, string Email, string Password)
        {
            this.BrojLicneKarte = BrojLicneKarte;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.BrojTelefona = BrojTelefona;
            this.StrucnaSprema = StrucnaSprema;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }

        public override string ToString()
        {
            return $"Broj lične karte: {BrojLicneKarte}, Ime: {Ime}, Prezime: {Prezime}, Broj telefona: {BrojTelefona}, Stručna sprema: {StrucnaSprema}";
        }
    }
}
