using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using MernisServiceReference;

namespace Business.Concrete
{
    //Ciplak class kalmasin. Implementasyon ya da inheritance zafiyeti kalmasin.
    //Classlar hem ozellik hem de operasyonlar tutmak icin kullanilabilir.
    //Ancak SOLID yazilim prensibine gore ozellikleri ve operasyonlari ayri siniflarda tutmaliyiz
    public class CitizenManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }

        //Maskeyi alanlari listeliyoruz. 
        //Person turunde bir liste istiyoruz.
        public List<Person> GetList()
        {
            return null;
        }
        //PTT kisiyi kontrol edecek. MERNIS'ten 
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return  client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
