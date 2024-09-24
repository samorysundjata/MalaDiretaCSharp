using Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinatarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DestinatarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("destinatario")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: DestinatarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DestinatarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DestinatarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DestinatarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DestinatarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DestinatarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DestinatarioController/Delete/5
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
