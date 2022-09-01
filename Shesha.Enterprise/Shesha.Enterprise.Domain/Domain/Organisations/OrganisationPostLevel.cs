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
    [Entity(TypeShortAlias = "Shesha.Enterprise.OrganisationPostLevel")]
    [Table("entpr_OrganisationPostLevels")]
    [Discriminator]
    public class OrganisationPostLevel : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(30)]
        public virtual string ShortName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [EntityDisplayName]
        [StringLength(100)]
        public virtual string FullName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(300)]
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? SignOffAmount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? DaysAllowedToRespond { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? RankLevel { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }
    }
}