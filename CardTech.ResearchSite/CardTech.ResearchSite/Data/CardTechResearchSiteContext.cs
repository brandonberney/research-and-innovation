using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CardTech.ResearchSite.Models;

namespace CardTech.ResearchSite.Data
{
    public class CardTechResearchSiteContext : DbContext
    {
        public CardTechResearchSiteContext (DbContextOptions<CardTechResearchSiteContext> options)
            : base(options)
        {
        }

        public DbSet<CardTech.ResearchSite.Models.Article> Article { get; set; }
    }
}
