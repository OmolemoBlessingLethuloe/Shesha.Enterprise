using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using Shesha.Domain.Enums;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Shesha.Enterprise.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.Employee")]

    public class Employee : Person
    {
        /// <summary> 
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "Yes|No")]
        [Display(Name = "Details have been validated")]
        public virtual bool DetailsValidated { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Display(Name = "Employee No")]
        public virtual string EmployeeNo { get; set; }

        /// <summary> 
        /// Security clearance end date (after this date it's reset to Public)
        /// </summary>
        [Display(Name = "Security Clearance valid till")]
        public virtual DateTime? SecurityClearanceEndDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Display(Name = "Office Room No")]
        public virtual string OfficeRoomNo { get; set; }

        /// <summary> 
        /// If true, indicates that this employee has no computer and doesn't work with the system directly. His account is used by another users to act on behalf of he
        /// </summary>
        [Display(Name = "Has no computer")]
        public virtual bool HasNoComputer { get; set; } = false;

        /// <summary> 
        /// 
        /// </summary>
        [Display(Name = "Shift Worker")]
        public virtual bool IsShiftWorker { get; set; }

        /// <summary> 
        /// Security clearance
        /// </summary>
        [Display(Name = "Security Clearance")]
        public virtual RefListSecurityClassification? SecurityClearance { get; set; } = RefListSecurityClassification.Public;

        /// <summary> 
        /// 
        /// </summary>
        public virtual RefListSignatureType SignatureType { get; set; } = RefListSignatureType.None;

        /// <summary> 
        /// 
        /// </summary>
        [Display(Name = "Office Location")]
        [AllowInherited]
        public virtual Area OfficeLocation { get; set; }
    }
}