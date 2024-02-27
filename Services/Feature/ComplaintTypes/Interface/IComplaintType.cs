using Services.Context;
using Services.Feature.ComplaintTypes.Core.DataModel;
using Services.Shared.Generic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Feature.ComplaintTypes.Interface
{
    internal interface IComplaintType:IDapperServices<ComplaintType>,IRepository<ComplaintType,FirContext>
    {

    }
}
