using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using Shesha.Domain.Enums;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Shesha.Enterprise.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.LogonMessage")]
    [Table("entpr_LogonMessages")]
    [Discriminator]
    public class LogonMessage : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        [StringLength(500)]
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DataType(DataType.Html)]
        [Required]
        public virtual string Content { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual DateTime? PublicationStartDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual DateTime? PublicationEndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual RefListLogonMessageVisibility Visibility { get; set; } = RefListLogonMessageVisibility.AllUsers;

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool IsActive { get; set; } = true;

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DistributionList DistributionList { get; set; }
    }
}