using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Viva.Api.Models;

namespace Viva.Api.Controllers
{
    // NOTE: This is a SAMPLE api only and does not reflect the final api. -- smayfield

    public class StatusController : ApiController
    {
        [Route("api/status/{userId}"), HttpGet]
        public List<Status> GetStatus(string userId)
        {
            var feed = new List<Status>();
            for (int i = 0; i < 10; i++)
            {
                var status = new Status()
                {
                    Id = i,
                    PostedOn = DateTime.Now,
                    User = new User()
                    {
                        Id = 1,
                        UserName = "jdoe",
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    Network = new Network() 
                    {
                        Id = (i % 2 == 0) ? 1 : 2,
                        Name = (i % 2 == 0) ? "Facebook" : "Twitter",
                        UrlSlug = (i % 2 == 0) ? "Facebook" : "Twitter"
                    },  
                    Content = "Sample content #" + i
                };
                feed.Add(status);
            }
            return feed;
        }

        [Route("api/status/{networkUrlSlug}/{userId}"), HttpGet]
        public List<Status> GetStatus(string networkUrlSlug, string userId)
        {
            var feed = new List<Status>();
            for (int i = 0; i < 10; i++)
            {
                var status = new Status()
                {
                    Id = i,
                    PostedOn = DateTime.Now,
                    User = new User()
                    {
                        Id = 1,
                        UserName = "jdoe",
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    Network = new Network()
                    {
                        Id = 1,
                        Name = networkUrlSlug
                    },
                    Content = "Sample content #" + i
                };
                feed.Add(status);
            }
            return feed;
        }


    }


}
