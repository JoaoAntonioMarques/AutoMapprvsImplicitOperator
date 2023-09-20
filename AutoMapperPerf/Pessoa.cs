namespace AutoMapperPerf
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public static implicit operator PessoaDto(Pessoa pessoa)
        {
            return new PessoaDto
            {
                Idade = pessoa.Idade,
                NomeCompleto = $"{pessoa.Nome}, {pessoa.Sobrenome}"
            };
        }
    }
}
