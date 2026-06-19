using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace AutoDrive
{
    public class Camioneta : Vehiculo
    {
        private bool _traccion4x4;

        public bool Traccion4x4
        {
            get
            {
                return _traccion4x4;
            }
            set
            {
                _traccion4x4 = value;
            }
        }

        public override string Arrancar()
        {
            if (Traccion4x4)
                return $"{Marca} arranca con tracción 4x4 activada.";
            else
                return $"{Marca} arranca en modo normal.";
        }
    }
}