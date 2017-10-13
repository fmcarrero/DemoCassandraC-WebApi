using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class CassandraMappings : Cassandra.Mapping.Mappings
    {
        public CassandraMappings() {
            For<Post>().TableName("post").PartitionKey(u => u.Id)
                .Column(x => x.Id,cm=> cm.WithName("post_id"))
                .Column(x => x.Title)
                .Column(x => x.Body)
                .Column(x => x.LastUpdated);
        }
    }
}
