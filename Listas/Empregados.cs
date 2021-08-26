using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Listas
{
    class Empregados
    {
        public string Nome { get; set; }
        public double Salario { get; private set; }
        public int Id { get; set; }

        public Empregados(string nome, double salario, int id)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Increase(double percent)
        {
            Salario += Salario * percent / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
