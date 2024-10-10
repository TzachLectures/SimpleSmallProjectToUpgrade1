using LegacyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleSmallProjectToUpgrade1.Controllers
{
    public class PostsDataController : ApiController
    {
        // In-memory data store for demo purposes
        private static List<string> todos = new List<string> { "Learn ASP.NET Web API", "Build an API project" };

        [HttpGet]
        public string Get()
        {
            LegacyHelper legacyHelper = new LegacyHelper();
            string posts = legacyHelper.GetApiData("https://jsonplaceholder.typicode.com/posts");
            return posts;
        }
    }
}
