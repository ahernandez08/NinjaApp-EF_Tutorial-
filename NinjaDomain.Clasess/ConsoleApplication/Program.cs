using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaDomain.Clasess;
using NinjaDomain.DataModel;
using System.Data.Entity;

namespace ConsoleApplication
{
    using Ninja = NinjaDomain.Clasess.Ninja;
    class Program
    {
        static void Main(string[] args)
        {
            //Database Initializer
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());

            bool loop = true;
            string option;

            while (loop)
            {
                Console.WriteLine("******Welcome to Ninja Manager*******");
                Console.WriteLine(" ");
                Console.WriteLine("1. Insert a Ninja.");
                Console.WriteLine("2. Delete a Ninja.");
                Console.WriteLine("3. Search a Ninja.");
                Console.WriteLine("4. Modify a Ninja.");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        break;
                    case "2":
                        Console.WriteLine("Okay");
                        break;
                    case "3":
                        loop = false;
                        break;
                }

            }

            Console.WriteLine("Thanks for using this app!");
            
        }

        public static void InsertNinja(int n_id, string name, bool served, int c_id)
        {
            var ninja = new Ninja{
                Id = n_id,
                Name = name,
                ServedInOniwaban = served,
                ClanId = c_id
            }; 

            var context = new NinjaContext();

            context.Database.Log = Console.Write;
            context.Ninjas.Add(ninja);
            context.SaveChanges();
        }

        public static void InsertNinja()
        {
            //Manera de inicializar un objeto
            Ninja ninja = new Ninja
            {
                Id = 1,
                Name = "Naruto",
                ServedInOniwaban = false,
                ClanId = 1,
                EquipmentOwned = null
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
            /*
             * Otra manera de inicializar un objeto
            var ninja = new Ninja
            {
                Id = 1,
                Name = "Naruto",
                ServedInOniwaban = false,
                Clan = null,
                ClanId = 0,
                EquipmentOwned = null
            };
            */
        }
    }
}
