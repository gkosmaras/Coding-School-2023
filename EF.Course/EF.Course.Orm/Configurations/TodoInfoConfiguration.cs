using EF.Course.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Course.Orm.Configurations
{
    public class TodoInfoConfiguration : IEntityTypeConfiguration<TodoInfo>
    {
        public void Configure(EntityTypeBuilder<TodoInfo> builder)
        {
            builder.ToTable("TodoInfo");

            builder.HasKey(todoInfo => todoInfo.Id);

            builder.Property(todoInfo => todoInfo.Id).ValueGeneratedOnAdd();
            builder.Property(todoInfo => todoInfo.StartDate).IsRequired(true);
            builder.Property(todoInfo => todoInfo.Details).HasMaxLength(500);

            builder.HasOne(todoInfo => todoInfo.Todo)
                .WithOne(todo => todo.TodoInfo)
                .HasForeignKey<TodoInfo>(todoInfo => todoInfo.TodoId);
        }
    }
}
