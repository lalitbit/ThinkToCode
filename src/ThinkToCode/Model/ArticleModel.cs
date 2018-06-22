using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThinkToCode.Common.Entity;

namespace ThinkToCode.Model
{
    public class ArticleModel  
    {
        public string File { get; set; }
        public IList<UserComment> UserComments { get; set; }
    }
}
