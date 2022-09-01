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
    [Entity(TypeShortAlias = "Shesha.Enterprise.DistributionListItem")]
    [Table("entpr_DistributionListItems")]
    [Discriminator]
    public class DistributionListItem : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(255)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(255)]
        public virtual string Email { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(255)]
        public virtual string CC { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(20)]
        public virtual string MobileNo { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual RefListDistributionItemType Type { get; set; } = RefListDistributionItemType.System;

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "DistributionItemSubType")]
        public virtual long? SubType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool NotifyByEmail { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool NotifyBySms { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DistributionList DistributionList { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Employee Person { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual OrganisationPost Post { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual ShaRole ShaRole { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual OrganisationPostLevel PostLevel { get; set; }
    }
}