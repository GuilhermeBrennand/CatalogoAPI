using Catalogo.Communication.Request;

namespace Catalogo.Application.UseCases
{
    public interface IUseCaseCreateMovie
    {
        void Execute(RequestMovie request);
    }
}
