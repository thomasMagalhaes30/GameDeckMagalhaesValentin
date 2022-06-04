using GameDeckBusiness;
using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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

                var g1 = new GenreDto { Nom = "Action" };
                var g2 = new GenreDto { Nom = "Tir" };
                Manager.GetInstance().AddGenre(g1);
                Manager.GetInstance().AddGenre(g2);

                // lecture des genres
                List<GenreDto> lesGenres = Manager.GetInstance().GetAllGenres();
                Console.WriteLine("Liste de mes genres : ");
                foreach (GenreDto g in lesGenres)
                {
                    Console.WriteLine("Genre n°{0} : {1}", g.Id, g.Nom);
                }
                Console.WriteLine("...Fin...");


                //Console.WriteLine(Manager.GetInstance().GetAllJeux());
                //Manager.GetInstance().AddEditeur(new EditeurDto { Nom = "Nintendo" });
                //var a = Manager.GetInstance().GetAllEditeurs();
                //Console.WriteLine(Manager.GetInstance().GetAllEditeurs());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
