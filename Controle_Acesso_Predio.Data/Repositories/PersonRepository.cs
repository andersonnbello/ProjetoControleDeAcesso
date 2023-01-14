using Controle_Acesso_Predio.Data.Context;
using Controle_Acesso_Predio.Domain.Entities;
using Controle_Acesso_Predio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Controle_Acesso_Predio.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly MyContext _db;

        public PersonRepository(MyContext db)
        {
            _db = db;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            _db.Person.Add(person);
            await _db.SaveChangesAsync();

            return person;
        }

        public async Task<Person> GetByDocument(string document)
        {
            return await _db.Person.FirstOrDefaultAsync(x => x.Document == document);
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _db.Person.ToListAsync();
        }
    }
}
