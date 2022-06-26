using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Converters
{
    /// <summary>
    /// Represente un adapteur du dto <see cref="EvaluationDto"/> en viewmodel  <see cref="EvaluationVM"/> et vice-versa.
    /// </summary>
    public class EvaluationAdapter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie <see cref="EvaluationVM"/> en <see cref="EvaluationDto"/>.
        /// </summary>
        /// <param name="vm">Le viewmodel a convertir en dto.</param>
        public static EvaluationDto ConvertToDto(EvaluationVM vm)
        {
            if (vm == null)
                return null;

            return new EvaluationDto
            {
                Id = vm.Id,
                NomEvaluateur = vm.NomEvaluateur,
                Date = vm.Date,
                Note = vm.Note,
                JeuId = vm.JeuId,
            };
        }

        /// <summary>
        /// Convertie <see cref="EvaluationDto"/> en <see cref="EvaluationVM"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static EvaluationVM ConvertToVM(EvaluationDto dto)
        {
            if (dto == null)
                return null;

            return new EvaluationVM
            {
                Id = dto.Id,
                NomEvaluateur = dto.NomEvaluateur,
                Date = dto.Date,
                Note = dto.Note,
                JeuId = dto.JeuId,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les <see cref="EvaluationVM"/> en <see cref="EvaluationDto"/>.
        /// </summary>
        /// <param name="EvaluationVM">Les vm a convertir en dto</param>
        public static List<EvaluationDto> ConvertToDto(List<EvaluationVM> vms)
        {
            // Si la collection est null ou vide
            if (vms?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EvaluationDto> dtos = new List<EvaluationDto>();
            foreach (EvaluationVM item in vms)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les <see cref="EvaluationDto"/> en <see cref="EvaluationVM"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en viewmodel</param>
        public static List<EvaluationVM> ConvertToVM(List<EvaluationDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EvaluationVM> vms = new List<EvaluationVM>();
            foreach (EvaluationDto item in dtos)
            {
                vms.Add(ConvertToVM(item));
            }
            return vms;
        }

        #endregion
    }
}