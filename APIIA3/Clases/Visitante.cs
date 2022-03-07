using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIIA3.Clases
{
    internal class Visitante
    {
        public string vis_nombre;
        public string vis_identificacion;
        public int vis_edad;
        public Categorias vis_categoria;

        public Visitante(string nombre, string identificacion, int edad, Categorias categoria)
        {
            vis_nombre = nombre;
            vis_identificacion = identificacion;
            vis_edad = edad;
            vis_categoria = categoria;
        }
        public int calculartarifa()
        {
            int tarifa = 30000;
            int descuento = 0;
            switch (vis_categoria)
            {
                case Categorias.a:
                    {
                        descuento = (int)descuentos.a;
                        break;
                    }
                case Categorias.b:
                    {
                        descuento = (int)descuentos.b;
                        break;
                    }
                case Categorias.c:
                    {
                        descuento = (int)descuentos.c;
                        break;
                    }
                case Categorias.not:
                    {
                        descuento = 0;
                        break;
                    }
            }
            if (vis_categoria == Categorias.not)
            {
                return tarifa;
            }
            else {
               tarifa = tarifa - (tarifa* descuento / 100);
                return tarifa;
            }


            return tarifa;
        }
    }
    public enum Categorias
    {
        a = 0,
        b = 1,
        c = 2,
        not = 3

    }
    public enum descuentos : int
    {
        not = 0,
        a = 15,
        b = 30,
        c = 50

    }

}