using LubyDesafio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LubyDesafio.Data.Mappings
{
    public class TimeEntryMapping : IEntityTypeConfiguration<TimeEntry>
    {
        public void Configure(EntityTypeBuilder<TimeEntry> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(n => n.DateBegin).IsRequired();
            builder.Property(a => a.DateEnd).IsRequired();
            builder.Property(x => x.TotalHours).IsRequired();

            builder.HasOne(x => x.Developer).WithMany(y => y.TimeEntries).HasForeignKey(x => x.DevelopeId);

        }
    }
}
