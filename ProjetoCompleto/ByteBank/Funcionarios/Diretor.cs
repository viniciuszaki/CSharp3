using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Diretor");
        }

        public bool Autenticar(string senha)
        {
            return true;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.15);
            //Salario = Salario * 1.15;
            Salario *= 1.15;
        }
    }
}
