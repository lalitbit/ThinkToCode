using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity.Menu;

namespace ThinkToCode.Repository.DbData
{
    internal class MenuDataTable
    {
        public MenuDetailEntity PopulateMenu()
        {
            var menu = new MenuDetailEntity();
            menu.Menus = this.GetMenus();
            menu.SubMenus = this.GetSubMenus();
            menu.SubMenuMappings = this.GetSubMenuMappings();
            menu.ArticleMappings = this.GetArticleMappings();
            return menu;
        }

        private IList<ArticleMapping> GetArticleMappings()
        {
            var articleMappings = new List<ArticleMapping>();
            articleMappings.Add(new ArticleMapping { Id = 1, ArticleName = "Visitor Pattern ReExplained", ArtilceUrlName = "Visitor-Pattern-ReExplained", FileKey = Guid.Parse("244cf499-6a89-4248-bf89-e81a964f4438"), SubMenuId = 4 });
            return articleMappings;
        }

        private IList<MenuSubMenuMapping> GetSubMenuMappings()
        {
            var subMenuMappings = new List<MenuSubMenuMapping>();
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 1, SubMenuId = 1, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 1, SubMenuId = 2, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 1, SubMenuId = 3, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 1, SubMenuId = 4, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 2, SubMenuId = 5, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 2, SubMenuId = 6, DisplayOrder = 2 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 2, SubMenuId = 7, DisplayOrder = 3 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 2, SubMenuId = 8, DisplayOrder = 4 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 2, SubMenuId = 9, DisplayOrder = 5 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 10, DisplayOrder = 1 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 11, DisplayOrder = 2 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 12, DisplayOrder = 3 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 13, DisplayOrder = 4 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 14, DisplayOrder = 5 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 15, DisplayOrder = 6 });
            subMenuMappings.Add(new MenuSubMenuMapping { MenuId = 3, SubMenuId = 16, DisplayOrder = 7 });

            return subMenuMappings;
        }

        private IList<MenuEntity> GetSubMenus()
        {
            var menu = new List<MenuEntity>();
            menu.Add(new MenuEntity { Id = 1, Name = "S.O.L.I.D Principle", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 2, Name = "Creational Patterns", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 3, Name = "Behavioral Patterns", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 4, Name = "Structural Patterns", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 5, Name = "Searching", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 6, Name = "Sorting", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 7, Name = "Graph", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 8, Name = "Bit", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 9, Name = "Pattern", DisplayOrder = 5 });
            menu.Add(new MenuEntity { Id = 10, Name = "Array", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 11, Name = "LinkedList", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 12, Name = "Stack", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 13, Name = "Queue", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 14, Name = "Tree", DisplayOrder = 5 });
            menu.Add(new MenuEntity { Id = 15, Name = "String", DisplayOrder = 6 });
            menu.Add(new MenuEntity { Id = 16, Name = "Matrix", DisplayOrder = 7 });
            return menu;
        }

        private IList<MenuEntity> GetMenus()
        {
            var menu = new List<MenuEntity>();
            menu.Add(new MenuEntity { Id = 1, Name = "Design Principles", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 2, Name = "Algorithms", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 3, Name = "Data Structure", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 4, Name = ".NET & C#", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 5, Name = "Tips & Tricks", DisplayOrder = 5 });
            menu.Add(new MenuEntity { Id = 6, Name = "About", DisplayOrder = 6 });
            return menu;
        }
    }
}
