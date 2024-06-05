namespace KnjigaUtisaka
{
    public class UtisakServis
    {
        private UtisakContext _context;
        private static int id = 0;

        public UtisakServis(UtisakContext context)
        {
            _context = context;
        }



        public async void Add(Utisak utisak)
        {
            utisak.Date = DateTime.Now;
            _context.Add(utisak);
            //await _context.SaveChangesAsync();
            _context.SaveChanges();
        }
        public List<Utisak> GetUtisci()
        {
            return _context.Utisci.ToList();
        }
    }
}
