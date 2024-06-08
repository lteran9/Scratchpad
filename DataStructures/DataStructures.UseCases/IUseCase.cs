using System;

namespace DataStructures.UseCases
{
   public interface IUseCase<TResponse>
   {
      TResponse Execute();
   }
}