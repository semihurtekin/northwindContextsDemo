using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilitiess;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        IProductDal _productDal;
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByName(string productName)
        {
            if (String.IsNullOrEmpty(productName))
            {
                return _productDal.GetAll();
            }
            else 
            {
                return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
            }
            
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);   
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product); 
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
