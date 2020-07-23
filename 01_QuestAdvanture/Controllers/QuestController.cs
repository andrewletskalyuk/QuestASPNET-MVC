using _01_QuestAdvanture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_QuestAdvanture.Controllers
{
    public class QuestController : Controller
    {
        private QuestRoomContex dbcontext = new QuestRoomContex();

        // GET: Quest
        public ActionResult Index()
        {
            var temp = dbcontext.QuestRooms.ToList();
            ViewBag.QuestRooms = temp;
            return View();
        }

        public ActionResult Details(int id)
        {
            if (id < 0)
            {
                return HttpNotFound();
            }
            var temp = dbcontext.QuestRooms.ToList();
            ViewBag.Detail = dbcontext.QuestRooms.FirstOrDefault(q => q.Id == id);
            ViewBag.Images = dbcontext.QuestRooms.FirstOrDefault(q => q.Id == id).Images;
            return View();
        }

        public ActionResult Search(string title)
        {
            var res = dbcontext.QuestRooms.Where(x => x.Name.Contains(title)).ToList();
            if (res.Count == 0)
            {
                return HttpNotFound("Такий квест не існує!=)");
            }
            return View(res);
        }
    }
}