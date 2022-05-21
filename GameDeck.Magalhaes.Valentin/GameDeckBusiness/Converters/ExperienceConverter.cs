using GameDeckDto;
using Modele.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameDeckBusiness.Converters
{
    /// <summary>
    /// Represente le converter de l'entite <see cref="Experience"/> en dto  <see cref="ExperienceDto"/> et vice-versa.
    /// </summary>
    public static class ExperienceConverter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie l'entites <see cref="Experience"/> en dto <see cref="ExperienceDto"/>.
        /// </summary>
        /// <param name="entity">L'entite a convertir en dto</param>
        public static ExperienceDto ConvertToDto(Experience entity)
        {
            return new ExperienceDto
            {
                Id = entity.Id,
                Joueur = entity.Joueur,
                TempsJeu = entity.TempsJeu,
                Pourcentage = entity.Pourcentage,
                JeuId = entity.JeuId,
                //JeuObj = JeuConverter.ConvertToDto(entity.JeuObj),
            };
        }

        /// <summary>
        /// Convertie le dto <see cref="ExperienceDto"/> en entite <see cref="Experience"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static Experience ConvertToEntity(ExperienceDto dto)
        {
            return new Experience
            {
                Id = dto.Id,
                Joueur = dto.Joueur,
                TempsJeu = dto.TempsJeu,
                Pourcentage = dto.Pourcentage,
                JeuId = dto.JeuId,
                //JeuObj = JeuConverter.ConvertToEntity(dto.JeuObj),
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les entites <see cref="Experience"/> en dtos <see cref="ExperienceDto"/>.
        /// </summary>
        /// <param name="entities">Les entites a convertir en dto</param>
        public static List<ExperienceDto> ConvertToDto(List<Experience> entities)
        {
            // Si la collection est null ou vide
            if (entities?.FirstOrDefault() == null)
            {
                return null;
            }

            List<ExperienceDto> dtos = new List<ExperienceDto>();
            foreach (Experience item in entities)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les dtos <see cref="ExperienceDto"/> en entities <see cref="Experience"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en entite</param>
        public static List<Experience> ConvertToEntity(List<ExperienceDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<Experience> entites = new List<Experience>();
            foreach (ExperienceDto item in dtos)
            {
                entites.Add(ConvertToEntity(item));
            }
            return entites;
        }

        #endregion
    }
}
