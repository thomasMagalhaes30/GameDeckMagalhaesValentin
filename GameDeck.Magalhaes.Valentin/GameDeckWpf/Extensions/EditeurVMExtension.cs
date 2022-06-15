using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class EditeurVMExtension
    {
        /// <summary>
        /// Convertie <see cref="EditeurVM"/> en <see cref="EditeurDto"/>.
        /// </summary>
        public static EditeurDto ToDto(this EditeurVM vm) =>
            new EditeurDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
            };
    }
}
