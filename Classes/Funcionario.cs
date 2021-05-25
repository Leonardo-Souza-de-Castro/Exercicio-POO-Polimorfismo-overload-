using System;

namespace Exercicio_Sobrecarga.Classes
{
    public class Funcionario
    {
        public string[] lista = new string[4];

        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            
        }

        public void Mostrar(int indice){
            Console.WriteLine(lista[indice]);
        }

        public void Mostrar(string busca){
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == busca)
                {
                    Console.WriteLine($"O item {lista[i]} foi encontrado no indice {i}");
                }
            }
        }
    }
}