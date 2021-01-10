using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOList.UI.ViewModel
{
    public class TaskViewModel
    {
        public IList<TODOList.Entities.Concrete.Task> ListTask{ get; set; }
        public TODOList.Entities.Concrete.Task Task { get; set; }
    }
}