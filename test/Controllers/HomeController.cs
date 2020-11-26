using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        ClientContext db;
        public HomeController(ClientContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View(db.Clients.ToList());
        }

        [HttpGet]
        public IActionResult AddFounder(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ClientId = id;
            return View();
        }
        [HttpGet]
        public IActionResult ViewFounder(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ClientId = id;
            return View(db.Founders.ToList());
        }

        [HttpGet]
        public IActionResult AddClient()
        {

            return View();
        }
        [HttpPost]
        public string AddFounder(Founder founder)
        {
            db.Founders.Add(founder);
            founder.Date_added_founder = DateTime.Now.ToString();
            // сохраняем в бд все изменения
            db.SaveChanges();
            return founder.Full_name_founder + "добавлен в список учередителей";
        }
        [HttpPost]
        public string AddClient(Client client)
        {
            db.Clients.Add(client);
            client.Date_added_client = DateTime.Now.ToString();
            // сохраняем в бд все изменения
            db.SaveChanges();
            return client.Name_client + "добавлен в список клиентов";
        }
        [HttpGet]
        public IActionResult DeleteClient(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ClientId = id;
            return View(db.Clients.ToList());
        }
        [HttpPost]
        public string DeleteClient(int id) 
            {
            var clientDelite = db.Clients.Find(id);
                            if (clientDelite == null)
                {
                return "Записи не существует";
            }
            db.Clients.Remove(clientDelite);
            db.SaveChanges();
            return "Запись удалена";
        }
        [HttpGet]
        public IActionResult DeleteFounder(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.FounderId = id;
            return View(db.Founders.ToList());
        }
        [HttpPost]
        public string DeleteFounder(int id)
        {
            var founderDelite = db.Founders.Find(id);
            if (founderDelite == null)
            {
                return "Записи не существует";
            }
            db.Founders.Remove(founderDelite);
            db.SaveChanges();
            return "Запись удалена";
        }
    }
    }

