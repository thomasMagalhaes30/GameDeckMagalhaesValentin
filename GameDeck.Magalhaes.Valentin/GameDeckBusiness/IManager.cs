using GameDeckBusiness.Queries;
using GameDeckDto;
using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente l'interface du manager.
    /// </summary>
    public interface IManager
    {
        #region methods Editeur

        /// <summary>
        /// Obtient une liste d'<see cref="EditeurDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="EditeurDto"/>.</returns>
        List<EditeurDto> GetAllEditeurs();

        /// <summary>
        /// Obtient une liste d'<see cref="EditeurDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="EditeurDto"/>.</returns>
        Task<List<EditeurDto>> GetAllEditeursAsync();

        /// <summary>
        /// Obtient un <see cref="EditeurDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'editeur.</param>
        /// <returns>Un <see cref="EditeurDto"/>.</returns>
        EditeurDto GetOneEditeur(int id);

        /// <summary>
        /// Obtient un <see cref="EditeurDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'editeur.</param>
        /// <returns>Un <see cref="EditeurDto"/>.</returns>
        Task<EditeurDto> GetOneEditeurAsync(int id);

        /// <summary>
        /// Ajoute un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à ajouter.</param>
        /// <returns>L'identifiant de l'editeur crée.</returns>
        int AddEditeur(EditeurDto editeur);

        /// <summary>
        /// Ajoute un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à ajouter.</param>
        /// <returns>L'identifiant de l'editeur crée.</returns>
        Task<int> AddEditeurAsync(EditeurDto editeur);

        /// <summary>
        /// Met à jour un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à modifier.</param>
        void UpdateEditeur(EditeurDto editeur);

        /// <summary>
        /// Met à jour un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à modifier.</param>
        Task UpdateEditeurAsync(EditeurDto editeur);

        /// <summary>
        /// Supprime un editeur par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'editeur à supprimer.</param>
        void DeleteEditeur(int id);

        /// <summary>
        /// Supprime un editeur par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'editeur à supprimer.</param>
        Task DeleteEditeurAsync(int id);

        #endregion

        #region methods Evaluation

        /// <summary>
        /// Obtient une liste d'<see cref"EvaluationDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref"EvaluationDto"/>.</returns>
        List<EvaluationDto> GetAllEvaluations();

        /// <summary>
        /// Obtient une liste d'<see cref"EvaluationDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref"EvaluationDto"/>.</returns>
        Task<List<EvaluationDto>> GetAllEvaluationsAsync();

        /// <summary>
        /// Obtient une <see cref="EvaluationDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'evaluation.</param>
        /// <returns>Une <see cref="EvaluationDto"/>.</returns>
        EvaluationDto GetOneEvaluation(int id);

        /// <summary>
        /// Obtient une <see cref="EvaluationDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'evaluation.</param>
        /// <returns>Une <see cref="EvaluationDto"/>.</returns>
        Task<EvaluationDto> GetOneEvaluationAsync(int id);

        /// <summary>
        /// Ajoute une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à ajouter.</param>
        /// <returns>L'identifiant de l'evaluation crée.</returns>
        int AddEvaluation(EvaluationDto evaluation);

        /// <summary>
        /// Ajoute une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à ajouter.</param>
        /// <returns>L'identifiant de l'evaluation crée.</returns>
        Task<int> AddEvaluationAsync(EvaluationDto evaluation);

        /// <summary>
        /// Met à jour une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à modifier.</param>
        void UpdateEvaluation(EvaluationDto evaluation);

        /// <summary>
        /// Met à jour une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à modifier.</param>
        Task UpdateEvaluationAsync(EvaluationDto evaluation);

        /// <summary>
        /// Supprime une evaluation par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'evaluation à supprimer.</param>
        void DeleteEvaluation(int id);

        /// <summary>
        /// Supprime une evaluation par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'evaluation à supprimer.</param>
        Task DeleteEvaluationAsync(int id);

        /// <summary>
        /// Obtient une liste de <see cref="EvaluationDto"/> les plus récentes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="EvaluationDto"/> les plus récentes.</returns>
        List<EvaluationDto> LastEvaluation(int nbItem);

        /// <summary>
        /// Obtient une liste de <see cref="EvaluationDto"/> les plus récentes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="EvaluationDto"/> les plus récentes.</returns>
        Task<List<EvaluationDto>> LastEvaluationAsync(int nbItem);

        #endregion

        #region methods Experience

        /// <summary>
        /// Obtient une liste d'<see cref="ExperienceDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="ExperienceDto"/>.</returns>
        List<ExperienceDto> GetAllExperiences();

        /// <summary>
        /// Obtient une liste d'<see cref="ExperienceDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="ExperienceDto"/>.</returns>
        Task<List<ExperienceDto>> GetAllExperiencesAsync();

        /// <summary>
        /// Obtient une <see cref="ExperienceDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'experience.</param>
        /// <returns>Une <see cref="ExperienceDto"/>.</returns>
        ExperienceDto GetOneExperience(int id);

        /// <summary>
        /// Obtient une <see cref="ExperienceDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'experience.</param>
        /// <returns>Une <see cref="ExperienceDto"/>.</returns>
        Task<ExperienceDto> GetOneExperienceAsync(int id);

        /// <summary>
        /// Ajoute une experience.
        /// </summary>
        /// <param name="experience">L'experience à ajouter.</param>
        /// <returns>L'identifiant de l'experience crée.</returns>
        int AddExperience(ExperienceDto experience);

        /// <summary>
        /// Ajoute une experience.
        /// </summary>
        /// <param name="experience">L'experience à ajouter.</param>
        /// <returns>L'identifiant de l'experience crée.</returns>
        Task<int> AddExperienceAsync(ExperienceDto experience);

        /// <summary>
        /// Met à jour une experience.
        /// </summary>
        /// <param name="experience">L'experience à modifier.</param>
        void UpdateExperience(ExperienceDto experience);

        /// <summary>
        /// Met à jour une experience.
        /// </summary>
        /// <param name="experience">L'experience à modifier.</param>
        Task UpdateExperienceAsync(ExperienceDto experience);

        /// <summary>
        /// Supprime une experience par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'experience à supprimer.</param>
        void DeleteExperience(int id);

        /// <summary>
        /// Supprime une experience par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'experience à supprimer.</param>
        Task DeleteExperienceAsync(int id);

        #endregion

        #region methods Genre

        /// <summary>
        /// Obtient une liste de <see cref="GenreDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="GenreDto"/>.</returns>
        List<GenreDto> GetAllGenres();

        /// <summary>
        /// Obtient une liste de <see cref="GenreDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="GenreDto"/>.</returns>
        Task<List<GenreDto>> GetAllGenresAsync();

        /// <summary>
        /// Obtient un <see cref="GenreDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du genre.</param>
        /// <returns>Un <see cref="GenreDto"/>.</returns>
        GenreDto GetOneGenre(int id);

        /// <summary>
        /// Obtient un <see cref="GenreDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du genre.</param>
        /// <returns>Un <see cref="GenreDto"/>.</returns>
        Task<GenreDto> GetOneGenreAsync(int id);

        /// <summary>
        /// Ajoute un genre.
        /// </summary>
        /// <param name="genre">Le genre à ajouter.</param>
        /// <returns>L'identifiant du genre crée.</returns>
        int AddGenre(GenreDto genre);

        /// <summary>
        /// Ajoute un genre.
        /// </summary>
        /// <param name="genre">Le genre à ajouter.</param>
        /// <returns>L'identifiant du genre crée.</returns>
        Task<int> AddGenreAsync(GenreDto genre);

        /// <summary>
        /// Met à jour un genre.
        /// </summary>
        /// <param name="genre">Le genre à modifier.</param>
        void UpdateGenre(GenreDto genre);

        /// <summary>
        /// Met à jour un genre.
        /// </summary>
        /// <param name="genre">Le genre à modifier.</param>
        Task UpdateGenreAsync(GenreDto genre);

        /// <summary>
        /// Supprime un genre par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du genre à supprimer.</param>
        void DeleteGenre(int id);

        /// <summary>
        /// Supprime un genre par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du genre à supprimer.</param>
        Task DeleteGenreAsync(int id);

        #endregion

        #region methods Jeu

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        List<JeuDto> GetAllJeux(bool includeAll = false, Func<JeuDto, bool> wherePredicate = null);

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        Task<List<JeuDto>> GetAllJeuxAsync(bool includeAll = false, Func<JeuDto, bool> wherePredicate = null);

        /// <summary>
        /// Obtient un <see cref="JeuDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du jeu.</param>
        /// <param name="includeAll">Indique si on veut inclure toutes propriétés du jeu (faux par défaut).</param>
        /// <returns>Un <see cref="JeuDto"/>.</returns>
        JeuDto GetOneJeu(int id, bool? includeAll = false);

        /// <summary>
        /// Obtient un <see cref="JeuDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du jeu.</param>
        /// <param name="includeAll">Indique si on veut inclure toutes propriétés du jeu (faux par défaut).</param>
        /// <returns>Un <see cref="JeuDto"/>.</returns>
        Task<JeuDto> GetOneJeuAsync(int id, bool? includeAll = false);

        /// <summary>
        /// Ajoute un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter.</param>
        /// <returns>L'identifiant du jeu crée.</returns>
        int AddJeu(JeuDto jeu);

        /// <summary>
        /// Ajoute un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter.</param>
        /// <returns>L'identifiant du jeu crée.</returns>
        Task<int> AddJeuAsync(JeuDto jeu);

        /// <summary>
        /// Met à jour un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à modifier.</param>
        void UpdateJeu(JeuDto jeu);

        /// <summary>
        /// Met à jour un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à modifier.</param>
        Task UpdateJeuAsync(JeuDto jeu);

        /// <summary>
        /// Supprime un jeu par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du jeu à supprimer.</param>
        void DeleteJeu(int id);

        /// <summary>
        /// Supprime un jeu par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du jeu à supprimer.</param>
        Task DeleteJeuAsync(int id);

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> correspondant à la recherche.
        /// </summary>
        /// <param name="searchText">la recherche.</param>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        List<JeuDto> FindJeuxByName(string searchText);

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> correspondant à la recherche.
        /// </summary>
        /// <param name="searchText">la recherche.</param>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        Task<List<JeuDto>> FindJeuxByNameAsync(string searchText);

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> ayant les meilleurs notes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="JeuDto"/> ayant les meilleurs notes.</returns>
        List<JeuDto> TopJeuxByMark(int nbItem);

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> ayant les meilleurs notes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="JeuDto"/> ayant les meilleurs notes.</returns>
        Task<List<JeuDto>> TopJeuxByMarkAsync(int nbItem);

        #endregion
    }
}
