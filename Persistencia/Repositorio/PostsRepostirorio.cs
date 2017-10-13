using Cassandra.Mapping;
using Models;
using Persistencia.Repositorio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorio
{
    public class PostsRepostirorio : IPostsRepostirorio
    {
        private IInitializer _initializer;
        public PostsRepostirorio(IInitializer initializer)
        {
            _initializer = initializer;
        }
        public List<Post> GetAllPost()
        {
            var listpost = _initializer.getIMapper().Fetch<Post>();
            return listpost.ToList();
        }
    }
}
