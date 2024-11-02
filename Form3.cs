using JEletronicaC_.helpers;

namespace JEletronicaC_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            List<string>? configs = FileHelper.ReadConfigFile();

            if (configs != null)
            {
                textBox1.Text = configs[0];
                textBox2.Text = configs[1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            textBox2.Text = folderBrowserDialog2.SelectedPath;
            folderBrowserDialog2.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string path1 = textBox1.Text;
            string path2 = textBox2.Text;

            if (path1 == "" || path2 == "") {
                MessageBox.Show("Informe um local para cada configuração");
                return;
            }

            FileHelper.writeToConfigFile(
                path1 + ";" + path2
                );
            MessageBox.Show("Configurações salvas com sucesso! \n" +
                "A aplicação será reiniciada.");
            this.Close();
            Application.Restart();
        }
    }
}
