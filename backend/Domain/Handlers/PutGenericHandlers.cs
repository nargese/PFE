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
    public class PutGenericHandlers<T> : IRequestHandler<PutGeneric<T>, string> where T : class
    {
        private readonly IRepository<T> repository;

        public PutGenericHandlers(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(PutGeneric<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Update(request.Obj);
            return Task.FromResult(result);
        }
    }
}
