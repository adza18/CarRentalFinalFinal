using CarRentalSystem.Application.Common.Services;
using CarRentalSystem.Application.Common;
using Microsoft.AspNetCore.Mvc;
using CarRentalSystem.Core.Entities;
using CarRentalSystem.Core.Enums;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using CarRentalSystem.Application.DTOs;

namespace CarRentalClean.Controllers
{
    public class RentalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IUserService _userService;

        public RentalController(IUnitOfWork unitOfWork, IFileService fileService, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RequestDamage(Guid id)
        {
            Damages model = new Damages();
            return View();
        }
        [HttpPost]
        public IActionResult RequestDamage(Damages model)
        {
            //_unitOfWork.Dama
            return View();
        }
        [HttpGet]
        public IActionResult CancelBooking(Guid id)
        {
            var rental = _unitOfWork.Rental.Get(id);
            _unitOfWork.Rental.UpdateStatus(id, RentalStatus.Cancelled);
            _unitOfWork.Vehicle.UpdateCancellation(rental.VehicleId);
            _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }
        [HttpGet]
        public IActionResult ReturnVehicle(Guid id)
        {
            var rental = _unitOfWork.Rental.Get(id);
            var vehicle = _unitOfWork.Vehicle.GetFirstOrDefault(x => x.Id == rental.VehicleId);
            rental.ReturnedDate = DateTime.Now;
            var noOfDaysRented = (rental.ReturnedDate - rental.RequestedDate).Days;
            var total = noOfDaysRented * vehicle.PricePerDay;
            ReturnVehicleDTO model = new ReturnVehicleDTO()
            {
                Rental = rental,
                Vehicle = vehicle,
                NoOfDays = noOfDaysRented,
                Total = total,
            };
            _unitOfWork.SaveChangesAsync();
            return View(model);

        }
        [HttpGet]
        public IActionResult RentalRequest(Guid id)
        {
            var rental = _unitOfWork.Rental.GetAll();
           
            return View(rental);
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Approve(Guid id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = new string(claim.Value);
            _unitOfWork.Rental.Approve(id, RentalStatus.OnRent,user);
            _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}
