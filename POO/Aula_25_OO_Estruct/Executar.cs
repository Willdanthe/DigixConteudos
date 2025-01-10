using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Estruct
{
    public class Executaraaa
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Construtor no Sctruct é Obrigatório inicalizar todos os campos e ter parâmetros
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            
            public double Distancia(Point p)
            {
                return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y- p.Y, 2));
            }
            
        }

    public class Player
        {
            public string Nome { get; set; }
            
            public Point Posicao {get;set;}

            public Player(string nome, Point posicao)
            {
                this.Nome = nome;
                this.Posicao = posicao;
            }

            public void Move(Point newPosition)
            {
                this.Posicao = newPosition;
            }
        }

    
        
        static void Teste(string[] args)
        {
            Point p1 = new Point(10,20);
            Point p2 = new Point(10,20);

            Player player1 = new Player("Zephaux",p1);
            System.Console.WriteLine($"{player1.Nome} está na posição {player1.Posicao}");


            Player player2 = new Player("Xuahpez",p2);
            System.Console.WriteLine($"{player2.Nome} está na posição {player2.Posicao}");


            System.Console.WriteLine($"Distância entre {player1.Nome} e {player2.Nome} é: {p1.Distancia(p2)}");


        }
    }
}