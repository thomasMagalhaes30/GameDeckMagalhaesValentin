using GameDeckDto;
using GameDeckWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckWpf.Extensions
{
    public static class EvaluationDtoExtension
    {
        public static EvaluationVM ToViewModel(this EvaluationDto dto) =>
            new EvaluationVM()
            {
                Id = dto.Id,
                NomEvaluateur = dto.NomEvaluateur,
                Date = dto.Date,
                Note = dto.Note,
                JeuId = dto.JeuId
            };
    }
}
