namespace proyecto2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ltsResultados = new ListBox();
            numericUpDown2 = new NumericUpDown();
            label14 = new Label();
            button4 = new Button();
            Tbntnivel1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Huesped:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Noches:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(80, 58);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 117);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Tarifa/noche(USB)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(184, 175);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(190, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Temporada Alta (+25%)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(184, 242);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(320, 242);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 524);
            button3.Name = "button3";
            button3.Size = new Size(411, 29);
            button3.TabIndex = 10;
            button3.Text = "Copiar para  Whatsapp\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // ltsResultados
            // 
            ltsResultados.FormattingEnabled = true;
            ltsResultados.Location = new Point(503, 197);
            ltsResultados.Name = "ltsResultados";
            ltsResultados.Size = new Size(161, 324);
            ltsResultados.TabIndex = 11;
            ltsResultados.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Location = new Point(613, 13);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(503, 15);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 13;
            label14.Text = "Tasa del dólar:";
            label14.Click += label14_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(632, 60);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Total en RD$";
            button4.UseVisualStyleBackColor = true;
            // 
            // Tbntnivel1
            // 
            Tbntnivel1.Location = new Point(12, 197);
            Tbntnivel1.Name = "Tbntnivel1";
            Tbntnivel1.Size = new Size(94, 29);
            Tbntnivel1.TabIndex = 18;
            Tbntnivel1.Text = "nivel1";
            Tbntnivel1.UseVisualStyleBackColor = true;
            Tbntnivel1.Click += Tbntnivel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 565);
            Controls.Add(Tbntnivel1);
            Controls.Add(button4);
            Controls.Add(label14);
            Controls.Add(numericUpDown2);
            Controls.Add(ltsResultados);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cotizador villa Coral - WilyEmiliano: 2026-0421";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox ltsResultados;
        private NumericUpDown numericUpDown2;
        private Label label14;
        private Button button4;
        private Button Tbntnivel1;
    }
}
