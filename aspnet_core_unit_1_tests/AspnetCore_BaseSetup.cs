using aspnet_core_unit_1.Mapping;
using aspnet_core_unit_1.Services.Implementation;
using aspnet_core_unit_1.Services.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspnet_core_unit_1_tests
{
    public abstract class AspnetCore_BaseSetup
    {
        protected IMapper Mapper { get; private set; }
        

        protected AspnetCore_BaseSetup()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            Mapper = mappingConfig.CreateMapper();
            
        }

        protected IUpravljanjeZalihamiServis GetIupravljanjeZalihamiServis()
        {
            return new UpravljanjeZalihamiServis(Mapper);
        }
    }
}
