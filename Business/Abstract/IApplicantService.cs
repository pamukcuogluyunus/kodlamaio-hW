using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    
    public interface IApplicantService
    {
        // buraya sadece metodun imzası yazilir.
        //interface'ler referans tutucudurlar. 

        void ApplyForMask(Person person);


        List<Person> GetList();


        bool CheckPerson(Person person);

    }
}
