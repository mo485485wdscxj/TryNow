using Movies_project.BLL.Dtos.MovieDtos;

namespace Movies_project.DAL.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<MovieDto> getAll();
        MovieDtoForOne? getById(int id);
        bool Add(CreateMovieDto dto);
    }
}
