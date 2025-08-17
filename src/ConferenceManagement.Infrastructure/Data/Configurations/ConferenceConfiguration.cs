using ConferenceManagement.Domain.Conference.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Infrastructure.Data.Configurations
{
    public class ConferenceConfiguration: IEntityTypeConfiguration<Conference>
    {
        public void Configure(EntityTypeBuilder<Conference> builder)
        {
            builder.ToTable("Conference");

            builder.HasKey(x => x.ConferenceId);

            builder.Property(c => c.StartDate)
                .HasColumnType("datetimeoffset");

            builder.Property(c => c.EndDate)
                .HasColumnType("datetimeoffset");
        }
    }
}
