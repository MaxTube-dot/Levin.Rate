using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Levin.Rate.Models.Repository
{
    interface IRepository<T> : IDisposable
         where T : class
    {
        IEnumerable<T> GetValuteList(); // получение всех объектов
        T GetValute(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}
