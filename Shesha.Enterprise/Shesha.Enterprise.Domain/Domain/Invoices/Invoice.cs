using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Shesha.Enterprise.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.Invoice")]
    [Table("entpr_Invoices")]
    [Discriminator]
    public class Invoice : FullAuditedEntityWithExternalSync<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string CellNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string TelNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string FaxNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public virtual DateTime? InvoicingPeriodStartDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public virtual DateTime? InvoicingPeriodEndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public virtual DateTime? InvoiceDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string InvoiceTitle { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string InvoiceDescription { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public virtual DateTime? DueDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string InvoiceNo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string PaymentMethod { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string PaymentTerms { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string VatNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "InvoiceStatus")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "0.00")]
        public virtual decimal? TotalExclTax { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "0.00")]
        public virtual decimal? TaxAmount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "0.00")]
        public virtual decimal? TotalInclTax { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "InvoiceType")]
        public virtual long? InvoiceType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person ContactPerson { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation IssuedBy { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation IssuedTo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Contract Contract { get; set; }
    }
}