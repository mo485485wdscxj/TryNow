using Movies_project.BLL.Dtos.MovieDtos;

namespace Movies_project.DAL.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<MovieDto> getAll();
        MovieDto? getById(int id);
        bool Add(CreateMovieDto dto);
    }
}
