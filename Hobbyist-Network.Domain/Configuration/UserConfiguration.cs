﻿using Hobbyist_Network.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hobbyist_Network.Domain.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Hobbies)
                   .WithOne(h => h.User)
                   .HasForeignKey(h => h.UserId);

            builder.HasMany(u => u.OrganisedEvents)
                   .WithOne(e => e.Organiser)
                   .HasForeignKey(e => e.OrganiserId);

            builder.HasMany(u => u.Contacts)
                   .WithOne(c => c.User1)
                   .HasForeignKey(c => c.User1Id);

            builder.HasMany(u => u.Contacts)
                   .WithOne(c => c.User2)
                   .HasForeignKey(c => c.User2Id);

            builder.Metadata.FindNavigation(nameof(User.Hobbies))
                   .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Metadata.FindNavigation(nameof(User.OrganisedEvents))
                   .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Metadata.FindNavigation(nameof(User.Contacts))
                   .SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
