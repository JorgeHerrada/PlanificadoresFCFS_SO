using System.Windows.Forms;

namespace PlanificadoresFCFS_SO
{
    public partial class Form1 : Form
    {
        int contadorProcesos = 0;
        int minutos = 0;
        int segundos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {

            if (txtNombreNuevoProceso.Text == "" || txtDuracionNuevoProceso.Text == "")
            {
                Console.WriteLine("Asigna nombre y duracion al proceso.");
                return;
            }
            else if (!txtDuracionNuevoProceso.Text.All(char.IsDigit))
            {
                Console.WriteLine(txtDuracionNuevoProceso.Text + " IS NOT A VALID INTEGER.");
                return;
            }
            // Aumenta contador de procesos y asigna a lista
            contadorProcesos++;
            lstNumeroProceso.Items.Add(contadorProcesos);

            // Agrega nombre de proceso y limpia la caja
            lstNombreProceso.Items.Add(txtNombreNuevoProceso.Text);
            txtNombreNuevoProceso.Text = "";

            // Agrega duracion de proceso y limpia la caja
            lstDuracionProceso.Items.Add(txtDuracionNuevoProceso.Text);
            txtDuracionNuevoProceso.Text = "";
        }

        // Elimina todos lo elementos de la cola y reinicia contador contador
        private void btnLimpiarCola_Click(object sender, EventArgs e)
        {
            while (lstNumeroProceso.Items.Count > 0)
            {
                lstNumeroProceso.Items.RemoveAt(0);
                lstNombreProceso.Items.RemoveAt(0);
                lstDuracionProceso.Items.RemoveAt(0);
            }
            contadorProcesos = 0; 
            //lstNumeroProceso.Items.Clear(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "";
        }

        private void btnIniciarProcesos_Click(object sender, EventArgs e)
        {
            // checar que lista no esté vacía
            if(lstNumeroProceso.Items.Count == 0)
            {
                return;
            }

            // Inicializa el timer
            timer.Enabled = true;
            lblTimer.Visible = true;
            pgrGlobal.Visible = true;

            // Activamos etiqueta y barra de progreso
            pbr1.Visible = true;
            lblProceso1.Text = (string)lstNombreProceso.Items[0];
            lblProceso1.Visible = true;
            //pbr1.Maximum = (int)lstDuracionProceso.Items[0];

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }

            lblTimer.Text = String.Format("{0:00}:", minutos) + String.Format("{0:00}", segundos);
        }

        private void btnPausarProcesos_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Enabled = false;
        }
    }
}