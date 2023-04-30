using CarRentalSystem.Application.Common;
using CarRentalSystem.Application.Common.Services;
using CarRentalSystem.Application.DTOs;
using CarRentalSystem.Core.Entities;
//using CarRentalSystem.Infrastructure.Migrations;
using CarRentalSystem.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarRentalClean.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IUserService _userService;

        public VehicleController(IUnitOfWork unitOfWork, IFileService fileService, IUserService userService)
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
        public IActionResult AddVehicle()
        {
            VehicleDTO vehiclePostDTO = new VehicleDTO();
            return View(vehiclePostDTO);
        }

        [HttpPost]
        public IActionResult AddVehicle(VehicleDTO model)
        {
            Vehicle vehicle = new Vehicle();
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = new string(claim.Value);
            if (model.PhotoUrl != null)
            {
                var result = _fileService.SaveImage(model.PhotoUrl);
                if (result.Item1 == 1)
                {
                    vehicle.VehicleImage = result.Item2;
                }

            }


            vehicle.Model = model.VehicleModel;
            vehicle.Color = model.Color;
            vehicle.PlateNumber = model.PlateNumber;
            vehicle.PricePerDay = model.PricePerDay;
            vehicle.CreatedBy = user;
            _unitOfWork.Vehicle.Add(vehicle);
            _unitOfWork.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult DisplayVehicle()
        {
            
            List<Vehicle> vehicleList = _unitOfWork.Vehicle.GetAll().Where(x => x.IsAvailable == true).ToList();
           
            return View(vehicleList);
        }

        [HttpGet]
        public IActionResult VehiclesOffer()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = new string(claim.Value);
            List<Vehicle> vehicleList = _unitOfWork.Vehicle.GetAll().Where(x => x.CreatedBy == user).ToList();
            return View(vehicleList);
        }

        [HttpGet]
        public IActionResult PublishOffer(Guid id)
        {
            OfferDTO offer = new OfferDTO()
            {
                VehicleId = id,
            };
            return View(offer);
        }
        [HttpPost]
        public IActionResult PublishOffer(OfferDTO model)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = new string(claim.Value);
            Offer offer = new Offer()
            {
                VehicleId = model.VehicleId,
                ValidityDate = model.ValidityDate,
                OfferDescription = model.OfferMessage,
                CreatedBy =  user,
                CreatedDate = DateTime.Now
            };
            _unitOfWork.Offer.Add(offer);
            _unitOfWork.SaveChangesAsync();
            return RedirectToAction("DisplayVehicle");
        }
        [HttpGet]
        public async Task<IActionResult> Rent(Guid id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = new string(claim.Value);
            var customer = _unitOfWork.Customer.GetFirstOrDefault(x => x.UserId == user);
            var document= _userService.GetDocument(user);
            RentVehicleDTO model = new RentVehicleDTO();

            if (document != "")
            {
                model.DocumentExists = true;
                model.DocumentName = document;
            }
            model.Vehicle = _unitOfWork.Vehicle.Get(id);
            model.Vehicleid = id;
            model.CustomerId = customer.Id;
            return View(model);

        }
        [HttpPost]
        public IActionResult Rent(RentVehicleDTO model)
        {
           
            Rental rental = new Rental()
            {
                VehicleId = model.Vehicleid,
                CustomerId = model.CustomerId,
                RequestedDate = model.RequestedDate,
            };
            Document document = new Document();
            _unitOfWork.Vehicle.Update(model.Vehicleid);
            if (model.DocumentUrl != null)
            {
                var result = _fileService.SaveImage(model.DocumentUrl);
                if (result.Item1 == 1)
                {
                    document.DocumentName = result.Item2;
                }
                document.DocumentType = model.DocumentType;
                document.CustomerId = model.CustomerId;
                _unitOfWork.Document.Add(document);
            

            }
            _unitOfWork.Rental.Add(rental);
            _unitOfWork.SaveChangesAsync();
            return RedirectToAction("Index", "Home");


        }


    }
}
