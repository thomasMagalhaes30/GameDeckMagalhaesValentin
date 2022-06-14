using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class ExperienceDtoExtension
    {
        public static ExperienceVM ToViewModel(this ExperienceDto dto) =>
            new ExperienceVM()
            {
                Id = dto.Id,
                Joueur = dto.Joueur,
                TempsJeu = dto.TempsJeu,
                Pourcentage = dto.Pourcentage,
                JeuId = dto.JeuId
            };
    }
}
