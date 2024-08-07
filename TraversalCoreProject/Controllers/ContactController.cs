﻿using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto sendMessageDto)
        {
            if (ModelState.IsValid)
            {


                _contactUsService.TInsert(new ContactUs()
                {
                    MessageBody = sendMessageDto.MessageBody,
                    Mail = sendMessageDto.Mail,
                    MessageStatus = true,
                    Name = sendMessageDto.Name,
                    Subject = sendMessageDto.Subject,
                    MessageDate = DateTime.Now
                });
                return RedirectToAction("Index");
            }
            return View(sendMessageDto);
        }
    }
}
