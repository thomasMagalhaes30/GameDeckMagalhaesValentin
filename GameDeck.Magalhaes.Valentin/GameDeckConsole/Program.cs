using GameDeckBusiness;
using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

                // GENRE
                var g1 = new GenreDto { Nom = "Course" };
                var g2 = new GenreDto { Nom = "Aventure" };
                g1 = Manager.GetInstance().AddGenre(g1);
                g2 = Manager.GetInstance().AddGenre(g2);
                // lecture des genres
                Console.WriteLine("\nListe de mes genres : ");
                Manager.GetInstance().GetAllGenres().ForEach(g => Console.WriteLine("Genre n°{0} : {1}", g.Id, g.Nom));
                Console.WriteLine("...Fin...");

                // EDITEUR
                var ed1 = new EditeurDto { Nom = "Nintendo" };
                var ed2 = new EditeurDto { Nom = "Ubisoft" };
                ed1 = Manager.GetInstance().AddEditeur(ed1);
                ed2 = Manager.GetInstance().AddEditeur(ed2);
                // lecture des editeur
                Console.WriteLine("\nListe de mes éditeurs : ");
                Manager.GetInstance().GetAllEditeurs().ForEach(e => Console.WriteLine("Editeur n°{0} : {1}", e.Id, e.Nom));
                Console.WriteLine("...Fin...");

                // JEUX
                var j1 = new JeuDto {
                    Nom = "Tracmania",
                    Description = "Jeu de voiture créer par nadéo",
                    DateSortie = DateTime.Today,
                    GenreId = g1.Id,
                    EditeurId = ed1.Id
                };
                var j2 = new JeuDto {
                    Nom = "kirby",
                    Description = "Jeu d'aventure créer par une personne",
                    DateSortie = new DateTime(2008, 6, 1, 7, 47, 0),
                    GenreId = g2.Id,
                    EditeurId = ed2.Id
                };
                j1 = Manager.GetInstance().AddJeu(j1);
                j2 = Manager.GetInstance().AddJeu(j2);

                // EVALUATION
                var eval1 = new EvaluationDto { NomEvaluateur = "Guillaume", Date = new DateTime(2022, 6, 4, 9, 54, 10), Note = 14.7f, JeuId = j1.Id };
                var eval2 = new EvaluationDto { NomEvaluateur = "Thomas", Date = new DateTime(2022, 6, 4, 9, 55, 30), Note = 18.5f, JeuId = j1.Id };
                eval1 = Manager.GetInstance().AddEvaluation(eval1);
                eval2 = Manager.GetInstance().AddEvaluation(eval2);

                // EXPERIENCE
                var exp1 = new ExperienceDto { Joueur = "Guillaume", TempsJeu = new TimeSpan(5, 6, 13), Pourcentage = 1f, JeuId = j1.Id };
                var exp2 = new ExperienceDto { Joueur = "Thomas", TempsJeu = new TimeSpan(32, 45, 30), Pourcentage = 2f, JeuId = j1.Id };
                exp1 = Manager.GetInstance().AddExperience(exp1);
                exp2 = Manager.GetInstance().AddExperience(exp2);

                // lecture des jeux
                Console.WriteLine("\nListe de mes jeux : ");
                Manager.GetInstance().GetAllJeux().ForEach(j => {
                    Console.WriteLine("Jeux n°{0} : {1}({2})\n{3}\n{4}", j.Id, j.Nom, j.DateSortie.ToString("dd/mm/yyyy"), j.GenreObj.Nom, j.Description);
                    j.Evaluations?.ToList().ForEach(eval =>
                        Console.WriteLine("Eval n°{0} : {1} - {2}", eval.Id, eval.NomEvaluateur, eval.Note)
                    );
                    j.Experiences?.ToList().ForEach(exp =>
                        Console.WriteLine("Exp n°{0} : {1} - {2} ({3})", exp.Id, exp.Joueur, exp.Pourcentage, exp.TempsJeu.ToString("g"))
                    );
                    Console.WriteLine();
                });
                Console.WriteLine("...Fin...");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
