using System;
using System.ComponentModel;
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
    /// Represents a Sequence used for the automated generation of sequence numbers.
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.Sequence")]
    [Table("entpr_Sequences")]
    [Discriminator]
    public class Sequence : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(100)]
        public virtual string SequenceName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(30)]
        public virtual string SeriesName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReadOnly(true)]
        public virtual int LastIssuedNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReadOnly(true)]
        public virtual DateTime? LastIssuedDate { get; set; }
    }
}