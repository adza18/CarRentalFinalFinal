using CarRentalSystem.Application.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalClean.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IPayment _paymentService;
        public InvoiceController(IPayment paymentService)
        {
            _paymentService = paymentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Payment(string payAmount, string payToken)
        {
            var response = _paymentService.Payment(payAmount, payToken);
            return View();
        }
        [HttpGet]
        public IActionResult GenerateInvoice(Guid id)
        {
            //var response = _paymentService.Payment(payAmount, payToken);
            return View();
        }
    }
}
