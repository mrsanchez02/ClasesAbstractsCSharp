using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasesAbstracts.model
{
    public class Rectangulo:Figura
    {
        private int _Base;
        private int _Altura;
        public Rectangulo(int Base, int Altura){
            this._Base = Base;
            this._Altura = Altura;
        }

        public override float Area(){
            return _Base * _Altura;
        }
        public override float Perimetro()
        {
            return (_Base*_Altura) * 2;
        }
    }
}