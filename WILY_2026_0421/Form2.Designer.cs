namespace WILY_2026_0421
{
    partial class Form2
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
            lstResultados = new ListBox();
            btnNivel1 = new Button();
            button1 = new Button();
            btnPesos = new Button();
            nudTasa = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            nudPersonas = new NumericUpDown();
            nudNoches = new NumericUpDown();
            chkFinSemana = new CheckBox();
            txtHuesped = new TextBox();
            BtnPorPersona = new Button();
            Huesped = new Label();
            Noches = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFinSemana = new Button();
            btnDeposito = new Button();
            btnDesglose = new Button();
            btnCuentaTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            SuspendLayout();
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(0, 292);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(802, 164);
            lstResultados.TabIndex = 0;
            lstResultados.SelectedIndexChanged += ltsResultados_SelectedIndexChanged;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(12, 95);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 1;
            btnNivel1.Text = "Nivel1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(533, 51);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(137, 95);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(102, 29);
            btnPesos.TabIndex = 3;
            btnPesos.Text = "Total En RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(86, 162);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(92, 27);
            nudTasa.TabIndex = 4;
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(662, 7);
            nudTarifa.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(92, 27);
            nudTarifa.TabIndex = 5;
            nudTarifa.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudTarifa.ValueChanged += nudTarifa_ValueChanged;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(319, 167);
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(92, 27);
            nudPersonas.TabIndex = 6;
            nudPersonas.ValueChanged += nudPersonas_ValueChanged;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(449, 7);
            nudNoches.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(92, 27);
            nudNoches.TabIndex = 7;
            nudNoches.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nudNoches.ValueChanged += nudNoches_ValueChanged;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(435, 150);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(166, 24);
            chkFinSemana.TabIndex = 8;
            chkFinSemana.Text = "Fin de Semana+15%";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(86, 6);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(256, 27);
            txtHuesped.TabIndex = 9;
            txtHuesped.TextChanged += txtHuesped_TextChanged;
            // 
            // BtnPorPersona
            // 
            BtnPorPersona.Location = new Point(272, 95);
            BtnPorPersona.Name = "BtnPorPersona";
            BtnPorPersona.Size = new Size(103, 29);
            BtnPorPersona.TabIndex = 11;
            BtnPorPersona.Text = "por persona";
            BtnPorPersona.UseVisualStyleBackColor = true;
            BtnPorPersona.Click += BtnPorPersona_Click;
            // 
            // Huesped
            // 
            Huesped.AutoSize = true;
            Huesped.Location = new Point(12, 9);
            Huesped.Name = "Huesped";
            Huesped.Size = new Size(68, 20);
            Huesped.TabIndex = 12;
            Huesped.Text = "Huesped";
            // 
            // Noches
            // 
            Noches.AutoSize = true;
            Noches.Location = new Point(388, 9);
            Noches.Name = "Noches";
            Noches.Size = new Size(55, 20);
            Noches.TabIndex = 13;
            Noches.Text = "noches";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "Tarifa US$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 164);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 15;
            label2.Text = "Tasa RD$";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 169);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 16;
            label3.Text = "Personas";
            label3.Click += label3_Click;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(560, 95);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(126, 29);
            btnFinSemana.TabIndex = 17;
            btnFinSemana.Text = "Fin de semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(408, 95);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(133, 29);
            btnDeposito.TabIndex = 18;
            btnDeposito.Text = "Deposito y saldo ";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(701, 95);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(94, 29);
            btnDesglose.TabIndex = 21;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(542, 209);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(189, 29);
            btnCuentaTotal.TabIndex = 22;
            btnCuentaTotal.Text = "Cuenta  Total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCuentaTotal);
            Controls.Add(btnDesglose);
            Controls.Add(btnDeposito);
            Controls.Add(btnFinSemana);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Noches);
            Controls.Add(Huesped);
            Controls.Add(BtnPorPersona);
            Controls.Add(txtHuesped);
            Controls.Add(chkFinSemana);
            Controls.Add(nudNoches);
            Controls.Add(nudPersonas);
            Controls.Add(nudTarifa);
            Controls.Add(nudTasa);
            Controls.Add(btnPesos);
            Controls.Add(button1);
            Controls.Add(btnNivel1);
            Controls.Add(lstResultados);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResultados;
        private Button btnNivel1;
        private Button button1;
        private Button btnPesos;
        private NumericUpDown nudTasa;
        private NumericUpDown nudTarifa;
        private NumericUpDown nudPersonas;
        private NumericUpDown nudNoches;
        private CheckBox chkFinSemana;
        private TextBox txtHuesped;
        private Button BtnPorPersona;
        private Label Huesped;
        private Label Noches;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFinSemana;
        private Button btnDeposito;
        private Button btnDesglose;
        private Button btnCuentaTotal;
    }
}