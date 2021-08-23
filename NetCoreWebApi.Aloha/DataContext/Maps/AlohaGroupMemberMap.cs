using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreWebApi.Aloha.Features.Aloha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.DataContext.Maps
{
    public class AlohaGroupMemberMap : IEntityTypeConfiguration<AlohaGroupMember>
    {
        public void Configure(EntityTypeBuilder<AlohaGroupMember> builder) 
        {
            builder.ToTable("AlohaGroupMember", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Id).IsRequired().UseIdentityColumn();
            builder.Property(q => q.MemberName).HasColumnName("MemberName").HasMaxLength(50).IsRequired();
            builder.Property(q => q.BirthDay).HasColumnName("BirthDay").IsRequired();
        }
    }
}
