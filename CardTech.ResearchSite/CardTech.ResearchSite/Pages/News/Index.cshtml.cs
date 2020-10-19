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
    public class IndexModel : PageModel
    {
        private readonly CardTech.ResearchSite.Data.CardTechResearchSiteContext _context;

        public IndexModel(CardTech.ResearchSite.Data.CardTechResearchSiteContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
