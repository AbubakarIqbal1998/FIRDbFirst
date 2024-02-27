using Services.Context;
using Services.Feature.Admins.Core.DataModel;
using Services.Feature.Admins.Interface;
using Services.Shared.Generic.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Feature.Admins.Repository
{
    public class AdminRepository : Repository<Admin, FirContext>, IAdminRepository
    {
        public IDbConnection connection;
        public AdminRepository(Func<FirContext> dbFactory, IDbConnection connection) : base(dbFactory,connection)
        {

        }

        public async Task<IEnumerable<Admin>> GetAll()
        {
       var data =await SimpleQuery<Admin>("Select * from Admin");
            return data;
        }

        public async Task<Admin> GetById(int Id)
        {
            var data = await ParameterizeQueryFirst<Admin>("Select * from Admin wher Id=@ID",new {ID=Id});
            return data;
        }
    }
}

