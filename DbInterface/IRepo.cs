using OrakUtilDotNetFrm.DataContainer;
using System.Collections.Generic;

namespace OrakYazilimLib.DbInterface
{
    public interface IRepo<T> where T : class, IEntity, new()
    {
        Fdr<List<T>> GetAll();
        Fdr<T> Get(int id);
        Fdr<int> Delete(int id);
        Fdr<int> Add(T entity);
        Fdr<int> Update(T entity);
    }
}