using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroStore.Models
{
    public class DataRepository: IRepository
    {
        private DataContext context;
        public DataRepository(DataContext context) =>
            this.context = context;
        public IEnumerable<Product> Products => context.Products;

        public void AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
    }
}
