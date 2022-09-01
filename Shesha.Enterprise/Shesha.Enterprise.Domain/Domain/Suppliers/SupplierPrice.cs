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
    [Entity(TypeShortAlias = "Shesha.Enterprise.SupplierPrice")]
    [Table("entpr_SupplierPrices")]
    [Discriminator]
    public class SupplierPrice : FullAuditedEntityWithExternalSync<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? Price { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Supplier Supplier { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Contract Contract { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Product Product { get; set; }
    }
}