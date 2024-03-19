using aspnet_core_unit_1.Models.Binding;
using aspnet_core_unit_1.Models.Dbo;
using aspnet_core_unit_1.Models.ViewModel;
using aspnet_core_unit_1.Services.Interface;
using AutoMapper;
using System.Reflection.Metadata.Ecma335;

namespace aspnet_core_unit_1.Services.Implementation
{
    public class UpravljanjeZalihamiServis : IUpravljanjeZalihamiServis
    {
        private static List<Proizvod> Proizvodi = new List<Proizvod>()
        { 
            new Proizvod
            {
                id = 1,
                Naziv = "Mobitel",
                Kolicina = 1
            },

            new Proizvod
            {
                id = 2,
                Naziv = "Gume",
                Kolicina = 4
            }
        };
        private readonly IMapper mapper;

        public UpravljanjeZalihamiServis(IMapper mapper)
        {
            this.mapper = mapper;
        }
    

        // Azuriranje Postojecih proizvoda
        public ProizvodViewModel DodajZalihe (ProizvodBindingUpdate model)
        {
            var proizvod = Proizvodi.Where(y => y.Naziv == model.Naziv).FirstOrDefault();
            mapper.Map(model, proizvod);
           
            
            return mapper.Map<ProizvodViewModel> (proizvod);
        }

        public ProizvodViewModel ProvjeriZalihe (string naziv)
        {
          var result = Proizvodi.Where(y => y.Naziv == naziv).FirstOrDefault();

            return mapper.Map<ProizvodViewModel>(result);
        }
        


    }
}
