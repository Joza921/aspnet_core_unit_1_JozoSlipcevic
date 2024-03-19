using aspnet_core_unit_1.Models.Binding;
using aspnet_core_unit_1.Models.Dbo;
using aspnet_core_unit_1.Models.ViewModel;
using AutoMapper;

namespace aspnet_core_unit_1.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProizvodViewModel, Proizvod>().ReverseMap();
            CreateMap<ProizvodBindingUpdate , Proizvod> ().ReverseMap();
        }
    }
}
