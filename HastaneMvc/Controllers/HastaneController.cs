using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace HastaneMvc.Controllers
{
    public class HastaneController : Controller
    {
        IHastaneService _hastaneService;
        public HastaneController(IHastaneService hastaneService)
        {
            _hastaneService = hastaneService;
        }
        public IActionResult Listele()
        {
           var result= _hastaneService.GetAll();
            return View(result);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Hastane hastane)
        {
            _hastaneService.AddHastane(hastane);
            return RedirectToAction("Listele");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Hastane hastane)
        {

            try { _hastaneService.DeleteHastane(hastane);
                return RedirectToAction("Listele");
            }
            catch { return View(); }
            
            
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Update()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Update(Hastane hastane)
        {
            _hastaneService.UpdateHastane(hastane);
            return RedirectToAction("Listele");
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
