using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_TEST.DI
{
    public interface IOperation
    {
        //Guid OperationId { get; }
        Guid GetCurrentID();
    }

    public interface IOperationTransient : IOperation
    {       
    }

    public interface IOperationScoped : IOperation { }

    public interface IOperationSingleton : IOperation { }

    public interface IOperationSingletonInstance : IOperation { }
}
