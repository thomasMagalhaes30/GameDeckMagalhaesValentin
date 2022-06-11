using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Converters
{
    /// <summary>
    /// Represente un adapteur du dto <see cref="EditeurDto"/> en viewmodel  <see cref="EditeurVM"/> et vice-versa.
    /// </summary>
    public class EditeurAdapter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie <see cref="EditeurVM"/> en <see cref="EditeurDto"/>.
        /// </summary>
        /// <param name="vm">Le viewmodel a convertir en dto.</param>
        public static EditeurDto ConvertToDto(EditeurVM vm)
        {
            if (vm == null)
                return null;

            return new EditeurDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
            };
        }

        /// <summary>
        /// Convertie <see cref="EditeurDto"/> en <see cref="EditeurVM"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en viewmodel</param>
        public static EditeurVM ConvertToVM(EditeurDto dto)
        {
            if (dto == null)
                return null;

            return new EditeurVM
            {
                Id = dto.Id,
                Nom = dto.Nom,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les <see cref="EditeurVM"/> en <see cref="EditeurDto"/>.
        /// </summary>
        /// <param name="EditeurVM">Les vm a convertir en dto</param>
        public static List<EditeurDto> ConvertToDto(List<EditeurVM> vms)
        {
            // Si la collection est null ou vide
            if (vms?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EditeurDto> dtos = new List<EditeurDto>();
            foreach (EditeurVM item in vms)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les <see cref="EditeurDto"/> en <see cref="EditeurVM"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en vm</param>
        public static List<EditeurVM> ConvertToVM(List<EditeurDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<EditeurVM> entites = new List<EditeurVM>();
            foreach (EditeurDto item in dtos)
            {
                entites.Add(ConvertToVM(item));
            }
            return entites;
        }

        #endregion
    }
}