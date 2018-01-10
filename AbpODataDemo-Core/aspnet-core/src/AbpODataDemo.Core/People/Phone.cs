using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace AbpODataDemo.People
{
    [Table("Phones")]
    public class Phone : CreationAuditedEntity
    {
        public virtual Person Person { get; set; }
        public virtual int PersonId { get; set; }

        public virtual PhoneType Type { get; set; }

        [Required]
        [MaxLength(16)]
        public virtual string Number { get; set; }

        public Phone()
        {
            
        }

        public Phone(PhoneType type, string number)
        {
            Type = type;
            Number = number;
        }
    }
}
