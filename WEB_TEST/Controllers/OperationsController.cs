using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_TEST.DI;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_TEST.Controllers
{
    public class OperationsController : Controller
    {
        private OperationService _operationService;
        private IOperationTransient _transientOperation;
        private IOperationScoped _scopedOperation;
        private IOperationSingleton _singletonOperation;
        private IOperationSingletonInstance _singletonInstanceOperation;

        // GET: /<controller>/
        public OperationsController(OperationService operationService,
        IOperationTransient transientOperation,
        IOperationScoped scopedOperation,
        IOperationSingleton singletonOperation,
        IOperationSingletonInstance singletonInstanceOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }
                
        public IActionResult Index()
        {
            ViewBag.Transient = _transientOperation;
            ViewBag.Scoped = _scopedOperation;
            ViewBag.Singleton = _singletonOperation;
            ViewBag.SingletonInstance = _singletonInstanceOperation;

            ViewBag.Service = _operationService;
            return View();
        }
    }
}
