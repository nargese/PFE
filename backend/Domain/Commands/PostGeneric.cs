using MediatR;

namespace Domain.Handlers
{
    public class PostGeneric<T> : IRequest<string> where T : class
    {
        
        public PostGeneric(T obj)
        {
            Obj = obj;
        }
        public T Obj { get; }

    
}
}