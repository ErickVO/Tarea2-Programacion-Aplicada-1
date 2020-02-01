using System;

namespace Ejercicio10_1
{
    class Tienda10_1
    {
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public String NombreProducto { get; set; }

        public Tienda10_1()
        {
            Precio = 0;
            Unidades = 0;
            NombreProducto = string.Empty;
        }

        public Tienda10_1(float _Precio, int _Unidades, String _NombreProducto)
        {
            Precio = _Precio;
            Unidades = _Unidades;
            NombreProducto = _NombreProducto;
        }

    }
}
