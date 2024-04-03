using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OsmoseInverse.Domain.Commands
{
    public class DeleteObject<T> : IRequest<string> where T : class
    {
        public DeleteObject(T entity)
        {
            Entity = entity;
        }

        public T Entity { get; }

    }
}





