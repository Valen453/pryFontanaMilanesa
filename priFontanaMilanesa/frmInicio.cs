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
            decimal verificacion = 0;
            for (int f = 0; f < matEmpleados.GetLength(0); f++)
            {
                for (int c = 1; c < matEmpleados.GetLength(1) + 1; c++)
                {

                    try
                    {
                    //convertir decimal a bool

                        if (dgvEmpleados.Rows[f].Cells[c].Value != null)
                        {
                            decimal dato = Convert.ToDecimal(dgvEmpleados.Rows[f].Cells[c].Value.ToString());

                                if (dato < 0)
                                {
                                    dgvEmpleados.Rows[f].Cells[c].Value = 0;
                                }
                                else
                                {
                                    dgvEmpleados.Rows[f].Cells[c].Value = Convert.ToDecimal(dgvEmpleados.Rows[f].Cells[c].Value);
                                }
                            }
                        }
                    catch (Exception)
                     {
                            check = true;
                        dgvEmpleados.Rows[f].Cells[c].Value = 0;
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

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            decimal mejor = 0;
            string empleado = "";
            decimal[] vecSuma = new decimal[5];
            for (int c = 1; c < matEmpleados.GetLength(1) + 1; c++)
            {
                for (int f = 0; f < matEmpleados.GetLength(0); f++)
                {
                    vecSuma[f] += Convert.ToDecimal(dgvEmpleados.Rows[f].Cells[c].Value);
                }
            }

            mejor = vecSuma.Max();
            for (int i = 0; i < matEmpleados.GetLength(0); i++)
            {
                if (mejor == vecSuma[i])
                {
                    lblMejorEmpleados.Text = Convert.ToString(dgvEmpleados.Rows[i].Cells[0].Value);
                }
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal[] vecSuma = new decimal[5];
            for (int c = 1; c < matEmpleados.GetLength(1) + 1; c++)
            {
                for (int f = 0; f < matEmpleados.GetLength(0); f++)
                {
                    total += Convert.ToDecimal(dgvEmpleados.Rows[f].Cells[c].Value);
                }
            }

            lblTotal.Text = Convert.ToString(total);
        }
    }
}
