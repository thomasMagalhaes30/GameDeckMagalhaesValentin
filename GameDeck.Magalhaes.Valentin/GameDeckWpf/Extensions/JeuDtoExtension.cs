using GameDeckDto;
using GameDeckWpf.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameDeckWpf.Extensions
{
    public static class JeuDtoExtension
    {
        /// <summary>
        /// Convertie <see cref="JeuDto"/> en <see cref="JeuVM"/>.
        /// </summary>
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
                Evaluations = dto.Evaluations != null ? new ObservableCollection<EvaluationVM>(dto.Evaluations.Select(e => e.ToViewModel()).OrderByDescending(e => e.Date).ThenBy(e => e.NomEvaluateur)) : null,
                Experiences = dto.Experiences != null ? new ObservableCollection<ExperienceVM>(dto.Experiences.Select(e => e.ToViewModel())) : null
            };
    }
}
