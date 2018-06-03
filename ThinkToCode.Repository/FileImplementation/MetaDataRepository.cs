using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;
using ThinkToCode.Repository.Common;
using ThinkToCode.Repository.Contract;

namespace ThinkToCode.Repository.FileImplementation
{
    public class FileBasedMetaDataRepository : Common.BaseRepository<Metadata>, IMetaDataRepository
    {
        
        public Metadata GetMetatags(string id)
        {
            throw new NotImplementedException();
        }
    }
}
