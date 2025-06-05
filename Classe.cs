using System;

namespace Apresentacao
{
    public class ClasseGenerica<T>
    {
        private T valor;

        public ClasseGenerica(T valor)
        {
            this.valor = valor;
        }

        public void ExibirValor()
        {
            Console.WriteLine($"Valor test: {valor}");
        }

        public T ObterValor()
        {
            return valor;
        }
    }
}