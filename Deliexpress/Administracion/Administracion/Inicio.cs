namespace Administracion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            centrado();
        }
        private void centrado()
        {
            int altura_forma = this.Height;
            int anchura_forma = this.Width;

            // Establecer el tamaño del groupBox1 igual al tamaño de la forma
            groupBox1.Width = anchura_forma;
            groupBox1.Height = altura_forma;

            // Calcula las coordenadas para centrar el groupBox1 en la forma
            int nuevaX = (anchura_forma - groupBox1.Width) / 2;
            int nuevaY = (altura_forma - groupBox1.Height) / 2;

            groupBox1.Location = new Point(nuevaX, nuevaY);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            centrado();
        }



        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Actividad actividades = new Actividad (NombreUsu.Text,Password.Text))
                actividades.ShowDialog();
                    }
    }
}