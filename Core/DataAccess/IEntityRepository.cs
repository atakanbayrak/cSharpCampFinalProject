using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Interfacelerin aynı methodları tekrar etmesinden ötürü performans artışı için
    // bütün methodların ortak bir expression ifadesinde toplanması. Bu düzenlemeden sonra
    // bu ve diğer projeler için ayrım gözetmekzisin hazır bir template core repository' miz mevcut.

    //Generic Constraint -> Entity Repository içerisindeki T'yi filtreleyip sınırlandırma
    // Generic Repository Design Pattern <T>
    // class : referans tip olabilir.
    // new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        // Category Id ye göre veya vb expressionlar için genel bir method yazma tekniği.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
