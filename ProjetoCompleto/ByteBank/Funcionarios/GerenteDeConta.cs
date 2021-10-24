﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {

        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }
}
