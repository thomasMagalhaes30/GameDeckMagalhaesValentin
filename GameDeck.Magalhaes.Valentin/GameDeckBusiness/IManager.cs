using GameDeckBusiness.Queries;
using GameDeckDto;
using Modele;
using Modele.Entities;
using System.Collections.Generic;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente l'interface du manager.
    /// </summary>
    public interface IManager
    {
        #region methods Editeur

        /// <summary>
        /// Obtient la liste des <see cref="EditeurDto"/>
        /// </summary>
        List<EditeurDto> GetAllEditeurs();

        /// <summary>
        /// Permet d'ajouter un <see cref="EditeurDto"/>
        /// </summary>
        void AddEditeur(EditeurDto experience);

        /// <summary>
        /// Permet de mettre à jour un <see cref="EditeurDto"/>
        /// </summary>
        void UpdateEditeur(EditeurDto experience);

        /// <summary>
        /// Permet de surprimer un <see cref="EditeurDto"/>
        /// </summary>
        void DeleteEditeur(EditeurDto experience);

        #endregion

        #region methods Evaluation

        /// <summary>
        /// Obtient la liste des <see cref="EvaluationDto"/>
        /// </summary>
        List<EvaluationDto> GetAllEvaluations();

        /// <summary>
        /// Permet d'ajouter un <see cref="EvaluationDto"/>
        /// </summary>
        void AddEvaluation(EvaluationDto experience);

        /// <summary>
        /// Permet de mettre à jour un <see cref="EvaluationDto"/>
        /// </summary>
        void UpdateEvaluation(EvaluationDto experience);

        /// <summary>
        /// Permet de surprimer un <see cref="EvaluationDto"/>
        /// </summary>
        void DeleteEvaluation(EvaluationDto experience);

        #endregion

        #region methods Experience

        /// <summary>
        /// Obtient la liste des <see cref="ExperienceDto"/>
        /// </summary>
        List<ExperienceDto> GetAllExperiences();

        /// <summary>
        /// Permet d'ajouter un <see cref="ExperienceDto"/>
        /// </summary>
        void AddExperience(ExperienceDto experience);

        /// <summary>
        /// Permet de mettre à jour un <see cref="ExperienceDto"/>
        /// </summary>
        void UpdateExperience(ExperienceDto experience);

        /// <summary>
        /// Permet de surprimer un <see cref="ExperienceDto"/>
        /// </summary>
        void DeleteExperience(ExperienceDto experience);

        #endregion

        #region methods Genre

        /// <summary>
        /// Obtient la liste des <see cref="GenreDto"/>
        /// </summary>
        List<GenreDto> GetAllGenres();

        /// <summary>
        /// Permet d'ajouter un <see cref="GenreDto"/>
        /// </summary>
        void AddGenre(GenreDto genre);

        /// <summary>
        /// Permet de mettre à jour un <see cref="GenreDto"/>
        /// </summary>
        void UpdateGenre(GenreDto genre);

        /// <summary>
        /// Permet de surprimer un <see cref="GenreDto"/>
        /// </summary>
        void DeleteGenre(GenreDto genre);

        #endregion

        #region methods Jeu

        /// <summary>
        /// Obtient la liste des <see cref="JeuDto"/>
        /// </summary>
        List<JeuDto> GetAllJeux();

        /// <summary>
        /// Permet d'ajouter un <see cref="JeuDto"/>
        /// </summary>
        void AddJeu(JeuDto jeu);

        /// <summary>
        /// Permet de mettre à jour un <see cref="JeuDto"/>
        /// </summary>
        void UpdateJeu(JeuDto jeu);

        /// <summary>
        /// Permet de surprimer un <see cref="JeuDto"/>
        /// </summary>
        void DeleteJeu(JeuDto jeu);

        #endregion
    }
}
