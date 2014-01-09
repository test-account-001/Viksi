namespace Viksi.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }

        public Category()
        {
            this.SubCategories = new HashSet<SubCategory>();
        }
		
    }
}