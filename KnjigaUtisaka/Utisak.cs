namespace KnjigaUtisaka
{
    public class Utisak
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }

        public string Komentar { get; set; }

        public DateTime Date { get; set; }

        public Utisak(string ime, string email, string komentar)
        {
            this.Ime = ime;
            this.Email = email;
            this.Komentar = komentar;
        }




    }
}
