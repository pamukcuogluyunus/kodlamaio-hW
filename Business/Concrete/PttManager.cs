using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //field'lar class'in icerisinde alt cizgi ile yazilir.
        
        private IApplicantService _applicantService;

        //Constuctor new yapildiginda calisir
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        //Bir is sinifi baska bir is sinifini kullanirken new yapıyorsa ileride degisiklik talebi geldiginde bu uygulama direnc gosterir
        //new yaptiginda persona baglisin demektir.Ornegin baska bir ulkenin vatandasina maske verilecek olsa sorun cikar
        public void GiveMask(Person person)
        {
            
            //Sart dogruysa if bloguna girer
            if (_applicantService.CheckPerson(person) )
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
