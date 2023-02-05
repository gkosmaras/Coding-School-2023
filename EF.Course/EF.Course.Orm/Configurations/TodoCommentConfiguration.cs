using EF.Course.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Course.Orm.Configurations
{
    public class TodoCommentConfiguration : IEntityTypeConfiguration<TodoComment>
    {
        public void Configure(EntityTypeBuilder<TodoComment> builder)
        {
            builder.ToTable("TodoComment");

            builder.HasKey(todoComment => todoComment.Id);

            builder.Property(todoComment => todoComment.Id).ValueGeneratedOnAdd();
            builder.Property(todoComment => todoComment.Text).HasMaxLength(500);

            builder.HasOne(todoComment => todoComment.Todo)
                 .WithMany(todo => todo.TodoComments)
                 .HasForeignKey(todoComment => todoComment.TodoId);
        }
    }
}
