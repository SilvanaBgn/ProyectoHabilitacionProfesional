using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class RepositorioGenerico<TEntity> where TEntity : class
    {
        internal ContextoAPP context;
        internal DbSet<TEntity> dbSet;

        /// <summary>
        /// Constructor del Repositorio Generico
        /// </summary>
        /// <param name="pContexto"></param>
        public RepositorioGenerico(ContextoAPP pContexto)
        {
            this.context = pContexto;
            this.dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Propiedad de solo lectura
        /// </summary>
        public IQueryable<TEntity> Queryable
        {
            get
            {
                return dbSet;
            }
        }

        /// <summary>
        /// Obtener Entidad por ID
        /// </summary>
        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Método genérico para buscar entidades en la base de datos
        /// </summary>
        /// <param name="pFilter">filtro de búsqueda</param>
        /// <returns>Devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> pFilter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> pOrderBy = null)
        {
            IQueryable<TEntity> query = this.Queryable;
            if (pFilter != null)
                query = query.Where(pFilter);

            if (pOrderBy != null)
                return pOrderBy(query).ToList();
            else
                return query.ToList();
            
        }

        /// <summary>
        /// Inserta entidad 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Elimina entidad a partir de un 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }


        /// <summary>
        /// Elimina entidad a partir de instancia
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Actualiza entidad
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
