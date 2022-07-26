﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NovyGorod.Domain.Models.Common;

namespace NovyGorod.Infrastructure.ModelConfigs.Configs;

public class LanguageConfig : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ApplyBaseEntityConfig();
        builder.Property(x => x.Code).IsRequired();
        builder.HasIndex(x => x.Code).IsUnique();
    }
}