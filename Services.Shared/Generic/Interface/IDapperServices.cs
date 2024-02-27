using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Shared.Generic.Interface
{
    public interface IDapperServices
    {
        Task<IEnumerable<T>> SimpleQuery<T>(string query) where T : class;
        Task<IEnumerable<T>> ParameterizeQuery<T>(string query,object parameter) where T : class;
        Task<T> ParameterizeQueryFirst<T>(string query,object parameter) where T : class;
    }
}
