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
    [Entity(TypeShortAlias = "Shesha.Enterprise.FinancialAccount")]

    public class FinancialAccount : Account
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual decimal? Balance { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? CreditLimit { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? LastTransactionProcessedDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal PendingBalance { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual Currency Currency { get; set; }
    }
}