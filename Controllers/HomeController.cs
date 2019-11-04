using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using viewmodelfun.Models;

namespace viewmodelfun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            Message message = new Message()
            {
                MessageContent = "kejrbvkjerbgkjewbrkgjbnewrkjgbekrjbgkjerbgtkjwe5tkjewbgkjewrbgiwergfkubwerkuhfbwrekuhfkwherfgjehrwbgwerbgbecjhwegf,jbhwevfjwherb fgkujhwevfjhwrekgfkurj vkjehrbv werjhfgkwmebfmwgerf rjver vuegrv emrjv ajr cmerjgvawmejcvawmrejc hw cmjcr"
            };
            return View(message);
        }

        [HttpGet("numbers")]
        public IActionResult Nums()
        {
            Number n1 = new Number()
            {
                num = 1
            };
            Number n2 = new Number()
            {
                num = 2
            };
            Number n3 = new Number()
            {
                num = 3
            };
            Number n4 = new Number()
            {
                num = 4
            };
            Number n5 = new Number()
            {
                num = 5
            };
            Number n6 = new Number()
            {
                num = 6
            };
            Number n7 = new Number()
            {
                num = 7
            };

            List<Number> viewnumbers = new List<Number>()
            {
                n1,
                n2,
                n3,
                n4,
                n5,
                n6,
                n7
            };
            return View("Nums", viewnumbers);
        }

        [HttpGet("users")]
        public IActionResult User()
        {
            User Ivar = new User()
            {
                FirstName = "Ivar",
                LastName = "Brandt"
            };

            User Bridger = new User()
            {
                FirstName = "Bridger",
                LastName = "Middleton"
            };

            User Sam = new User()
            {
                FirstName = "Sam",
                LastName = "tron"
            };

            User AlltheDaves = new User()
            {
                FirstName = "AlltheDaves",
                LastName = "Dave1234"
            };
            List<User> viewnames = new List<User>()
            {
                Ivar,
                Bridger,
                Sam,
                AlltheDaves
            };
            return View("User", viewnames);
        }

        [HttpGet("user")]
        public IActionResult SingleUser()
        {

            SingleUser Ivar = new SingleUser()
            {
                FirstName = "Ivar",
                LastName = "Brandt"
            };
            List<SingleUser> singlename = new List<SingleUser>()
            {
                Ivar,
            };

            return View("SingleUser", singlename);
        }
    }

}
