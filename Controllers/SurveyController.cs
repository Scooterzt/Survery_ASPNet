using Microsoft.AspNetCore.Mvc;
using System;
    namespace Survey.Controllers{
        public class SurveyController : Controller{
            [HttpGet("")]
            public IActionResult Index(){
                return View();
            }
            [HttpPost("/submit")]
            public IActionResult submit(string name, string location, string langauge, string comment){
                ViewBag.name = name;
                ViewBag.location = location;
                ViewBag.langauge = langauge;
                ViewBag.comment = comment;
                return RedirectToAction("Success");
            }
            [HttpGet("Success")]
            public IActionResult Success(){
                return View();
            }
        }
    }