namespace Ejercicio2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String momento, mensaje = "";

            if (comboBox1.SelectedItem != null)
            {
                momento = comboBox1.SelectedItem.ToString();
                switch (momento)
                {
                    case "Mañana":
                        mensaje = "Buenos días";
                        BackColor = Color.LightBlue;
                        break;

                    case "Tarde":
                        mensaje = "Buenas tardes";
                        BackColor = Color.Coral;
                        break;

                    case "Noche":
                        mensaje = "Buenas noches";
                        BackColor = Color.MediumPurple;
                        break;

                    default:
                        mensaje = "Buenas..";
                        BackColor = Color.LightGray;
                        break;
                }
            }
            else
            {
                mensaje = "Buenas..";
                BackColor = Color.White;
            }
            string titulo = ", ";
            if (rButtonSr.Checked == true)
            {
                titulo = titulo + "Sr. ";
            } else if (rButtonSra.Checked == true)
            {
                titulo = titulo + "Sra. ";
            } else if (rButtonSrta.Checked == true)
            {
                titulo = titulo + "Srta. ";
            }

            label1.Text = mensaje + titulo + textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
