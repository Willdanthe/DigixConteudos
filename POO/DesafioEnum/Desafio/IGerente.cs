using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public interface IGerente
    {
        void Autorizar();

        bool ConcederAumento();

        bool AutorizarLicenca(Empregado empregado);
    }
}