using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThinkToCode.Common.Entity;
using ThinkToCode.Services.Contract;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ThinkToCode.Controllers
{
    public class CommentController : Controller
    {
        private IArticleService articleService;

        public CommentController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet]
        public IList<UserComment> GetCommnets(string id)
        {
            var comments = this.articleService.GetUserComments(id);
            return comments;
        }

        [HttpPost]
        public bool post(string id, string comment)
        {
            return this.articleService.SaveUserComment(new UserComment { UserName = "User 1", Comment = comment, FileId = id });
        }
    }
}
