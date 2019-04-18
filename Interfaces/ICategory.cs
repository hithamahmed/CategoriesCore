using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CategoriesCore.Interfaces
{
    public interface ICategory
    {
        Task<IReadOnlyCollection<CategoriesDTO>> GetAllICategories(int CatalogId);

        Task<IReadOnlyCollection<CategoriesDTO>> GetAllISubCategories(int CategoryId);
    }
}
