using System;

namespace Algorithms.UseCases
{
    public interface IUseCase<TResponse>
    {
        TResponse Execute();
    }
}