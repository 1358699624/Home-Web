using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YY_Model;
using YY_Services;

namespace YY_NpoiExportAndImport.Controllers
{
    public class OperationController : Controller
    {
        // GET: OperationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OperationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OperationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperationController/Create
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

        // GET: OperationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OperationController/Edit/5
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

        // POST: OperationController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            //请求数据库使用EF
            userInfoService userInfoService = new userInfoService();
            int  i =  userInfoService.Delete(id);
            if (i>0)
            {
              
            }
            return View();
        }
        //Ajax
        // POST: OperationController/Delete/5
        [HttpPost]
        public IActionResult Delete111([FromForm] int Id)
        {
            try
            {
                return Json(new { code = 0, msg = $"接收到的参数 para1:{Id}" });
                /*userInfoService userInfoService = new userInfoService();
                int i = userInfoService.Delete(Id);
                if (i > 0)
                {

                }
                return Json(new { code = 0, msg = $"接收到的参数 ids:{Id}" });*/
            }
            catch
            {
                return View();
            }
        }


    }
}
