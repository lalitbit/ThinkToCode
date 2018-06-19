using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;
using ThinkToCode.Common.Entity.Menu;

namespace ThinkToCode.Repository.DbData
{
    internal class MenuDataTable
    {
        public static MenuDataTable Instance { get; set; }

        public MenuDetailEntity MenuDetailEntity;
        public ArticleEntity ArticleEntity;
        static MenuDataTable()
        {
            Instance = new MenuDataTable();
        }
        private MenuDataTable()
        {

        }

        public MenuDetailEntity PopulateMenu()
        {
            MenuDetailEntity = MenuDetailEntity ?? this.Populate();
            return MenuDetailEntity;
        }

        private MenuDetailEntity Populate()
        {
            var articles = ArticleDataTable.Instance.Populate();

            var menu = new MenuDetailEntity();
            menu.Menus = this.GetMenus();
            var subMenus = this.GetSubMenus();
            var subMenuMappings = this.GetSubMenuMappings();
            menu.ArticleMappings = this.GetArticleMappings();
            menu.SubMenus = subMenus;
            menu.SubMenuMappings = subMenuMappings;

       //     menu.Menus = menu.Menus.Where(x=>x.ari)
            foreach (var item in menu.Menus)
            {
                subMenuMappings.Where(x => x.MenuId == item.Id).ToList()
                     .ForEach(x =>
                     {
                         var submenu = subMenus.Where(y => x.SubMenuId == y.Id && articles.Any(article => article.TopicId == y.Id)).FirstOrDefault();
                         if (submenu != null)
                         {
                             item.SubMenus.Add(submenu);
                         }
                     });
            }

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
            menu.Add(new MenuEntity { Id = 1, Name = "S.O.L.I.D Principle", UrlName = "SOLID-Principle", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 2, Name = "Creational Patterns", UrlName = "Creational-Patterns", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 3, Name = "Behavioral Patterns", UrlName = "Behavioral-Patterns", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 4, Name = "Structural Patterns", UrlName = "Structural-Patterns", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 5, Name = "Searching", UrlName = "", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 6, Name = "Sorting", UrlName = "", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 7, Name = "Graph", UrlName = "", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 8, Name = "Bit", UrlName = "", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 9, Name = "Pattern", UrlName = "", DisplayOrder = 5 });
            menu.Add(new MenuEntity { Id = 10, Name = "Array", UrlName = "", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 11, Name = "LinkedList", UrlName = "", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 12, Name = "Stack", UrlName = "", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 13, Name = "Queue", UrlName = "", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 14, Name = "Tree", UrlName = "Tree", DisplayOrder = 5 });
            menu.Add(new MenuEntity { Id = 15, Name = "String", UrlName = "String", DisplayOrder = 6 });
            menu.Add(new MenuEntity { Id = 16, Name = "Matrix", UrlName = "Matrix", DisplayOrder = 7 });
            return menu;
        }

        private IList<MenuEntity> GetMenus()
        {
            var menu = new List<MenuEntity>();
            menu.Add(new MenuEntity { Id = 1, Name = "Design Principles", UrlName = "Design-Principles", DisplayOrder = 1 });
            menu.Add(new MenuEntity { Id = 2, Name = "Algorithms", UrlName = "Algorithms", DisplayOrder = 2 });
            menu.Add(new MenuEntity { Id = 3, Name = "Data Structure", UrlName = "Data-Structure", DisplayOrder = 3 });
            menu.Add(new MenuEntity { Id = 4, Name = ".NET & C#", UrlName = "DotNet-CSharp", DisplayOrder = 4 });
            menu.Add(new MenuEntity { Id = 5, Name = "Tips & Tricks", UrlName = "Tips-Tricks", DisplayOrder = 5 });
            return menu;
        }
    }
}
