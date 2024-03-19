using aspnet_core_unit_1.Models.Binding;
using aspnet_core_unit_1.Models.ViewModel;

namespace aspnet_core_unit_1.Services.Interface
{
    public interface IUpravljanjeZalihamiServis
    {
        ProizvodViewModel DodajZalihe(ProizvodBindingUpdate model);
        ProizvodViewModel ProvjeriZalihe(string naziv);
    }
}
