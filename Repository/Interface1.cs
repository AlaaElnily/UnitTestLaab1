﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
        public interface IRepositoryBase<T>
        {
            IQueryable<T> FindAll();
            T FindById(int id);
            void Create(T entity);
            void Update(T entity);
            void Delete(int id);
        }
}
