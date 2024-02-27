using Services.Context;
using Services.Feature.Admins.Core;
using Services.Feature.Admins.Core.DataModel;
using Services.Shared.Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Feature.Admins.Interface
{
    public interface IAdminRepository:IRepository<Admin,FirContext>
    {
        Task<IEnumerable<Admin>> GetAll();
        Task<Admin> GetById(int Id);
    }
}
