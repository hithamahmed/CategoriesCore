using ApplicationCore.Entities;
using CategoriesCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoriesCore
{
    public class CategoryMapper
    {

        public List<CategoriesDTO> MapCategoryToCategoriesDTO(IEnumerable<Category> entity)
        {
            List<CategoriesDTO> _Categorymap = new List<CategoriesDTO>();
            foreach (var item in entity)
            {
                _Categorymap.Add(new CategoriesDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    PictureUri = item.PictureUri,
                    Status = item.Status
                });
            }
            return _Categorymap;
        }
    }
}
