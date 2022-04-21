namespace ProjetoMoradia.Models
{
    public class Moradia
    {
        private string Endereco { get; set; }
        private int Cep { get; set; }
        private double TamanhoEmMetros { get; set; }
        private int QuantidadeDeBanheiros { get; set; }
        private int QuantidadeDeQuartos { get; set; }
        private List<Morador> Moradores { get; set; }

        public Moradia(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos)
        {
            SetEndereco(endereco);
            SetCep(cep);
            SetTamanhoEmMetros(tamanhoEmMetros);
            SetQuantidadeDeBanheiros(quantidadeDeBanheiros);
            SetQuantidadeDeQuartos(quantidadeDeQuartos);
            SetMoradores(new List<Morador>());
        }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public void SetCep(int cep)
        {
            Cep = cep;
        }

        public int GetCep()
        {
            return Cep;
        }

        public void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            TamanhoEmMetros = tamanhoEmMetros;
        }

        public double GetTamanhoEmMetros()
        {
            return TamanhoEmMetros;
        }

        public void SetQuantidadeDeBanheiros(int quantidadeDeBanheiros)
        {
            QuantidadeDeBanheiros = quantidadeDeBanheiros;
        }

        public int GetQuantidadeDeBanheiros()
        {
            return QuantidadeDeBanheiros;
        }

        public void SetQuantidadeDeQuartos(int quantidadeDeQuartos)
        {
            QuantidadeDeQuartos = quantidadeDeQuartos;
        }

        public int GetQuantidadeDeQuartos()
        {
            return QuantidadeDeQuartos;
        }

        public void SetMoradores(List<Morador> moradores)
        {
            Moradores = moradores;
        }

        public List<Morador> GetMoradores()
        {
            return Moradores;
        }

        public virtual double CalcularValor()
        {
            var valor = 0.0;
            return valor;
        }

        public void AdicionarMoradores(Morador morador)
        {
            Moradores.Add(morador);
        }

        public void RemoverMorador(string cpf)
        {
            Moradores.RemoveAll(morador => morador.GetCpf() == cpf);
        }
    }
}