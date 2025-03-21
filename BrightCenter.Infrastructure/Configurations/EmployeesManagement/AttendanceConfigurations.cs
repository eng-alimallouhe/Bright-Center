using BrightCenter.Domain.Entities.EmployeesManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightCenter.Infrastructure.Configurations.EmployeesManagement
{
    class AttendanceConfigurations: IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(a => a.AttendanceId);

            builder.Property(a => a.AttendanceId)
                    .ValueGeneratedOnAdd();

            builder.Property(a => a.Date)
                    .IsRequired();

            builder.Property(a => a.TimeIn)
                    .IsRequired();

            builder.Property(a => a.TimeOut)
                    .IsRequired();

            builder.Property(a => a.IsActive)
                    .HasDefaultValueSql("1");

            builder.Property(a => a.IsPresent)
                    .IsRequired(false);

            builder.HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .IsRequired();
        }
    }
}
