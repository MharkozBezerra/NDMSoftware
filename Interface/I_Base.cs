using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Classes;
namespace NDM_SoftwareV5.Interface
{
   public interface I_Base
    {
        void add_empresa(Empresa empresa);
        void upt_empresa(Empresa empresa);
        void add_filial(Filial filial);
        void upt_filial(Filial filial);
    }
}
