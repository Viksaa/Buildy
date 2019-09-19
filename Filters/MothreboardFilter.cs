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
    public class MotherboardFilter
    {
        protected HttpSessionStateBase Session;
        private ApplicationDbContext db = new ApplicationDbContext();
        private IQueryable<Motherboard> motherboardQuery;

        public MotherboardFilter(HttpSessionStateBase Session)
        {
            this.Session = Session;
        }

        public async Task<List<Motherboard>> FilterMotherboard()
        {

            var motherboardInclude = db.Motherboards
                .Include("Manufacturer")
                .Include("Socket")
                .Include("MotherboardType")
                .Include("Chipset");
            motherboardQuery = motherboardInclude;

            if (Session["Cpu"] != null)
            {
                var tempCpu = (CPU)Session["Cpu"];
                motherboardQuery = motherboardQuery.Where(c => c.ChipsetId == tempCpu.ChipsetId);
            }
            if (Session["Case"] != null)
            {
                var tempCase = (Case)Session["Case"];
                motherboardQuery = motherboardQuery.Where(mb => mb.MotherboardTypeId == tempCase.MotherboardTypeId);
            }

            var motherboards = await motherboardQuery.ToListAsync();
            return  motherboards ;
        }
    }
}