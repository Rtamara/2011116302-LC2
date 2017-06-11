using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //CREATES
        void Add(TEntity entity);
        //Agrega un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void AddRange(IEnumerable<TEntity> entities);

        //READS
        TEntity Get(int? Id);
        //Obtiene todos los registros de la tabla TEntity
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


        //DELETES
        //Elimina un registro al repositorio (SQL Server) a la tabla TEntity
        void Delete(TEntity entity);
        //Elimina un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
