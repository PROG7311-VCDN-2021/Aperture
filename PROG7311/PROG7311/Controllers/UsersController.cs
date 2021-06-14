using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROG7311.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PROG7311.Controllers
{
    public class UsersController : Controller
    {
        private readonly _19003646_prog7311Context db;

        public UsersController(_19003646_prog7311Context context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //________________________________________Code Attribution________________________________________
        //The following code was taken from C# Corner
        //Author: Purushottam Rathore

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            IEnumerable<User> loginUser = from user in db.Users
                                            where user.Username == Username && user.UserPassword == Password
                                            select user;


            if (loginUser.ToList().Count > 0) //username and password is correct
            {

                
               // HttpContext.Session.SetString("testing", loginUser.ToList().ElementAt(0).Username);

                return RedirectToAction("Index", "Home");
            }
            else
            {

                ViewBag.Error = "Incorrect Username or Password";
                //Response.WriteAsync("<Script> alert ('Successful');</Script>");
                return View("Login");
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string Username, string Password)
        {
            IEnumerable<User> RegUser = from user in db.Users
                                          where user.Username == Username && user.UserPassword == Password
                                          select user;




            if (RegUser.ToList().Count > 0) //username and password is correct
            {

                // HttpContext.Session.SetString("testing", loginUser.ToList().ElementAt(0).Username);

                return RedirectToAction("Logins", "Login");
            }
           else
            {
                ViewBag.Error = "Incorrect Username or Password";
                return View("Register");
            }
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}