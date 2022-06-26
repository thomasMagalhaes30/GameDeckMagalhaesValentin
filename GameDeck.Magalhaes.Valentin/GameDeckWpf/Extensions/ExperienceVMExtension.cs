using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class ExperienceVMExtension
    {
        /// <summary>
        /// Convertie <see cref="ExperienceVM"/> en <see cref="ExperienceDto"/>.
        /// </summary>
        public static ExperienceDto ToDto(this ExperienceVM vm) =>
            new ExperienceDto
            {
                Id = vm.Id,
                Joueur = vm.Joueur,
                TempsJeu = vm.TempsJeu,
                Pourcentage = vm.Pourcentage,
                JeuId = vm.JeuId,
            };
    }
}
