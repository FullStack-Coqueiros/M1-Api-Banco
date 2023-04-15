using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio8.Models;

namespace exercicio8.Services
{
    public class ClientesService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get (){
            return clientes;
        }
        Cliente BuscarClientePorNumeroDeConta (int numeroConta){; 
        foreach(Cliente cliente in clientes){
            if(cliente.NumeroConta == numeroConta){
            return cliente;
            }
        }
        // mesma coisa que o foreach
        // for(int i =0; i < clientes.Count; i++){
        //    if(clientes[i].NumeroConta == numeroConta);
        //     return clientes[i];
        // }
        return null;
        }

        void ExibirClientes(){
        Console.WriteLine("Número da conta        | Nome         | CPF    ");
        for(int i =0; i < clientes.Count; i++){
            Console.WriteLine(clientes[i].ResumoCliente());
        }
        }

        public void CriarConta(Cliente cliente){

            if(!cliente.EhMaior()){
            Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
            return ;
            }
         
            clientes.Add(cliente);
        }
    }
}