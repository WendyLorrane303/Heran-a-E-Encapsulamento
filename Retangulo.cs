using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_E_Encapsulamento
{
    class Retangulo : Figura
    {
        private double _altura;
        private double _largura;

        public double Altura
        {
            get
            {
                return this._altura;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }

        public double Largura
        {
            get
            {
                return this._largura;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Largura inválida");
                }
                else
                {
                    this._largura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }

        public Retangulo(double alt, double larg)
        {
            this.Altura = alt;
            this.Largura = larg;
        }

        private void AtualizarArea()
        {
            this._area = this._altura * this._largura;
        }

        private void AtualizarPerimetro()
        {
            this._perimetro = (2 * this._altura) + (2 * this._largura);
        }

    }
}
}
