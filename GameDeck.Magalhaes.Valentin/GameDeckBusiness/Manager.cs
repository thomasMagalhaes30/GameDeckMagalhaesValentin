using GameDeckBusiness.Commands;
using GameDeckBusiness.Converters;
using GameDeckBusiness.Queries;
using GameDeckDto;
using Modele;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GameDeckBusiness
{
    /// <summary>
    /// Represente un manager.
    /// </summary>
    /// <remarks>Attention c'est un singleton</remarks>
    public class Manager : IManager
    {
        private static Manager _instance = null;
        //private readonly Context _context;

        private Manager()
        {
            //_context = new Context();
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
            return Task.Run(() => GetAllEditeursAsync()).Result;
        }

        /// <summary>
        /// Obtient une liste d'<see cref="EditeurDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="EditeurDto"/>.</returns>
        public async Task<List<EditeurDto>> GetAllEditeursAsync()
        {
            using (var context = new Context())
            {
                return EditeurConverter.ConvertToDto(
                     await new EditeurQuery(context).GetAll().ToListAsync()
                 );
            }
        }

        /// <summary>
        /// Obtient un <see cref="EditeurDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'editeur.</param>
        /// <returns>Un <see cref="EditeurDto"/>.</returns>
        public EditeurDto GetOneEditeur(int id)
        {
            return Task.Run(() => GetOneEditeurAsync(id)).Result;
        }

        /// <summary>
        /// Obtient un <see cref="EditeurDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'editeur.</param>
        /// <returns>Un <see cref="EditeurDto"/>.</returns>
        public async Task<EditeurDto> GetOneEditeurAsync(int id)
        {
            using (var context = new Context())
            {
                return EditeurConverter.ConvertToDto(
                    await new EditeurQuery(context).GetById(id).FirstOrDefaultAsync()
                );
            }
        }

        /// <summary>
        /// Ajoute un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à ajouter.</param>
        /// <returns>L'identifiant de l'editeur crée.</returns>
        public int AddEditeur(EditeurDto editeur)
        {
            return Task.Run(() => AddEditeurAsync(editeur)).Result;
        }

        /// <summary>
        /// Ajoute un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à ajouter.</param>
        /// <returns>L'identifiant de l'editeur crée.</returns>
        public async Task<int> AddEditeurAsync(EditeurDto editeur)
        {
            using (var context = new Context())
            {
                return await new EditeurCommand(context).Add(
                    EditeurConverter.ConvertToEntity(editeur)
                );
            }
        }

        /// <summary>
        /// Met à jour un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à modifier.</param>
        public void UpdateEditeur(EditeurDto editeur)
        {
            Task.Run(() => UpdateEditeurAsync(editeur)).Wait();
        }

        /// <summary>
        /// Met à jour un editeur.
        /// </summary>
        /// <param name="editeur">L'editeur à modifier.</param>
        public async Task UpdateEditeurAsync(EditeurDto editeur)
        {
            using (var context = new Context())
            {
                await new EditeurCommand(context).Update(
                     EditeurConverter.ConvertToEntity(editeur)
                );
            }
        }

        /// <summary>
        /// Supprime un editeur par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'editeur à supprimer.</param>
        public void DeleteEditeur(int id)
        {
            Task.Run(() => DeleteEditeurAsync(id)).Wait();
        }

        /// <summary>
        /// Supprime un editeur par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'editeur à supprimer.</param>
        public async Task DeleteEditeurAsync(int id)
        {
            using (var context = new Context())
            {
                await new EditeurCommand(context).Delete(id);
            }
        }

        #endregion

        #region methods Evaluation

        /// <summary>
        /// Obtient une liste d'<see cref"EvaluationDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref"EvaluationDto"/>.</returns>
        public List<EvaluationDto> GetAllEvaluations()
        {
            return Task.Run(() => GetAllEvaluationsAsync()).Result;
        }

        /// <summary>
        /// Obtient une liste d'<see cref"EvaluationDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref"EvaluationDto"/>.</returns>
        public async Task<List<EvaluationDto>> GetAllEvaluationsAsync()
        {
            using (var context = new Context())
            {
                return EvaluationConverter.ConvertToDto(
                    await new EvaluationQuery(context).GetAll().ToListAsync()
                );
            }
        }

        /// <summary>
        /// Obtient une <see cref="EvaluationDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'evaluation.</param>
        /// <returns>Une <see cref="EvaluationDto"/>.</returns>
        public EvaluationDto GetOneEvaluation(int id)
        {
            return Task.Run(() => GetOneEvaluationAsync(id)).Result;
        }

        /// <summary>
        /// Obtient une <see cref="EvaluationDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'evaluation.</param>
        /// <returns>Une <see cref="EvaluationDto"/>.</returns>
        public async Task<EvaluationDto> GetOneEvaluationAsync(int id)
        {
            using (var context = new Context())
            {
                return EvaluationConverter.ConvertToDto(
                    await new EvaluationQuery(context).GetById(id).FirstOrDefaultAsync()
                );
            }
        }

        /// <summary>
        /// Ajoute une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à ajouter.</param>
        /// <returns>L'identifiant de l'evaluation crée.</returns>
        public int AddEvaluation(EvaluationDto evaluation)
        {
            return Task.Run(() => AddEvaluationAsync(evaluation)).Result;
        }

        /// <summary>
        /// Ajoute une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à ajouter.</param>
        /// <returns>L'identifiant de l'evaluation crée.</returns>
        public async Task<int> AddEvaluationAsync(EvaluationDto evaluation)
        {
            using (var context = new Context())
            {
                return await new EvaluationCommand(context).Add(
                    EvaluationConverter.ConvertToEntity(evaluation)
                );
            }
        }

        /// <summary>
        /// Met à jour une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à modifier.</param>
        public void UpdateEvaluation(EvaluationDto evaluation)
        {
            Task.Run(() => UpdateEvaluationAsync(evaluation)).Wait();
        }

        /// <summary>
        /// Met à jour une evaluation.
        /// </summary>
        /// <param name="evaluation">L'evaluation à modifier.</param>
        public async Task UpdateEvaluationAsync(EvaluationDto evaluation)
        {
            using (var context = new Context())
            {
                await new EvaluationCommand(context).Update(
                    EvaluationConverter.ConvertToEntity(evaluation)
                );
            }
        }

        /// <summary>
        /// Supprime une evaluation par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'evaluation à supprimer.</param>
        public void DeleteEvaluation(int id)
        {
            Task.Run(() => DeleteEvaluationAsync(id)).Wait();
        }

        /// <summary>
        /// Supprime une evaluation par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'evaluation à supprimer.</param>
        public async Task DeleteEvaluationAsync(int id)
        {
            using (var context = new Context())
            {
                await new EvaluationCommand(context).Delete(id);
            }
        }

        /// <summary>
        /// Obtient une liste de <see cref="EvaluationDto"/> les plus récentes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="EvaluationDto"/> les plus récentes.</returns>
        public List<EvaluationDto> LastEvaluation(int nbItem)
        {
            return Task.Run(() => LastEvaluationAsync(nbItem)).Result;
        }

        /// <summary>
        /// Obtient une liste de <see cref="EvaluationDto"/> les plus récentes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="EvaluationDto"/> les plus récentes.</returns>
        public async Task<List<EvaluationDto>> LastEvaluationAsync(int nbItem)
        {
            using (var context = new Context())
            {
                return EvaluationConverter.ConvertToDto(
                    await new EvaluationQuery(context).GetAll().OrderByDescending(e => e.Date).ThenBy(e => e.Id).Take(nbItem).ToListAsync()
                );
            }
        }

        #endregion

        #region methods Experience

        /// <summary>
        /// Obtient une liste d'<see cref="ExperienceDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="ExperienceDto"/>.</returns>
        public List<ExperienceDto> GetAllExperiences()
        {
            return Task.Run(() => GetAllExperiencesAsync()).Result;
        }

        /// <summary>
        /// Obtient une liste d'<see cref="ExperienceDto"/>.
        /// </summary>
        /// <returns>Une liste d'<see cref="ExperienceDto"/>.</returns>
        public async Task<List<ExperienceDto>> GetAllExperiencesAsync()
        {
            using (var context = new Context())
            {
                return ExperienceConverter.ConvertToDto(
                    await new ExperienceQuery(context).GetAll().ToListAsync()
                );
            }
        }

        /// <summary>
        /// Obtient une <see cref="ExperienceDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'experience.</param>
        /// <returns>Une <see cref="ExperienceDto"/>.</returns>
        public ExperienceDto GetOneExperience(int id)
        {
            return Task.Run(() => GetOneExperienceAsync(id)).Result;
        }

        /// <summary>
        /// Obtient une <see cref="ExperienceDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant de l'experience.</param>
        /// <returns>Une <see cref="ExperienceDto"/>.</returns>
        public async Task<ExperienceDto> GetOneExperienceAsync(int id)
        {
            using (var context = new Context())
            {
                return ExperienceConverter.ConvertToDto(
                    await new ExperienceQuery(context).GetById(id).FirstOrDefaultAsync()
                );
            }
        }

        /// <summary>
        /// Ajoute une experience.
        /// </summary>
        /// <param name="experience">L'experience à ajouter.</param>
        /// <returns>L'identifiant de l'experience crée.</returns>
        public int AddExperience(ExperienceDto experience)
        {
            return Task.Run(() => AddExperienceAsync(experience)).Result;
        }

        /// <summary>
        /// Ajoute une experience.
        /// </summary>
        /// <param name="experience">L'experience à ajouter.</param>
        /// <returns>L'identifiant de l'experience crée.</returns>
        public async Task<int> AddExperienceAsync(ExperienceDto experience)
        {
            using (var context = new Context())
            {
                return await new ExperienceCommand(context).Add(
                    ExperienceConverter.ConvertToEntity(experience)
                );
            }
        }

        /// <summary>
        /// Met à jour une experience.
        /// </summary>
        /// <param name="experience">L'experience à modifier.</param>
        public void UpdateExperience(ExperienceDto experience)
        {
            Task.Run(() => UpdateExperienceAsync(experience)).Wait();
        }

        /// <summary>
        /// Met à jour une experience.
        /// </summary>
        /// <param name="experience">L'experience à modifier.</param>
        public async Task UpdateExperienceAsync(ExperienceDto experience)
        {
            using (var context = new Context())
            {
                await new ExperienceCommand(context).Update(
                    ExperienceConverter.ConvertToEntity(experience)
                );
            }
        }

        /// <summary>
        /// Supprime une experience par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'experience à supprimer.</param>
        public void DeleteExperience(int id)
        {
            Task.Run(() => DeleteExperienceAsync(id)).Wait();
        }

        /// <summary>
        /// Supprime une experience par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant de l'experience à supprimer.</param>
        public async Task DeleteExperienceAsync(int id)
        {
            using (var context = new Context())
            {
                await new ExperienceCommand(context).Delete(id);
            }
        }

        #endregion

        #region methods Genre

        /// <summary>
        /// Obtient une liste de <see cref="GenreDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="GenreDto"/>.</returns>
        public List<GenreDto> GetAllGenres()
        {
            return Task.Run(() => GetAllGenresAsync()).Result;
        }

        /// <summary>
        /// Obtient une liste de <see cref="GenreDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="GenreDto"/>.</returns>
        public async Task<List<GenreDto>> GetAllGenresAsync()
        {
            using (var context = new Context())
            {
                return GenreConverter.ConvertToDto(
                    await new GenreQuery(context).GetAll().ToListAsync()
                );
            }
        }

        /// <summary>
        /// Obtient un <see cref="GenreDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du genre.</param>
        /// <returns>Un <see cref="GenreDto"/>.</returns>
        public GenreDto GetOneGenre(int id)
        {
            return Task.Run(() => GetOneGenreAsync(id)).Result;
        }

        /// <summary>
        /// Obtient un <see cref="GenreDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du genre.</param>
        /// <returns>Un <see cref="GenreDto"/>.</returns>
        public async Task<GenreDto> GetOneGenreAsync(int id)
        {
            using (var context = new Context())
            {
                return GenreConverter.ConvertToDto(
                    await new GenreQuery(context).GetById(id).FirstOrDefaultAsync()
                );
            }
        }

        /// <summary>
        /// Ajoute un genre.
        /// </summary>
        /// <param name="genre">Le genre à ajouter.</param>
        /// <returns>L'identifiant du genre crée.</returns>
        public int AddGenre(GenreDto genre)
        {
            return Task.Run(() => AddGenreAsync(genre)).Result;
        }

        /// <summary>
        /// Ajoute un genre.
        /// </summary>
        /// <param name="genre">Le genre à ajouter.</param>
        /// <returns>L'identifiant du genre crée.</returns>
        public async Task<int> AddGenreAsync(GenreDto genre)
        {
            using (var context = new Context())
            {
                return await new GenreCommand(context).Add(
                    GenreConverter.ConvertToEntity(genre)
                );
            }
        }

        /// <summary>
        /// Met à jour un genre.
        /// </summary>
        /// <param name="genre">Le genre à modifier.</param>
        public void UpdateGenre(GenreDto genre)
        {
            Task.Run(() => UpdateGenreAsync(genre)).Wait();
        }

        /// <summary>
        /// Met à jour un genre.
        /// </summary>
        /// <param name="genre">Le genre à modifier.</param>
        public async Task UpdateGenreAsync(GenreDto genre)
        {
            using (var context = new Context())
            {
                await new GenreCommand(context).Update(
                    GenreConverter.ConvertToEntity(genre)
                );
            }
        }

        /// <summary>
        /// Supprime un genre par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du genre à supprimer.</param>
        public void DeleteGenre(int id)
        {
            Task.Run(() => DeleteGenreAsync(id)).Wait();
        }

        /// <summary>
        /// Supprime un genre par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du genre à supprimer.</param>
        public async Task DeleteGenreAsync(int id)
        {
            using (var context = new Context())
            { 
                await new GenreCommand(context).Delete(id);
            }
        }

        #endregion

        #region methods Jeu

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public List<JeuDto> GetAllJeux(bool includeAll = false, Func<JeuDto, bool> wherePredicate = null)
        {
            return Task.Run(() => GetAllJeuxAsync(includeAll, wherePredicate)).Result;
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/>.
        /// </summary>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public async Task<List<JeuDto>> GetAllJeuxAsync(bool includeAll = false, Func<JeuDto, bool> wherePredicate = null)
        {
            using (var context = new Context())
            {
                IQueryable<Modele.Entities.Jeu> query = new JeuQuery(context).GetAll();

                if (includeAll)
                {
                    query = query
                        .Include(jeu => jeu.GenreObj)
                        .Include(jeu => jeu.EditeurObj)
                        .Include(jeu => jeu.Evaluations)
                        .Include(jeu => jeu.Experiences);
                }

                if (wherePredicate != null)
                {
                    List<Modele.Entities.Jeu> result1 = await query.ToListAsync();
                    // oui oui on tri bien avoir ton récupéré c'est pas beau
                    return result1.Select(j => JeuConverter.ConvertToDto(j)).Where(wherePredicate).ToList();
                }

                // Premier .ToList() nécessaire sinon expression interprété par linq => ne connait pas ConvertToDto().
                List<Modele.Entities.Jeu> result = await query.ToListAsync();
                return result.Select(j => JeuConverter.ConvertToDto(j)).ToList();
            }
        }

        /// <summary>
        /// Obtient un <see cref="JeuDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du jeu.</param>
        /// <param name="includeAll">Indique si on veut inclure toutes propriétés du jeu (faux par défaut).</param>
        /// <returns>Un <see cref="JeuDto"/>.</returns>
        public JeuDto GetOneJeu(int id, bool? includeAll = false)
        {
            return Task.Run(() => GetOneJeuAsync(id, includeAll)).Result;
        }

        /// <summary>
        /// Obtient un <see cref="JeuDto"/> par son identifiant.
        /// </summary>
        /// <param name="id">L'identifiant du jeu.</param>
        /// <param name="includeAll">Indique si on veut inclure toutes propriétés du jeu (faux par défaut).</param>
        /// <returns>Un <see cref="JeuDto"/>.</returns>
        public async Task<JeuDto> GetOneJeuAsync(int id, bool? includeAll = false)
        {
            using (var context = new Context())
            {
                IQueryable<Modele.Entities.Jeu> query = new JeuQuery(context).GetById(id);

                if (includeAll.HasValue && includeAll.Value)
                {
                    query = query
                        .Include(jeu => jeu.GenreObj)
                        .Include(jeu => jeu.EditeurObj)
                        .Include(jeu => jeu.Evaluations)
                        .Include(jeu => jeu.Experiences);
                }

                return JeuConverter.ConvertToDto(
                     await query.FirstOrDefaultAsync()
                 );
            }
        }

        /// <summary>
        /// Ajoute un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter.</param>
        /// <returns>L'identifiant du jeu crée.</returns>
        public int AddJeu(JeuDto jeu)
        {
            return Task.Run(() => AddJeuAsync(jeu)).Result;
        }

        /// <summary>
        /// Ajoute un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter.</param>
        /// <returns>L'identifiant du jeu crée.</returns>
        public async Task<int> AddJeuAsync(JeuDto jeu)
        {
            using (var context = new Context())
            {
                return await new JeuCommand(context).Add(
                    JeuConverter.ConvertToEntity(jeu)
                );
            }
        }

        /// <summary>
        /// Met à jour un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à modifier.</param>
        public void UpdateJeu(JeuDto jeu)
        {
            Task.Run(() => UpdateJeuAsync(jeu)).Wait();
        }

        /// <summary>
        /// Met à jour un jeu.
        /// </summary>
        /// <param name="jeu">Le jeu à modifier.</param>
        public async Task UpdateJeuAsync(JeuDto jeu)
        {
            using (var context = new Context())
            {
                await new JeuCommand(context).Update(
                    JeuConverter.ConvertToEntity(jeu)
                );
            }
        }

        /// <summary>
        /// Supprime un jeu par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du jeu à supprimer.</param>
        public void DeleteJeu(int id)
        {
            Task.Run(() => DeleteJeuAsync(id)).Wait();
        }

        /// <summary>
        /// Supprime un jeu par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du jeu à supprimer.</param>
        public async Task DeleteJeuAsync(int id)
        {
            using (var context = new Context())
            {
                await new JeuCommand(context).Delete(id);
            }
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> correspondant à la recherche.
        /// </summary>
        /// <param name="searchText">la recherche.</param>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public List<JeuDto> FindJeuxByName(string searchText)
        {
            return Task.Run(() => FindJeuxByNameAsync(searchText)).Result;
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> correspondant à la recherche.
        /// </summary>
        /// <param name="searchText">la recherche.</param>
        /// <returns>Une liste de <see cref="JeuDto"/>.</returns>
        public async Task<List<JeuDto>> FindJeuxByNameAsync(string searchText)
        {
            using (var context = new Context())
            {
                return JeuConverter.ConvertToDto(
                    await new JeuQuery(context).GetAll().Where(jeu => jeu.Nom.Contains(searchText)).ToListAsync()
                );
            }
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> ayant les meilleurs notes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="JeuDto"/> ayant les meilleurs notes.</returns>
        public List<JeuDto> TopJeuxByMark(int nbItem)
        {
            return Task.Run(() => TopJeuxByMarkAsync(nbItem)).Result;
        }

        /// <summary>
        /// Obtient une liste de <see cref="JeuDto"/> ayant les meilleurs notes.
        /// </summary>
        /// <param name="nbItem">nombre d'item a recupérer.</param>
        /// <returns>Une liste de <see cref="JeuDto"/> ayant les meilleurs notes.</returns>
        public async Task<List<JeuDto>> TopJeuxByMarkAsync(int nbItem)
        {
            using (var context = new Context())
            {
                return JeuConverter.ConvertToDto(
                    await new JeuQuery(context).GetAll().Include(j => j.Evaluations).OrderByDescending(jeu => jeu.Evaluations.Average(e => e.Note)).ThenBy(e => e.Id).Take(nbItem).ToListAsync()
                );
            }
        }

        #endregion
    }
}
