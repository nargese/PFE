using Domain.Queries;
using MediatR;
using OsmoseInverse.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OsmoseInverse.Domain.Handler
{
    public class GetGenericHandlerById<T> : IRequestHandler<GetGenericQueryById<T>, T> where T : class
    {

        private readonly IRepository<T> repository;

        public GetGenericHandlerById(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<T> Handle(GetGenericQueryById<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Get(request.Condition, request.Includes);
            return Task.FromResult(result);
        }
    }
}


