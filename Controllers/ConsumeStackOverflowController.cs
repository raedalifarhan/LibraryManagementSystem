using LibraryManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;

namespace LibraryManagementSystem.Controllers
{
    public class ConsumeStackOverflowController : Controller
    {
        // GET: ConsumeStackOverflowController
        public async Task<ActionResult> GetQuestions(int page = 5, int pagesize = 50)
        {
            StackResponseViewModel questions = null;


            HttpClientHandler handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (var Client = new HttpClient(handler))
            {
                Client.BaseAddress = new Uri("https://api.stackexchange.com/");
                //HTTP GET
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));
                var response = Client.GetAsync("/2.3/questions?page=" + page + "&pagesize=" + pagesize + "&order=desc&sort=activity&site=stackoverflow");
                response.Wait();
                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<StackResponseViewModel>();
                    readTask.Wait();
                    questions = readTask.Result;
                }

            }

            return View(questions);
        }

        // GET: ConsumeStackOverflowController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            StackAnswerViewModel comments = null;


            HttpClientHandler handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (var Client = new HttpClient(handler))
            {
                Client.BaseAddress = new Uri("https://api.stackexchange.com/");
                //HTTP GET
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));
                var response = Client.GetAsync("/2.3/questions/" + id + "/answers?order=desc&sort=activity&site=stackoverflow");

                response.Wait();
                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<StackAnswerViewModel>();
                    readTask.Wait();
                    comments = readTask.Result;
                }

            }

            return View(comments);
        }
    }
}
