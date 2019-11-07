using BlazorCRUD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Contracts
{
    public interface IArticleManager
    {
        Task<int> Create(Article article);
        Task<int> Delete(int Id);
        Task<int> Update(Article article);
        Task<Article> GetById(int Id);
        Task<List<Article>> ListAll();
    }
}
