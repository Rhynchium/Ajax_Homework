using AJAX_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AJAX_Homework.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;
        public ApiController(DemoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CheckAccount(Members member)
        {
            var datas = _context.Members.Select(a => a.Name).ToList();

            if (datas.FirstOrDefault(m => m == member.Name) != null)
            {
                return Content("1");
            }
            return Content("");//回傳空字串作為false讀取
        }

        public IActionResult Cities()
        {
            var datas = _context.Address.Select(a => a.City).Distinct().OrderBy(a => a);

            return Json(datas);
        }

        public IActionResult Sites(string city)
        {
            var datas = _context.Address.Where(a => a.City == city)
                                        .Select(a => a.SiteId)
                                        .Distinct().OrderBy(a => a);

            return Json(datas);
        }

        public IActionResult Roads(string siteid)
        {
            var datas = _context.Address.Where(a => a.SiteId == siteid)
                                        .Select(a => a.Road)
                                        .Distinct().OrderBy(a => a);

            return Json(datas);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
