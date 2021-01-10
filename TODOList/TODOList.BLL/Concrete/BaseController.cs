using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.BLL.Abstract;
using TODOList.Dal.Abstract;
using TODOList.Entities.Concrete;

namespace TODOList.BLL.Concrete
{
    public class BaseController : IBaseController
    {
        public readonly ITaskDal _taskDal;
        public BaseController(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public Entities.Concrete.Task Add(Entities.Concrete.Task task)
        {
            _taskDal.Add(task);
            return task;
        }

        public void Delete(Entities.Concrete.Task task)
        {
            _taskDal.Delete(task);
        }

        public Entities.Concrete.Task Get(int id)
        {
            return _taskDal.Get(x => x.Id == id);
        }

        public IList<Entities.Concrete.Task> GetAll()
        {
            return _taskDal.GetAll(x => x.IsDeleted != true);
        }

        public Entities.Concrete.Task Update(Entities.Concrete.Task task)
        {
            _taskDal.Update(task);
            return task;
        }
    }
}
