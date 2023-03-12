using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // İş katmanında kullanıcıya gösterilecek olan sonuçların doğru bir şekilde gelmesi için kullanılacak
    // methodların tanımlanması.
    public interface IProductService
    {
        // IDataResult yapısı ile dönüşlerimizi tek bir generic yapı altına topladık.
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
    
    }
}
