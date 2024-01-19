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
            ResponseMovie response = new()
            {
                Title = request.Title,
                Duration = request.Duration,
                Gender = request.Gender,
                Url = request.Url
            };

            Movie movie = new(
                response.Title,
                response.Duration,
                response.Gender,
                response.Url
                );
            _repository.Create(movie);

        }
    }
}
