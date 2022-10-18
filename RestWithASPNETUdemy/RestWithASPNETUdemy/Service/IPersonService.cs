﻿using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
