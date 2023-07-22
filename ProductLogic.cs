using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogleash;
        private Dictionary<string, CatFood> _catfood;
        public ProductLogic()
        {
            _products = new List<Product>();
            _dogleash = new Dictionary<string, DogLeash>();
            _catfood = new Dictionary<string, CatFood>();
        }


        public void AddProduct(Product product) 
        {
            if (product is DogLeash)
            {
                _dogleash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood) 
            {
                _catfood.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
            
        }
        List<Product> GetAllProducts() 
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        { 
            return _dogleash[name];
        }












    }
}


