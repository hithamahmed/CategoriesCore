using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoriesCore
{
    public class CategoryUriComposer : IUriComposer
    {
        private readonly CategorySettings _categorySettings;

        public CategoryUriComposer(CategorySettings categorySettings) => _categorySettings = categorySettings;

        public string  ComposePicUri(string uriTemplate)
        {
            return uriTemplate.Replace("http://categorybaseurltobereplaced", _categorySettings.CategoryBaseUrl);
        }
    }
}
