using GameDeckDto;
using GameDeckWpf.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameDeckWpf.Extensions
{
    public static class JeuDtoExtension
    {
        public static JeuVM ToViewModel(this JeuDto dto) =>
            new JeuVM()
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Description = dto.Description,
                DateSortie = dto.DateSortie,
                GenreId = dto.GenreId,
                EditeurId = dto.EditeurId,
                Genre = dto.GenreObj?.ToViewModel(),
                Editeur = dto.EditeurObj?.ToViewModel(),
                Evaluations = dto.Evaluations != null ? new ObservableCollection<EvaluationVM>(dto.Evaluations.Select(e => e.ToViewModel())) : null,
                Experiences = dto.Experiences != null ? new ObservableCollection<ExperienceVM>(dto.Experiences.Select(e => e.ToViewModel())) : null
            };
    }
}
