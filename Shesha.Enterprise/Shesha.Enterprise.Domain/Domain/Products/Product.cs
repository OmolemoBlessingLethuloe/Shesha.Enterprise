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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Product")]
    [Table("entpr_Products")]
    [Discriminator]
    public class Product : FullAuditedEntityWithExternalSync<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string ProductCode { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string DefaultUnitOfMeasure { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "ProductType")]
        public virtual long? ProductType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "ProductSubType")]
        public virtual long? ProductSubType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "WorkOrderWorkDone")]
        public virtual long? WorkDone { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual TaxRate DefaultTaxRate { get; set; }
    }
}