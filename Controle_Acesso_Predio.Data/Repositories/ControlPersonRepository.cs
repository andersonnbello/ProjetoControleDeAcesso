using Controle_Acesso_Predio.Data.Context;
using Controle_Acesso_Predio.Domain.Entities;
using Controle_Acesso_Predio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Controle_Acesso_Predio.Data.Repositories
{
    public class ControlPersonRepository : IControlPersonRepository
    {
        private readonly MyContext _db;

        public ControlPersonRepository(MyContext db)
        {
            _db = db;
        }

        public async Task<ControlPerson> CreateAsync(ControlPerson controlPerson)
        {
            _db.ControlPerson.Add(controlPerson);
            await _db.SaveChangesAsync();

            return controlPerson;
        }

        public async Task<IEnumerable<ControlPerson>> GetAllAsync()
        {
            return await _db.ControlPerson.ToListAsync();
        }
    }
}
