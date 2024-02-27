using Microsoft.EntityFrameworkCore;
using Services.Shared.Generic.Interface;
using Services.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using Dapper;
using System.Data.Common;

namespace Services.Shared.Generic.Repositories
{
    public class Repository<T, TDbContext> : DbFactory<TDbContext>, IRepository<T, TDbContext> where T : class where TDbContext : DbContext
    {
        public IDbConnection connection;
        public Repository(Func<TDbContext> dbFactory, IDbConnection connection) :base(dbFactory)
        {
            this.connection = connection;
        }
        public async Task<T> Add(T entity)
        {
            try
            {
                await DBContext.AddAsync(entity);
                await DBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            DBContext.Remove(entity);
            await DBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> ParameterizeQuery<T>(string query, object parameter) where T : class
        {
            try
            {
                var data = await connection.QueryAsync<T>(query, parameter);
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<T> ParameterizeQueryFirst<T>(string query, object parameter) where T: class
        {
            try
            {
                var data = await connection.QueryFirstAsync<T>(query, parameter);
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> SimpleQuery<T>(string query) where T : class
        {
            try
            {
                var data = await connection.QueryAsync<T>(query);
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<T> Update(T entity)
        {
            DBContext.Update(entity);
            await DBContext.SaveChangesAsync();
            return entity;
        }

        
    }
}
