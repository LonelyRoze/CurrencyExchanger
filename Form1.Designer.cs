namespace CurrencyExchanger
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            idTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(317, 327);
            button1.Name = "button1";
            button1.Size = new Size(146, 64);
            button1.TabIndex = 0;
            button1.Text = "Обмен";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 97);
            label1.Name = "label1";
            label1.Size = new Size(38, 30);
            label1.TabIndex = 1;
            label1.Text = "Из";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(536, 97);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 2;
            label2.Text = "В";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "KZT", "RUB", "EUR", "USD" });
            listBox1.Location = new Point(109, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Items.AddRange(new object[] { "KZT", "RUB", "EUR", "USD" });
            listBox2.Location = new Point(536, 130);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 242);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 9;
            label3.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(536, 266);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 10;
            label4.Text = "label";
            // 
            // button2
            // 
            button2.Location = new Point(0, 12);
            button2.Name = "button2";
            button2.Size = new Size(10, 23);
            button2.TabIndex = 11;
            button2.Text = "Админ панель";
            button2.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(317, 73);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(146, 23);
            idTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(317, 40);
            label5.Name = "label5";
            label5.Size = new Size(142, 30);
            label5.TabIndex = 13;
            label5.Text = "ИИН клиента";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(idTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "CurrencyExcanger";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox idTextBox;
        private Label label5;
    }
}