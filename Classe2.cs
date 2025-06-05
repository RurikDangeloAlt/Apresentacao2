using System;

namespace Apresentacao
{
    public class ClasseGenerica22<T>
    {
        private T valor;

        public ClasseGenerica2(T valor)
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