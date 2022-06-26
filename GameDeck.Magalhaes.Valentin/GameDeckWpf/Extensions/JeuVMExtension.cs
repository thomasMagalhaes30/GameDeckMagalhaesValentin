using GameDeckDto;
using GameDeckWpf.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace GameDeckWpf.Extensions
{
    public static class JeuVMExtension
    {
        /// <summary>
        /// Convertie <see cref="JeuVM"/> en <see cref="JeuDto"/>.
        /// </summary>
        public static JeuDto ToDto(this JeuVM vm) =>
            new JeuDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
                Description = vm.Description,
                DateSortie = vm.DateSortie,
                GenreId = vm.GenreId,
                EditeurId = vm.EditeurId,
                EditeurObj = vm.Editeur?.ToDto(),
                GenreObj = vm.Genre?.ToDto(),
                Evaluations = vm.Evaluations != null ? new ObservableCollection<EvaluationDto>(vm.Evaluations?.Select(e => e?.ToDto())) : null,
                Experiences = vm.Experiences != null ? new ObservableCollection<ExperienceDto>(vm.Experiences?.Select(e => e?.ToDto())) : null,
            };
    }
}
