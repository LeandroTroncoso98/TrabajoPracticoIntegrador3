using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegrador3
{
    public partial class Form1 : Form
    {
        private List<Producto> _listaProductos;
        private Producto _producto = new Producto();
        private Producto _productoClon;
        public Form1()
        {
            _listaProductos = new List<Producto>();


            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "Inventario de " + Environment.NewLine + "productos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtCode1.MaxLength = 3;
            txtCode2.MaxLength = 3;
            txtCode3.MaxLength = 5;
        }
        private void ActualizarDgv()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _listaProductos;
            dgvProductos.Columns["Current"].Visible = false;
        }

        private void btnAgregarProduct_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                string codigo = String.Concat(txtCode1.Text, '-', txtCode2.Text, '-', txtCode3.Text, '-', dtpFechaFabricacion.Value.ToString("d")).ToUpper();
                if (Producto.ValidarCodigo(codigo))
                {
                    if (ValidarTxtStock(txtStock.Text))
                    {
                        if (Producto.IDExistente(codigo, _listaProductos))
                        {
                            if (Producto.DescripcionExistente(txtDescripcion.Text, _listaProductos))
                            {
                                Producto producto = new Producto
                                {
                                    Id = codigo,
                                    Descripcion = txtDescripcion.Text,
                                    Precio = decimal.Parse(txtPrecio.Text.Replace('.', ',')),
                                    Stock = int.Parse(txtStock.Text)
                                };
                                _listaProductos.Add(producto);
                                ActualizarDgv();
                                VaciarCamposDeRegistro();
                                MessageBox.Show($"El producto ID = {codigo} fue creado con exíto.");
                            }
                            else MessageBox.Show("La Descripcion del producto ya exíste.");
                        }
                        else MessageBox.Show("El ID del producto ya exíste.");
                    }
                    else MessageBox.Show("El campo de stock debe ser valido");
                }
                else MessageBox.Show("El codigo tiene el formato incorrecto." + Environment.NewLine
                    + "Codigo de producto : 000" + Environment.NewLine
                    + "Número de línea: L00" + Environment.NewLine
                    + "Código de operador: OP000" + Environment.NewLine
                    + "Fecha de fabricación: dd/mm/aaaa","Error de formato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe Completar los campos");
        }
        private bool CamposVacios()
        {
            if (!String.IsNullOrWhiteSpace(txtCode1.Text) && !String.IsNullOrWhiteSpace(txtCode2.Text) && !String.IsNullOrWhiteSpace(txtCode3.Text) && !String.IsNullOrWhiteSpace(txtDescripcion.Text) && !String.IsNullOrWhiteSpace(txtPrecio.Text) && !String.IsNullOrWhiteSpace(txtStock.Text)) return true;
            return false;
        }
        private void VaciarCamposDeRegistro()
        {
            txtCode1.Text = "";
            txtCode2.Text = "";
            txtCode3.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                string[] codigo = Producto.DecodificadorID(_producto.Id);
                txtCode1.Text = codigo[0];
                txtCode2.Text = codigo[1];
                txtCode3.Text = codigo[2];
                dtpFechaFabricacion.Value = DateTime.Parse(codigo[3]);
                txtDescripcion.Text = _producto.Descripcion;
                txtPrecio.Text = _producto.Precio.ToString();
                txtStock.Text = _producto.Stock.ToString();
                lblIEnumerator.Text = "";
                foreach (string s in _producto)
                {
                    lblIEnumerator.Text += s + Environment.NewLine;
                }

            }
            catch
            {
                MessageBox.Show("No se ha podido seleccionar ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            VaciarCamposDeRegistro();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow.DataBoundItem != null)
                {
                    _listaProductos.Remove(_producto);
                    ActualizarDgv();
                    VaciarCamposDeRegistro();
                    MessageBox.Show($"Se ha eliminado con exito." + Environment.NewLine + "Producto ID = {_producto.Id}");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrecioAscendente_Click(object sender, EventArgs e)
        {
            _listaProductos.Sort(new Producto.AscPriceProduct());
            ActualizarDgv();
        }



        private void btnPrecioDescendente_Click(object sender, EventArgs e)
        {
            _listaProductos.Sort(new Producto.DescPriceProduct());
            ActualizarDgv();
        }

        private void btnIDAscendente_Click(object sender, EventArgs e)
        {
            _listaProductos.Sort(new Producto.AscIdProduct());
            ActualizarDgv();
        }

        private void btnIDDescendente_Click(object sender, EventArgs e)
        {
            _listaProductos.Sort(new Producto.DescIdProduct());
            ActualizarDgv();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposVacios())
                {
                    string codigo = String.Concat(txtCode1.Text, '-', txtCode2.Text, '-', txtCode3.Text, '-', dtpFechaFabricacion.Value.ToString("d")).ToUpper();
                    Producto productoEditado = new Producto
                    {
                        Id = codigo,
                        Descripcion = txtDescripcion.Text,
                        Precio = decimal.Parse(txtPrecio.Text.Replace('.', ',')),
                        Stock = int.Parse(txtStock.Text)
                    };
                    if (Producto.IDExistente(codigo, _listaProductos, _producto.Id))
                    {
                        if (Producto.DescripcionExistente(productoEditado.Descripcion, _listaProductos, _producto.Descripcion))
                        {
                            _producto.Id = productoEditado.Id;
                            _producto.Descripcion = productoEditado.Descripcion;
                            _producto.Precio = productoEditado.Precio;
                            _producto.Stock = productoEditado.Stock;
                            ActualizarDgv();
                            VaciarCamposDeRegistro();
                        }
                        else MessageBox.Show("La descripcion ya se encuentra en uso.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("El codigo ya se encuentra en uso.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Debe Completar los campos");
            }
            catch
            {
                MessageBox.Show("No fue posible modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClonarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _productoClon = (Producto)_producto.Clone();
                _listaProductos.Add(_productoClon);
                MessageBox.Show($"Se ha creado un clon del producto:" + Environment.NewLine + $"ID: {_productoClon.Id}." + Environment.NewLine + $"Descripcion: {_productoClon.Descripcion}." + Environment.NewLine + $"Precio: ${_productoClon.Precio}", "Clonacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarCamposDeRegistro();
                ActualizarDgv();
            }
            catch
            {
                MessageBox.Show("No pudo clonarse con exito el producto.", "Al parecer hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarTxtStock(string stock)
        {
            foreach (char c in stock)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
