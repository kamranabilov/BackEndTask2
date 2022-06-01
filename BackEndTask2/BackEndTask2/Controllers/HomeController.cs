using BackEndTask2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndTask2.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    Image = "https://free4kwallpapers.com/uploads/originals/2015/11/09/potala-palace-in-tibet-wallpaper.jpg",
                    Title = "Title",
                    Subtitle = "subtitle",
                    Button = "https://www.google.com/"
                }
            };

            return View(sliders);

            
        }
    }
}
