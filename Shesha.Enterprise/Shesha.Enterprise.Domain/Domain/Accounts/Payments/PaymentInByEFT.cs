using System;
using System.ComponentModel.DataAnnotations;
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
    [Entity(TypeShortAlias = "Shesha.Enterprise.PaymentInByEFT")]

    public class PaymentInByEFT : PaymentIn
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile ProofOfPayment { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual BankTransaction BankTransaction { get; set; }
    }
}