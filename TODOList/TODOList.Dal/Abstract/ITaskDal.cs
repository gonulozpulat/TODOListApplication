using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Core.Data.Abstract;

namespace TODOList.Dal.Abstract
{
    public interface ITaskDal:IEntityRepository<TODOList.Entities.Concrete.Task>
    {
    }
}
