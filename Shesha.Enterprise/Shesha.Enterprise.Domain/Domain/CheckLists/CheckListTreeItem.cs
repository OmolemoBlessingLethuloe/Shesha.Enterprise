using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Shesha.Enterprise.Domain
{
    /// <summary>
    /// Check list tree item
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.CheckListTreeItem")]
    [Table("entpr_CheckListTreeItems")]
    [Discriminator]
    public class CheckListTreeItem : Entity<Guid>
    {
        /// <summary> 
        /// Name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary> 
        /// Parent item Id
        /// </summary>
        public virtual Guid? ParentId { get; set; }

        /// <summary> 
        /// If true, indicates that item has child items
        /// </summary>
        public virtual bool HasChilds { get; set; }

        /// <summary> 
        /// Order Index
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// Tenant Id
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// Check list Id
        /// </summary>
        public virtual Guid CheckListId { get; set; }

        /// <summary> 
        /// Creation time
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
    }
}