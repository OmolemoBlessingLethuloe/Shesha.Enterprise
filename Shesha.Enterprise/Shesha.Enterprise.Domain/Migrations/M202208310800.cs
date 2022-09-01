using System;
using FluentMigrator;
using Intent.RoslynWeaver.Attributes;
using Shesha.FluentMigrator;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.FluentMigrator.Migration", Version = "1.0")]

namespace Shesha.Enterprise
{
    [Migration(202208310800)]
    public class M202208310800 : Migration
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Up()
        {

            Create.Table("entpr_Currencies")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Code").AsString()
             .WithColumn("FullName").AsString()
             .WithColumn("Symbol").AsString();


            Create.Table("entpr_LogonMessageAuditItems")
             .WithIdAsGuid()
             .WithColumn("DontShowAgain").AsBoolean();


            Create.Table("entpr_LogonMessages")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Description").AsString()
             .WithColumn("Content").AsString()
             .WithColumn("PublicationStartDate").AsDateTime().Nullable()
             .WithColumn("PublicationEndDate").AsDateTime().Nullable()
             .WithColumn("VisibilityLkp").AsInt64()
             .WithColumn("IsActive").AsBoolean()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_Periods")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Name").AsString()
             .WithColumn("ShortName").AsString()
             .WithColumn("PeriodStart").AsDateTime().Nullable()
             .WithColumn("PeriodEnd").AsDateTime().Nullable()
             .WithColumn("PeriodType").AsInt32().Nullable();


            Create.Table("entpr_ShaRoleAppointedPostLevels")
             .WithIdAsGuid();


            Create.Table("entpr_ShaRoleAppointedPosts")
             .WithIdAsGuid();


            Create.Table("entpr_TaxRates")
             .WithIdAsGuid()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("Rate").AsString().Nullable();


            Create.Table("entpr_AccountTransfers")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("FromReference").AsString()
             .WithColumn("ToReference").AsString()
             .WithColumn("Amount").AsString().Nullable()
             .WithColumn("StatusLkp").AsInt64()
             .WithColumn("DateCompleted").AsDateTime().Nullable()
             .WithColumn("AdditionalInfoJson").AsString()
             .WithColumn("RejectionReasonLkp").AsInt64().Nullable()
             .WithColumn("TransferReasonLkp").AsInt64().Nullable()
             .WithColumn("TransferMethodLkp").AsInt64().Nullable()
             .WithColumn("SignedRequest").AsString();


            Create.Table("entpr_Accounts")
             .WithIdAsGuid()
             .WithFullAuditColumns();


            Create.Table("entpr_FinancialAccounts")
             .WithIdAsGuid()
             .WithColumn("Balance").AsString().Nullable()
             .WithColumn("CreditLimit").AsString().Nullable()
             .WithColumn("LastTransactionProcessedDate").AsDateTime().Nullable()
             .WithColumn("PendingBalance").AsString();


            Create.Table("entpr_FinancialTransactions")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Amount").AsString().Nullable()
             .WithColumn("TransactionDate").AsDateTime().Nullable()
             .WithColumn("RunningBalance").AsString().Nullable()
             .WithColumn("TransactionTypeLkp").AsInt64().Nullable()
             .WithColumn("Reference").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("SourceEntityId").AsGuid().Nullable()
             .WithColumn("SourceEntityType").AsString()
             .WithColumn("StatusLkp").AsInt64().Nullable()
             .WithColumn("CancellationReason").AsString();


            Create.Table("entpr_PaymentInByEFTs")
             .WithIdAsGuid();


            Create.Table("entpr_PaymentIns")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("PaymentDate").AsDateTime().Nullable()
             .WithColumn("Amount").AsString().Nullable()
             .WithColumn("PaymentMethodReference").AsString();


            Create.Table("entpr_PaymentOuts")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("PaymentDate").AsDateTime().Nullable()
             .WithColumn("Amount").AsString().Nullable()
             .WithColumn("PaymentMethodReference").AsString();


            Create.Table("entpr_PayoutOutByEFTs")
             .WithIdAsGuid();


            Create.Table("entpr_BankAccounts")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("AccountName").AsString()
             .WithColumn("BankLkp").AsInt64().Nullable()
             .WithColumn("BranchName").AsString()
             .WithColumn("BranchCode").AsString()
             .WithColumn("AccountTypeLkp").AsInt64().Nullable()
             .WithColumn("AccountNumber").AsString()
             .WithColumn("StatusLkp").AsInt64().Nullable()
             .WithColumn("CurrentBalance").AsString().Nullable();


            Create.Table("entpr_BankTransactions")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Reference").AsString()
             .WithColumn("Amount").AsString()
             .WithColumn("TransactionDate").AsDateTime()
             .WithColumn("Balance").AsString()
             .WithColumn("AllocationMechanismLkp").AsInt64().Nullable()
             .WithColumn("AllocatedDate").AsDateTime()
             .WithColumn("AllocationApprovedDate").AsDateTime()
             .WithColumn("AllocationStatusLkp").AsInt64().Nullable()
             .WithColumn("AllocationRejectedComments").AsString()
             .WithColumn("Comments").AsString()
             .WithColumn("TransactionTypeLkp").AsInt64().Nullable();


            Create.Table("entpr_CheckListItemSelections")
             .WithIdAsGuid()
             .WithColumn("SelectionLkp").AsInt64().Nullable()
             .WithColumn("Comments").AsString();


            Create.Table("entpr_CheckListItems")
             .WithIdAsGuid()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("ItemTypeLkp").AsInt64().Nullable()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("AllowAddComments").AsBoolean()
             .WithColumn("CommentsHeading").AsString()
             .WithColumn("CommentsVisibilityExpression").AsString();


            Create.Table("entpr_CheckListTreeItems")
             .WithIdAsGuid()
             .WithColumn("Name").AsString()
             .WithColumn("ParentId").AsGuid().Nullable()
             .WithColumn("HasChilds").AsBoolean()
             .WithColumn("OrderIndex").AsInt32()
             .WithColumn("TenantId").AsInt32().Nullable()
             .WithColumn("CheckListId").AsGuid()
             .WithColumn("CreationTime").AsDateTime();


            Create.Table("entpr_CheckLists")
             .WithIdAsGuid()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString();


            Create.Table("entpr_Contracts")
             .WithIdAsGuid()
             .WithColumn("ContractName").AsString()
             .WithColumn("ContractDescription").AsString()
             .WithColumn("ContractStartDate").AsDateTime().Nullable()
             .WithColumn("ContractEndDate").AsDateTime().Nullable()
             .WithColumn("StatusLkp").AsInt64().Nullable()
             .WithColumn("ContractValue").AsString().Nullable()
             .WithColumn("InvoicedToDate").AsString().Nullable()
             .WithColumn("PrimaryContactEmail").AsString()
             .WithColumn("PrimaryContactTelephone").AsString()
             .WithColumn("ContractNumber").AsString();


            Create.Table("entpr_DistributionListItems")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Name").AsString()
             .WithColumn("Email").AsString()
             .WithColumn("CC").AsString()
             .WithColumn("MobileNo").AsString()
             .WithColumn("TypeLkp").AsInt64()
             .WithColumn("SubTypeLkp").AsInt64().Nullable()
             .WithColumn("NotifyByEmail").AsBoolean()
             .WithColumn("NotifyBySms").AsBoolean()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_DistributionLists")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Name").AsString()
             .WithColumn("Namespace").AsString()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_Employees")
             .WithIdAsGuid()
             .WithColumn("DetailsValidated").AsBoolean()
             .WithColumn("EmployeeNo").AsString()
             .WithColumn("SecurityClearanceEndDate").AsDateTime().Nullable()
             .WithColumn("OfficeRoomNo").AsString()
             .WithColumn("HasNoComputer").AsBoolean()
             .WithColumn("IsShiftWorker").AsBoolean()
             .WithColumn("SecurityClearanceLkp").AsInt64().Nullable()
             .WithColumn("SignatureTypeLkp").AsInt64();


            Create.Table("entpr_HomeUrlAppointments")
             .WithIdAsGuid()
             .WithColumn("HomeUrlId").AsGuid()
             .WithColumn("RoleId").AsGuid();


            Create.Table("entpr_HomeUrlRoutes")
             .WithIdAsGuid()
             .WithColumn("Roles").AsString()
             .WithColumn("HomeUrl").AsString()
             .WithColumn("OrderIndex").AsInt32();


            Create.Table("entpr_InvoiceLineItems")
             .WithIdAsGuid()
             .WithColumn("ItemName").AsString()
             .WithColumn("ItemDescription").AsString()
             .WithColumn("Quantity").AsInt32().Nullable()
             .WithColumn("UnitOfMeasure").AsString()
             .WithColumn("UnitPrice").AsString().Nullable()
             .WithColumn("LineItemSubTotal").AsString().Nullable()
             .WithColumn("LineItemSubTotalInclTax").AsString().Nullable()
             .WithColumn("LineItemTaxAmount").AsString().Nullable();


            Create.Table("entpr_Invoices")
             .WithIdAsGuid()
             .WithColumn("CellNumber").AsString()
             .WithColumn("TelNumber").AsString()
             .WithColumn("FaxNumber").AsString()
             .WithColumn("InvoicingPeriodStartDate").AsDateTime().Nullable()
             .WithColumn("InvoicingPeriodEndDate").AsDateTime().Nullable()
             .WithColumn("InvoiceDate").AsDateTime().Nullable()
             .WithColumn("InvoiceTitle").AsString()
             .WithColumn("InvoiceDescription").AsString()
             .WithColumn("DueDate").AsDateTime().Nullable()
             .WithColumn("InvoiceNo").AsString()
             .WithColumn("PaymentMethod").AsString()
             .WithColumn("PaymentTerms").AsString()
             .WithColumn("VatNumber").AsString()
             .WithColumn("StatusLkp").AsInt64().Nullable()
             .WithColumn("TotalExclTax").AsString().Nullable()
             .WithColumn("TaxAmount").AsString().Nullable()
             .WithColumn("TotalInclTax").AsString().Nullable()
             .WithColumn("InvoiceTypeLkp").AsInt64().Nullable();


            Create.Table("entpr_Orders")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("RequisitionNo").AsString()
             .WithColumn("RefNo").AsString()
             .WithColumn("RequestedCollectionDate").AsDateTime().Nullable()
             .WithColumn("ConfirmedCollectionDate").AsDateTime().Nullable()
             .WithColumn("Comment").AsString()
             .WithColumn("StatusLkp").AsInt64();


            Create.Table("entpr_OrganisationBankAccounts")
             .WithIdAsGuid()
             .WithColumn("Role").AsInt32().Nullable();


            Create.Table("entpr_OrganisationPostAppointments")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("AppointmentStatusLkp").AsInt64()
             .WithColumn("AppointmentStartDate").AsDateTime().Nullable()
             .WithColumn("AppointmentEndDate").AsDateTime().Nullable()
             .WithColumn("Comment").AsString()
             .WithColumn("UserHasOpened").AsBoolean()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_OrganisationPostLevels")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("ShortName").AsString()
             .WithColumn("FullName").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("SignOffAmount").AsString().Nullable()
             .WithColumn("DaysAllowedToRespond").AsInt32().Nullable()
             .WithColumn("RankLevel").AsInt32().Nullable()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_OrganisationPosts")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("Name").AsString()
             .WithColumn("ShortName").AsString()
             .WithColumn("PostDiscriminator").AsString()
             .WithColumn("IsUnitSupervisor").AsBoolean()
             .WithColumn("TenantId").AsInt32().Nullable();


            Create.Table("entpr_Products")
             .WithIdAsGuid()
             .WithColumn("Name").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("ProductCode").AsString()
             .WithColumn("DefaultUnitOfMeasure").AsString()
             .WithColumn("ProductTypeLkp").AsInt64().Nullable()
             .WithColumn("ProductSubTypeLkp").AsInt64().Nullable()
             .WithColumn("WorkDoneLkp").AsInt64().Nullable();


            Create.Table("entpr_PublicHolidays")
             .WithIdAsGuid()
             .WithFullAuditColumns();


            Create.Table("entpr_Sequences")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("SequenceName").AsString()
             .WithColumn("SeriesName").AsString()
             .WithColumn("LastIssuedNumber").AsInt32()
             .WithColumn("LastIssuedDate").AsDateTime().Nullable();


            Create.Table("entpr_Services")
             .WithIdAsGuid()
             .WithFullAuditColumns()
             .WithColumn("ServiceName").AsString()
             .WithColumn("Description").AsString()
             .WithColumn("Comments").AsString()
             .WithColumn("TenantId").AsInt32().Nullable()
             .WithColumn("ServiceCategory").AsInt32().Nullable();


            Create.Table("entpr_SupplierPrices")
             .WithIdAsGuid()
             .WithColumn("Price").AsString().Nullable()
             .WithColumn("Name").AsString();


            Create.Table("entpr_Suppliers")
             .WithIdAsGuid()
             .WithColumn("SupplierNo").AsString()
             .WithColumn("SupplierStatusLkp").AsInt64().Nullable();


            Alter.Table("entpr_LogonMessageAuditItems").AddForeignKeyColumn("LogonMessageId", "entpr_LogonMessages");

            Alter.Table("entpr_LogonMessageAuditItems").AddForeignKeyColumn("PersonId", "Core_Persons");

            Alter.Table("entpr_LogonMessages").AddForeignKeyColumn("DistributionListId", "entpr_DistributionLists");

            Alter.Table("entpr_Periods").AddForeignKeyColumn("ParentPeriodId", "entpr_Periods");

            Alter.Table("entpr_ShaRoleAppointedPostLevels").AddForeignKeyColumn("OrganisationPostLevelId", "entpr_OrganisationPostLevels");

            Alter.Table("entpr_ShaRoleAppointedPosts").AddForeignKeyColumn("OrganisationPostId", "entpr_OrganisationPosts");

            Alter.Table("entpr_AccountTransfers").AddForeignKeyColumn("FromAccountEntityId", "entpr_FinancialAccounts");

            Alter.Table("entpr_AccountTransfers").AddForeignKeyColumn("ToAccountId", "entpr_FinancialAccounts");

            Alter.Table("entpr_FinancialAccounts").AddForeignKeyColumn("CurrencyId", "entpr_Currencies");

            Alter.Table("entpr_FinancialTransactions").AddForeignKeyColumn("AccountId", "entpr_FinancialAccounts");

            Alter.Table("entpr_PaymentInByEFTs").AddForeignKeyColumn("ProofOfPaymentId", "Core_StoredFiles");

            Alter.Table("entpr_PaymentInByEFTs").AddForeignKeyColumn("BankTransactionId", "entpr_BankTransactions");

            Alter.Table("entpr_PaymentIns").AddForeignKeyColumn("AccountId", "entpr_FinancialAccounts");

            Alter.Table("entpr_PaymentOuts").AddForeignKeyColumn("AccountId", "entpr_FinancialAccounts");

            Alter.Table("entpr_PayoutOutByEFTs").AddForeignKeyColumn("BankTransactionId", "entpr_BankTransactions");

            Alter.Table("entpr_BankAccounts").AddForeignKeyColumn("OwnerPersonId", "Core_Persons");

            Alter.Table("entpr_BankAccounts").AddForeignKeyColumn("OwnerOrganisationId", "Core_Organisations");

            Alter.Table("entpr_BankAccounts").AddForeignKeyColumn("CurrencyId", "entpr_Currencies");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("BankAccountId", "entpr_BankAccounts");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("AllocatedById", "Core_Persons");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("AllocationApprovedById", "Core_Persons");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("AllocatedPersonId", "Core_Persons");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("AllocatedOrganisationId", "Core_Organisations");

            Alter.Table("entpr_BankTransactions").AddForeignKeyColumn("AllocatedAccountId", "entpr_FinancialAccounts");

            Alter.Table("entpr_CheckListItemSelections").AddForeignKeyColumn("CheckListItemId", "entpr_CheckListItems");

            Alter.Table("entpr_CheckListItems").AddForeignKeyColumn("CheckListId", "entpr_CheckLists");

            Alter.Table("entpr_CheckListItems").AddForeignKeyColumn("ParentId", "entpr_CheckListItems");

            Alter.Table("entpr_Contracts").AddForeignKeyColumn("SupplierId", "entpr_Suppliers");

            Alter.Table("entpr_DistributionListItems").AddForeignKeyColumn("DistributionListId", "entpr_DistributionLists");

            Alter.Table("entpr_DistributionListItems").AddForeignKeyColumn("PersonId", "entpr_Employees");

            Alter.Table("entpr_DistributionListItems").AddForeignKeyColumn("PostId", "entpr_OrganisationPosts");

            Alter.Table("entpr_DistributionListItems").AddForeignKeyColumn("ShaRoleId", "Core_ShaRoles");

            Alter.Table("entpr_DistributionListItems").AddForeignKeyColumn("PostLevelId", "entpr_OrganisationPostLevels");

            Alter.Table("entpr_Employees").AddForeignKeyColumn("OfficeLocationId", "Core_Areas");

            Alter.Table("entpr_HomeUrlRoutes").AddForeignKeyColumn("AppId", "Core_FrontEndApps");

            Alter.Table("entpr_InvoiceLineItems").AddForeignKeyColumn("InvoiceId", "entpr_Invoices");

            Alter.Table("entpr_InvoiceLineItems").AddForeignKeyColumn("ProductId", "entpr_Products");

            Alter.Table("entpr_Invoices").AddForeignKeyColumn("ContactPersonId", "Core_Persons");

            Alter.Table("entpr_Invoices").AddForeignKeyColumn("IssuedById", "Core_Organisations");

            Alter.Table("entpr_Invoices").AddForeignKeyColumn("IssuedToId", "Core_Organisations");

            Alter.Table("entpr_Invoices").AddForeignKeyColumn("ContractId", "entpr_Contracts");

            Alter.Table("entpr_Orders").AddForeignKeyColumn("RequesterId", "Core_Persons");

            Alter.Table("entpr_Orders").AddForeignKeyColumn("ReceiverId", "Core_Persons");

            Alter.Table("entpr_OrganisationBankAccounts").AddForeignKeyColumn("OrganisationId", "Core_Organisations");

            Alter.Table("entpr_OrganisationBankAccounts").AddForeignKeyColumn("BankAccountId", "entpr_BankAccounts");

            Alter.Table("entpr_OrganisationPostAppointments").AddForeignKeyColumn("OrganisationPostId", "entpr_OrganisationPosts");

            Alter.Table("entpr_OrganisationPostAppointments").AddForeignKeyColumn("EmployeeId", "entpr_Employees");

            Alter.Table("entpr_OrganisationPostAppointments").AddForeignKeyColumn("StoredFileId", "Core_StoredFiles");

            Alter.Table("entpr_OrganisationPosts").AddForeignKeyColumn("OrganisationPostLevelId", "entpr_OrganisationPostLevels");

            Alter.Table("entpr_OrganisationPosts").AddForeignKeyColumn("OrganisationUnitId", "Core_OrganisationUnits");

            Alter.Table("entpr_OrganisationPosts").AddForeignKeyColumn("SupervisorPostId", "entpr_OrganisationPosts");

            Alter.Table("entpr_Products").AddForeignKeyColumn("DefaultTaxRateId", "entpr_TaxRates");

            Alter.Table("entpr_SupplierPrices").AddForeignKeyColumn("SupplierId", "entpr_Suppliers");

            Alter.Table("entpr_SupplierPrices").AddForeignKeyColumn("ContractId", "entpr_Contracts");

            Alter.Table("entpr_SupplierPrices").AddForeignKeyColumn("ProductId", "entpr_Products");

        }

        /// <summary>
        /// 
        /// </summary>
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}