using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CardTech.ResearchSite.Data;
using CardTech.ResearchSite.Models;

namespace CardTech.ResearchSite.Pages.News
{
    public class DetailsModel : PageModel
    {
        private readonly CardTech.ResearchSite.Data.CardTechResearchSiteContext _context;

        public DetailsModel(CardTech.ResearchSite.Data.CardTechResearchSiteContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article.FirstOrDefaultAsync(m => m.ID == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
