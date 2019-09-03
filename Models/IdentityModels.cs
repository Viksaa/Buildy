using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Buildy.Models.PC_Components;
using Buildy.Models.PC_Components.PC_Helper_Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Buildy.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string ImageUrl { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MotherboardType> MotherboardTypes { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<GPU> Gpus { get; set; }
        public DbSet<CPU> Cpus { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PSU> Psus { get; set; }
        public DbSet<RAM> Rams { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Socket> Sockets { get; set; }
        public DbSet<CoolingType> CoolingTypes { get; set; }
        public DbSet<RAMMemoryType> RamMemoryTypes { get; set; } 
        public DbSet<Chipset> Chipsets { get; set; } 
        public DbSet<StorageType> StorageTypes { get; set; }
        public DbSet<PSUEficency> PsuEficenciess { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}