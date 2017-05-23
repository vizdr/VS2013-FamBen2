namespace Ben4Fam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    //public class PersonModels : ApplicationDbContext
    //{
    //    // Your context has been configured to use a 'PersonModels' connection string from your application's 
    //    // configuration file (App.config or Web.config). By default, this connection string targets the 
    //    // 'Ben4Fam.Models.PersonModels' database on your LocalDb instance. 
    //    // 
    //    // If you wish to target a different database and/or database provider, modify the 'PersonModels' 
    //    // connection string in the application configuration file.
    //    // 
    //    public PersonModels()
    //        : base()
    //    {
    //    }

    //    // Add a DbSet for each entity type that you want to include in your model. For more information 
    //    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //    public  DbSet<Person> People { get; set; }
    //}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public  class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        //public FamilyRole FamilyRelation { get; set; }
        public String NickName { get; set; }
        public Supplier Supplier { get; set; }
        public Acceptor Acceptor { get; set; }
    }

    //public enum FamilyRole
    //{
    //    Alien, Friend, Acquaintance, Eltern, ElternEltern, Chilld, Relative
    //}

    public class Supplier
    {
        [Key]
        [ForeignKey("Person")]
        public int SupplierId { get; set; }
        public Person Person { get; set; }
        public virtual ICollection<Turnover> Turnovers { get; set; }
        public Supplier()
        {
            Turnovers = new List<Turnover>();
        }
    }

    public class Acceptor
    {
        [Key]
        [ForeignKey("Person")]
        public int AcceptorId { get; set; }

        public Person Person { get; set; }
        public virtual ICollection<Turnover> Turnovers { get; set; }
        public Acceptor()
        {
            Turnovers = new List<Turnover>();
        }
    }

   
}