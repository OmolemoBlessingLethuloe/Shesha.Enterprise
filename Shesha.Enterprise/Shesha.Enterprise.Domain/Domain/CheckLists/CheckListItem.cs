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
    /// Check list item
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.CheckListItem")]
    [Table("entpr_CheckListItems")]
    [Discriminator]
    public class CheckListItem : FullPowerEntity
    {
        /// <summary> 
        /// Order index of the item
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// Item type (group/two state/tri state)
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "CheckListItemType")]
        public virtual long? ItemType { get; set; }

        /// <summary> 
        /// Item name
        /// </summary>
        [Required]
        [StringLength(255)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// Item description
        /// </summary>
        [StringLength(int.MaxValue)]
        public virtual string Description { get; set; }

        /// <summary> 
        /// If true, the user is able to add comments to this item/group
        /// </summary>
        public virtual bool AllowAddComments { get; set; }

        /// <summary> 
        /// Heading of the comments box
        /// </summary>
        [StringLength(255)]
        public virtual string CommentsHeading { get; set; }

        /// <summary> 
        /// Custom visibility of comments (javascript expression)
        /// </summary>
        [DataType(DataType.MultilineText)]
        [StringLength(int.MaxValue)]
        public virtual string CommentsVisibilityExpression { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual CheckList CheckList { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual CheckListItem Parent { get; set; }
    }
}