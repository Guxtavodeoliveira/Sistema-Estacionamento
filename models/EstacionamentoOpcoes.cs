using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.obj.models
{
    public class EstacionamentoOpcoes
    {
        //Função para calculo do valor para pagamento
        public decimal PrecoFinal(decimal x, decimal y, decimal z)
        {
            decimal resultado = x + y * z;
            return resultado;
        }

        //Função para CADASTRAR os carros na lista
        public List<string> Cadastro(List<string> lista, string placa)
        {
            lista.Add(placa);
            return lista;
        }

        //Função para REMOVER os carros da lista
        public List<string> RemoverCarro(List<string> lista, string placa)
        {
            lista.Remove(placa);
            return lista;
        }

        //Função para pausar e dar clear no final de cada opção do menu
        public void PausarConsole()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}