using MediatR;
using OsmoseInverse.Domain.Commands;
using OsmoseInverse.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OsmoseInverse.Domain.Handler
{
    public class DeleteObjectHandler<T> : IRequestHandler<DeleteObject<T>, string> where T : class
    {

        private readonly IRepository<T> repository;
        public DeleteObjectHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }

        public Task<string> Handle(DeleteObject<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Removeobject(request.Entity);
            return Task.FromResult(result);
        }
    }
}


