using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODOList.BLL.Abstract;
using TODOList.UI.ViewModel;

namespace TODOList.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseController _baseController;

        public HomeController(IBaseController  baseController)
        {
            _baseController = baseController;
        }
        public ActionResult Index()
        {
            TaskViewModel taskViewModel = new TaskViewModel();
            var taskList = _baseController.GetAll();
            taskViewModel.ListTask = taskList;
            return View(taskViewModel);
        }

        [HttpPost]
        public ActionResult Create(TaskViewModel taskViewModel)
        {
            _baseController.Add(taskViewModel.Task);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var entity = _baseController.Get(id);
            _baseController.Delete(entity);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int Id)
        {
            var entity = _baseController.Get(Id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(TODOList.Entities.Concrete.Task entity)
        {
            _baseController.Update(entity);
            return View(entity);
        }
    }
}