using GameDeckDto;
using Modele.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameDeckBusiness.Converters
{
    /// <summary>
    /// Represente le converter de l'entite <see cref="Editeur"/> en dto  <see cref="EditeurDto"/> et vice-versa.
    /// </summary>
    public static class EditeurConverter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie l'entites <see cref="Editeur"/> en dto <see cref="EditeurDto"/>.
        /// </summary>
        /// <param name="entity">L'entite a convertir en dto</param>
        public static EditeurDto ConvertToDto(Editeur entity)
        {
            if (entity == null)
                return null;

            return new EditeurDto
            {
                Id = entity.Id,
                Nom = entity.Nom,
                //Jeux = JeuConverter.ConvertToDto(entity.Jeux?.ToList()),
            };
        }

        /// <summary>
        /// Convertie le dto <see cref="EditeurDto"/> en entite <see cref="Editeur"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static Editeur ConvertToEntity(EditeurDto dto)
        {
            if (dto == null)
                return null;

            return new Editeur
            {
                Id = dto.Id,
                Nom = dto.Nom,
                //Jeux = JeuConverter.ConvertToEntity(dto.Jeux?.ToList()),
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les entites <see cref="Editeur"/> en dtos <see cref="EditeurDto"/>.
        /// </summary>
        /// <param name="entities">Les entites a convertir en dto</param>
        public static List<EditeurDto> ConvertToDto(List<Editeur> entities)
        {
            // Si la collection est null ou vide
            if (entities?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EditeurDto> dtos = new List<EditeurDto>();
            foreach (Editeur item in entities)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les dtos <see cref="EditeurDto"/> en entities <see cref="Editeur"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en entite</param>
        public static List<Editeur> ConvertToEntity(List<EditeurDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<Editeur> entites = new List<Editeur>();
            foreach (EditeurDto item in dtos)
            {
                entites.Add(ConvertToEntity(item));
            }
            return entites;
        }

        #endregion
    }
}
