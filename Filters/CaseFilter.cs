using Buildy.Models;
using Buildy.Models.PC_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;


namespace Buildy.Filters
{
    public class CaseFilter
    {
        protected HttpSessionStateBase Session;
        private ApplicationDbContext db = new ApplicationDbContext();
        private IQueryable<Case> caseQuery;

        public CaseFilter(HttpSessionStateBase Session)
        {
            this.Session = Session;
        }

        public async Task<List<Case>> FilterCase()
        {

            var caseInclude = db.Cases
                .Include("Manufacturer")
                .Include("MotherboardType");

            caseQuery = caseInclude;

            if (Session["Mb"] != null)
            {
                var tempMb = (Motherboard)Session["Mb"];
                caseQuery = caseQuery.Where(c => c.MotherboardTypeId == tempMb.MotherboardTypeId);
            }

            var cases = await caseQuery.ToListAsync();
            return cases;
        }
    }
}