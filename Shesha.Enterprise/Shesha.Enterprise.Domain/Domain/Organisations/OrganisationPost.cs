using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Hangfire.Annotations;
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
    [Entity(TypeShortAlias = "Shesha.Enterprise.OrganisationPost")]
    [Table("entpr_OrganisationPosts")]
    [Discriminator]
    public class OrganisationPost : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [EntityDisplayName]
        [StringLength(100)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string ShortName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string PostDiscriminator { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "Yes|No")]
        public virtual bool IsUnitSupervisor { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [CanBeNull]
        public virtual OrganisationPostLevel OrganisationPostLevel { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual OrganisationUnit OrganisationUnit { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual OrganisationPost SupervisorPost { get; set; }
    }
}