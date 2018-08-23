using CRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace CRUDAPI.Controllers
{
    public class UserViewController : Controller
    {
        private HttpClient client;
        private const string url = "http://localhost:60990/api/user/";
        public UserViewController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
           // client.DefaultRequestHeaders.Accept.Clear();
           // client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: UserView
        public ActionResult Index()
        {
            IEnumerable<UserViewModel> Users = null;

            //using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60990/api/");
                //HTTP GET
                var responseTask = client.GetAsync("user/getAll");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<UserViewModel>>();
                    readTask.Wait();

                    Users = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Users = Enumerable.Empty<UserViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Users);
            
        }
        [HttpGet]
        public ActionResult update(int id)
        {
            UserViewModel Users = null;
            //using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60990/api/user/");
                //HTTP GET
                var responseCreateTask = client.GetAsync("getById?id=" + id.ToString());
                responseCreateTask.Wait();

                var result = responseCreateTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<UserViewModel>();
                    readTask.Wait();

                    Users = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Users);
        }
        [HttpPost]
        public ActionResult update(UserViewModel u)
        {
           
            //using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60990/api/user/");
                //HTTP GET
                var responseTask = client.PutAsJsonAsync<UserViewModel>("update", u);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else //web api sent error response 
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(u);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel u)
        {
           
           // using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60990/api/");
                //HTTP GET
                var responsePostTask = client.PostAsJsonAsync<UserViewModel>("user/create", u);
                responsePostTask.Wait();

                var result = responsePostTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else //web api sent error response 
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(u);

        }
        
        public ActionResult Delete(int id)
        {
           client.BaseAddress = new Uri(url);
                //HTTP GET
                var responseCreateTask = client.DeleteAsync("delete?id=" + id.ToString());
                responseCreateTask.Wait();

                var result = responseCreateTask.Result;
                if (result.IsSuccessStatusCode)
                {
                return RedirectToAction("Index");
                  }
                else //web api sent error response 
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            return RedirectToAction("Index");

        }
    }
}