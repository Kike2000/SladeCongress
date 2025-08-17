using ConferenceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConferenceManagement.Infrastructure.Data.Configurations
{
    public class ConferenceConfiguration: IEntityTypeConfiguration<Conference>
    {
        public void Configure(EntityTypeBuilder<Conference> builder)
        {
            builder.ToTable("Conference", "dbo");

            builder.Property(c => c.ConferenceId)
                .HasColumnName("ConferenceID");

            builder.Property(c => c.PublicId)
                .IsRequired();

            builder.Property(c => c.Title)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(c => c.StartDate)
                .HasColumnType("datetimeoffset");

            builder.Property(c => c.EndDate)
                .HasColumnType("datetimeoffset");
        }
    }
}
