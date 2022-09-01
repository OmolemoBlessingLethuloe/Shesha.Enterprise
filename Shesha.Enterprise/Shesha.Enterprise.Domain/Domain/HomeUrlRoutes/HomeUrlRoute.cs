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
    [Entity(TypeShortAlias = "Shesha.Enterprise.HomeUrlRoute")]
    [Table("entpr_HomeUrlRoutes")]
    [Discriminator]
    public class HomeUrlRoute : FullPowerEntity
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(2000)]
        public virtual string Roles { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(1000)]
        public virtual string HomeUrl { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int OrderIndex { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual FrontEndApp App { get; set; }
    }
}