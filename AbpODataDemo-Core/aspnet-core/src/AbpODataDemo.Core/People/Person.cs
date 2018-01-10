using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace AbpODataDemo.People
{
    [Table("Persons")]
    public class Person : FullAuditedEntity
    {
        [Required]
        [MaxLength(32)]
        public virtual string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public Person()
        {
            
        }

        public Person(string name, params Phone[] phones)
        {
            Name = name;
            
            if (phones != null)
            {
                Phones = new Collection<Phone>();
                foreach (var phone in phones)
                {
                    phone.Person = this;
                    Phones.Add(phone);
                }
            }
        }
    }
}
