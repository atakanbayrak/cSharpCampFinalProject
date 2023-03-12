using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Interface' den kalıtım alan manager sınıfının methodları dependency injection ile çağırması.
    // Methodların bazılarında filter expression kullanılarak filtreleme yapıldı.
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal _productDal)
        {
            this._productDal = _productDal;
        }

        public IResult Add(Product product)
        {
            //business code here
            _productDal.Add(product);
            return new Result(true,"Urün eklendi.");
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
