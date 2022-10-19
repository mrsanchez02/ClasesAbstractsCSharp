using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasesAbstracts.model
{
    public class Cuadrado:Figura
    {
        private int _Lado;
        public Cuadrado(int Lado){
            this._Lado = Lado;
        }

        public override float Area(){
            return _Lado*_Lado;
        }
        public override float Perimetro()
        {
            return _Lado * 4;
        }
    }
}