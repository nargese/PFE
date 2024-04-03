using MediatR;
using OsmoseInverse.Domain.Commands;
using OsmoseInverse.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class DeleteGenericHandlers<T> : IRequestHandler<DeleteGeneric<T>, string> where T : class
    {

        private readonly IRepository<T> repository;
        public DeleteGenericHandlers(IRepository<T> Repository)
        {
            repository = Repository;
        }

        public Task<string> Handle(DeleteGeneric<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Remove(request.Id);
            return Task.FromResult(result);
        }
    }
}
