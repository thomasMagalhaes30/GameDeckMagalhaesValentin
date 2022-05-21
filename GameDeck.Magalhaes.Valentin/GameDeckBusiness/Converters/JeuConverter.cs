using GameDeckDto;
using Modele.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameDeckBusiness.Converters
{
    /// <summary>
    /// Represente le converter de l'entite <see cref="Jeu"/> en dto  <see cref="JeuDto"/> et vice-versa.
    /// </summary>
    public static class JeuConverter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie l'entites <see cref="Jeu"/> en dto <see cref="JeuDto"/>.
        /// </summary>
        /// <param name="entity">L'entite a convertir en dto</param>
        public static JeuDto ConvertToDto(Jeu entity)
        {
            return new JeuDto
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Description = entity.Description,
                DateSortie = entity.DateSortie,
                GenreId = entity.GenreId,
                EditeurId = entity.EditeurId,
                EditeurObj = EditeurConverter.ConvertToDto(entity.EditeurObj),
                GenreObj = GenreConverter.ConvertToDto(entity.GenreObj),
                Evaluations = EvaluationConverter.ConvertToDto(entity.Evaluations.ToList()),
                Experiences = ExperienceConverter.ConvertToDto(entity.Experiences.ToList()),
            };
        }

        /// <summary>
        /// Convertie le dto <see cref="JeuDto"/> en entite <see cref="Jeu"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static Jeu ConvertToEntity(JeuDto dto)
        {
            return new Jeu
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Description = dto.Description,
                DateSortie = dto.DateSortie,
                GenreId = dto.GenreId,
                EditeurId = dto.EditeurId,
                EditeurObj = EditeurConverter.ConvertToEntity(dto.EditeurObj),
                GenreObj = GenreConverter.ConvertToEntity(dto.GenreObj),
                Evaluations = dto.Evaluations,
                Experiences = dto.Experiences,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les entites <see cref="Jeu"/> en dtos <see cref="JeuDto"/>.
        /// </summary>
        /// <param name="entities">Les entites a convertir en dto</param>
        public static List<JeuDto> ConvertToDto(List<Jeu> entities)
        {
            // Si la collection est null ou vide
            if (entities?.FirstOrDefault() == null)
            {
                return null;
            }

            List<JeuDto> dtos = new List<JeuDto>();
            foreach (Jeu item in entities)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les dtos <see cref="JeuDto"/> en entities <see cref="Jeu"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en entite</param>
        public static List<Jeu> ConvertToEntity(List<JeuDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<Jeu> entites = new List<Jeu>();
            foreach (JeuDto item in dtos)
            {
                entites.Add(ConvertToEntity(item));
            }
            return entites;
        }

        #endregion
    }
}
