using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegrador3
{
    class Producto : ICloneable, IEnumerable, IEnumerator
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        string _Current = "";
        static int c = 0;
        bool r = false;

        public object Current => _Current;

        public class AscIdProduct : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return string.Compare(x.Id, y.Id);
            }
        }
        public class DescIdProduct : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return string.Compare(x.Id, y.Id) * -1;
            }
        }
        public class AscPriceProduct : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return string.Compare(x.Precio.ToString(), y.Precio.ToString());
            }
        }
        public class DescPriceProduct : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return string.Compare(x.Precio.ToString(), y.Precio.ToString()) * -1;
            }
        }
        public static bool ValidarCodigo(string code)
        {
            string[] codigos = code.Split('-');
            //Verificamos que el codigo "Numero de linea" sea el correcto
            if (codigos[0].Length != 3) return false;
            foreach (char a in codigos[0])
            {
                if (!Char.IsDigit(a)) return false;
            }
            //Verificamos que el codigo "Numero de linea" sea el correcto
            if (codigos[1].Length != 3) return false;
            string codigo = codigos[1];
            if (codigo[0] != 'L' || !Char.IsDigit(codigo[1]) || !Char.IsDigit(codigo[2])) return false;
            //Verificamos que el codigo "Codigo de operador" sea el correcto
            if (codigos[2].Length != 5) return false;
            codigo = codigos[2];
            if (codigo[0] != 'O' || codigo[1] != 'P' || !Char.IsDigit(codigo[2]) || !Char.IsDigit(codigo[3]) || !Char.IsDigit(codigo[4])) return false;
            return true;
        }
        public static string[] DecodificadorID(string id)
        {
            string[] codigos = id.Split('-');
            return codigos;
        }
        public static bool IDExistente(string id, List<Producto> productos, string idExcepcion = null)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Id == id && id != idExcepcion) return false;
            }
            return true;
        }
        public static bool DescripcionExistente(string descripcion, List<Producto> productos, string descripcionExcepcion = null)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Descripcion == descripcion && producto.Descripcion != descripcionExcepcion) return false;
            }
            return true;
        }

        public object Clone()
        {
            return new Producto
            {
                Id = this.Id,
                Descripcion = this.Descripcion,
                Stock = this.Stock,
                Precio = this.Precio
            };
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            // 123 Codigo del producto
            // 456 Numero de linea
            // 7-11 Codigo de operador
            // 12-21 Fecha de fabricacion
            string codigo = this.Id.Replace("-", "");
            if (c == 0) { _Current = "Codigo del producto: " + codigo.Substring(0, 3); r = true; c++; }
            else if (c == 1) { _Current = "Numero de línea: " + codigo.Substring(3, 3); r = true; c++; }
            else if (c == 2) { _Current = "Codigo de operador: " + codigo.Substring(6, 5); r = true; c++; }
            else if (c == 3) { _Current = "Fecha de fabricación: " + codigo.Substring(11, 9); r = true; c++; }
            else Reset();
            return r;
        }

        public void Reset()
        {
            c = 0;
            r = false;
            _Current = "";
        }
    }
}
