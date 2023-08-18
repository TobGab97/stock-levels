namespace stock_levels
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            button_add = new Button();
            textBox_column = new TextBox();
            textBox_row = new TextBox();
            textBox_quantity = new TextBox();
            textBox_serial_nr = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            button_search = new Button();
            label10 = new Label();
            textBox_column_search = new TextBox();
            textBox_row_search = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox_serial_nr_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(778, 297);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(textBox_column);
            panel1.Controls.Add(textBox_row);
            panel1.Controls.Add(textBox_quantity);
            panel1.Controls.Add(textBox_serial_nr);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 248);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(222, 0, 87);
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(111, 10);
            label5.Name = "label5";
            label5.Size = new Size(113, 22);
            label5.TabIndex = 9;
            label5.Text = "Add to stock";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Right;
            button_add.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_add.Location = new Point(253, 186);
            button_add.Name = "button_add";
            button_add.Size = new Size(113, 27);
            button_add.TabIndex = 8;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            // 
            // textBox_column
            // 
            textBox_column.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_column.Location = new Point(111, 190);
            textBox_column.Name = "textBox_column";
            textBox_column.Size = new Size(114, 23);
            textBox_column.TabIndex = 7;
            // 
            // textBox_row
            // 
            textBox_row.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_row.Location = new Point(111, 140);
            textBox_row.Name = "textBox_row";
            textBox_row.Size = new Size(114, 23);
            textBox_row.TabIndex = 6;
            // 
            // textBox_quantity
            // 
            textBox_quantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_quantity.Location = new Point(111, 90);
            textBox_quantity.Name = "textBox_quantity";
            textBox_quantity.Size = new Size(114, 23);
            textBox_quantity.TabIndex = 5;
            // 
            // textBox_serial_nr
            // 
            textBox_serial_nr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_serial_nr.Location = new Point(111, 40);
            textBox_serial_nr.Name = "textBox_serial_nr";
            textBox_serial_nr.Size = new Size(114, 23);
            textBox_serial_nr.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 3;
            label4.Text = "Column";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 2;
            label3.Text = "Row";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 0;
            label1.Text = "Serial nr";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button_search);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox_column_search);
            panel2.Controls.Add(textBox_row_search);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox_serial_nr_search);
            panel2.Location = new Point(391, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 248);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(222, 0, 87);
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(111, 10);
            label6.Name = "label6";
            label6.Size = new Size(136, 22);
            label6.TabIndex = 19;
            label6.Text = "Search in stock";
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Right;
            button_search.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_search.Location = new Point(258, 186);
            button_search.Name = "button_search";
            button_search.Size = new Size(113, 27);
            button_search.TabIndex = 18;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(20, 40);
            label10.Name = "label10";
            label10.Size = new Size(59, 19);
            label10.TabIndex = 10;
            label10.Text = "Serial nr";
            // 
            // textBox_column_search
            // 
            textBox_column_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_column_search.Location = new Point(111, 137);
            textBox_column_search.Name = "textBox_column_search";
            textBox_column_search.Size = new Size(119, 23);
            textBox_column_search.TabIndex = 17;
            // 
            // textBox_row_search
            // 
            textBox_row_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_row_search.Location = new Point(111, 87);
            textBox_row_search.Name = "textBox_row_search";
            textBox_row_search.Size = new Size(119, 23);
            textBox_row_search.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(20, 87);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 12;
            label8.Text = "Row";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 137);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 13;
            label7.Text = "Column";
            // 
            // textBox_serial_nr_search
            // 
            textBox_serial_nr_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_serial_nr_search.Location = new Point(111, 40);
            textBox_serial_nr_search.Name = "textBox_serial_nr_search";
            textBox_serial_nr_search.Size = new Size(119, 23);
            textBox_serial_nr_search.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Stock Levels";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_row;
        private TextBox textBox_quantity;
        private TextBox textBox_serial_nr;
        private TextBox textBox_column;
        private Label label5;
        private Button button_add;
        private Panel panel2;
        private Label label6;
        private Button button_search;
        private Label label10;
        private TextBox textBox_column_search;
        private TextBox textBox_row_search;
        private Label label8;
        private Label label7;
        private TextBox textBox_serial_nr_search;
    }
}