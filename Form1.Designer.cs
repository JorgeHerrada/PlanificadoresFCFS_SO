namespace PlanificadoresFCFS_SO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAgregarProcesos = new System.Windows.Forms.Label();
            this.lblNombreNuevoProceso = new System.Windows.Forms.Label();
            this.lblDuracionNuevoProceso = new System.Windows.Forms.Label();
            this.txtNombreNuevoProceso = new System.Windows.Forms.TextBox();
            this.txtDuracionNuevoProceso = new System.Windows.Forms.TextBox();
            this.lblColaProcesos = new System.Windows.Forms.Label();
            this.lblNumeroProcesoColumna = new System.Windows.Forms.Label();
            this.lblNombreProcesoColumna = new System.Windows.Forms.Label();
            this.lblDuracionProcesoColumna = new System.Windows.Forms.Label();
            this.lstNumeroProceso = new System.Windows.Forms.ListBox();
            this.lstNombreProceso = new System.Windows.Forms.ListBox();
            this.lstDuracionProceso = new System.Windows.Forms.ListBox();
            this.btnAgregarProceso = new System.Windows.Forms.Button();
            this.gbxProcesos = new System.Windows.Forms.GroupBox();
            this.lblProceso7 = new System.Windows.Forms.Label();
            this.lblProceso6 = new System.Windows.Forms.Label();
            this.lblProceso5 = new System.Windows.Forms.Label();
            this.lblProceso4 = new System.Windows.Forms.Label();
            this.lblProceso3 = new System.Windows.Forms.Label();
            this.lblProceso2 = new System.Windows.Forms.Label();
            this.lblProceso1 = new System.Windows.Forms.Label();
            this.pbr7 = new System.Windows.Forms.ProgressBar();
            this.pbr6 = new System.Windows.Forms.ProgressBar();
            this.pbr5 = new System.Windows.Forms.ProgressBar();
            this.pbr4 = new System.Windows.Forms.ProgressBar();
            this.pbr3 = new System.Windows.Forms.ProgressBar();
            this.pbr2 = new System.Windows.Forms.ProgressBar();
            this.pbr1 = new System.Windows.Forms.ProgressBar();
            this.btnLimpiarCola = new System.Windows.Forms.Button();
            this.btnPausarProcesos = new System.Windows.Forms.Button();
            this.btnIniciarProcesos = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pgrGlobal = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblGlobal = new System.Windows.Forms.Label();
            this.gbxProcesos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregarProcesos
            // 
            this.lblAgregarProcesos.AutoSize = true;
            this.lblAgregarProcesos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarProcesos.Location = new System.Drawing.Point(34, 9);
            this.lblAgregarProcesos.Name = "lblAgregarProcesos";
            this.lblAgregarProcesos.Size = new System.Drawing.Size(223, 37);
            this.lblAgregarProcesos.TabIndex = 0;
            this.lblAgregarProcesos.Text = "Agregar Procesos";
            // 
            // lblNombreNuevoProceso
            // 
            this.lblNombreNuevoProceso.AutoSize = true;
            this.lblNombreNuevoProceso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreNuevoProceso.Location = new System.Drawing.Point(13, 60);
            this.lblNombreNuevoProceso.Name = "lblNombreNuevoProceso";
            this.lblNombreNuevoProceso.Size = new System.Drawing.Size(85, 28);
            this.lblNombreNuevoProceso.TabIndex = 1;
            this.lblNombreNuevoProceso.Text = "Nombre";
            // 
            // lblDuracionNuevoProceso
            // 
            this.lblDuracionNuevoProceso.AutoSize = true;
            this.lblDuracionNuevoProceso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracionNuevoProceso.Location = new System.Drawing.Point(185, 60);
            this.lblDuracionNuevoProceso.Name = "lblDuracionNuevoProceso";
            this.lblDuracionNuevoProceso.Size = new System.Drawing.Size(91, 28);
            this.lblDuracionNuevoProceso.TabIndex = 2;
            this.lblDuracionNuevoProceso.Text = "Duración";
            // 
            // txtNombreNuevoProceso
            // 
            this.txtNombreNuevoProceso.Location = new System.Drawing.Point(13, 91);
            this.txtNombreNuevoProceso.Name = "txtNombreNuevoProceso";
            this.txtNombreNuevoProceso.Size = new System.Drawing.Size(157, 23);
            this.txtNombreNuevoProceso.TabIndex = 3;
            // 
            // txtDuracionNuevoProceso
            // 
            this.txtDuracionNuevoProceso.Location = new System.Drawing.Point(176, 91);
            this.txtDuracionNuevoProceso.Name = "txtDuracionNuevoProceso";
            this.txtDuracionNuevoProceso.Size = new System.Drawing.Size(100, 23);
            this.txtDuracionNuevoProceso.TabIndex = 4;
            // 
            // lblColaProcesos
            // 
            this.lblColaProcesos.AutoSize = true;
            this.lblColaProcesos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColaProcesos.Location = new System.Drawing.Point(34, 196);
            this.lblColaProcesos.Name = "lblColaProcesos";
            this.lblColaProcesos.Size = new System.Drawing.Size(219, 37);
            this.lblColaProcesos.TabIndex = 5;
            this.lblColaProcesos.Text = "Cola de Procesos";
            // 
            // lblNumeroProcesoColumna
            // 
            this.lblNumeroProcesoColumna.AutoSize = true;
            this.lblNumeroProcesoColumna.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroProcesoColumna.Location = new System.Drawing.Point(13, 233);
            this.lblNumeroProcesoColumna.Name = "lblNumeroProcesoColumna";
            this.lblNumeroProcesoColumna.Size = new System.Drawing.Size(29, 28);
            this.lblNumeroProcesoColumna.TabIndex = 6;
            this.lblNumeroProcesoColumna.Text = "# ";
            // 
            // lblNombreProcesoColumna
            // 
            this.lblNombreProcesoColumna.AutoSize = true;
            this.lblNombreProcesoColumna.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProcesoColumna.Location = new System.Drawing.Point(51, 233);
            this.lblNombreProcesoColumna.Name = "lblNombreProcesoColumna";
            this.lblNombreProcesoColumna.Size = new System.Drawing.Size(85, 28);
            this.lblNombreProcesoColumna.TabIndex = 7;
            this.lblNombreProcesoColumna.Text = "Nombre";
            // 
            // lblDuracionProcesoColumna
            // 
            this.lblDuracionProcesoColumna.AutoSize = true;
            this.lblDuracionProcesoColumna.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracionProcesoColumna.Location = new System.Drawing.Point(185, 233);
            this.lblDuracionProcesoColumna.Name = "lblDuracionProcesoColumna";
            this.lblDuracionProcesoColumna.Size = new System.Drawing.Size(91, 28);
            this.lblDuracionProcesoColumna.TabIndex = 8;
            this.lblDuracionProcesoColumna.Text = "Duración";
            // 
            // lstNumeroProceso
            // 
            this.lstNumeroProceso.FormattingEnabled = true;
            this.lstNumeroProceso.ItemHeight = 15;
            this.lstNumeroProceso.Location = new System.Drawing.Point(13, 264);
            this.lstNumeroProceso.Name = "lstNumeroProceso";
            this.lstNumeroProceso.Size = new System.Drawing.Size(34, 319);
            this.lstNumeroProceso.TabIndex = 9;
            // 
            // lstNombreProceso
            // 
            this.lstNombreProceso.FormattingEnabled = true;
            this.lstNombreProceso.ItemHeight = 15;
            this.lstNombreProceso.Location = new System.Drawing.Point(51, 264);
            this.lstNombreProceso.Name = "lstNombreProceso";
            this.lstNombreProceso.Size = new System.Drawing.Size(128, 319);
            this.lstNombreProceso.TabIndex = 10;
            // 
            // lstDuracionProceso
            // 
            this.lstDuracionProceso.FormattingEnabled = true;
            this.lstDuracionProceso.ItemHeight = 15;
            this.lstDuracionProceso.Location = new System.Drawing.Point(185, 264);
            this.lstDuracionProceso.Name = "lstDuracionProceso";
            this.lstDuracionProceso.Size = new System.Drawing.Size(91, 319);
            this.lstDuracionProceso.TabIndex = 11;
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProceso.Location = new System.Drawing.Point(12, 120);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(264, 43);
            this.btnAgregarProceso.TabIndex = 12;
            this.btnAgregarProceso.Text = "Agregar";
            this.btnAgregarProceso.UseVisualStyleBackColor = true;
            this.btnAgregarProceso.Click += new System.EventHandler(this.btnAgregarProceso_Click);
            // 
            // gbxProcesos
            // 
            this.gbxProcesos.Controls.Add(this.lblProceso7);
            this.gbxProcesos.Controls.Add(this.lblProceso6);
            this.gbxProcesos.Controls.Add(this.lblProceso5);
            this.gbxProcesos.Controls.Add(this.lblProceso4);
            this.gbxProcesos.Controls.Add(this.lblProceso3);
            this.gbxProcesos.Controls.Add(this.lblProceso2);
            this.gbxProcesos.Controls.Add(this.lblProceso1);
            this.gbxProcesos.Controls.Add(this.pbr7);
            this.gbxProcesos.Controls.Add(this.pbr6);
            this.gbxProcesos.Controls.Add(this.pbr5);
            this.gbxProcesos.Controls.Add(this.pbr4);
            this.gbxProcesos.Controls.Add(this.pbr3);
            this.gbxProcesos.Controls.Add(this.pbr2);
            this.gbxProcesos.Controls.Add(this.pbr1);
            this.gbxProcesos.Controls.Add(this.btnLimpiarCola);
            this.gbxProcesos.Controls.Add(this.btnPausarProcesos);
            this.gbxProcesos.Controls.Add(this.btnIniciarProcesos);
            this.gbxProcesos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxProcesos.Location = new System.Drawing.Point(289, 9);
            this.gbxProcesos.Name = "gbxProcesos";
            this.gbxProcesos.Size = new System.Drawing.Size(951, 574);
            this.gbxProcesos.TabIndex = 13;
            this.gbxProcesos.TabStop = false;
            this.gbxProcesos.Text = "Procesos";
            // 
            // lblProceso7
            // 
            this.lblProceso7.AutoSize = true;
            this.lblProceso7.Location = new System.Drawing.Point(6, 480);
            this.lblProceso7.Name = "lblProceso7";
            this.lblProceso7.Size = new System.Drawing.Size(65, 28);
            this.lblProceso7.TabIndex = 16;
            this.lblProceso7.Text = "label7";
            this.lblProceso7.Visible = false;
            // 
            // lblProceso6
            // 
            this.lblProceso6.AutoSize = true;
            this.lblProceso6.Location = new System.Drawing.Point(6, 406);
            this.lblProceso6.Name = "lblProceso6";
            this.lblProceso6.Size = new System.Drawing.Size(65, 28);
            this.lblProceso6.TabIndex = 15;
            this.lblProceso6.Text = "label6";
            this.lblProceso6.Visible = false;
            // 
            // lblProceso5
            // 
            this.lblProceso5.AutoSize = true;
            this.lblProceso5.Location = new System.Drawing.Point(6, 330);
            this.lblProceso5.Name = "lblProceso5";
            this.lblProceso5.Size = new System.Drawing.Size(65, 28);
            this.lblProceso5.TabIndex = 14;
            this.lblProceso5.Text = "label5";
            this.lblProceso5.Visible = false;
            // 
            // lblProceso4
            // 
            this.lblProceso4.AutoSize = true;
            this.lblProceso4.Location = new System.Drawing.Point(6, 255);
            this.lblProceso4.Name = "lblProceso4";
            this.lblProceso4.Size = new System.Drawing.Size(65, 28);
            this.lblProceso4.TabIndex = 13;
            this.lblProceso4.Text = "label4";
            this.lblProceso4.Visible = false;
            // 
            // lblProceso3
            // 
            this.lblProceso3.AutoSize = true;
            this.lblProceso3.Location = new System.Drawing.Point(6, 181);
            this.lblProceso3.Name = "lblProceso3";
            this.lblProceso3.Size = new System.Drawing.Size(65, 28);
            this.lblProceso3.TabIndex = 12;
            this.lblProceso3.Text = "label3";
            this.lblProceso3.Visible = false;
            // 
            // lblProceso2
            // 
            this.lblProceso2.AutoSize = true;
            this.lblProceso2.Location = new System.Drawing.Point(6, 111);
            this.lblProceso2.Name = "lblProceso2";
            this.lblProceso2.Size = new System.Drawing.Size(65, 28);
            this.lblProceso2.TabIndex = 11;
            this.lblProceso2.Text = "label2";
            this.lblProceso2.Visible = false;
            // 
            // lblProceso1
            // 
            this.lblProceso1.AutoSize = true;
            this.lblProceso1.Location = new System.Drawing.Point(6, 36);
            this.lblProceso1.Name = "lblProceso1";
            this.lblProceso1.Size = new System.Drawing.Size(65, 28);
            this.lblProceso1.TabIndex = 10;
            this.lblProceso1.Text = "label1";
            this.lblProceso1.Visible = false;
            // 
            // pbr7
            // 
            this.pbr7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr7.Location = new System.Drawing.Point(135, 480);
            this.pbr7.Name = "pbr7";
            this.pbr7.Size = new System.Drawing.Size(810, 43);
            this.pbr7.TabIndex = 9;
            this.pbr7.Visible = false;
            // 
            // pbr6
            // 
            this.pbr6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr6.Location = new System.Drawing.Point(135, 406);
            this.pbr6.Name = "pbr6";
            this.pbr6.Size = new System.Drawing.Size(810, 43);
            this.pbr6.TabIndex = 8;
            this.pbr6.Visible = false;
            // 
            // pbr5
            // 
            this.pbr5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr5.Location = new System.Drawing.Point(135, 330);
            this.pbr5.Name = "pbr5";
            this.pbr5.Size = new System.Drawing.Size(810, 43);
            this.pbr5.TabIndex = 7;
            this.pbr5.Visible = false;
            // 
            // pbr4
            // 
            this.pbr4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr4.Location = new System.Drawing.Point(135, 255);
            this.pbr4.Name = "pbr4";
            this.pbr4.Size = new System.Drawing.Size(810, 43);
            this.pbr4.TabIndex = 6;
            this.pbr4.Visible = false;
            // 
            // pbr3
            // 
            this.pbr3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr3.Location = new System.Drawing.Point(135, 181);
            this.pbr3.Name = "pbr3";
            this.pbr3.Size = new System.Drawing.Size(810, 43);
            this.pbr3.TabIndex = 5;
            this.pbr3.Visible = false;
            // 
            // pbr2
            // 
            this.pbr2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr2.Location = new System.Drawing.Point(135, 111);
            this.pbr2.Name = "pbr2";
            this.pbr2.Size = new System.Drawing.Size(810, 43);
            this.pbr2.TabIndex = 4;
            this.pbr2.Visible = false;
            // 
            // pbr1
            // 
            this.pbr1.BackColor = System.Drawing.SystemColors.Control;
            this.pbr1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbr1.Enabled = false;
            this.pbr1.Location = new System.Drawing.Point(135, 36);
            this.pbr1.Name = "pbr1";
            this.pbr1.Size = new System.Drawing.Size(810, 43);
            this.pbr1.TabIndex = 3;
            this.pbr1.Visible = false;
            // 
            // btnLimpiarCola
            // 
            this.btnLimpiarCola.Location = new System.Drawing.Point(135, 529);
            this.btnLimpiarCola.Name = "btnLimpiarCola";
            this.btnLimpiarCola.Size = new System.Drawing.Size(169, 39);
            this.btnLimpiarCola.TabIndex = 2;
            this.btnLimpiarCola.Text = "Limpiar Cola";
            this.btnLimpiarCola.UseVisualStyleBackColor = true;
            this.btnLimpiarCola.Click += new System.EventHandler(this.btnLimpiarCola_Click);
            // 
            // btnPausarProcesos
            // 
            this.btnPausarProcesos.Location = new System.Drawing.Point(776, 529);
            this.btnPausarProcesos.Name = "btnPausarProcesos";
            this.btnPausarProcesos.Size = new System.Drawing.Size(169, 39);
            this.btnPausarProcesos.TabIndex = 1;
            this.btnPausarProcesos.Text = "Pausar Procesos";
            this.btnPausarProcesos.UseVisualStyleBackColor = true;
            this.btnPausarProcesos.Click += new System.EventHandler(this.btnPausarProcesos_Click);
            // 
            // btnIniciarProcesos
            // 
            this.btnIniciarProcesos.Location = new System.Drawing.Point(601, 529);
            this.btnIniciarProcesos.Name = "btnIniciarProcesos";
            this.btnIniciarProcesos.Size = new System.Drawing.Size(169, 39);
            this.btnIniciarProcesos.TabIndex = 0;
            this.btnIniciarProcesos.Text = "Iniciar Procesos";
            this.btnIniciarProcesos.UseVisualStyleBackColor = true;
            this.btnIniciarProcesos.Click += new System.EventHandler(this.btnIniciarProcesos_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pgrGlobal
            // 
            this.pgrGlobal.Enabled = false;
            this.pgrGlobal.Location = new System.Drawing.Point(424, 597);
            this.pgrGlobal.Name = "pgrGlobal";
            this.pgrGlobal.Size = new System.Drawing.Size(810, 43);
            this.pgrGlobal.TabIndex = 17;
            this.pgrGlobal.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(13, 597);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(120, 54);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "00:00";
            this.lblTimer.Visible = false;
            // 
            // lblGlobal
            // 
            this.lblGlobal.AutoSize = true;
            this.lblGlobal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGlobal.Location = new System.Drawing.Point(295, 597);
            this.lblGlobal.Name = "lblGlobal";
            this.lblGlobal.Size = new System.Drawing.Size(114, 28);
            this.lblGlobal.TabIndex = 17;
            this.lblGlobal.Text = "Cola Global";
            this.lblGlobal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 652);
            this.Controls.Add(this.lblGlobal);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pgrGlobal);
            this.Controls.Add(this.gbxProcesos);
            this.Controls.Add(this.btnAgregarProceso);
            this.Controls.Add(this.lstDuracionProceso);
            this.Controls.Add(this.lstNombreProceso);
            this.Controls.Add(this.lstNumeroProceso);
            this.Controls.Add(this.lblDuracionProcesoColumna);
            this.Controls.Add(this.lblNombreProcesoColumna);
            this.Controls.Add(this.lblNumeroProcesoColumna);
            this.Controls.Add(this.lblColaProcesos);
            this.Controls.Add(this.txtDuracionNuevoProceso);
            this.Controls.Add(this.txtNombreNuevoProceso);
            this.Controls.Add(this.lblDuracionNuevoProceso);
            this.Controls.Add(this.lblNombreNuevoProceso);
            this.Controls.Add(this.lblAgregarProcesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProcesos.ResumeLayout(false);
            this.gbxProcesos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAgregarProcesos;
        private Label lblNombreNuevoProceso;
        private Label lblDuracionNuevoProceso;
        private TextBox txtNombreNuevoProceso;
        private TextBox txtDuracionNuevoProceso;
        private Label lblColaProcesos;
        private Label lblNumeroProcesoColumna;
        private Label lblNombreProcesoColumna;
        private Label lblDuracionProcesoColumna;
        private ListBox lstNumeroProceso;
        private ListBox lstNombreProceso;
        private ListBox lstDuracionProceso;
        private Button btnAgregarProceso;
        private GroupBox gbxProcesos;
        private Button btnLimpiarCola;
        private Button btnPausarProcesos;
        private Button btnIniciarProcesos;
        private ProgressBar pbr7;
        private ProgressBar pbr6;
        private ProgressBar pbr5;
        private ProgressBar pbr4;
        private ProgressBar pbr3;
        private ProgressBar pbr2;
        private ProgressBar pbr1;
        private Label lblProceso7;
        private Label lblProceso6;
        private Label lblProceso5;
        private Label lblProceso4;
        private Label lblProceso3;
        private Label lblProceso2;
        private Label lblProceso1;
        private System.Windows.Forms.Timer timer;
        private ProgressBar pgrGlobal;
        private Label lblTimer;
        private Label lblGlobal;
    }
}