using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Gerentes
            GerenteProducao gerenteProducao = new GerenteProducao("Arthur",11750, RegiaoEnum.OESTE);
            GerenteVendas gerenteVendas = new GerenteVendas("Gravena", 11750, RegiaoEnum.SUL);
            Vendedor vendedor1 = new Vendedor("Willdanthe", 3500);
            Vendedor vendedor2 = new Vendedor("Henrique", 3500);
            Vendedor vendedor3 = new Vendedor("Kauã", 3500);

            
            Empregados empregados = new Empregados();

            empregados.AddEmpregado(gerenteProducao);
            empregados.AddEmpregado(gerenteVendas);
            empregados.AddEmpregado(vendedor1);
            empregados.AddEmpregado(vendedor2);
            empregados.AddEmpregado(vendedor3);

            empregados.ImprimirFuncionarios();

            empregados.ConsultarFuncionario("Gravena");
            empregados.ConsultarFuncionario("Rodrigo");

            gerenteProducao.AutorizarLicenca(vendedor1);
            gerenteVendas.Autorizar();
            gerenteVendas.ConcederAumento();

        }







    }
}