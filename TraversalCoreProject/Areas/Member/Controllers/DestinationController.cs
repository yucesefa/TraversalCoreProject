﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}
