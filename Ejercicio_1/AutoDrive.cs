using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDrive
{
    public class Vehiculo
    {
        private string _marca;

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _marca = value;
                }
            }
        }

        public virtual string Arrancar()
        {
            return $"{Marca} arranca.";
        }
    }
}
