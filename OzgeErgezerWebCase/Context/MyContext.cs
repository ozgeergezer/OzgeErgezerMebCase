using OzgeErgezerWebCase.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgeErgezerWebCase.Context
{
   
        public class MyContext : DbContext
        {
        public MyContext() : base("name=MebCaseDb")
        {
            Database.SetInitializer(new KategoriInitializer());
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
    
}
