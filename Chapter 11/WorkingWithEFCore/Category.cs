using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Packt.CS7
{
    public class Category
    {
        // these propertiesmap to columns in the database
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        // defines a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            // to enable developers to add products to Catergory we must
            // initialize the navigation property to an empty list
            this.Products = new List<Product>();

        }
    }
}
