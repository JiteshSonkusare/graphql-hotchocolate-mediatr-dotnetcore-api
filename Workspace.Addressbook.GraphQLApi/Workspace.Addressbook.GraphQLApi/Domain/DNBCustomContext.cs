using System;
using Microsoft.EntityFrameworkCore;

namespace Workspace.Addressbook.GraphQLApi.Domain
{
    public partial class DNBCustomContext : DbContext
    {
        public DNBCustomContext()
        {
        }

        public DNBCustomContext(DbContextOptions<DNBCustomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SimplyHr> SimplyHrs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SimplyHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SimplyHR");

                entity.Property(e => e.AssociateEndDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateFamilyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateGivenName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateHrnum)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AssociateHRNum");

                entity.Property(e => e.AssociateId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateMiddleName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateOrganizationPositionEndDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateOrganizationPositionPct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateOrganizationPositionStartDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipAccessTerminationDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipEndDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipPct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipStartDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipSubTypeCd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateRelationshipTypeCd)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AssociateStartDttm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsultantHourlyRateAmtOc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsultantVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentDt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupEntityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupLegalEntityCd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InternalAccountingUnitCd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(135)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerAssociateHrnum)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ManagerAssociateHRNum");

                entity.Property(e => e.ManagerAssociateId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerAssociatePayrollNum)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerAssociatePrimaryLogonId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerAssociateSourceAssociateId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileTelephoneCountryCodeNum)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MobileTelephoneNum)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OperationalInternalOrganizationUnitCd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPositionCategoryCd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPositionCategoryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPositionFamilyCd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPositionFamilyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPositionName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollNum)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryLogonId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecordMetadata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SiteAddressLine1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteAddressLine2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteCd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SitePostalCd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SitePostalCodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAssociateId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSiteCd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkEmailAddressTxt)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
