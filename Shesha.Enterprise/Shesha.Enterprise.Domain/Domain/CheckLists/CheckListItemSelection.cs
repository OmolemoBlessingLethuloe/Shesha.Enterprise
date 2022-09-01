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
    /// Check list item selection (value selected by the user)
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.CheckListItemSelection")]
    [Table("entpr_CheckListItemSelections")]
    [Discriminator]
    public class CheckListItemSelection : FullPowerManyToManyLinkEntity
    {
        /// <summary> 
        /// Value selected by the user
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "CheckListSelectionType")]
        public virtual long? Selection { get; set; }

        /// <summary> 
        /// User comments
        /// </summary>
        [DataType(DataType.MultilineText)]
        [EntityDisplayName]
        [StringLength(int.MaxValue)]
        public virtual string Comments { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual CheckListItem CheckListItem { get; set; }
    }
}