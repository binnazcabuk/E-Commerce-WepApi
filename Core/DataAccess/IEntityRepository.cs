
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


//evrensel kodları core project içinde oluşturuyoruz.
//hangi katmanda kullanacaksak hangisi ile ilişkili ise o isimde klasör oluşturup içine koyduk

namespace Core.DataAccess
{

    // (generic constraint) tekrarlayan  komutlarının önüne geçeriz generic yapıyla
    //new'lenebilir,IEntity veya implement eden nesne olmalı

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // bu kod ile çeşitli fitrelemeyeyi yapabiliriz çağırdığımız yerde örn:ürünleri kategoriye göre filtrele
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
