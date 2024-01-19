using Catalogo.Application.Repository;
using Catalogo.Communication.Request;
using Catalogo.Communication.Response;
using Catalogo.Model.Entities;

namespace Catalogo.Application.UseCases
{
    public class UseCaseCreateMovie : IUseCaseCreateMovie
    {
        private readonly IRepositoty _repository;

        public UseCaseCreateMovie(IRepositoty repository)
        {
            _repository = repository;
        }

        public void Execute(RequestMovie request)
        {
            Movie movie = new(
                request.Title,
                request.Duration,
                request.Gender,
                request.Url
                );
            _repository.Create(movie);
        }
    }
}
