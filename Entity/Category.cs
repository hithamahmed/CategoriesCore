using ApplicationCore.Entities;
using CataloguesCore.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CategoriesCore.Entity
{
    public class Category : EntityBase
    {
        //Application Categories by catalogue
        //public Category()
        //{
        //    ProviderCategories = new HashSet<ProvidersCategory>();
        //}
        public int CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
        public int? ParentcategoryId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string PictureUri { get; set; }


        //public ICollection<ProvidersCategory> ProviderCategories { get; set; }

    }
}
