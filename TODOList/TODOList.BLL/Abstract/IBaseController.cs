using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.BLL.Abstract
{
    public interface IBaseController
    {
        IList<TODOList.Entities.Concrete.Task> GetAll();

        TODOList.Entities.Concrete.Task Get(int id);
        TODOList.Entities.Concrete.Task Add(TODOList.Entities.Concrete.Task task);
        TODOList.Entities.Concrete.Task Update(TODOList.Entities.Concrete.Task task);
        void Delete(TODOList.Entities.Concrete.Task task);
    }
}
