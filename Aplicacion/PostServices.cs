using Aplicacion.contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Persistencia;
using Persistencia.Repositorio.Contratos;

namespace Aplicacion
{
    public class PostServices : IPostServices
    {
        private IPostsRepostirorio _postsrepostirorio;
        public PostServices(IPostsRepostirorio postsrepostirorio) {
            _postsrepostirorio = postsrepostirorio;
        }
        public List<Post> GetAllPost()
        {
            return _postsrepostirorio.GetAllPost();
        }
    }
}
