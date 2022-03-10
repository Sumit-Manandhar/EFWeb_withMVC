using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFWeb.model;
using EFWeb.repository;
using EFWeb.repository.Interface;

namespace EFWeb.Controllers
{
    public class DoctorController : Controller
    {

        private readonly IDoctorRopo _repo;

        public DoctorController()
        {
            _repo = new DoctorRepo();
        }
        // GET: Doctor
        public ActionResult Index()
        {
            return View(_repo.GetList());
        }

        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            var model = _repo.GetById(id);
            return View(model);
        }

        // GET: Doctor/Create
        public ActionResult Create()
        {
            Doctor model = new Doctor
            {
                DegreeList = _repo.DropDownList()
            };
            return View(model);
        }

        // POST: Doctor/Create
        [HttpPost]
        public ActionResult Create(Doctor data)
        {
            try
            {
                _repo.Add(data);
                return RedirectToAction("Index");

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _repo.GetById(id);
            Doctor model = new Doctor
            {
                Name = item.Name,
                Address=item.Address,
                Id=item.Id,
                DegreeList = _repo.DropDownList()
            };
            return View(model);
        }

        // POST: Doctor/Edit/5
        [HttpPost]
        public ActionResult Edit( Doctor data)
        {
            try
            {
                _repo.Update(data);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Delete/5
        public ActionResult Delete(int id)
        {
            var entity = _repo.GetById(id);
            return View(entity);
        }

        // POST: Doctor/Delete/5
        [HttpPost]
        public ActionResult Delete(Doctor data)
        {
            try
            {
                // TODO: Add delete logic here

                _repo.Delete(data);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
