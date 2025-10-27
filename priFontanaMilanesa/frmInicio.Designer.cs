namespace priFontanaMilanesa
{
    partial class frmInicio
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
            dgvEmpleados = new DataGridView();
            clEmpleados = new DataGridViewTextBoxColumn();
            clComidas = new DataGridViewTextBoxColumn();
            clBebidasSH = new DataGridViewTextBoxColumn();
            clBebicasCH = new DataGridViewTextBoxColumn();
            clPostres = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDia = new Button();
            btnTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { clEmpleados, clComidas, clBebidasSH, clBebicasCH, clPostres });
            dgvEmpleados.Location = new Point(43, 76);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(544, 154);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // clEmpleados
            // 
            clEmpleados.Frozen = true;
            clEmpleados.HeaderText = "Empleados";
            clEmpleados.Name = "clEmpleados";
            clEmpleados.ReadOnly = true;
            // 
            // clComidas
            // 
            clComidas.Frozen = true;
            clComidas.HeaderText = "Comidas";
            clComidas.Name = "clComidas";
            // 
            // clBebidasSH
            // 
            clBebidasSH.Frozen = true;
            clBebidasSH.HeaderText = "Bebidas S/H";
            clBebidasSH.Name = "clBebidasSH";
            // 
            // clBebicasCH
            // 
            clBebicasCH.Frozen = true;
            clBebicasCH.HeaderText = "Bebidas C/H";
            clBebicasCH.Name = "clBebicasCH";
            // 
            // clPostres
            // 
            clPostres.Frozen = true;
            clPostres.HeaderText = "Postres";
            clPostres.Name = "clPostres";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(479, 373);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(108, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDia
            // 
            btnMozoDia.Enabled = false;
            btnMozoDia.Location = new Point(283, 373);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(105, 23);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del Día";
            btnMozoDia.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            btnTotal.Enabled = false;
            btnTotal.Location = new Point(43, 373);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(108, 23);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 475);
            Controls.Add(btnTotal);
            Controls.Add(btnMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvEmpleados);
            Name = "frmInicio";
            Text = "Form1";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn clEmpleados;
        private DataGridViewTextBoxColumn clComidas;
        private DataGridViewTextBoxColumn clBebidasSH;
        private DataGridViewTextBoxColumn clBebicasCH;
        private DataGridViewTextBoxColumn clPostres;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotal;
    }
}
