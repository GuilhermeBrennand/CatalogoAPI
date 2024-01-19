using Catalogo.Application.Repository;
using Catalogo.Model.Entities;

namespace Catalogo.Persistence
{
    public class RepositoryMock : IRepositoty
    {
        List<Movie> _movies = [];
        public void Create(Movie movie)
        {
            var Id = Guid.NewGuid();
            _movies.Select(id => Id).FirstOrDefault();
            _movies.Add(movie);
        }
    }
}
