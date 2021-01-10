using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Core.Data.Concrete.Framework.EntityFramework;
using TODOList.Dal.Abstract;

namespace TODOList.Dal.Concrete.Framework.EntityFramework
{
    public class TaskDal:EntityRepositoryEF<TODOList.Entities.Concrete.Task,TODOListContext>,ITaskDal
    {
    }
}
