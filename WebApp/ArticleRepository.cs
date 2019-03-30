using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "What is Lorem Ipsum?",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 01, 20),
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Article
            {
                Id =  2,
                Title = "Why do we use it?",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 01, 21),
                Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."
            },
            new Article
            {
                Id = 3,
                Title = "Where does it come from?",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 01, 22),
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old."
            },
            new Article
            {
                Id = 4,
                Title = "Yet another article",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 03, 27),
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old."
            },
        };

        public Article GetArticle(int id)
        {
            var article = articles.FirstOrDefault(a => a.Id == id);

            if (article == null)
            {
                article = new Article();
            }
            return article;
        }

        public List<Article> GetLatest()
        {
            return articles;
        }
    }
}
