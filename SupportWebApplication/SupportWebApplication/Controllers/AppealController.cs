using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using SupportWebApplication.Models;


namespace SupportWebApplication.Controllers
{
    public class AppealController : Controller

    {

        private static List<Appeal> _appeals = new List<Appeal>();



        public IActionResult Index()

        {

            // Active Appeals

            var activeAppeals = _appeals.Where(a => !a.IsResolved).OrderByDescending(a => a.Deadline);

            return View(activeAppeals);

        }



        [HttpPost]

        public IActionResult Create(Appeal appeal)

        {

            appeal.Id = Guid.NewGuid().ToString(); 

            appeal.SubmissionTime = DateTime.Now;

            _appeals.Add(appeal);

            return RedirectToAction("Index");

        }



        [HttpPost]

        public IActionResult MarkAsResolved(string appealId)

        {

            var appeal = _appeals.FirstOrDefault(a => a.Id == appealId);

            if (appeal != null)

            {

                appeal.IsResolved = true;

            }

            return RedirectToAction("Index");

        }

    }
}