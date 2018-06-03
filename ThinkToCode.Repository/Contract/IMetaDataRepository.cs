using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;
using ThinkToCode.Repository.Common;

namespace ThinkToCode.Repository.Contract
{
    public interface IMetaDataRepository : IBaseRepository<Metadata>
    {
        Metadata GetMetatags(string id);
    }
}
