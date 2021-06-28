using IdentityCore.Areas.Identity.Data;
using IdentityCore.Data;
using IdentityCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly DbIdentityContext _context;
        private readonly UserManager<AppUsers> _userManager;
        // DI: Dependency Injection
        // Tiêm Db vào Controller của AccountControllers
        public AccountController(DbIdentityContext context, UserManager<AppUsers> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: AccountController
        public ActionResult Index()

        {
            var listUser = _context.Users.Select(x => new UserVIewModel
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                Firstname = x.Firstname,
                LastName = x.lastname,
                PhoneNumber = x.PhoneNumber
            }).ToList();
            return View(listUser);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(string id)
        {
            var userDetail = _context.Users.Where(x => x.Id == id)
                .Select(x => new UserVIewModel
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    Firstname = x.Firstname,
                    LastName = x.lastname,
                    PhoneNumber = x.PhoneNumber
                })
                .FirstOrDefault();
            return View(userDetail);
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(IFormCollection collection)
        {
            try
            {
                var user = new AppUsers
                {
                    UserName = collection["UserName"],
                    Email = collection["Email"],
                    Firstname = collection["FirstName"],
                    lastname = collection["LastName"],
                    PhoneNumber = collection["PhoneNumber"]
                };
                var result = await _userManager.CreateAsync(user, "Abc123!@#");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(string id)
        // Lấy lại thông tin của User mà có Id = id
        {
            var userDetail = _context.Users.Where(x => x.Id == id)
              .Select(x => new UserVIewModel
              {
                  Id = x.Id,
                  UserName = x.UserName,
                  Email = x.Email,
                  Firstname = x.Firstname,
                  LastName = x.lastname,
                  PhoneNumber = x.PhoneNumber
              })
              .FirstOrDefault();
            return View(userDetail);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(string id, IFormCollection collection)
        {
            try
            {
                // Lấy lại User có Id = id
                var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
                user.UserName = collection["UserName"];
                user.Email = collection["Email"];
                user.Firstname = collection["Firstname"];
                user.lastname = collection["LastName"];
                user.PhoneNumber = collection["PhoneNumber"];

                var result = await _userManager.UpdateAsync(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public async Task<ActionResult> DeleteAsync(string id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            var result = await _userManager.DeleteAsync(user);
            return View("Index");
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
