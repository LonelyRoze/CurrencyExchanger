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
            adminButton = new Button();
            idTextBox = new TextBox();
            label5 = new Label();
            dbButton = new Button();
            chechSum = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(317, 291);
            button1.Name = "button1";
            button1.Size = new Size(146, 64);
            button1.TabIndex = 0;
            button1.Text = "Транзакция";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 64);
            label1.Name = "label1";
            label1.Size = new Size(38, 30);
            label1.TabIndex = 1;
            label1.Text = "Из";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(536, 64);
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
            listBox1.Location = new Point(109, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 124);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Items.AddRange(new object[] { "KZT", "RUB", "EUR", "USD" });
            listBox2.Location = new Point(536, 97);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 124);
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
            // adminButton
            // 
            adminButton.Location = new Point(12, 62);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 45);
            adminButton.TabIndex = 11;
            adminButton.Text = "Админ панель";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += button2_Click;
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
            // dbButton
            // 
            dbButton.Location = new Point(12, 12);
            dbButton.Name = "dbButton";
            dbButton.Size = new Size(75, 45);
            dbButton.TabIndex = 14;
            dbButton.Text = "Открыть БД";
            dbButton.UseVisualStyleBackColor = true;
            dbButton.Click += dbButton_Click_1;
            // 
            // chechSum
            // 
            chechSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chechSum.Location = new Point(317, 361);
            chechSum.Name = "chechSum";
            chechSum.Size = new Size(146, 41);
            chechSum.TabIndex = 15;
            chechSum.Text = "Проверить сумму";
            chechSum.UseVisualStyleBackColor = true;
            chechSum.Click += chechSum_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 351);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 376);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 402);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 354);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 19;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(129, 376);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 20;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 403);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 21;
            label11.Text = "label11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(chechSum);
            Controls.Add(dbButton);
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
            Controls.Add(adminButton);
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
        private Button adminButton;
        private TextBox idTextBox;
        private Label label5;
        private Button dbButton;
        private Button chechSum;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}