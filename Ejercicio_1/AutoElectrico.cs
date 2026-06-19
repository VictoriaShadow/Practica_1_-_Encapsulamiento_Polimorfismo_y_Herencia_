using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace AutoDrive
{
    public class AutoElectrico : AutoDrive
    {
        private int _autonomia;

        public int Autonomia
        {
            get
            {
                return (_autonomia);
            }
            set
            {
                if (value > 0)
                {
                    _autonomia = value;
                }
            }
        }

         public override string Arrancar()
        {
            return $"{Marca} arranca silenciosamente con una autonomía de {Autonomia} km.";
        }
    }
}