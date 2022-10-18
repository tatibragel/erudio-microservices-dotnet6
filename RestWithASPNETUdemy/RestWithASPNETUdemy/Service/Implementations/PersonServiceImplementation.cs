using RestWithASPNETUdemy.Model;
using System;
using System.Security.Cryptography;

namespace RestWithASPNETUdemy.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {

           return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                list.Add(person);
            }
            return list;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Nome" + i,
                LastName = "Sobrenome" + i,
                Address = "naquela rua" + i ,
                Gender = "undefined"
            };
        }

        private long IncrementAndGet()
        {

            return Interlocked.Increment(ref count);
        }

        public Person FindByID(long id)
        {

            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Tati",
                LastName = "Viana",
                Address = "minha casa",
                Gender = "Mulher da porra"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
