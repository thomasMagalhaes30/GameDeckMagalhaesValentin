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

                Console.WriteLine("On vide tout");
                Manager.GetInstance().GetAllExperiences()?.ForEach(e => Manager.GetInstance().DeleteExperience(e.Id));
                Manager.GetInstance().GetAllEvaluations()?.ForEach(e => Manager.GetInstance().DeleteEvaluation(e.Id));
                Manager.GetInstance().GetAllJeux()?.ForEach(j => Manager.GetInstance().DeleteJeu(j.Id));
                Manager.GetInstance().GetAllGenres()?.ForEach(g => Manager.GetInstance().DeleteGenre(g.Id));
                Manager.GetInstance().GetAllEditeurs()?.ForEach(e => Manager.GetInstance().DeleteEditeur(e.Id));


                // GENRE
                GenreDto g1 = new GenreDto { Nom = "Course" };
                GenreDto g2 = new GenreDto { Nom = "Aventure" };
                GenreDto g3 = new GenreDto { Nom = "Famille" };
                g1.Id = Manager.GetInstance().AddGenre(g1);
                g2.Id = Manager.GetInstance().AddGenre(g2);
                g3.Id = Manager.GetInstance().AddGenre(g3);
                // lecture des genres
                Console.WriteLine("\nListe de mes genres : ");
                Manager.GetInstance().GetAllGenres().ForEach(g => Console.WriteLine("Genre n°{0} : {1}", g.Id, g.Nom));
                Console.WriteLine("...Fin...");

                // EDITEUR
                EditeurDto ed1 = new EditeurDto { Nom = "Nintendo" };
                EditeurDto ed2 = new EditeurDto { Nom = "Ubisoft" };
                ed1.Id = Manager.GetInstance().AddEditeur(ed1);
                ed2.Id = Manager.GetInstance().AddEditeur(ed2);
                // lecture des editeur
                Console.WriteLine("\nListe de mes éditeurs : ");
                Manager.GetInstance().GetAllEditeurs().ForEach(e => Console.WriteLine("Editeur n°{0} : {1}", e.Id, e.Nom));
                Console.WriteLine("...Fin...");

                // JEUX
                Console.WriteLine("Ajout des jeux");
                JeuDto j1 = new JeuDto {
                    Nom = "Tracmania",
                    Description = "Jeu de voiture créer par nadéo",
                    DateSortie = DateTime.Today,
                    GenreId = g1.Id,
                    EditeurId = ed1.Id
                };
                JeuDto j2 = new JeuDto {
                    Nom = "kirby",
                    Description = "Jeu d'aventure créer par une personne chinoise du japon",
                    DateSortie = new DateTime(2008, 6, 1, 7, 47, 0),
                    GenreId = g2.Id,
                    EditeurId = ed2.Id
                };
                JeuDto j3 = new JeuDto
                {
                    Nom = "Super Mario Party Switch",
                    Description = "La série Mario Party débarque sur Nintendo Switch avec un gameplay et des mini-jeux survoltés pour tous ! Le jeu de plateau original a été agrémenté de nouveaux éléments stratégiques, comme les dés propres à chaque personnage.",
                    DateSortie = new DateTime(2018, 10, 5, 0, 0, 0),
                    GenreId = g3.Id,
                    EditeurId = ed2.Id
                };
                j1.Id = Manager.GetInstance().AddJeu(j1);
                j2.Id = Manager.GetInstance().AddJeu(j2);
                j3.Id = Manager.GetInstance().AddJeu(j3);

                // EVALUATION
                Console.WriteLine("Ajout des évaluations");
                EvaluationDto eval1 = new EvaluationDto { NomEvaluateur = "Guillaume", Date = new DateTime(2022, 6, 4, 9, 54, 10), Note = 14.7f, JeuId = j1.Id };
                EvaluationDto eval2 = new EvaluationDto { NomEvaluateur = "Thomas", Date = new DateTime(2022, 6, 4, 9, 55, 30), Note = 18.5f, JeuId = j1.Id };
                EvaluationDto eval3 = new EvaluationDto { NomEvaluateur = "James", Date = new DateTime(2022, 6, 25, 9, 55, 30), Note = 15f, JeuId = j3.Id };
                eval1.Id = Manager.GetInstance().AddEvaluation(eval1);
                eval2.Id = Manager.GetInstance().AddEvaluation(eval2);
                eval3.Id = Manager.GetInstance().AddEvaluation(eval3);

                // EXPERIENCE
                Console.WriteLine("Ajout des expériences");
                ExperienceDto exp1 = new ExperienceDto { Joueur = "Guillaume", TempsJeu = new TimeSpan(5, 6, 13), Pourcentage = 1f, JeuId = j1.Id };
                ExperienceDto exp2 = new ExperienceDto { Joueur = "Thomas", TempsJeu = new TimeSpan(32, 45, 30), Pourcentage = 2f, JeuId = j1.Id };
                exp1.Id = Manager.GetInstance().AddExperience(exp1);
                exp2.Id = Manager.GetInstance().AddExperience(exp2);

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
