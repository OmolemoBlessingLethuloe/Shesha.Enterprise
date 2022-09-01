using System;
using System.Collections.Generic;
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
    [Entity(TypeShortAlias = "Shesha.Enterprise.CheckList")]
    [Table("entpr_CheckLists")]
    [Discriminator]
    public class CheckList : FullPowerEntity
    {
        /// <summary> 
        /// Name of the check list
        /// </summary>
        [StringLength(255)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// Description
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual IEnumerable<CheckListItem> CheckListItems { get; set; }
    }
}