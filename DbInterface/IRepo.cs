using OrakUtilDotNetFrm.FiContainer;
using System.Collections.Generic;

namespace OrakYazilimLib.DbInterface
{
    public interface IRepo<T> where T : class, IEntity, new()
    {
        FdrGen<List<T>> GetAll();
        FdrGen<T> Get(int id);
        FdrGen<int> Delete(int id);
        FdrGen<int> Add(T entity);
        FdrGen<int> Update(T entity);
    }
}