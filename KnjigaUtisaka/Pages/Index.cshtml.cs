using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KnjigaUtisaka.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly UtisakServis _servis;

        [BindProperty]
        public string Ime { get; set; }
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Komentar { get; set; }

        
        public IndexModel(ILogger<IndexModel> logger, UtisakServis servis)
        {
            _logger = logger;
            _servis = servis;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostDodaj()
        {
            if(ModelState.IsValid)
            {
                Utisak u = new Utisak(Ime, Email, Komentar);
                _servis.Add(u);
            }
            return Page();

        }
    }
}
