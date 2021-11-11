using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSI_WEB_APP.Network.Interfaces
{
    public interface IBase<TEntity> where TEntity : class
    {
        List<TEntity> get();
        TEntity get(Object id);
        void insert(TEntity T);
        void update(TEntity T);
        void delete(TEntity T);
        void delete(Object id);
    }
}
