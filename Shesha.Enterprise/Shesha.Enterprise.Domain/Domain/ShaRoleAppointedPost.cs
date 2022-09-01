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
    [Entity(TypeShortAlias = "Shesha.Enterprise.ShaRoleAppointedPost")]

    public class ShaRoleAppointedPost : ShaRoleAppointment
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual OrganisationPost OrganisationPost { get; set; }
    }
}