namespace SistemaERP.Telas
{
    partial class Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Primeiro nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 107);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Ultimo nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 23);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 168);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 264);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 6;
            label4.Text = "Data de nascimento";
            // 
            // button1
            // 
            button1.Location = new Point(171, 220);
            button1.Name = "button1";
            button1.Size = new Size(131, 59);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(327, 288);
            monthCalendar1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 9;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrar";
            Text = "Cadastro de usuario";
            FormClosed += Registrar_FormClosed;
            Load += Registrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button1;
        private MonthCalendar monthCalendar1;
    }
}