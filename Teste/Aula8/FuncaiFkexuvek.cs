using System;

namespace Aula8
{
    public class FuncaoFlexivel
    {

        
        // declarando um delegate
        public delegate int Operacao(int a, int b);

        // expressao Lambda

        static int Soma(int a, int b) => a + b;
        
        // Juntar 2 funções no delegate
        public delegate void Notificar();
        public static void EnviarEmail() => System.Console.WriteLine("Email enviado!");
        public static void EnviarSMS() => System.Console.WriteLine("SMS enviado!");




        static void Main(string[] args){
            Operacao op = Soma;
            Operacao op2 = (int a, int b) => a * b; // Criando uma função sem declarar lá em cima

            System.Console.WriteLine(op2(2,3));
            System.Console.WriteLine(op(3,2));

            // Metodos anônimos;
            Func<int, int, int> op3 = delegate(int a, int b) {return a-b;};
            System.Console.WriteLine(op3(2,3));


            // Delegate Multicast
            Notificar notificar = EnviarEmail;
            notificar += EnviarSMS;

            notificar();

        }

        

    }
}