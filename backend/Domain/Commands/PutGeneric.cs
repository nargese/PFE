﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OsmoseInverse.Domain.Commands
{
    public class PutGeneric<T> : IRequest<string> where T : class

    {
        public PutGeneric(T obj)
        {
            Obj = obj;
        }

        public T Obj { get; set; }
    }
}

