using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorio.Contratos
{
    public interface IPostsRepostirorio
    {
        List<Post> GetAllPost();
    }
}
