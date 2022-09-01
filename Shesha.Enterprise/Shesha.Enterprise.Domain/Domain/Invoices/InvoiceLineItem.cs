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
    [Entity(TypeShortAlias = "Shesha.Enterprise.InvoiceLineItem")]
    [Table("entpr_InvoiceLineItems")]
    [Discriminator]
    public class InvoiceLineItem : FullAuditedEntityWithExternalSync<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string ItemName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string ItemDescription { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? Quantity { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string UnitOfMeasure { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? UnitPrice { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? LineItemSubTotal { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? LineItemSubTotalInclTax { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? LineItemTaxAmount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Invoice Invoice { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Product Product { get; set; }
    }
}