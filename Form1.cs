using JEletronicaC_.database;
using JEletronicaC_.helpers;

namespace JEletronicaC_
{
    public partial class Form1 : Form
    {

        private BindingSource bindingSource1 = new BindingSource();

        DateTime inDateGlobal = DateTime.Now;
        DateTime outDateGlobal = DateTime.Now;

        public Form1()
        {

            InitializeComponent();

            if (FileHelper.ReadConfigFile() == null) {
                MessageBox.Show("Faça as configurações iniciais!\n" +
                    "Clique no ícone de engreagem no canto superior direito " +
                    "e execute as configurações informadas.", "Bem vindo!");

                
            }


            dateTimePicker1 = new DateTimePicker();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["acoes"].Index)
            {

                int selectedHistoryId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

                Form2 frm = new Form2(selectedHistoryId, (frm) =>
                {
                    frm.Close();
                    getHistoryData();
                    dataGridView1.Refresh();
                });
                frm.ShowDialog(this);
                frm.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (FileHelper.ReadConfigFile() != null)
            {
                DalHelper.CriarBancoSQLite();
                DalHelper.CriarTabelaSQlite();
               
                dataGridView1.DataSource = bindingSource1;
                getHistoryData();
            }
        }

        private void getHistoryData()
        {
            bindingSource1.DataSource = DalHelper.GetHistorys();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.inDateGlobal = ((DateTimePicker)sender).Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var historyObject = new
            {
                customer = textBox1.Text,
                electronic = textBox2.Text,
                defect = richTextBox1.Text,
                warrantyDays = (int)numericUpDown1.Value,
                inDate = this.inDateGlobal,
                outDate = this.outDateGlobal
            };

            DalHelper.Add(new model.HistoryModel(
                historyObject.customer,
                historyObject.electronic,
                historyObject.defect,
                historyObject.warrantyDays,
                historyObject.inDate,
                historyObject.outDate
                )
            );

            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            numericUpDown1.Value = 90;
            dateTimePicker1.Value = DateTime.Now;
            inDateGlobal = DateTime.Now;

            getHistoryData();
            dataGridView1.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3.Dispose();
        }
    }
}
