using GameDeckBusiness.Commands;
using GameDeckBusiness.Converters;
using GameDeckBusiness.Queries;
using GameDeckDto;
using Modele;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente un manager.
    /// </summary>
    /// <remarks>Attention c'est un singleton</remarks>
    public class Manager : IManager
    {
        private static Manager _instance = null;
        private readonly Context _context;

        private Manager()
        {
            _context = new Context();
        }

        /// <summary>
        /// Obtient l'instance du <see cref="Manager"/>
        /// </summary>
        public static Manager GetInstance()
            => _instance ?? (_instance = new Manager());

        #region methods Editeur

        /// <summary>
        /// Obtient une liste d'<see cref="EditeurDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="EditeurDto"/>.</returns>
        public List<EditeurDto> GetAllEditeurs()
        {
            return EditeurConverter.ConvertToDto(
                new EditeurQuery(_context).GetAll().ToList()
            );
        }

        /// <summary>
        /// Obtient un <see cref="EditeurDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'editeur.</param>
        /// <returns>Un <see cref="EditeurDto"/>.</returns>
        public EditeurDto GetOneEditeur(int id)
        {
            return EditeurConverter.ConvertToDto(
                 new EditeurQuery(_context).GetById(id).FirstOrDefault()
             );
        }

        /// <summary>
        /// Ajoute un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à ajouter.</param>
        /// <returns>L'identifiant de l'editeur crée.</returns>
        public int AddEditeur(EditeurDto editeur)
        {
            return new EditeurCommand(_context).Add(
                EditeurConverter.ConvertToEntity(editeur)
            );
        }

        /// <summary>
        /// Met à jour un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à modifier.</param>
        public void UpdateEditeur(EditeurDto editeur)
        {
            new EditeurCommand(_context).Update(
                 EditeurConverter.ConvertToEntity(editeur)
            );
        }

        /// <summary>
        /// Supprime un editeur par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'editeur à supprimer.</param>
        public void DeleteEditeur(int id)
        {
            new EditeurCommand(_context).Delete(id);
        }

        #endregion

        #region methods Evaluation

        /// <summary>
        /// Obtient une liste d'<see cref"EvaluationDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref"EvaluationDto"/>.</returns>
        public List<EvaluationDto> GetAllEvaluations()
        {
            return EvaluationConverter.ConvertToDto(
                new EvaluationQuery(_context).GetAll().ToList()
            );
        }

        /// <summary>
        /// Obtient une <see cref="EvaluationDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'evaluation.</param>
        /// <returns>Une <see cref="EvaluationDto"/>.</returns>
        public EvaluationDto GetOneEvaluation(int id)
        {
            return EvaluationConverter.ConvertToDto(
                 new EvaluationQuery(_context).GetById(id).FirstOrDefault()
             );
        }

        /// <summary>
        /// Ajoute une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à ajouter.</param>
        /// <returns>L'identifiant de l'evaluation crée.</returns>
        public int AddEvaluation(EvaluationDto evaluation)
        {
            return new EvaluationCommand(_context).Add(
                EvaluationConverter.ConvertToEntity(evaluation)
            );
        }

        /// <summary>
        /// Met à jour une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à modifier.</param>
        public void UpdateEvaluation(EvaluationDto evaluation)
        {
            new EvaluationCommand(_context).Update(
                EvaluationConverter.ConvertToEntity(evaluation)
            );
        }

        /// <summary>
        /// Supprime une evaluation par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'evaluation à supprimer.</param>
        public void DeleteEvaluation(int id)
        {
            new EvaluationCommand(_context).Delete(id);
        }

        #endregion

        #region methods Experience

        /// <summary>
        /// Obtient une liste d'<see cref="ExperienceDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="ExperienceDto"/>.</returns>
        public List<ExperienceDto> GetAllExperiences()
        {
            return ExperienceConverter.ConvertToDto(
                new ExperienceQuery(_context).GetAll().ToList()
            );
        }

        /// <summary>
        /// Obtient une <see cref="ExperienceDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'experience.</param>
        /// <returns>Une <see cref="ExperienceDto"/>.</returns>
        public ExperienceDto GetOneExperience(int id)
        {
            return ExperienceConverter.ConvertToDto(
                 new ExperienceQuery(_context).GetById(id).FirstOrDefault()
             );
        }

        /// <summary>
        /// Ajoute une experience.
        /// </summary>
        /// <param name="experience">L'experience à ajouter.</param>
        /// <returns>L'identifiant de l'experience crée.</returns>
        public int AddExperience(ExperienceDto experience)
        {
            return new ExperienceCommand(_context).Add(
                ExperienceConverter.ConvertToEntity(experience)
            );
        }

        /// <summary>
        /// Met à jour une experience.
        /// </summary>
        /// <param name="experience">L'experience à modifier.</param>
        public void UpdateExperience(ExperienceDto experience)
        {
            new ExperienceCommand(_context).Update(
                ExperienceConverter.ConvertToEntity(experience)
            );
        }

        /// <summary>
        /// Supprime une experience par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'experience à supprimer.</param>
        public void DeleteExperience(int id)
        {
            new ExperienceCommand(_context).Delete(id);
        }

        #endregion

        #region methods Genre

        /// <summary>
        /// Obtient une liste de <see cref="GenreDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="GenreDto"/>.</returns>
        public List<GenreDto> GetAllGenres()
        {
            return GenreConverter.ConvertToDto(
                new GenreQuery(_context).GetAll().ToList()
            );
        }

        /// <summary>
        /// Obtient un <see cref="GenreDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du genre.</param>
        /// <returns>Un <see cref="GenreDto"/>.</returns>
        public GenreDto GetOneGenre(int id)
        {
            return GenreConverter.ConvertToDto(
                 new GenreQuery(_context).GetById(id).FirstOrDefault()
             );
        }

        /// <summary>
        /// Ajoute un genre.
        /// </summary>
        /// <param name="genre">Le genre à ajouter.</param>
        /// <returns>L'identifiant du genre crée.</returns>
        public int AddGenre(GenreDto genre)
        {
            return new GenreCommand(_context).Add(
                GenreConverter.ConvertToEntity(genre)
            );
        }

        /// <summary>
        /// Met à jour un genre.
        /// </summary>
        /// <param name="genre">Le genre à modifier.</param>
        public void UpdateGenre(GenreDto genre)
        {
            new GenreCommand(_context).Update(
                GenreConverter.ConvertToEntity(genre)
            );
        }

        /// <summary>
        /// Supprime un genre par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du genre à supprimer.</param>
        public void DeleteGenre(int id)
        {
            new GenreCommand(_context).Delete(id);
        }

        #endregion

        #region methods Jeu

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public List<JeuDto> GetAllJeux(bool includeAll = false, Func<JeuDto, bool> wherePredicate = null)
        {
            IQueryable<Modele.Entities.Jeu> query = new JeuQuery(_context).GetAll();

            if (includeAll)
                query = query
                    .Include(jeu => jeu.GenreObj)
                    .Include(jeu => jeu.EditeurObj)
                    .Include(jeu => jeu.Evaluations)
                    .Include(jeu => jeu.Experiences);

            if (wherePredicate != null)
                return query.ToList().Select(j => JeuConverter.ConvertToDto(j)).Where(wherePredicate).ToList();

            // Premier .ToList() nécessaire sinon expression interprété par linq => ne connait pas ConvertToDto().
            return query.ToList().Select(j => JeuConverter.ConvertToDto(j)).ToList();
        }

        /// <summary>
        /// Obtient un <see cref="JeuDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du jeu.</param>
        /// <param name="includeAll">Indique si on veut inclure toutes propriétés du jeu (faux par défaut).</param>
        /// <returns>Un <see cref="JeuDto"/>.</returns>
        public JeuDto GetOneJeu(int id, bool? includeAll = false)
        {
            IQueryable<Modele.Entities.Jeu> query = new JeuQuery(_context).GetById(id);

            if (includeAll.HasValue && includeAll.Value)
            {
                query.Include(jeu => jeu.GenreObj);
                query.Include(jeu => jeu.EditeurObj);
                query.Include(jeu => jeu.Evaluations);
                query.Include(jeu => jeu.Experiences);
            }

            return JeuConverter.ConvertToDto(
                 query.FirstOrDefault()
             );
        }

        /// <summary>
        /// Ajoute un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter.</param>
        /// <returns>L'identifiant du jeu crée.</returns>
        public int AddJeu(JeuDto jeu)
        {
            return new JeuCommand(_context).Add(
                JeuConverter.ConvertToEntity(jeu)
            );
        }

        /// <summary>
        /// Met à jour un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à modifier.</param>
        public void UpdateJeu(JeuDto jeu)
        {
            new JeuCommand(_context).Update(
                JeuConverter.ConvertToEntity(jeu)
            );
        }

        /// <summary>
        /// Supprime un jeu par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du jeu à supprimer.</param>
        public void DeleteJeu(int id)
        {
            new JeuCommand(_context).Delete(id);
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> correspondant à la recherche.
        /// </summary>
        /// <param name="searchText">la recherche.</param>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public List<JeuDto> FindJeuxByName(string searchText)
        {
            return JeuConverter.ConvertToDto(
                new JeuQuery(_context).GetAll().Where(jeu => jeu.Nom.Contains(searchText)).ToList()
            );
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> ayant les meilleurs notes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="JeuDto"/> ayant les meilleurs notes.</returns>
        public List<JeuDto> TopJeuxByMark(int nbItem)
        {
            return JeuConverter.ConvertToDto(
                new JeuQuery(_context).GetAll().Include(j => j.Evaluations).OrderByDescending(jeu => jeu.Evaluations.Average(e => e.Note)).Take(nbItem).ToList()
            );
        }

        #endregion
    }
}
