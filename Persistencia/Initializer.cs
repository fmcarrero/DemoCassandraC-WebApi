using Cassandra;
using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Initializer : IInitializer
    {
        private ICluster _cluster;
        private ISession _session;
        private IMapper _mapper;
        public Initializer() {
              _cluster = Cluster.Builder().AddContactPoint("localhost").WithPort(32769).Build();
             _session = _cluster.Connect("blog");
             _mapper = new Mapper(_session);
        }

        public IMapper getIMapper()
        {
            return _mapper;
        }
    }
}
