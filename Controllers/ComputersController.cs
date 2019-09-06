using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Buildy.Models;
using Buildy.Models.PC_Components;

namespace Buildy.Controllers
{
    public class ComputersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Computers
        public async Task<ActionResult> Index()
        {
            var computers = db.Computers.Include(c => c.Case).Include(c => c.Cooling).Include(c => c.Cpu).Include(c => c.Gpu).Include(c => c.Motherboard).Include(c => c.Psu).Include(c => c.Ram).Include(c => c.Storage);
            return View(await computers.ToListAsync());
        }

        // GET: Computers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computer computer = await db.Computers.FindAsync(id);
            if (computer == null)
            {
                return HttpNotFound();
            }
            return View(computer);
        }

        // GET: Computers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CaseId,CoolingId,CoolingAmmount,CpuId,GpuId,MotherboardId,PsuId,RamId,RamAmmount,StorageId,StorageAmmount")] Computer computer)
        {
            if (ModelState.IsValid)
            {
                db.Computers.Add(computer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CaseId = new SelectList(db.Cases, "Id", "Name", computer.CaseId);
            ViewBag.CoolingId = new SelectList(db.Coolings, "Id", "Name", computer.CoolingId);
            ViewBag.CpuId = new SelectList(db.Cpus, "Id", "Name", computer.CpuId);
            ViewBag.GpuId = new SelectList(db.Gpus, "Id", "Name", computer.GpuId);
            ViewBag.MotherboardId = new SelectList(db.Motherboards, "Id", "Name", computer.MotherboardId);
            ViewBag.PsuId = new SelectList(db.Psus, "Id", "Name", computer.PsuId);
            ViewBag.RamId = new SelectList(db.Rams, "Id", "Name", computer.RamId);
            ViewBag.StorageId = new SelectList(db.Storages, "Id", "Name", computer.StorageId);
            return View(computer);
        }

        // GET: Computers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computer computer = await db.Computers.FindAsync(id);
            if (computer == null)
            {
                return HttpNotFound();
            }
            ViewBag.CaseId = new SelectList(db.Cases, "Id", "Name", computer.CaseId);
            ViewBag.CoolingId = new SelectList(db.Coolings, "Id", "Name", computer.CoolingId);
            ViewBag.CpuId = new SelectList(db.Cpus, "Id", "Name", computer.CpuId);
            ViewBag.GpuId = new SelectList(db.Gpus, "Id", "Name", computer.GpuId);
            ViewBag.MotherboardId = new SelectList(db.Motherboards, "Id", "Name", computer.MotherboardId);
            ViewBag.PsuId = new SelectList(db.Psus, "Id", "Name", computer.PsuId);
            ViewBag.RamId = new SelectList(db.Rams, "Id", "Name", computer.RamId);
            ViewBag.StorageId = new SelectList(db.Storages, "Id", "Name", computer.StorageId);
            return View(computer);
        }

        // POST: Computers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CaseId,CoolingId,CoolingAmmount,CpuId,GpuId,MotherboardId,PsuId,RamId,RamAmmount,StorageId,StorageAmmount")] Computer computer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(computer).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CaseId = new SelectList(db.Cases, "Id", "Name", computer.CaseId);
            ViewBag.CoolingId = new SelectList(db.Coolings, "Id", "Name", computer.CoolingId);
            ViewBag.CpuId = new SelectList(db.Cpus, "Id", "Name", computer.CpuId);
            ViewBag.GpuId = new SelectList(db.Gpus, "Id", "Name", computer.GpuId);
            ViewBag.MotherboardId = new SelectList(db.Motherboards, "Id", "Name", computer.MotherboardId);
            ViewBag.PsuId = new SelectList(db.Psus, "Id", "Name", computer.PsuId);
            ViewBag.RamId = new SelectList(db.Rams, "Id", "Name", computer.RamId);
            ViewBag.StorageId = new SelectList(db.Storages, "Id", "Name", computer.StorageId);
            return View(computer);
        }

        // GET: Computers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Computer computer = await db.Computers.FindAsync(id);
            if (computer == null)
            {
                return HttpNotFound();
            }
            return View(computer);
        }

        // POST: Computers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Computer computer = await db.Computers.FindAsync(id);
            db.Computers.Remove(computer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public async Task<ActionResult> AddCpu()
        {
            var dbCpu = await db.Cpus
                .Include(c => c.Manufacturer)
                .Include(c => c.Chipset)
                .ToListAsync();

            return View("AddCpu", dbCpu);
        }

        public async Task<ActionResult> AddCpuToPc(int id)
        {
            var dbCpu = await db.Cpus.Include(mb => mb.Manufacturer).Where(mb => mb.Id == id).FirstAsync();
            Session["Cpu"] = dbCpu;

            return RedirectToAction("Create");
        }

        public ActionResult RemoveCpu()
        {
            Session["Cpu"] = null;
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> AddMotherboard()
        {
            var dbMb = await db.Motherboards
                .Include(mb => mb.Manufacturer)
                .Include(mb => mb.Socket)
                .Include(mb => mb.Chipset)
                .Include(mb => mb.MotherboardType)
                .ToListAsync();

            return View("AddMotherboard", dbMb);
        }

        public async Task<ActionResult> AddMotherboardToPc(int id)
        {
            var dbMb = await db.Motherboards.Include(mb => mb.Manufacturer).Where(mb => mb.Id == id).FirstAsync();
            Session["Mb"] = dbMb;

            return RedirectToAction("Create");
        }

        public ActionResult RemoveMotherboard()
        {
            Session["Mb"] = null;
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> AddCase()
        {
            var dbCase = await db.Cases
                .Include(mb => mb.Manufacturer)
                .Include(mb => mb.MotherboardType)
                .ToListAsync();

            return View("AddCase", dbCase);
        }

        public async Task<ActionResult> AddCaseToPc(int id)
        {
            var dbCase = await db.Cases.Include(mb => mb.Manufacturer).Where(mb => mb.Id == id).FirstAsync();
            Session["Case"] = dbCase;

            return RedirectToAction("Create");
        }

        public ActionResult RemoveCase()
        {
            Session["Case"] = null;
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> AddGpu()
        {
            var dbGpu = await db.Gpus
                .Include(mb => mb.Manufacturer)
                .Include(mb => mb.RamMemoryType)
                .ToListAsync();

            return View("AddGpu", dbGpu);
        }

        public async Task<ActionResult> AddGpuToPc(int id)
        {
            var dbGpu = await db.Gpus.Include(mb=> mb.Manufacturer).Where(mb=> mb.Id == id).FirstAsync();
            Session["Gpu"] = dbGpu;

            return RedirectToAction("Create");
        }

        public ActionResult RemoveGpu()
        {
            Session["Gpu"] = null;
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> AddPsu()
        {
            var dbPsu = await db.Psus
                .Include(mb => mb.Manufacturer)
                .Include(mb => mb.PsuEficency)
                .ToListAsync();

            return View("AddPsu", dbPsu);
        }

        public async Task<ActionResult> AddPsuToPc(int id)
        {
            var dbPsu = await db.Psus.Include(mb => mb.Manufacturer).Where(mb => mb.Id == id).FirstAsync();
            Session["Psu"] = dbPsu;

            return RedirectToAction("Create");
        }

        public ActionResult RemovePsu()
        {
            Session["Psu"] = null;
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> AddRam()
        {
            var dbRam = await db.Rams
                .Include(mb => mb.Manufacturer)
                .Include(mb => mb.RamMemoryType)
                .ToListAsync();

            return View("AddRam", dbRam);
        }

        public async Task<ActionResult> AddRamToPc(int id)
        {
            var dbRam = await db.Rams.Include(mb => mb.Manufacturer).Where(mb => mb.Id == id).FirstAsync();
            Session["Ram"] = dbRam;

            return RedirectToAction("Create");
        }

        public ActionResult RemoveRam()
        {
            Session["Ram"] = null;
            return RedirectToAction("Create");
        }
    }
}
