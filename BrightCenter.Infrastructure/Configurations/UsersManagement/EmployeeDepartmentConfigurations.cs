﻿using BrightCenter.Domain.Entities.UsersManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightCenter.Infrastructure.Configurations.UsersManagement
{
    public class EmployeeDepartmentConfigurations :
        IEntityTypeConfiguration<EmployeeDepartment>
    {
        public void Configure(EntityTypeBuilder<EmployeeDepartment> builder)
        {
            builder.HasKey(ed => ed.EmployeeDepartmentId);

            builder.Property(ed => ed.EmployeeDepartmentId)
                    .ValueGeneratedOnAdd();

            builder.Property(ed => ed.AppointmentDecisionUrl)
                    .IsRequired()
                    .HasMaxLength(255);


            builder.Property(ed => ed.StartDate)
                    .IsRequired();

            builder.Property(ed => ed.EndDate)
                    .IsRequired(false);

            builder.Property(ed => ed.IsActive)
                    .HasDefaultValueSql("1");

            builder.HasOne(ed => ed.Employee)
                    .WithMany()
                    .HasForeignKey(ed => ed.EmployeeId)
                    .IsRequired();

            builder.HasOne(ed => ed.Department)
                    .WithMany()
                    .HasForeignKey(ed => ed.DepartmentId)
                    .IsRequired();
        }
    }
}
