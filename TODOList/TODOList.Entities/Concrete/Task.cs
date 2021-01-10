using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Core.Entities;

namespace TODOList.Entities.Concrete
{
    public class Task: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ComplationDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDone { get; set; }

    }
}
