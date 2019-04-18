using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoriesCore
{
    public class CategoriesDTO : EntityBase
    {
        public string Name { get; set; }
        public string PictureUri { get; set; }
    }
}
