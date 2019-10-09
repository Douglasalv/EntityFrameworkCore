using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);


            builder.HasMany(e => e.Evaluations)
                   .WithOne(s => s.Student)
                   .HasForeignKey(s => s.StudentId);

            builder.HasData
            (
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Age = 30
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Doe",
                    Age = 25
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Mike Miles",
                    Age = 28
                },

                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "TEST Name",
                    Age = 100
                }
            );
        }
    }
}
