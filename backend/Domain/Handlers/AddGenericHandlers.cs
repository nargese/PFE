using MediatR;
using OsmoseInverse.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class AddGenericHandlers<T> : IRequestHandler<PostGeneric<T>, string> where T : class
    {

        private readonly IRepository<T> repository;
        public AddGenericHandlers(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(PostGeneric<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Add(request.Obj);
            return Task.FromResult(result);
        }

    }
}
