using NUnit.Framework;
using WebApp;

namespace Tests
{
    public class ArticleRepositoryTests
    {
        [Test]
        public void GetLatestDoesNotReturnAnEmptyList()
        {
            // arrange
            var repository = new ArticleRepository();

            // assert
            Assert.IsTrue(repository.GetLatest() != null);
        }

        [Test]
        public void GetArticleReturnsAnArticleForValidId()
        {
            // arrange
            var repository = new ArticleRepository();

            // act
            var article = repository.GetArticle(2);

            // assert
            Assert.IsTrue(article.Id != 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(article.Title));
        }

        [Test]
        public void GetArticleReturnsAnEmptyArticleForInvalidId()
        {
            // arrange
            var repository = new ArticleRepository();

            // act
            var article = repository.GetArticle(5);

            // assert
            Assert.IsTrue(article.Id == 0);
            Assert.IsTrue(string.IsNullOrWhiteSpace(article.Title));
        }
    }
}