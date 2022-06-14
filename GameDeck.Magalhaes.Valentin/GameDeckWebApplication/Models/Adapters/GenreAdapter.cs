using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Converters
{
    /// <summary>
    /// Represente un adapteur du dto <see cref="GenreDto"/> en viewmodel  <see cref="GenreVM"/> et vice-versa.
    /// </summary>
    public class GenreAdapter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie <see cref="GenreVM"/> en <see cref="GenreDto"/>.
        /// </summary>
        /// <param name="vm">Le viewmodel a convertir en dto.</param>
        public static GenreDto ConvertToDto(GenreVM vm)
        {
            if (vm == null)
                return null;

            return new GenreDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
            };
        }

        /// <summary>
        /// Convertie <see cref="GenreDto"/> en <see cref="GenreVM"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en viewmodel</param>
        public static GenreVM ConvertToVM(GenreDto dto)
        {
            if (dto == null)
                return null;

            return new GenreVM
            {
                Id = dto.Id,
                Nom = dto.Nom,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les <see cref="GenreVM"/> en <see cref="GenreDto"/>.
        /// </summary>
        /// <param name="GenreVM">Les vm a convertir en dto</param>
        public static List<GenreDto> ConvertToDto(List<GenreVM> vms)
        {
            // Si la collection est null ou vide
            if (vms?.FirstOrDefault() == null)
            {
                return null;
            }

            List<GenreDto> dtos = new List<GenreDto>();
            foreach (GenreVM item in vms)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les <see cref="GenreDto"/> en <see cref="GenreVM"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en vm</param>
        public static List<GenreVM> ConvertToVM(List<GenreDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<GenreVM> vms = new List<GenreVM>();
            foreach (GenreDto item in dtos)
            {
                vms.Add(ConvertToVM(item));
            }
            return vms;
        }

        #endregion
    }
}