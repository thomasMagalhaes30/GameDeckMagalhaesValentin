using GameDeckBusiness.Converters;
using GameDeckBusiness.Queries;
using GameDeckDto;
using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente un manager.
    /// </summary>
    /// <remarks>Attention c'est un singleton</remarks>
    public class Manager : IManager
    {
        private static Manager _instance = null;
        private Context _context;

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
        /// Obtient la liste des <see cref="EditeurDto"/>
        /// </summary>
        public List<EditeurDto> GetAllEditeurs()
        {
            return EditeurConverter.ConvertToDto(new EditeurQuery(_context).GetAll());
        }

        /// <summary>
        /// Permet d'ajouter un <see cref="EditeurDto"/>
        /// </summary>
        public void AddEditeur(EditeurDto experience)
        {
            new EditeurQuery(_context).Add(EditeurConverter.ConvertToEntity(experience));
        }

        /// <summary>
        /// Permet de mettre à jour un <see cref="EditeurDto"/>
        /// </summary>
        public void UpdateEditeur(EditeurDto experience)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de surprimer un <see cref="EditeurDto"/>
        /// </summary>
        public void DeleteEditeur(EditeurDto experience)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region methods Evaluation

        /// <summary>
        /// Obtient la liste des <see cref="EvaluationDto"/>
        /// </summary>
        public List<EvaluationDto> GetAllEvaluations()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet d'ajouter un <see cref="EvaluationDto"/>
        /// </summary>
        public void AddEvaluation(EvaluationDto experience)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de mettre à jour un <see cref="EvaluationDto"/>
        /// </summary>
        public void UpdateEvaluation(EvaluationDto experience)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de surprimer un <see cref="EvaluationDto"/>
        /// </summary>
        public void DeleteEvaluation(EvaluationDto experience)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region methods Experience

        /// <summary>
        /// Obtient la liste des <see cref="ExperienceDto"/>
        /// </summary>
        public List<ExperienceDto> GetAllExperiences()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet d'ajouter un <see cref="ExperienceDto"/>
        /// </summary>
        public void AddExperience(ExperienceDto experience)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de mettre à jour un <see cref="ExperienceDto"/>
        /// </summary>
        public void UpdateExperience(ExperienceDto experience)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de surprimer un <see cref="ExperienceDto"/>
        /// </summary>
        public void DeleteExperience(ExperienceDto experience)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region methods Genre

        /// <summary>
        /// Obtient la liste des <see cref="GenreDto"/>
        /// </summary>
        public List<GenreDto> GetAllGenres()
        {
            return GenreConverter.ConvertToDto(new GenreQuery(_context).GetAll());
        }

        /// <summary>
        /// Permet d'ajouter un <see cref="GenreDto"/>
        /// </summary>
        public void AddGenre(GenreDto genre)
        {
            new GenreQuery(_context).Add(GenreConverter.ConvertToEntity(genre));
        }

        /// <summary>
        /// Permet de mettre à jour un <see cref="GenreDto"/>
        /// </summary>
        public void UpdateGenre(GenreDto genre)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de surprimer un <see cref="GenreDto"/>
        /// </summary>
        public void DeleteGenre(GenreDto genre)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region methods Jeu

        /// <summary>
        /// Obtient la liste des <see cref="JeuDto"/>
        /// </summary>
        public List<JeuDto> GetAllJeux()
        {
            return JeuConverter.ConvertToDto(new JeuQuery(_context).GetAll());
        }

        /// <summary>
        /// Permet d'ajouter un <see cref="JeuDto"/>
        /// </summary>
        public void AddJeu(JeuDto jeu)
        {
            new JeuQuery(_context).Add(JeuConverter.ConvertToEntity(jeu));
        }

        /// <summary>
        /// Permet de mettre à jour un <see cref="JeuDto"/>
        /// </summary>
        public void UpdateJeu(JeuDto jeu)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permet de surprimer un <see cref="JeuDto"/>
        /// </summary>
        public void DeleteJeu(JeuDto jeu)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
