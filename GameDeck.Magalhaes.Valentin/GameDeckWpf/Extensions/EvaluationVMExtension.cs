using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class EvaluationVMExtension
    {
        /// <summary>
        /// Convertie <see cref="EvaluationVM"/> en <see cref="EvaluationDto"/>.
        /// </summary>
        public static EvaluationDto ToDto(this EvaluationVM vm) =>
            new EvaluationDto
            {
                Id = vm.Id,
                NomEvaluateur = vm.NomEvaluateur,
                Date = vm.Date,
                Note = vm.Note,
                JeuId = vm.JeuId,
            };
    }
}
