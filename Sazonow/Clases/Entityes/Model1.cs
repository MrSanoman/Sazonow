using MySql.Data.EntityFramework;
using Sazonow.Clases.Entityes;
using System;
using System.Data.Entity;
using System.Linq;


namespace Sazonow.Clases.Entityes
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Model1 : DbContext
    {
        private static Model1 Instance;
        public static Model1 init()
        {
            if (Instance == null)
            {
                Instance = new Model1();

            }
            return Instance;
        }
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Sazonow.Clases.Entityes.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("Server = 192.168.201.12; Port = 3306; UserID = ISP347_SazonovAI; Password = 2001; Database = ISP347_SazonovAI_Gibdd; CharacterSet = utf8")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //public virtual DbSet<MyEntity> MyEntities { get; set; }

         public virtual DbSet<User> Users { get; set; }

         public virtual DbSet<Tovar> Tovars { get; set; }

         public virtual DbSet<Sell> Sells { get; set; }


}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}