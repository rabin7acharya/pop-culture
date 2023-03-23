using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PopCulture.DataAccess;
using PopCulture.DataAccess.Repository.IRepository;
using PopCulture.Models;
using PopCulture.Utility;

namespace PopCultureWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class WearTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public WearTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<WearType> objWearTypeList = _unitOfWork.WearType.GetAll();
            return View(objWearTypeList);
        }
        // GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(WearType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.WearType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Wear Type created successfully.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var WearTypeFromDbFirst = _unitOfWork.WearType.GetFirstOrDefault(u => u.Id == id);

            if (WearTypeFromDbFirst == null)
            {
                return NotFound();
            }
            return View(WearTypeFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(WearType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.WearType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Wear Type updated successfully.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var WearTypeFromDbFirst = _unitOfWork.WearType.GetFirstOrDefault(u => u.Id == id);

            if (WearTypeFromDbFirst == null)
            {
                return NotFound();
            }
            return View(WearTypeFromDbFirst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.WearType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.WearType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Wear Type deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}
