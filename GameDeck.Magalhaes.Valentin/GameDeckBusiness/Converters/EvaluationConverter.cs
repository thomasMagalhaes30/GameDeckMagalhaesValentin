using GameDeckDto;
using Modele.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GameDeckBusiness.Converters
{
    /// <summary>
    /// Represente le converter de l'entite <see cref="Evaluation"/> en dto  <see cref="EvaluationDto"/> et vice-versa.
    /// </summary>
    public static class EvaluationConverter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie l'entites <see cref="Evaluation"/> en dto <see cref="EvaluationDto"/>.
        /// </summary>
        /// <param name="entity">L'entite a convertir en dto</param>
        public static EvaluationDto ConvertToDto(Evaluation entity)
        {
            return new EvaluationDto
            {
                Id = entity.Id,
                NomEvaluateur = entity.NomEvaluateur,
                Date = entity.Date,
                Note = entity.Note,
                JeuId = entity.JeuId,
                //JeuObj = JeuConverter.ConvertToDto(entity.JeuObj),
            };
        }

        /// <summary>
        /// Convertie le dto <see cref="EvaluationDto"/> en entite <see cref="Evaluation"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static Evaluation ConvertToEntity(EvaluationDto dto)
        {
            return new Evaluation
            {
                Id = dto.Id,
                NomEvaluateur = dto.NomEvaluateur,
                Date = dto.Date,
                Note = dto.Note,
                JeuId = dto.JeuId,
                //JeuObj = JeuConverter.ConvertToDto(dto.JeuObj),
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les entites <see cref="Evaluation"/> en dtos <see cref="EvaluationDto"/>.
        /// </summary>
        /// <param name="entities">Les entites a convertir en dto</param>
        public static List<EvaluationDto> ConvertToDto(List<Evaluation> entities)
        {
            // Si la collection est null ou vide
            if (entities?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EvaluationDto> dtos = new List<EvaluationDto>();
            foreach (Evaluation item in entities)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les dtos <see cref="EvaluationDto"/> en entities <see cref="Evaluation"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en entite</param>
        public static List<Evaluation> ConvertToEntity(List<EvaluationDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<Evaluation> entites = new List<Evaluation>();
            foreach (EvaluationDto item in dtos)
            {
                entites.Add(ConvertToEntity(item));
            }
            return entites;
        }

        #endregion
    }
}
