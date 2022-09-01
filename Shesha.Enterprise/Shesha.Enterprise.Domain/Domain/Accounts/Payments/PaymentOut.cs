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
    [Entity(TypeShortAlias = "Shesha.Enterprise.PaymentOut")]
    [Table("entpr_PaymentOuts")]
    [Discriminator]
    public class PaymentOut : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? PaymentDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? Amount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string PaymentMethodReference { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual FinancialAccount Account { get; set; }
    }
}