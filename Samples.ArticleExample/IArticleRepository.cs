using System.Collections.Generic;

namespace Samples.ArticleExample
{
    public interface IArticleRepository
    {
        IEnumerable<Article> RetrieveAll();
    }
}
