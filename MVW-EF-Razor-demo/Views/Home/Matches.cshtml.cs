using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVW_EF_Razor_demo.Models;

namespace MVW_EF_Razor_demo.Views
{
    public class MatchesModel : PageModel
    {
        private readonly RatingSystemContext _db;

        public MatchesModel(RatingSystemContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            var matches = _db.MatchGames.ToList();
        }
        public void OnPost(){}
        public void LoadData()
        {
            
        }
    }
}
