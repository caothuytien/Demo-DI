using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_TEST.DI
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        //public Operation() : this(Guid.NewGuid())
        //{
        //}
        //public Operation(Guid id)
        //{
        //    OperationId = id;
        //}
        //public Guid OperationId { get; private set; }

        public Guid Guid { get; set; }

        public Operation()
        {
            Guid = Guid.NewGuid();
        }

        public Operation(Guid guid)
        {
            Guid = guid;
        }

        public Guid GetCurrentID()
        {
            return Guid;
        }
    }
}
