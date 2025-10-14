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
    }
}
