﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;

            CPF = cpf;
            Salario = salario;
        }
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
