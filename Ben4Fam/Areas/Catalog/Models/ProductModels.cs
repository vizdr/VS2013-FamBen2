namespace Ben4Fam.Areas.Catalog.Models
{
    using Ben4Fam.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    //public class ProductModels : ApplicationDbContext
    //{
    //    // Your context has been configured to use a 'ProductModels' connection string from your application's 
    //    // configuration file (App.config or Web.config). By default, this connection string targets the 
    //    // 'Ben4Fam.Areas.Catalog.Models.ProductModels' database on your LocalDb instance. 
    //    // 
    //    // If you wish to target a different database and/or database provider, modify the 'ProductModels' 
    //    // connection string in the application configuration file. // base("name=DefaultConnection")
    //    public ProductModels()
    //        : base()
    //    {
    //    }
    //    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    //    // Add a DbSet for each entity type that you want to include in your model. For more information 
    //    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //    public DbSet<Product> Products { get; set; }
    //}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProdGroupId { get; set; }
        public ProdGroup ProdGroup { get; set; }
        public ICollection<Turnover> Turnovers { get; set; }
        public Product()
        {
            Turnovers = new List<Turnover>();
        }
    }

    public class Service : Product
    {
        public DateTime Periodicity { get; set; }
    }

    public class Thing : Product
    {
        public DateTime LifeTime { get; set; }
        public DateTime GarantieTime { get; set; }
        //public ThingUnit Unit { get; set; }

    }

    public class Wearable : Thing
    {
        //public Seasons Season { get; set; }
        //public Color Color { get; set; }
        public string Material { get; set; }
        //public UsageType UsageType { get; set; }
        public int ProdSubGroupId { get; set; }
        public ProdSubGroup ProdSubgroup { get; set; }

    }

    //public class Applicable : Thing
    //{
    //    public Enum NeedType { get; set; }
    //}

    public class ProdGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProdGroup()
        {
            Products = new List<Product>();
        }
    }

    public class ProdSubGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Wearable> Wearables { get; set; }
        public ProdSubGroup()
        {
            Wearables = new List<Wearable>();
        }
    }



    //public enum ThingUnit
    //{
    //    Item, Kg, Meter, Sec, Liter
    //}

    //public enum Seasons
    //{
    //    Winter, DemiSeason, Sommer
    //}

    //public enum Color
    //{
    //    Black, White, Gray, Yellow, Red, Blue, Green, Brown
    //}

    //public enum UsageType
    //{
    //    EveryDay, Home, Sport, Presentation, Work, Holiday
    //}
}