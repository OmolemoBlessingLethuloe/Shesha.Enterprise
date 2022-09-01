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
    [Entity(TypeShortAlias = "Shesha.Enterprise.HomeUrlAppointment")]
    [Table("entpr_HomeUrlAppointments")]
    [Discriminator]
    public class HomeUrlAppointment : FullPowerEntity
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual Guid HomeUrlId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Guid RoleId { get; set; }
    }
}