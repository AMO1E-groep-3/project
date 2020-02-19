using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barSysteem
{
    public class Category
    {
        public string name;
        public int id;

        public List<Product> products;
        
        /// <summary>
        /// Word opgeroepen wanneer er een nieuwe categorie word gemaakt
        /// </summary>
        public Category(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
