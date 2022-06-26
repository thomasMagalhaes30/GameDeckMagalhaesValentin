using GameDeckDto;
using GameDeckWpf.ViewModel;

namespace GameDeckWpf.Extensions
{
    public static class GenreDtoExtension
    {
        public static GenreVM ToViewModel(this GenreDto dto) =>
            new GenreVM()
            {
                Id = dto.Id,
                Nom = dto.Nom
            };
    }
}
