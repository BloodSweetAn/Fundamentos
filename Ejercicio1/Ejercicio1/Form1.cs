namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<PuntoVenta> puntoventa = new List<PuntoVenta>();
        public Form1()
        {
            InitializeComponent();
            String[] drowpDownItemsList = { "Bebida", "Abarrote", "Confiteria" };

            comboBoxCategoriaProductos.Items.AddRange(drowpDownItemsList);
        }

        private void MostrarPuntoVenta(List<PuntoVenta> lista)
        {
            listViewPDV.Items.Clear();

            foreach (PuntoVenta pv in lista)
            {
                ListViewItem fila = new ListViewItem(pv.Codigo);
                fila.SubItems.Add(pv.Nombre);
                fila.SubItems.Add(pv.Distrito);
                fila.SubItems.Add(pv.VentaMensutal);
                listViewPDV.Items.Add(fila);
            }
        }

        private void MostrarProducto(List<Producto> lista)
        {
            listViewProducto.Items.Clear();

            foreach (Producto pv in lista)
            {
                ListViewItem fila = new ListViewItem(pv.Codigo);
                fila.SubItems.Add(pv.Nombre);
                fila.SubItems.Add(pv.Categoria);
                listViewProducto.Items.Add(fila);
            }
        }

        private void buttonRegistrarPDV_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoPDV.Text == "" || textBoxDistritoPDV.Text == "" || textBoxNombrePDV.Text == "" ||
                textBoxVentaPDV.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos");
                return;
            }

            bool existe = puntoventa.Exists(elemento => elemento.Codigo.Equals(textBoxCodigoPDV.Text));

            if (existe)
            {
                MessageBox.Show("Ingrese otro codigo , este ya existe");
                return;
            }

            PuntoVenta pv = new()
            {
                Codigo = textBoxCodigoPDV.Text,
                Distrito = textBoxDistritoPDV.Text,
                Nombre = textBoxNombrePDV.Text,
                VentaMensutal = textBoxVentaPDV.Text,
                productos = new()
            };

            puntoventa.Add(pv);

            textBoxCodigoPDV.Text = "";
            textBoxDistritoPDV.Text = "";
            textBoxNombrePDV.Text = "";
            textBoxVentaPDV.Text = "";

            MostrarPuntoVenta(puntoventa);
        }

        private void buttonLimpiarPDV_Click(object sender, EventArgs e)
        {
            MostrarPuntoVenta(puntoventa);
        }

        private void buttonRegistrarP_Click(object sender, EventArgs e)
        {
            bool seleccionado = listViewPDV.SelectedItems.Count != 0;

            if (!seleccionado)
            {
                MessageBox.Show("Seleccione un punto de venta");
                return;
            }

            if (textBoCodigoProductos.Text == "" || textBoxNombreProductos.Text == "" || comboBoxCategoriaProductos.Text == "")
            {
                MessageBox.Show("Ingresar todos los campos");
                return;
            }

            String codigo = textBoCodigoProductos.Text;

            foreach (PuntoVenta pnVenta in puntoventa)
            {
                bool productoexiste = pnVenta.productos.Exists(elemento => elemento.Codigo.Equals(codigo));

                if (productoexiste)
                {
                    MessageBox.Show("Esta producto ya existe en la lista");
                    return;
                }
            }

            String Codigo = listViewPDV.SelectedItems[0].Text;

            PuntoVenta? puntoventaseleccionado = puntoventa.Find(elemento => elemento.Codigo.Equals(Codigo));



            if (puntoventaseleccionado != null)
            {
                Producto producto = new Producto()
                {
                    Categoria = comboBoxCategoriaProductos.Text,
                    Codigo = textBoCodigoProductos.Text,
                    Nombre = textBoxNombreProductos.Text
                };

                puntoventaseleccionado.productos.Add(producto);

                comboBoxCategoriaProductos.SelectedIndex = -1;
                textBoxNombreProductos.Text = "";
                textBoCodigoProductos.Text = "";


                MostrarProducto(puntoventaseleccionado.productos);
            }

        }

        private void buttonLimpiarP_Click(object sender, EventArgs e)
        {
            MostrarProducto(new List<Producto>());
        }

        private void listViewPDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool puntoselecionado = listViewPDV.SelectedItems.Count != 0;

            if (!puntoselecionado) return;

            String codigo = listViewPDV.SelectedItems[0].Text;

            PuntoVenta? puntoventatmp = puntoventa.Find(elemento => elemento.Codigo.Equals(codigo));

            if (puntoventatmp == null) return;

            MostrarProducto(puntoventatmp.productos);

        }

        private void buttonBuscarPDVSinProducto_Click(object sender, EventArgs e)
        {
            if (textBoxNoVendeProducto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del prodcuto");
                return;
            }

            List<PuntoVenta> puntoV = new();

            String codigo = textBoxNoVendeProducto.Text;

            foreach (PuntoVenta pV in puntoventa)
            {
                bool existeProducto = pV.productos.Exists(i => i.Codigo.Equals(codigo));

                if (!existeProducto)
                {
                    puntoV.Add(pV);
                }
            }

            MostrarPuntoVenta(puntoV);
            textBoxNoVendeProducto.Text = "";
        }

        private void buttonBuscarDistrito_Click(object sender, EventArgs e)
        {
            if(textBoxBuscarDistrito.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del distrito");
                return;
            }

            List<PuntoVenta> puntoDistrito = puntoventa.FindAll(i => i.Distrito.Equals(textBoxBuscarDistrito.Text));

            if(puntoDistrito != null)
            {
                MostrarPuntoVenta(puntoDistrito);
            }

            textBoxBuscarDistrito.Text = "";
        }
    }
}