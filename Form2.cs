using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using JEletronicaC_.database;
using JEletronicaC_.helpers;
using JEletronicaC_.model;
using System.Drawing.Printing;

namespace JEletronicaC_
{
    public partial class Form2 : Form
    {
        HistoryModel model;

        DateTime inDateGlobal = DateTime.Now;
        DateTime outDateGlobal = DateTime.Now;
        Action<Form2> closeAction;
        Bitmap memoryImage;

        public Form2(int historyId, Action<Form2> closeAction)
        {

            InitializeComponent();

            this.closeAction = closeAction;

            this.loadHistory(historyId);

            textBox1.Text = this.model.customer;
            textBox2.Text = this.model.electronic;
            richTextBox1.Text = this.model.defect;
            numericUpDown1.Value = this.model.warrantyDays;
            dateTimePicker1.Value = this.model.inDate;

            label6.Visible = false;

            if (this.model.outDate != null)
            {
                dateTimePicker2.Value = this.model.outDate.Value;
            }

            dateTimePicker2.Visible = false;
        }


        internal void loadHistory(int historyId)
        {
            List<HistoryModel> historyList = GenericConverter
                .ConvertDataTableToHistoryModelList(DalHelper.GetHistory(historyId));

            this.model = historyList[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.inDateGlobal = ((DateTimePicker)sender).Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.outDateGlobal = ((DateTimePicker)sender).Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var historyObject = new
            {
                id = this.model.id,
                customer = textBox1.Text,
                electronic = textBox2.Text,
                defect = richTextBox1.Text,
                warrantyDays = (int)numericUpDown1.Value,
                inDate = this.inDateGlobal
            };

            DialogResult result = MessageBox.Show(
            "Você está alterando os dados desse histórico. Deseja continuar?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result == DialogResult.Yes)
            {
                if (checkBox1.Checked)
                {
                    dateTimePicker1.Value = this.outDateGlobal;
                    DalHelper.SetOutDate(this.model.id, this.outDateGlobal);
                }

                DalHelper.Update(new HistoryModel(
                        historyObject.id,
                        historyObject.customer,
                        historyObject.electronic,
                        historyObject.defect,
                        historyObject.warrantyDays,
                        historyObject.inDate
                    )
                );

                MessageBox.Show("Dados atualizados com sucesso.");
                this.closeAction(this);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ação cancelada.");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = checkBox1.Checked;
            dateTimePicker2.Visible = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (this.model.outDate.Equals(null))
            {
                MessageBox.Show("Prefira atribuir uma data de saída " +
                    "antes da geração do termo de garantia.");
            }

            DialogResult result = MessageBox.Show(
            "Você está gerando o termo de garantia. Deseja continuar?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result == DialogResult.Yes)
            {
                var termPath = FileHelper.ReadConfigFile()[1];
                var termFileName = "termo-" 
                    + this.model.customer.Replace(" ","-") 
                    + "-" 
                    + DateTime.Now.ToFileTime() 
                    + ".pdf";

                FileHelper.createFile(termPath, termFileName);
                var fullTermFilePath = System.IO.Path.Combine(termPath, termFileName);

                using (PdfWriter writer = new PdfWriter(fullTermFilePath))
                {
                    // Cria um documento PDF
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Adiciona um título
                        document.Add(new Paragraph("Termo de Garantia")
                            .SetFontSize(18)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.CENTER));

                        document.Add(new Paragraph("\n")); // Espaço em branco

                        // Adiciona informações do produto
                        document.Add(new Paragraph("Cliente: " + this.model.customer)
                            .SetFontSize(12));
                        document.Add(new Paragraph("Eletronico:" + this.model.electronic)
                            .SetFontSize(12));
                        document.Add(new Paragraph("Entrada: " + this.model.inDate + "\n" +
                                                    " Saída: " + this.model.outDate)
                            .SetFontSize(12));

                        document.Add(new Paragraph("Defeito: \n" + this.model.defect)
                            .SetFontSize(12));

                        document.Add(new Paragraph("\n")); // Espaço em branco

                        // Adiciona seções do termo de garantia
                        document.Add(new Paragraph("1. GARANTIA")
                            .SetFontSize(14)
                            .SetBold());

                        document.Add(new Paragraph("A presente garantia (até " + DateTime.Now.AddDays(this.model.warrantyDays).ToString("dd/MM/yyyy") + ") cobre defeitos de componentes, desde que o produto tenha sido utilizado de acordo com as instruções fornecidas no momento da retirada.")
                            .SetFontSize(12));

                        document.Add(new Paragraph("\n")); // Espaço em branco

                        document.Add(new Paragraph("2. EXCLUSÕES")
                            .SetFontSize(14)
                            .SetBold());

                        document.Add(new Paragraph("Esta garantia não cobre danos causados por acidentes, uso inadequado ou modificações não autorizadas no produto.")
                            .SetFontSize(12));

                        document.Add(new Paragraph("\n")); // Espaço em branco

                        document.Add(new Paragraph("3. CONTATO")
                            .SetFontSize(14)
                            .SetBold());

                        document.Add(new Paragraph("Para mais informações, entre em contato comigo pelo whatsapp (81) 9 9225-6702.")
                            .SetFontSize(12));

                        document.Add(new Paragraph("\n")); // Espaço em branco

                        document.Add(new Paragraph("_______________________________________________\n Assinatura")
                           .SetFontSize(10)
                           .SetTextAlignment(TextAlignment.CENTER)
                           .SetMarginTop(20));


                        // Adiciona um rodapé
                        document.Add(new Paragraph("Timbaúba - PE, Brasil\n" +
                            DateTime.Now.ToShortDateString())
                            .SetFontSize(10)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetMarginTop(20));

                        document.Close();
                    }
                }
                //WebBrowser webBrowser = new WebBrowser();
                //webBrowser.Navigate(String.Format(@"file://" + fullTermFilePath), Application.StartupPath);
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo(
                        fullTermFilePath)
                    { UseShellExecute = true});
                this.closeAction(this);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ação cancelada.");
            }

        }

        private void PrintDocument1_PrintPage(
           System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            "Você realmente deseja excluir esse histórico?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result == DialogResult.Yes)
            {
                DalHelper.Delete(this.model.id);
                MessageBox.Show("Histórico excluido com sucesso.");
                this.closeAction(this);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ação cancelada.");
            }

           
        }
    }
}
