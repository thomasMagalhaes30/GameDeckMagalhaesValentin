using GameDeckDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models.Converters
{
    /// <summary>
    /// Represente un adapteur du dto <see cref="ExperienceDto"/> en viewmodel  <see cref="ExperienceVM"/> et vice-versa.
    /// </summary>
    public class ExperienceAdapter
    {
        #region [ Converter ]

        /// <summary>
        /// Convertie <see cref="ExperienceVM"/> en <see cref="ExperienceDto"/>.
        /// </summary>
        /// <param name="vm">Le viewmodel a convertir en dto.</param>
        public static ExperienceDto ConvertToDto(ExperienceVM vm)
        {
            if (vm == null)
                return null;

            return new ExperienceDto
            {
                Id = vm.Id,
                Joueur = vm.Joueur,
                TempsJeu = vm.TempsJeu,
                Pourcentage = vm.Pourcentage,
                JeuId = vm.JeuId,
            };
        }

        /// <summary>
        /// Convertie <see cref="ExperienceDto"/> en <see cref="ExperienceVM"/>.
        /// </summary>
        /// <param name="dto">Le dto a convertir en entite</param>
        public static ExperienceVM ConvertToVM(ExperienceDto dto)
        {
            if (dto == null)
                return null;

            return new ExperienceVM
            {
                Id = dto.Id,
                Joueur = dto.Joueur,
                TempsJeu = dto.TempsJeu,
                Pourcentage = dto.Pourcentage,
                JeuId = dto.JeuId,
            };
        }

        #endregion

        #region [ Converter List ]

        /// <summary>
        /// Convertie les <see cref="ExperienceVM"/> en <see cref="ExperienceDto"/>.
        /// </summary>
        /// <param name="ExperienceVM">Les vm a convertir en viewmodel</param>
        public static List<ExperienceDto> ConvertToDto(List<ExperienceVM> vms)
        {
            // Si la collection est null ou vide
            if (vms?.FirstOrDefault() == null)
            {
                return null;
            }

            List<ExperienceDto> dtos = new List<ExperienceDto>();
            foreach (ExperienceVM item in vms)
            {
                dtos.Add(ConvertToDto(item));
            }
            return dtos;
        }

        /// <summary>
        /// Convertie les <see cref="ExperienceDto"/> en <see cref="ExperienceVM"/>.
        /// </summary>
        /// <param name="dtos">Les dtos a convertir en vm</param>
        public static List<ExperienceVM> ConvertToVM(List<ExperienceDto> dtos)
        {
            // Si la collection est null ou vide
            if (dtos?.FirstOrDefault() == null)
            {
                return null;
            }

            List<ExperienceVM> entites = new List<ExperienceVM>();
            foreach (ExperienceDto item in dtos)
            {
                entites.Add(ConvertToVM(item));
            }
            return entites;
        }

        #endregion
    }
}