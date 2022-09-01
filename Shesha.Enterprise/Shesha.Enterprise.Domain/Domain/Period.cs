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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Period")]
    [Table("entpr_Periods")]
    [Discriminator]
    public class Period : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(1000)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string ShortName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? PeriodStart { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? PeriodEnd { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? PeriodType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Period ParentPeriod { get; set; }
    }
}