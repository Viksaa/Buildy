namespace Buildy.Migrations
{
    using Buildy.Models.PC_Components.PC_Helper_Models;
    using Buildy.Models.PC_Components;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Buildy.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Buildy.Models.ApplicationDbContext context)
        {
            context.Manufacturers.AddOrUpdate(x => x.Id,
              new Manufacturer() { Id = 1, Name = "Nvdia" },
              new Manufacturer() { Id = 2, Name = "AMD" },
              new Manufacturer() { Id = 3, Name = "Intel" },
              new Manufacturer() { Id = 4, Name = "MSI" },
              new Manufacturer() { Id = 5, Name = "EVGA" },
              new Manufacturer() { Id = 6, Name = "Cooler Master" },
              new Manufacturer() { Id = 7, Name = "Deep Cool" },
              new Manufacturer() { Id = 8, Name = "NZXT" },
              new Manufacturer() { Id = 9, Name = "Samsung" },
              new Manufacturer() { Id = 10, Name = "Kingston" },
              new Manufacturer() { Id = 11, Name = "Gigabyte" },
              new Manufacturer() { Id = 12, Name = "G Skill" },
              new Manufacturer() { Id = 13, Name = "Toshiba" },
              new Manufacturer() { Id = 14, Name = "Western Digital" },
              new Manufacturer() { Id = 15, Name = "Fractial Design" },
              new Manufacturer() { Id = 16, Name = "Sharkoon" },
              new Manufacturer() { Id = 17, Name = "A-Data" },
              new Manufacturer() { Id = 18, Name = "Asus" },
              new Manufacturer() { Id = 18, Name = "Corsair" }
               );

            context.MotherboardTypes.AddOrUpdate(x => x.Id,
                new MotherboardType() { Id = 1 , Name = "Atx"},
                new MotherboardType() { Id = 2, Name = "micro-Atx" },
                new MotherboardType() { Id = 3, Name = "mini-Atx" }
               );

            context.PsuEficenciess.AddOrUpdate(x => x.Id,
                new PSUEficency() { Id = 1, Name = "80 Plus Bronze" },
                new PSUEficency() { Id = 2, Name = "80 Plus Silver" },
                new PSUEficency() { Id = 3, Name = "80 Plus Gold" },
                new PSUEficency() { Id = 4, Name = "80 Plus Platinum" },
                new PSUEficency() { Id = 5, Name = "80 Plus Titanium" },
                new PSUEficency() { Id = 6, Name = "80 Plus " }
               );

            context.RamMemoryTypes.AddOrUpdate(x => x.Id,
                new RAMMemoryType() { Id = 1, Name = "DDR 3" },
                new RAMMemoryType() { Id = 2, Name = "DDR 4" },
                new RAMMemoryType() { Id = 3, Name = "GDDR 4" },
                new RAMMemoryType() { Id = 4, Name = "GDDR 5" },
                new RAMMemoryType() { Id = 5, Name = "GDDR 6" }
               );

            context.Sockets.AddOrUpdate(x => x.Id,
                new Socket() { Id = 1, Name = "LGA" },
                new Socket() { Id = 2, Name = "PGA" }
               );

            context.StorageTypes.AddOrUpdate(x => x.Id,
                new StorageType() { Id = 1, Name = "HDD"},
                new StorageType() { Id = 2, Name = "SSD" },
                new StorageType() { Id = 3, Name = "M.2" }
               );

            context.Chipsets.AddOrUpdate(x => x.Id,
                new Chipset() { Id = 1, Name = "AM4" },
                new Chipset() { Id = 2, Name = "AM3" },
                new Chipset() { Id = 3, Name = "LGA 1156" },
                new Chipset() { Id = 4, Name = "LGA 1155" },
                new Chipset() { Id = 5, Name = "LGA 1150" },
                new Chipset() { Id = 6, Name = "LGA 1366" }
               );

            context.CoolingTypes.AddOrUpdate(x => x.Id,
                new CoolingType() {Id = 1, Name = "Liquid" },
                new CoolingType() { Id = 1, Name = "Air" }
                );

            context.Cases.AddOrUpdate(x => x.Id,
                new Case() { Id = 1 , Name = "H510 Elite" , Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4 , ManufacturerId = 8 , ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2428/large_b2feaa953e1c78d9.jpg" , Price  = 170 , MotherboardTypeId = 1} ,
                new Case() { Id = 2, Name = "H710i", Dimensions = "W: 230mm H: 516mm D: 494mm", FanSupport = 5, ManufacturerId = 8, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2462/large_caaa8ad6b19de81c.jpg", Price = 200, MotherboardTypeId = 1 } ,
                new Case() { Id = 3, Name = "H500", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, ImageURL = "https://www.scan.co.uk/images/products/2948278-a.jpg", Price = 75, MotherboardTypeId = 1 } ,
                new Case() { Id = 4, Name = "H210i", Dimensions = "	W: 210mm H: 349mm D: 372mm", FanSupport = 4, ManufacturerId = 8, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2262/large_2fbdddad9178e815.jpg", Price = 120, MotherboardTypeId = 2 } ,
                new Case() { Id = 5, Name = "H510", Dimensions = "W: 210mm H: 435mm D: 428mm", FanSupport = 4, ManufacturerId = 8, ImageURL = "https://sta3-nzxtcorporation.netdna-ssl.com/uploads/product_image/image/2385/large_119c49cc79b97b94.jpg", Price = 80, MotherboardTypeId = 1 }
                );

            context.Gpus.AddOrUpdate(x => x.Id,
                new GPU() { Id = 1, Name = "RTX 2080 Black", ManufacturerId = 5, RAMSize = 8, Price = 675, Frequency = 1515, Timing = "1", MemoryClock = 14000, RAMTypeId = 5 , ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8f9aabc24178caf70135e2e6dc2f5445.1600.jpg" } ,
                new GPU() { Id = 2, Name = "RTX 2080 Ti Black", ManufacturerId = 5, RAMSize = 11, Price = 1070, Frequency = 1350, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/8f9aabc24178caf70135e2e6dc2f5445.1600.jpg" },
                new GPU() { Id = 3, Name = "RTX 2080 Ti ULTRA GAMING", ManufacturerId = 5, RAMSize = 11, Price = 1400, Frequency = 1755, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/03524d3eecccc31527c359f9de79d9c7.1600.jpg" },
                new GPU() { Id = 4, Name = "RTX 2080 Ti ROG Strix Gaming OC", ManufacturerId = 18, RAMSize = 11, Price = 1280, Frequency = 1350, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/0174f5005fe9f34decdf2d379bfe7221.1600.jpg" },
                new GPU() { Id = 5, Name = "RTX 2080 ROG Strix Gaming", ManufacturerId = 18, RAMSize = 8, Price = 770, Frequency = 1515, Timing = "1", MemoryClock = 14000, RAMTypeId = 5, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/d15b18b5b4b518256c4b8003672424c7.1600.jpg" }
                );

            context.Psus.AddOrUpdate(x => x.Id,
                new PSU() { Id = 1 , Name = "CXM" , Capacity = 550 , Modular = false , EfficiencyId = 1 , ManufacturerId = 18 ,Price = 70 ,ImageURL = "http://ecx.images-amazon.com/images/I/51RxdsALapL.jpg" },
                new PSU() { Id = 2, Name = "SuperNOVA G3", Capacity = 750, Modular = true, EfficiencyId = 3, ManufacturerId = 5, Price = 127, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/2a2172d1f17661103de901f43d831187.1600.jpg" },
                new PSU() { Id = 3, Name = "RMx (2018)", Capacity = 650, Modular = true, EfficiencyId = 3, ManufacturerId = 18, Price = 85, ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51icxwzI9VL.jpg" },
                new PSU() { Id = 4, Name = "MASTERWATT MAKER MIJ", Capacity = 1200, Modular = true, EfficiencyId = 5, ManufacturerId = 6, Price = 200, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/244afeb4bd3917774842c887571a9803.1600.jpg" },
                new PSU() { Id = 5, Name = "Master V", Capacity = 1000, Modular = true, EfficiencyId = 4, ManufacturerId = 6, Price = 180, ImageURL = "https://cdn.pcpartpicker.com/static/forever/images/product/c28253b1b63474d96ab2f28ff5cdcdce.1600.jpg" }
                );

        }
    }
}
