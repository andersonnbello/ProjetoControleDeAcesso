using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Acesso_Predio.Domain.Entities
{
    public class Person
    {
        [Key]
        [ForeignKey("ControlPerson")]
        public int Id { get; set; }
        public string Document { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public virtual ControlPerson ControlPerson { get; set; }

        public Person(string document, string name, string phone)
        {
            Document = document;
            Name = name;
            Phone = phone;
        }

        public Person()
        {
        }
    }
}
