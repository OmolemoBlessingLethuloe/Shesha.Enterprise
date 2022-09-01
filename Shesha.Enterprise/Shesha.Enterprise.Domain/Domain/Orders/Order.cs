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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Order")]
    [Table("entpr_Orders")]
    [Discriminator]
    public class Order : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string RequisitionNo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string RefNo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? RequestedCollectionDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? ConfirmedCollectionDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Comment { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "OrderStatu")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Requester { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Receiver { get; set; }
    }
}