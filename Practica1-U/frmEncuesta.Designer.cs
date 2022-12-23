namespace Practica1_U
{
    partial class frmEncuesta
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
            this.chk_perro = new System.Windows.Forms.CheckBox();
            this.chk_canguro = new System.Windows.Forms.CheckBox();
            this.chk_pez = new System.Windows.Forms.CheckBox();
            this.chk_paloma = new System.Windows.Forms.CheckBox();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.txb_mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chk_perro
            // 
            this.chk_perro.AutoSize = true;
            this.chk_perro.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_perro.Location = new System.Drawing.Point(77, 63);
            this.chk_perro.Name = "chk_perro";
            this.chk_perro.Size = new System.Drawing.Size(99, 31);
            this.chk_perro.TabIndex = 0;
            this.chk_perro.Text = "PERRO";
            this.chk_perro.UseVisualStyleBackColor = true;
            // 
            // chk_canguro
            // 
            this.chk_canguro.AutoSize = true;
            this.chk_canguro.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_canguro.Location = new System.Drawing.Point(77, 116);
            this.chk_canguro.Name = "chk_canguro";
            this.chk_canguro.Size = new System.Drawing.Size(125, 31);
            this.chk_canguro.TabIndex = 1;
            this.chk_canguro.Text = "CANGURO";
            this.chk_canguro.UseVisualStyleBackColor = true;
            // 
            // chk_pez
            // 
            this.chk_pez.AutoSize = true;
            this.chk_pez.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_pez.Location = new System.Drawing.Point(77, 169);
            this.chk_pez.Name = "chk_pez";
            this.chk_pez.Size = new System.Drawing.Size(73, 31);
            this.chk_pez.TabIndex = 2;
            this.chk_pez.Text = "PEZ";
            this.chk_pez.UseVisualStyleBackColor = true;
            // 
            // chk_paloma
            // 
            this.chk_paloma.AutoSize = true;
            this.chk_paloma.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_paloma.Location = new System.Drawing.Point(77, 219);
            this.chk_paloma.Name = "chk_paloma";
            this.chk_paloma.Size = new System.Drawing.Size(112, 31);
            this.chk_paloma.TabIndex = 3;
            this.chk_paloma.Text = "PALOMA";
            this.chk_paloma.UseVisualStyleBackColor = true;
            // 
            // btn_procesar
            // 
            this.btn_procesar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_procesar.Location = new System.Drawing.Point(77, 315);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(167, 79);
            this.btn_procesar.TabIndex = 4;
            this.btn_procesar.Text = "PROCESAR";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // txb_mostrar
            // 
            this.txb_mostrar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_mostrar.Location = new System.Drawing.Point(366, 47);
            this.txb_mostrar.Multiline = true;
            this.txb_mostrar.Name = "txb_mostrar";
            this.txb_mostrar.ReadOnly = true;
            this.txb_mostrar.Size = new System.Drawing.Size(376, 213);
            this.txb_mostrar.TabIndex = 5;
            // 
            // frmEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_mostrar);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.chk_paloma);
            this.Controls.Add(this.chk_pez);
            this.Controls.Add(this.chk_canguro);
            this.Controls.Add(this.chk_perro);
            this.MaximizeBox = false;
            this.Name = "frmEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENCUESTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chk_perro;
        private CheckBox chk_canguro;
        private CheckBox chk_pez;
        private CheckBox chk_paloma;
        private Button btn_procesar;
        private TextBox txb_mostrar;
    }
}