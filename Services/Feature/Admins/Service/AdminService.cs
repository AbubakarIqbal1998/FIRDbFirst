using Services.Feature.Admins.Core.DataModel;
using Services.Feature.Admins.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Feature.Admins.Service
{
    public class AdminService
    {
        public IAdminRepository adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public async Task PostAdmin(Admin obj)
        {
           await adminRepository.Add(obj);

        }
        public async Task PutAdmin(Admin obj)
        {
            await adminRepository.Update(obj);
        }
    }
}
