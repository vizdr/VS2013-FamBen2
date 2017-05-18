namespace Ben4Fam.Areas.Catalog.Models
{
    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

    public class ProductModels : DbContext
    {
        // Your context has been configured to use a 'ProductModels' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Ben4Fam.Areas.Catalog.Models.ProductModels' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProductModels' 
        // connection string in the application configuration file.
        public ProductModels()
            : base("name=ProductModels")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Enum Currency { get; set; }
        public int ProdGroupId { get; set; }
        public ProdGroup Group { get; set; }
    }

    public class Service : Product
    {
        public DateTime Periodicity { get; set; }
    }

    public class Thing : Product
    {
        public DateTime Lifetime { get; set; }
        //public float Qty { get; set; }
        public Enum Unit { get; set; }
        public bool IsInWork { get; set; }
        public bool IsStored { get; set; }
    }

    public class Wearable : Thing
    {
        public Enum Season { get; set; }
        public Enum Color { get; set; }
        public string Material { get; set; }
        public Enum UsageType { get; set; }
        public int ProdSubGroupId { get; set; }
        public ProdSubGroup ProdSubgroup { get; set; }

    }

    public class Applicable : Thing
    {
        public Enum NeedType { get; set; }
    }

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
}