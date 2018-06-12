using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkToCode.Common.Entity.Menu
{
    public class MenuDetailEntity
    {
        public IList<MenuEntity> Menus { get; set; }

        public IList<MenuEntity> SubMenus { get; set; }

        public IList<MenuSubMenuMapping> SubMenuMappings { get; set; }

        public IList<ArticleMapping> ArticleMappings { get; set; }
    }
}
