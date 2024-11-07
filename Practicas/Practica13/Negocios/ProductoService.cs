using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ProductoService
    {
        private ProductoDAO productoDAO = new ProductoDAO(); 

        public DataTable MostrarProductos()
        {
            return productoDAO.ObtenerProductos();
        }

        public void InsertarProducto(string nombre, string descripcion, string marca, double precio, int inventario)
        {
            productoDAO.Insertar(nombre, descripcion, marca, precio, inventario);
        }

        public void EditarProducto(string nombre, string descripcion, string marca, double precio, int inventario, int id)
        {
            productoDAO.Editar(nombre, descripcion, marca, precio, inventario, id);
        }
        public void EliminarProducto(int id)
        {
            productoDAO.Eliminar(id);
        }
        public bool verificar(string user, string pass)
        {
            return productoDAO.verificarCredenciales(user, pass);
        }

    }
}
