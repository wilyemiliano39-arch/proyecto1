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
            ltsResultados = new ListBox();
            btnNivel1 = new Button();
            SuspendLayout();
            // 
            // ltsResultados
            // 
            ltsResultados.FormattingEnabled = true;
            ltsResultados.Location = new Point(185, 127);
            ltsResultados.Name = "ltsResultados";
            ltsResultados.Size = new Size(150, 104);
            ltsResultados.TabIndex = 0;
            ltsResultados.SelectedIndexChanged += ltsResultados_SelectedIndexChanged;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(481, 97);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 1;
            btnNivel1.Text = "Nivel1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNivel1);
            Controls.Add(ltsResultados);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ltsResultados;
        private Button btnNivel1;
    }
}