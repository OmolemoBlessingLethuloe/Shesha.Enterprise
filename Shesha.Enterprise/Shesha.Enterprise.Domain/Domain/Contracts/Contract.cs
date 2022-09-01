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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Contract")]
    [Table("entpr_Contracts")]
    [Discriminator]
    public class Contract : FullAuditedEntityWithExternalSync<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string ContractName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string ContractDescription { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? ContractStartDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? ContractEndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "ContractStatus")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? ContractValue { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? InvoicedToDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string PrimaryContactEmail { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string PrimaryContactTelephone { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string ContractNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Supplier Supplier { get; set; }
    }
}