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
    [Entity(TypeShortAlias = "Shesha.Enterprise.LogonMessageAuditItem")]
    [Table("entpr_LogonMessageAuditItems")]
    [Discriminator]
    public class LogonMessageAuditItem : CreationAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual bool DontShowAgain { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual LogonMessage LogonMessage { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person Person { get; set; }
    }
}