using Buildy.Models;
using Buildy.Models.PC_Components.PC_Helper_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net;
using Buildy.Models.PC_Components;
using System.Web;

namespace Buildy.Filters
{
    public class CpuFilter
    {
        protected HttpSessionStateBase Session;
        private ApplicationDbContext db = new ApplicationDbContext();
        private IQueryable<CPU> cpuQuery;

        public CpuFilter(HttpSessionStateBase Session)
        {
            this.Session = Session;
        }

        public async Task<List<CPU>> FilterCpu()
        {

            var cpuInclude = db.Cpus
                .Include("Manufacturer")
                .Include("Chipset");
            cpuQuery = cpuInclude;

            if (Session["Mb"] != null)
            {
                var tempMb = (Motherboard)Session["Mb"];
                cpuQuery = cpuQuery.Where(c => c.ChipsetId == tempMb.ChipsetId);
            }

            var cpus = cpuQuery.ToList();
            return cpus;
        }
    }
}