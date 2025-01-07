using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public class GerenteProducao : Empregado , IGerente 
    {
        public RegiaoEnum Regiao { get; set; }
        
        
        public GerenteProducao(string nome, double salario, RegiaoEnum regiao) : base(nome,salario) 
        {
            this.Regiao = regiao;
        }

        public void Autorizar()
        {
            System.Console.WriteLine("Autorizando...");
        }

        public bool ConcederAumento()
        {
            Random r = new Random();
            int cache = r.Next(0,1);

            if (cache == 1)
            {
                System.Console.WriteLine("Aumento Permitido!");
                return true;
            }
            else
            {
                System.Console.WriteLine("Aumento Negado!");
                return false;
            }
        }

        public bool AutorizarLicenca (Empregado empregado)
        {
            Random r = new Random();
            int cache = r.Next(0,1);

            if (cache == 1)
            {
                System.Console.WriteLine("Licença Permitida!");
                System.Console.WriteLine("+1!");
                empregado.LicencaPremioRecebido++;
                return true;
            }
            else
            {
                System.Console.WriteLine("Licença Negada! ");
                System.Console.WriteLine("-1...");
                empregado.LicencaPremioRecebido--;
                return false;
            }
        }

        public double GetSalario()
        {
            return Salario;
        }
    }
}