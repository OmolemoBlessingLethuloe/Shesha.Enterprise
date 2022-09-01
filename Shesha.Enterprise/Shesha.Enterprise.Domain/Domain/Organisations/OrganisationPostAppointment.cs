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
    [Entity(TypeShortAlias = "Shesha.Enterprise.OrganisationPostAppointment")]
    [Table("entpr_OrganisationPostAppointments")]
    [Discriminator]
    public class OrganisationPostAppointment : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "AppointmentTyp")]
        public virtual long? AppointmentStatus { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? AppointmentStartDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? AppointmentEndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Comment { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual bool UserHasOpened { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual OrganisationPost OrganisationPost { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual Employee Employee { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual StoredFile StoredFile { get; set; }
    }
}