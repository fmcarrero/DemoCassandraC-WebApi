using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.contratos
{
   public interface IPostServices
    {
        List<Post> GetAllPost();
    }
}
