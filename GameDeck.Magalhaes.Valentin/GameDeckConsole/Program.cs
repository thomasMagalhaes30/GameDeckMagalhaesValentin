using GameDeckBusiness;
using GameDeckDto;
using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Debug.WriteLine("APP CONSOLE");
                Console.WriteLine($"APP CONSOLE {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}");
                Console.WriteLine(Manager.GetInstance().GetAllJeux());
                Manager.GetInstance().AddEditeur(new EditeurDto { Nom = "Nitendo" });
                Console.WriteLine(Manager.GetInstance().GetAllEditeurs());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
