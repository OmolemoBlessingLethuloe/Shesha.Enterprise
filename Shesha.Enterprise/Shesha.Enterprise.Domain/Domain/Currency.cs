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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Currency")]
    [Table("entpr_Currencies")]
    [Discriminator]
    public class Currency : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string Code { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string FullName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string Symbol { get; set; }
    }
}