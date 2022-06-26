using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class EditeurDtoExtension
    {
        public static EditeurVM ToViewModel(this EditeurDto dto) =>
            new EditeurVM()
            {
                Id = dto.Id,
                Nom = dto.Nom
            };
    }
}
