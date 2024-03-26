using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using System.Linq;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplemetation : IPersonService
    {
        private MysqlContext _context;

        public PersonServiceImplemetation(MysqlContext context)
        {
                _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {            
            return _context.Persons.ToList();
        }


        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
