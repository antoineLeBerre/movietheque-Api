using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movietheque.Data.Models;

namespace Movietheque.Data.Configurations
{
    public class UserConfigurator : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("mtq_User");
            builder.HasIndex(p => new { p.Email })
                .IsUnique(true);
            builder.HasIndex(p => new { p.Login })
                .IsUnique(true);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            
            builder.Property(p => p.Login)
                .HasMaxLength(25)
                .IsRequired();
            
            builder.Property(p => p.Password)
                .HasMaxLength(75)
                .IsRequired();
            
            builder.Property(p => p.Email)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}