using System.ComponentModel.DataAnnotations;

namespace Controle_Acesso_Predio.Domain.Entities
{
    public class ControlPerson
    {
        [Key]
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string NameRoom { get; set; }
        public string TypeRoom { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Person> Persons { get; set; }

        public ControlPerson(int idPerson, string document, string name, string nameRoom, string typeRoom, DateTime date)
        {
            IdPerson = idPerson;
            Document = document;
            Name = name;
            NameRoom = nameRoom;
            TypeRoom = typeRoom;
            Date = date;
            Persons = new List<Person>();
        }

        public ControlPerson()
        {
        }
    }
}
