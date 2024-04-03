﻿using MediatR;
using OsmoseInverse.Domain.Interfaces;
using OsmoseInverse.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class GetAllGenericHandlers<T> : IRequestHandler<GetAllGenericQuery<T>, IEnumerable<T>> where T : class
    {
        private readonly IRepository<T> repository;

        public GetAllGenericHandlers(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<IEnumerable<T>> Handle(GetAllGenericQuery<T> request, CancellationToken cancellationToken)
        {
            var result = repository.GetList(request.Condition, request.Includes);
            return Task.FromResult(result);
        }
    }
}
