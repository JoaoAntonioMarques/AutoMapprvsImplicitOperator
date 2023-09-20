using AutoMapper;

namespace AutoMapperPerf
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Configuração de mapeamento de Pessoa para PessoaDto
            CreateMap<Pessoa, PessoaDto>()
                .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => $"{src.Nome}, {src.Sobrenome} anos"));
        }
    }

}
