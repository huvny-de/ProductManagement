using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UpLoadPhotoMVC.DbContexts;
using UpLoadPhotoMVC.Entities;

namespace UpLoadPhotoMVC.Controllers
{
    public class PhotoController : Controller
    {
        private readonly DbUpLoadPhotoMVC _context;
        private IWebHostEnvironment webHostEnviroment;
        public PhotoController(DbUpLoadPhotoMVC context, IWebHostEnvironment _webHostEnviroment)
        {
            _context = context;
            webHostEnviroment = _webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod, IFormFile hinhanh)
        {
            if (hinhanh == null || hinhanh.Length == 0)
            {
                return Content("Vui lòng chọn hình ảnh");
            }
            else
            {
                var path = Path.Combine(this.webHostEnviroment.WebRootPath, "images", hinhanh.FileName);
                var stream = new FileStream(path, FileMode.Create);
                hinhanh.CopyToAsync(stream);
                prod.Photo = hinhanh.FileName;
                _context.Products.Add(prod);
                _context.SaveChanges();
            }
            return View("KetQua", prod);
        }
    }
}
