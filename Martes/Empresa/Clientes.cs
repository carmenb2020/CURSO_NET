using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonasEmpresa
{
    public class Clientes : PersonasEmpresa.PersonasEmpresa, PersonasEmpresa
    {
        private int Telefono;

        public PersonasEmpresa PersonasEmpresa
        {
            get => default(PersonasEmpresa.PersonasEmpresa);
            set
            {
            }
        }

        public Empresa Empresa
        {
            get => default(PersonasEmpresa.Empresa);
            set
            {
            }
        }
    }
}