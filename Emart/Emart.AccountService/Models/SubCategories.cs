using System;
using System.Collections.Generic;

namespace Emart.AccountService.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            Items = new HashSet<Items>();
        }

        public int SubCategoryId { get; set; }
        public string Subcategoryname { get; set; }
        public int? CategoryId { get; set; }
        public string BriefDetails { get; set; }
        public string Gst { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
