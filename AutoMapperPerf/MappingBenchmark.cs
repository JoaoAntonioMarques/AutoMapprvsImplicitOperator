using AutoMapper;
using BenchmarkDotNet.Attributes;

namespace AutoMapperPerf
{
    public class MappingBenchmark
    {
        private readonly Pessoa pessoa;

        private readonly IMapper autoMapper;

        public MappingBenchmark()
        {
            pessoa = new Pessoa
            {
                Nome = "Joao",
                Sobrenome = "Marques",
                Idade = 32
            };

            // Configurar o AutoMapper
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Pessoa, PessoaDto>()
                 .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => $"{src.Nome}, {src.Sobrenome} anos"))
            );
            autoMapper = config.CreateMapper();
        }

        [Benchmark]
        public PessoaDto AutoMapperMapping()
        {
            return autoMapper.Map<PessoaDto>(pessoa);
        }

        [Benchmark]
        public PessoaDto StaticImplicitOperatorMapping()
        {
            PessoaDto pessoaDto = pessoa;
            return pessoaDto;
        }
    }
}
