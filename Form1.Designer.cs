namespace JEletronicaC_
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
            DateTimePicker dateTimePicker1;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            electronic = new DataGridViewTextBoxColumn();
            defect = new DataGridViewTextBoxColumn();
            warranty_days = new DataGridViewTextBoxColumn();
            in_date = new DataGridViewTextBoxColumn();
            out_date = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            create_at_full = new DataGridViewTextBoxColumn();
            acoes = new DataGridViewImageColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            button1 = new Button();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(943, 195);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 26);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2024, 8, 16, 22, 53, 1, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, customer, electronic, defect, warranty_days, in_date, out_date, created_at, create_at_full, acoes });
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(928, 368);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 42;
            // 
            // customer
            // 
            customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer.DataPropertyName = "customer";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customer.DefaultCellStyle = dataGridViewCellStyle2;
            customer.HeaderText = "Cliente";
            customer.MinimumWidth = 8;
            customer.Name = "customer";
            // 
            // electronic
            // 
            electronic.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            electronic.DataPropertyName = "electronic";
            electronic.HeaderText = "Eletrônico";
            electronic.MinimumWidth = 8;
            electronic.Name = "electronic";
            // 
            // defect
            // 
            defect.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            defect.DataPropertyName = "defect";
            defect.HeaderText = "Defeito";
            defect.MinimumWidth = 8;
            defect.Name = "defect";
            // 
            // warranty_days
            // 
            warranty_days.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            warranty_days.DataPropertyName = "warranty_days";
            warranty_days.HeaderText = "Garantia";
            warranty_days.MaxInputLength = 3;
            warranty_days.MinimumWidth = 6;
            warranty_days.Name = "warranty_days";
            warranty_days.Resizable = DataGridViewTriState.False;
            warranty_days.Width = 76;
            // 
            // in_date
            // 
            in_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            in_date.DataPropertyName = "in_date";
            in_date.HeaderText = "Entrada";
            in_date.MinimumWidth = 6;
            in_date.Name = "in_date";
            in_date.Width = 72;
            // 
            // out_date
            // 
            out_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            out_date.DataPropertyName = "out_date";
            out_date.HeaderText = "Saída";
            out_date.MinimumWidth = 6;
            out_date.Name = "out_date";
            out_date.Width = 60;
            // 
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Criado em";
            created_at.MinimumWidth = 6;
            created_at.Name = "created_at";
            created_at.Width = 87;
            // 
            // create_at_full
            // 
            create_at_full.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            create_at_full.DataPropertyName = "created_at_full";
            create_at_full.HeaderText = "create_at_full";
            create_at_full.MinimumWidth = 6;
            create_at_full.Name = "create_at_full";
            create_at_full.Visible = false;
            // 
            // acoes
            // 
            acoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            acoes.HeaderText = "Ações";
            acoes.Image = Properties.Resources.gear;
            acoes.MinimumWidth = 6;
            acoes.Name = "acoes";
            acoes.Resizable = DataGridViewTriState.False;
            acoes.SortMode = DataGridViewColumnSortMode.Automatic;
            acoes.Width = 64;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(943, 93);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 29);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(943, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(943, 121);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Eletrônico";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(943, 144);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 29);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(943, 238);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 7;
            label4.Text = "Defeito";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(943, 261);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(288, 64);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(940, 172);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 11;
            label5.Text = "Entrada";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(943, 342);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(287, 36);
            button1.TabIndex = 13;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1155, 121);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 14;
            label7.Text = "Garantia";
            label7.Click += label7_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(1155, 144);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 29);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.gear;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1188, 10);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(43, 32);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1001, 10);
            label1.Name = "label1";
            label1.Size = new Size(166, 34);
            label1.TabIndex = 17;
            label1.Text = "JEletrônica";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 385);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "JEletrônica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button1;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private DataGridViewImageColumn check_out;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn electronic;
        private DataGridViewTextBoxColumn defect;
        private DataGridViewTextBoxColumn warranty_days;
        private DataGridViewTextBoxColumn in_date;
        private DataGridViewTextBoxColumn out_date;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn create_at_full;
        private DataGridViewImageColumn acoes;
        private Button button2;
        private Label label1;
    }
}
