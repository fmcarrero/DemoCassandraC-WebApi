using Aplicacion.contratos;
using Cassandra;
using Cassandra.Mapping;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CassandraPost.Controllers
{
    public class BlogController : ApiController
    {
        private IPostServices _PostsServices;
        public BlogController(IPostServices postsServices)
        {
            _PostsServices = postsServices;
        }
        [HttpGet]
        [Route("api/posts")]
        public IHttpActionResult GetAllPost()
        {
            var listpost = _PostsServices.GetAllPost();
            return Ok(listpost.ToList());
        }        
    }
}