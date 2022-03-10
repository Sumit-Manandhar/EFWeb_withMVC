using EFWeb.model;
using EFWeb.repository;
using EFWeb.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWeb.Controllers
{
    public class DegreeController : Controller
    {

        private readonly IDegreeRepo _repo;

        public DegreeController()
        {
            _repo = new DegreeRepo();
        }
        // GET: Degree
        public ActionResult Index()
        {
            return View(_repo.GetList());
        }

        // GET: Degree/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetById(id));
        }

        // GET: Degree/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Degree/Create
        [HttpPost]
        public ActionResult Create(Degree data)
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

        // GET: Degree/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: Degree/Edit/5
        [HttpPost]
        public ActionResult Edit(Degree data)
        {
            try
            {
                // TODO: Add update logic here
                _repo.Update(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Degree/Delete/5
        public ActionResult Delete(int id)
        {
            var entity= _repo.GetById(id);
            return View(entity);
        }

        //POST: Degree/Delete/5
        [HttpPost]
        public ActionResult Delete(Degree data)
        {
            try
            {
                
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
