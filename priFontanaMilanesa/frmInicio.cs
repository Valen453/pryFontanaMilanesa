namespace priFontanaMilanesa
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public string[,] matEmpleados = new string[5, 4];
        int indice = 0;


        private void frmInicio_Load(object sender, EventArgs e)
        {
            matEmpleados[0, 0] = "Julio";
            matEmpleados[1, 0] = "Esteban";
            matEmpleados[2, 0] = "Javier";
            matEmpleados[3, 0] = "Gonzalo";
            matEmpleados[4, 0] = "Alberto";

            for (int f = 0; f < matEmpleados.GetLength(0); f++)
            {
                dgvEmpleados.Rows.Add(matEmpleados[f, 0]);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            var check = false;
            for (int f = 0; f < matEmpleados.GetLength(0); f++)
            {
                for (int c = 1; c < matEmpleados.GetLength(1); c++)
                {
                    if (check == false)
                    {
                        try
                        {
                            Convert.ToDecimal(dgvEmpleados.Rows[f].Cells[c].Value);
                        }
                        catch (Exception)
                        {
                            check = true;
                        }
                    }

                }

            }
            if (check == false)
            {
                btnTotal.Enabled = true;
                btnMozoDia.Enabled = true;
            }
            else
            {
                btnTotal.Enabled = false;
                btnMozoDia.Enabled = false;
                MessageBox.Show("Solo se permiten valores numericos en la tabla");
            }

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTotal.Enabled = false;
            btnMozoDia.Enabled = false;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTotal.Enabled = false;
            btnMozoDia.Enabled = false;
        }
    }
}
