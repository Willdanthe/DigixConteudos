using System;

namespace Name
{
    public class Atividade1
    {
        public delegate double Operacao(double[] a);
        
        public static double Media(double[] a){
            double somaTotal = 0;
            for (int i = 0 ; i < a.Length; i++){
                somaTotal += a[i];    
            }
            double media = Convert.ToDouble(somaTotal)/a.Length;
            return media;
        }


        static void Ex1(string[] args)
        {
            double[] vet = new double[5];
            Operacao op = Media;

            for (int i = 0; i < vet.Length ; i++)
            {
                System.Console.WriteLine($"Digite um número pra pos {i}: ");
                vet[i] = Convert.ToDouble(Console.ReadLine());
            }


            System.Console.WriteLine(op(vet));
        }
    }
}