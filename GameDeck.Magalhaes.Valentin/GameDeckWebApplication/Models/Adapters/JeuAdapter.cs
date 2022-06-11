using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Converters
{
    /// <summary>
    /// Represente un adapteur du dto <see cref="JeuDto"/> en viewmodel  <see cref="JeuVM"/> et vice-versa.
    /// </summary>
    public class JeuAdapter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie <see cref="JeuVM"/> en <see cref="JeuDto"/>.
        /// </summary>
        /// <param name="vm">Le viewmodel a convertir en dto.</param>
        public static JeuDto ConvertToDto(JeuVM vm)
        {
            if (vm == null)
                return null;

            return new JeuDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
                Description = vm.Description,
                DateSortie = vm.DateSortie,
                GenreId = vm.GenreId,
                EditeurId = vm.EditeurId,
                EditeurObj = EditeurAdapter.ConvertToDto(vm.EditeurObj),
                GenreObj = GenreAdapter.ConvertToDto(vm.GenreObj),
                Evaluations = EvaluationAdapter.ConvertToDto(vm.Evaluations?.ToList()),
                Experiences = ExperienceAdapter.ConvertToDto(vm.Experiences?.ToList()),
            };
        }

        /// <summary>
        /// Convertie <see cref="JeuDto"/> en <see cref="JeuVM"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en viewmodel</param>
        public static JeuVM ConvertToVM(JeuDto dto)
        {
            if (dto == null)
                return null;

            return new JeuVM
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Description = dto.Description,
                DateSortie = dto.DateSortie,
                GenreId = dto.GenreId,
                EditeurId = dto.EditeurId,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les <see cref="JeuVM"/> en <see cref="JeuDto"/>.
        /// </summary>
        /// <param name="JeuVM">Les vm a convertir en dto</param>
        public static List<JeuDto> ConvertToDto(List<JeuVM> vms)
        {
            // Si la collection est null ou vide
            if (vms?.FirstOrDefault() == null)
            {
                return null;
            }

            List<JeuDto> dtos = new List<JeuDto>();
            foreach (JeuVM item in vms)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les <see cref="JeuDto"/> en <see cref="JeuVM"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en vm</param>
        public static List<JeuVM> ConvertToVM(List<JeuDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<JeuVM> entites = new List<JeuVM>();
            foreach (JeuDto item in dtos)
            {
                entites.Add(ConvertToVM(item));
            }
            return entites;
        }

        #endregion
    }
}