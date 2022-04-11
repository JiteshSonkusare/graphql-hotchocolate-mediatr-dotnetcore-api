using System;
using System.Collections.Generic;

#nullable disable

namespace Workspace.Addressbook.GraphQLApi.Domain
{
    public partial class SimplyHr
    {
        public int Id { get; set; }
        public string RecordType { get; set; }
        public string RecordMetadata { get; set; }
        public string AssociateId { get; set; }
        public string PrimaryLogonId { get; set; }
        public string AssociateHrnum { get; set; }
        public string SourceAssociateId { get; set; }
        public string PayrollNum { get; set; }
        public string AssociateGivenName { get; set; }
        public string AssociateMiddleName { get; set; }
        public string AssociateFamilyName { get; set; }
        public string AssociateStartDttm { get; set; }
        public string AssociateEndDttm { get; set; }
        public string WorkEmailAddressTxt { get; set; }
        public string MobileTelephoneNum { get; set; }
        public string MobileTelephoneCountryCodeNum { get; set; }
        public string GroupLegalEntityCd { get; set; }
        public string GroupEntityName { get; set; }
        public string AssociateRelationshipStartDttm { get; set; }
        public string AssociateRelationshipAccessTerminationDttm { get; set; }
        public string AssociateRelationshipEndDttm { get; set; }
        public string EmploymentDt { get; set; }
        public string TerminationDt { get; set; }
        public string AssociateRelationshipTypeCd { get; set; }
        public string AssociateRelationshipPct { get; set; }
        public string AssociateRelationshipSubTypeCd { get; set; }
        public string ConsultantVendorName { get; set; }
        public string ConsultantHourlyRateAmtOc { get; set; }
        public string AssociateOrganizationPositionStartDttm { get; set; }
        public string AssociateOrganizationPositionEndDttm { get; set; }
        public string AssociateOrganizationPositionPct { get; set; }
        public string OrganizationPositionName { get; set; }
        public string OrganizationPositionCategoryCd { get; set; }
        public string OrganizationPositionCategoryName { get; set; }
        public string OrganizationPositionFamilyCd { get; set; }
        public string OrganizationPositionFamilyName { get; set; }
        public string JobTitle { get; set; }
        public string ManagerAssociateId { get; set; }
        public string ManagerAssociatePrimaryLogonId { get; set; }
        public string ManagerAssociateHrnum { get; set; }
        public string ManagerAssociateSourceAssociateId { get; set; }
        public string ManagerAssociatePayrollNum { get; set; }
        public string InternalAccountingUnitCd { get; set; }
        public string OperationalInternalOrganizationUnitCd { get; set; }
        public string SiteCd { get; set; }
        public string SiteName { get; set; }
        public string SiteAddressLine1 { get; set; }
        public string SiteAddressLine2 { get; set; }
        public string SitePostalCd { get; set; }
        public string SitePostalCodeName { get; set; }
        public string SubSiteCd { get; set; }
    }
}
