using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(values);
        }
        //[HttpGet]
        //public IActionResult AddAnnouncement()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddAnnouncement(AnnouncementAddDto announcementAddDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _announcementService.TInsert(new Announcement()
        //        {
        //            Content = announcementAddDto.Content,
        //            Title = announcementAddDto.Title,
        //            Date = DateTime.Now
        //        });
        //        return RedirectToAction("Index");
        //    }
        //    return View(announcementAddDto);
        //}
        //[HttpGet]
        //public IActionResult UpdateAnnouncement(int id)
        //{
        //    var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetById(id));
        //    return View(values);
        //}

        //[HttpPost]
        //public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _announcementService.TUpdate(new Announcement
        //        {
        //            AnnouncementId = model.AnnouncementId,
        //            Content = model.Content,
        //            Title = model.Title,
        //            Date = DateTime.Now
        //        });
        //        return RedirectToAction("Index");
        //    }

        //    return View(model);
        //}
    }
}
