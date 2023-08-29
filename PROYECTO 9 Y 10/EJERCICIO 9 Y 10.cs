namespace EJERCICIO_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal montoConsumo = decimal.Parse(txtMonConsu.Text);

            decimal descuento, impuesto, subtotal, importeTotal;
            if (montoConsumo <= 100)
            {
                descuento = montoConsumo * 0.1m;
                impuesto = (montoConsumo - descuento) * 0.18m;
            }
            else
            {
                descuento = montoConsumo * 0.2m;
                impuesto = (montoConsumo - descuento) * 0.18m;
            }
            {
                subtotal = montoConsumo - descuento;
                importeTotal = subtotal + impuesto;
            }
            txtDesc.Text = descuento.ToString("");
            txtImp.Text = impuesto.ToString("");
            txtSubTotal.Text = subtotal.ToString("");
            txtImPagar.Text = importeTotal.ToString("");
        }
    }
}


