using aspnet_core_unit_1.Models.Binding;
using aspnet_core_unit_1.Services.Interface;
using System.Reflection;

namespace aspnet_core_unit_1_tests
{
    public class UpravljanjeZalihamiServisUnitTest : AspnetCore_BaseSetup
    {
        private readonly IUpravljanjeZalihamiServis upravljanjeZalihamiServis;
    
    public UpravljanjeZalihamiServisUnitTest()
        {
            this.upravljanjeZalihamiServis = GetIupravljanjeZalihamiServis();
        }


        [Fact]
        public void DodajZalihe_MockData_ReturnsViewModel()
        {

            var result = upravljanjeZalihamiServis.DodajZalihe(new ProizvodBindingUpdate
            {

                Naziv = "Mobitel",
                Kolicina = 500
            });

            var provjera = upravljanjeZalihamiServis.ProvjeriZalihe(result.Naziv);
            Assert.Equal(provjera.Kolicina, result.Kolicina);


        }
 
        [Fact]
        public void DodajZaliheBroj2_MockData_ReturnsViewModel()
        {

            var result = upravljanjeZalihamiServis.DodajZalihe(new ProizvodBindingUpdate
            {
                Naziv = "Gume",
                Kolicina = 2
            });
            var Dbo = upravljanjeZalihamiServis.ProvjeriZalihe(result.Naziv);

            Assert.Equal(result.Kolicina, Dbo.Kolicina);

        }
    }
}