﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{//Generic Repository                          //Generic Constraint-kısıt
    public interface IEntityRepository<T> where T:class,IEntity,new()//new oluşumu olabilsin.
    {
        List<T> GetAll(Expression<Func<T,bool>>  filter=null);  

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
