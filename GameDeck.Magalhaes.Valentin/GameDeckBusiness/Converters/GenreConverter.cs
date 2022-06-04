using GameDeckDto;
using Modele.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameDeckBusiness.Converters
{
    /// <summary>
    /// Represente le converter de l'entite <see cref="Genre"/> en dto  <see cref="GenreDto"/> et vice-versa.
    /// </summary>
    public static class GenreConverter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie l'entites <see cref="Genre"/> en dto <see cref="GenreDto"/>.
        /// </summary>
        /// <param name="entity">L'entite a convertir en dto</param>
        public static GenreDto ConvertToDto(Genre entity)
        {
            if (entity == null)
                return null;

            return new GenreDto
            {
                Id = entity.Id,
                Nom = entity.Nom,
                //Jeux = JeuConverter.ConvertToDto(entity.Jeux?.ToList()),
            };
        }

        /// <summary>
        /// Convertie le dto <see cref="GenreDto"/> en entite <see cref="Genre"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static Genre ConvertToEntity(GenreDto dto)
        {
            if (dto == null)
                return null;

            return new Genre
            {
                Id = dto.Id,
                Nom = dto.Nom,
                //Jeux = JeuConverter.ConvertToEntity(dto.Jeux?.ToList()),
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les entites <see cref="Genre"/> en dtos <see cref="GenreDto"/>.
        /// </summary>
        /// <param name="entities">Les entites a convertir en dto</param>
        public static List<GenreDto> ConvertToDto(List<Genre> entities)
        {
            // Si la collection est null ou vide
            if (entities?.FirstOrDefault() == null)
            {
                return null;
            }

            List<GenreDto> dtos = new List<GenreDto>();
            foreach (Genre item in entities)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les dtos <see cref="GenreDto"/> en entities <see cref="Genre"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en entite</param>
        public static List<Genre> ConvertToEntity(List<GenreDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<Genre> entites = new List<Genre>();
            foreach (GenreDto item in dtos)
            {
                entites.Add(ConvertToEntity(item));
            }
            return entites;
        }

        #endregion
    }
}
