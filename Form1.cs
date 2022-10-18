using System.Linq.Expressions;
using System.Windows.Forms;

namespace PlanificadoresFCFS_SO
{
    public partial class Form1 : Form
    {
        int contadorProcesos = 0;
        int minutos = 0;
        int segundos = 0;
        int barraActual = 0;
        int duracionGlobal = 0;
        bool iniciado = false;
        //bool moveNext = true;
        bool terminado = false;

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

        
        private void btnLimpiarCola_Click(object sender, EventArgs e)
        {
            // detiene timer
            timer.Enabled = false;

            // Elimina todos lo elementos de la cola 
            while (lstNumeroProceso.Items.Count > 0)
            {
                lstNumeroProceso.Items.RemoveAt(0);
                lstNombreProceso.Items.RemoveAt(0);
                lstDuracionProceso.Items.RemoveAt(0);
            }

            // permite la entrada de nuevos procesos
            txtDuracionNuevoProceso.Enabled = true;
            txtNombreNuevoProceso.Enabled = true;
            btnAgregarProceso.Enabled = true;
            btnIniciarProcesos.Enabled = true;
            btnPausarProcesos.Enabled = false;

            // reinicia contador de procesos y barra de progreso actual
            contadorProcesos = 0;
            barraActual = 0;

            // oculta todas etiquetas, reiniciar y ocultar las barras de progreso 
            lblProceso1.Visible = false;
            lblProceso2.Visible = false;
            lblProceso3.Visible = false;
            lblProceso4.Visible = false;
            lblProceso5.Visible = false;
            lblProceso6.Visible = false;
            lblProceso7.Visible = false;
            lblGlobal.Visible = false;

            pbr1.Visible = false;
            pbr2.Visible = false;
            pbr3.Visible = false;
            pbr4.Visible = false;
            pbr5.Visible = false;
            pbr6.Visible = false;
            pbr7.Visible = false;
            pgrGlobal.Visible = false;

            pbr1.Value = 0;
            pbr2.Value = 0;
            pbr3.Value = 0;
            pbr4.Value = 0;
            pbr5.Value = 0;
            pbr6.Value = 0;
            pbr7.Value = 0;
            pgrGlobal.Value = 0;    

            // reiniciar tiempo y ocultar timer
            minutos = segundos = 0;
            lblTimer.Visible = false;
            iniciado = false;
            terminado = false;
            duracionGlobal = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "";
            btnPausarProcesos.Enabled = false;
        }

        private void btnIniciarProcesos_Click(object sender, EventArgs e)
        {
            // Bloquea la entrada de nuevos procesos o reinicio y permite pausar 
            txtDuracionNuevoProceso.Enabled = false;
            txtNombreNuevoProceso.Enabled = false;
            btnAgregarProceso.Enabled = false;

            btnIniciarProcesos.Enabled = false;
            btnPausarProcesos.Enabled = true;

            // checar que lista no esté vacía
            if (lstNumeroProceso.Items.Count == 0)
            {
                return;
            }

            // Inicialización o reanucación?
            if (iniciado)
            {
                timer.Enabled = true;
            }
            else
            {
                // activamos barra global
                pgrGlobal.Visible = true;
                lblGlobal.Visible = true;
                for(int i = 0; i < lstNumeroProceso.Items.Count; i++)
                {
                    duracionGlobal += Int32.Parse((string)lstDuracionProceso.Items[i]);
                }
                pgrGlobal.Maximum = duracionGlobal;


                // Activamos etiqueta y barra de progreso
                lblProceso1.Text = (string)lstNombreProceso.Items[0];
                lblProceso1.Visible = true;
                pbr1.Visible = true;

                // asigna la duraccion del proceso como maximo de la barra de progreso
                pbr1.Maximum = Int32.Parse((string)lstDuracionProceso.Items[0]);

                // Inicializa el timer
                timer.Enabled = true;
                lblTimer.Visible = true;
            }
            // Bandera de que ya se ha hecho la primera inicializacion 
            iniciado = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // procesos terminados?
            if (terminado)
            {
                return;
            }

            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }

            lblTimer.Text = String.Format("{0:00}:", minutos) + String.Format("{0:00}", segundos);

            
            // Se completaron las barras? paramos timer
            if (lstNumeroProceso.Items.Count == barraActual)
            {
                timer.Enabled = false;
                terminado = true;
                return;
            }

            // si estamos en penultima barra, el switch ya no inicializa la siguiente
            /*if (lstNumeroProceso.Items.Count == barraActual+1)
            {
                moveNext = false;
            }*/

            if (pgrGlobal.Value < duracionGlobal)
            {
                pgrGlobal.Value++;
            }

            switch (barraActual)
            {
                case 0:
                    if (pbr1.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr1.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr2.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso2.Text = (string)lstNombreProceso.Items[barraActual];
                            
                        }
                        catch
                        {
                            return;
                        }
                        pbr2.Visible = true;
                        lblProceso2.Visible = true;
                    }
                    break;
                case 1:
                    if (pbr2.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr2.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr3.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso3.Text = (string)lstNombreProceso.Items[barraActual];
                        }
                        catch
                        {
                            return;
                        }
                        lblProceso3.Visible = true;
                        pbr3.Visible = true;
                    }
                    break;
                case 2:
                    if (pbr3.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr3.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr4.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso4.Text = (string)lstNombreProceso.Items[barraActual];
                        }
                        catch
                        {
                            return;
                        }
                        pbr4.Visible = true;
                        lblProceso4.Visible = true;
                    }
                    break;
                case 3:
                    if (pbr4.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr4.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr5.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso5.Text = (string)lstNombreProceso.Items[barraActual];
                        }
                        catch
                        {
                            return;
                        }
                        pbr5.Visible = true;
                        lblProceso5.Visible = true;
                    }
                    break;
                case 4:
                    if (pbr5.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr5.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr6.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso6.Text = (string)lstNombreProceso.Items[barraActual];
                        }
                        catch
                        {
                            return;
                        }
                        pbr6.Visible = true;
                        lblProceso6.Visible = true;
                    }
                    break;
                case 5:
                    if (pbr6.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr6.Value++;
                    }
                    else
                    {
                        try
                        {
                            barraActual++;
                            pbr7.Maximum = Int32.Parse((string)lstDuracionProceso.Items[barraActual]);
                            lblProceso7.Text = (string)lstNombreProceso.Items[barraActual];
                        }
                        catch
                        {
                            return;
                        }
                        pbr7.Visible = true;
                        lblProceso7.Visible = true;
                    }
                    break;
                case 6:
                    if (pbr7.Value < Int32.Parse((string)lstDuracionProceso.Items[barraActual]))
                    {
                        pbr7.Value++;
                    }
                    else
                    {
                        timer.Enabled = false;
                    }
                    break;
                default:
                    timer.Enabled = false;
                    break;
            }
        }

        private void btnPausarProcesos_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnPausarProcesos.Enabled = false;
            btnIniciarProcesos.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Enabled = false;
        }
    }
}