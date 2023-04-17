﻿using System.Linq.Expressions;

namespace SQLiteDemo.Abstractions
{
    public interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        void SaveItem(T item);

        T GetItem(int id);

        T GetItem(Expression<Func<T, bool>> predicate);

        List<T> GetItems();

        List<T> GetItems(Expression<Func<T, bool>> predicate);

        void DeleteItem(T item);
    }
}
