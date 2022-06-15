using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class GenreVMExtension
    {
        /// <summary>
        /// Convertie <see cref="GenreVM"/> en <see cref="GenreDto"/>.
        /// </summary>
        public static GenreDto ToDto(this GenreVM vm) =>
            new GenreDto
            {
                Id = vm.Id,
                Nom = vm.Nom,
            };
    }
}
