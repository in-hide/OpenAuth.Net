﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;
using OpenAuth.Domain;

namespace OpenAuth.Repository.Models.Mapping
{
    public partial class ApplyTransitionHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ApplyTransitionHistory>
    {
        public ApplyTransitionHistoryMap()
        {
            // table
            ToTable("ApplyTransitionHistory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .IsRequired();
            Property(t => t.ApplyId)
                .HasColumnName("ApplyId")
                .IsRequired();
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .IsOptional();
            Property(t => t.AllowedToUserNames)
                .HasColumnName("AllowedToUserNames")
                .IsRequired();
            Property(t => t.TransitionTime)
                .HasColumnName("TransitionTime")
                .IsOptional();
            Property(t => t.Order)
                .HasColumnName("Order")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.InitialState)
                .HasColumnName("InitialState")
                .HasMaxLength(1024)
                .IsRequired();
            Property(t => t.DestinationState)
                .HasColumnName("DestinationState")
                .HasMaxLength(1024)
                .IsRequired();
            Property(t => t.Command)
                .HasColumnName("Command")
                .HasMaxLength(1024)
                .IsRequired();

            // Relationships
        }
    }
}