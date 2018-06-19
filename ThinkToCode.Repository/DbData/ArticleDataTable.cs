using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinkToCode.Common.Entity;

namespace ThinkToCode.Repository.DbData
{
    public class ArticleDataTable
    {
        public static ArticleDataTable Instance { get; set; }

        private IList<ArticleEntity> ArticleData;

        static ArticleDataTable()
        {
            Instance = new ArticleDataTable();
        }
        private ArticleDataTable()
        {

        }

        public IList<ArticleEntity> PopulateArticles()
        {
            ArticleData = ArticleData ?? this.Populate();
            return ArticleData;
        }

        public IList<ArticleEntity> Populate()
        {
            var articleEntities = new List<ArticleEntity>();
            var article = new ArticleEntity
            {
                Id = 1,
                TopicId = 4,
                Tile = "Visitor Pattern - ReExplained !!",
                SeoTitle = "Visitor-Pattern-ReExplained",
                FileKey = "36b7ebcd-e635-404f-b0c0-786adf1373ae",
                Description = "Visitor Pattern is, in general opinion, is the most complicated design pattern because of the nature of problem it solves.We will look what it is, how it works and how it should be implemented in real scenarios. Every one among us might get into the situation, when we have a complex class hierarchy and we want to add or modify their behaviors without changing their original code.The “Complex” word I have used because in the hierarchy, every object are of different types and we want to add operation which will run on specific type’s.i.e.different operation for different types of object. Frankly saying, most of time we do type/instance checking to determine the type and then select the operation via If-else statement.This approach has its own limitations and, of course, not an object oriented way.To fix this type of problems in an object oriented way – Visitor Pattern came into picture.",
                WrittenOn = "March 17, 2018"
            };

            articleEntities.Add(article);

            article = new ArticleEntity
            {
                Id = 2,
                TopicId = 5,
                Tile = "Linear Search",
                SeoTitle = "Linear-Search",
                FileKey = "0b2390aa-b65f-4fd8-bf82-c3d0c6ded435",
                Description = "Linear search is rarely used practically because other search algorithms such as the binary search algorithm and hash tables allow significantly faster searching comparison to Linear search.The time complexity of above algorithm is O(n).",
                WrittenOn = "Feb 24, 2018"
            };

            articleEntities.Add(article);

            article = new ArticleEntity
            {
                Id = 3,
                TopicId = 6,
                Tile = "Bubble Sort",
                SeoTitle = "Bubble-Sort",
                FileKey = "e0cfb749-440d-4605-9683-fcf3d924e867",
                Description = "Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list to be sorted, compares each pair of adjacent items and swaps them if they are in the wrong order.Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.",
                WrittenOn = "June 12, 2018"
            };

            articleEntities.Add(article);

            return articleEntities;
        }
    }
}
