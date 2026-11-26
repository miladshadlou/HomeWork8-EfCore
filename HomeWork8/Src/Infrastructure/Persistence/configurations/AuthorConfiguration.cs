using HomeWork8.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace HomeWork8.Infrastructure.Persistence.configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        // تنظیمات نام نویسنده
        builder.Property(a => a.FullName)
            .IsRequired()
            .HasMaxLength(100);

        // تنظیمات بیوگرافی نویسنده
        builder.Property(a => a.Biography)
            .IsRequired()
            .HasMaxLength(1000);

    }
}
