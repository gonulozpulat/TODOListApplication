using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Dal.Concrete.Framework.EntityFramework.FluentMapping
{
    public class MapTask : EntityTypeConfiguration<TODOList.Entities.Concrete.Task>
    {
        public MapTask()
        {
            ToTable("Tasks", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Title).HasColumnName("Title").HasMaxLength(100);
            Property(x => x.Description).HasColumnName("Description").HasMaxLength(500);
            Property(x => x.EndTime).HasColumnName("EndTime");
            Property(x => x.StartDate).HasColumnName("StartDate");
            Property(x => x.EndDate).HasColumnName("EndDate");
            Property(x => x.ComplationDate).HasColumnName("ComplationDate");
            Property(x => x.IsDone).HasColumnName("IsDone");
            Property(x => x.IsDeleted).HasColumnName("IsDeleted");

        }
    }
}
