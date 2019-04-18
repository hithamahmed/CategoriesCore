using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using CategoriesCore.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using CategoriesCore.Entity;

namespace CategoriesCore.Services
{
    public class CategoryServices : ICategory
    {
        private readonly IAppLogger<CategoryServices> _logger;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IUriComposer _uriComposer;
        //private CategoryMapper _CategoryMapper = new CategoryMapper();

        public CategoryServices(
            IAsyncRepository<Category> CategoryRepository,
            IUriComposer uriComposer,
            IAppLogger<CategoryServices> logger)
        {
            _categoryRepository = CategoryRepository;
            _uriComposer = uriComposer;
            _logger = logger;
         

        }

        public async Task<IReadOnlyCollection<CategoriesDTO>> GetAllICategories(int CatalogueId)
        {
            _logger.LogInformation("GetCategories called With Catalogue: " + CatalogueId);
            var ListOfData = await _categoryRepository.Where(x => x.CatalogueId == CatalogueId && x.ParentcategoryId == null).ConfigureAwait(false);
            ListOfData.ForEach(x =>
            {
                x.PictureUri = _uriComposer.ComposePicUri(x.PictureUri);
            });
            var destObject = ListOfData.Adapt<IReadOnlyCollection<CategoriesDTO>>();
            return destObject;// _CategoryMapper.MapCategoryToCategoriesDTO(ListOfData);
        }

        public async Task<IReadOnlyCollection<CategoriesDTO>> GetAllISubCategories(int CategoryId)
        {
            _logger.LogInformation("GetSubCategories called With Category: " + CategoryId);

            var ListOfData = await _categoryRepository.Where(x => x.ParentcategoryId == CategoryId).ConfigureAwait(false);
            ListOfData.ForEach(x =>
            {
                x.PictureUri = _uriComposer.ComposePicUri(x.PictureUri);
            });
            var destObject = ListOfData.Adapt<IReadOnlyCollection<CategoriesDTO>>();

            return destObject;// _CategoryMapper.MapCategoryToCategoriesDTO(ListOfData);
        }

    


    }
}
