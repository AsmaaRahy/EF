using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Model
{
    internal class TaskEntityEntityTypeConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.Property(e => e.Date).IsRequired();

            builder.ToTable("NewTask");

            builder.Property(e => e.Date).HasColumnName("Deadline");

        }
    }
}
