namespace Practica1_U
{
    partial class PrimerFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerFormulario));
            this.grb_manager = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.grb_botonesPpales = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lst_manager = new System.Windows.Forms.ListBox();
            this.grb_manager.SuspendLayout();
            this.grb_botonesPpales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_manager
            // 
            this.grb_manager.Controls.Add(this.btn_save);
            this.grb_manager.Controls.Add(this.btn_cancel);
            this.grb_manager.Controls.Add(this.txb_descripcion);
            this.grb_manager.Controls.Add(this.lbl_Descripcion);
            this.grb_manager.Controls.Add(this.txb_codigo);
            this.grb_manager.Controls.Add(this.lbl_Codigo);
            this.grb_manager.Enabled = false;
            this.grb_manager.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grb_manager.Location = new System.Drawing.Point(37, 128);
            this.grb_manager.Name = "grb_manager";
            this.grb_manager.Size = new System.Drawing.Size(641, 458);
            this.grb_manager.TabIndex = 8;
            this.grb_manager.TabStop = false;
            this.grb_manager.Text = "Manager";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(422, 295);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 38);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(190, 295);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 38);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_descripcion.Location = new System.Drawing.Point(190, 142);
            this.txb_descripcion.MaxLength = 45;
            this.txb_descripcion.Multiline = true;
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(425, 69);
            this.txb_descripcion.TabIndex = 12;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descripcion.Location = new System.Drawing.Point(52, 145);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(112, 24);
            this.lbl_Descripcion.TabIndex = 14;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_codigo.Location = new System.Drawing.Point(190, 69);
            this.txb_codigo.MaxLength = 5;
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.Size = new System.Drawing.Size(160, 32);
            this.txb_codigo.TabIndex = 11;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(52, 72);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(71, 24);
            this.lbl_Codigo.TabIndex = 13;
            this.lbl_Codigo.Text = "Código";
            // 
            // grb_botonesPpales
            // 
            this.grb_botonesPpales.Controls.Add(this.btnNuevo);
            this.grb_botonesPpales.Controls.Add(this.btnSalir);
            this.grb_botonesPpales.Controls.Add(this.btnReporte);
            this.grb_botonesPpales.Controls.Add(this.btnEliminar);
            this.grb_botonesPpales.Controls.Add(this.btnActualizar);
            this.grb_botonesPpales.Location = new System.Drawing.Point(37, 636);
            this.grb_botonesPpales.Name = "grb_botonesPpales";
            this.grb_botonesPpales.Size = new System.Drawing.Size(1213, 221);
            this.grb_botonesPpales.TabIndex = 9;
            this.grb_botonesPpales.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(36, 34);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 140);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1017, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 140);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Control;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(620, 34);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(160, 140);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(425, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 140);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(228, 34);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 140);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lst_manager
            // 
            this.lst_manager.Enabled = false;
            this.lst_manager.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_manager.FormattingEnabled = true;
            this.lst_manager.ItemHeight = 24;
            this.lst_manager.Location = new System.Drawing.Point(715, 128);
            this.lst_manager.Name = "lst_manager";
            this.lst_manager.Size = new System.Drawing.Size(535, 460);
            this.lst_manager.TabIndex = 10;
            this.lst_manager.Visible = false;
            this.lst_manager.Click += new System.EventHandler(this.lst_manager_Click);
            // 
            // PrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.lst_manager);
            this.Controls.Add(this.grb_botonesPpales);
            this.Controls.Add(this.grb_manager);
            this.MaximizeBox = false;
            this.Name = "PrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimerFormulario";
            this.grb_manager.ResumeLayout(false);
            this.grb_manager.PerformLayout();
            this.grb_botonesPpales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grb_manager;
        private Button btn_save;
        private Button btn_cancel;
        private TextBox txb_descripcion;
        private Label lbl_Descripcion;
        private TextBox txb_codigo;
        private Label lbl_Codigo;
        private GroupBox grb_botonesPpales;
        private Button btnNuevo;
        private Button btnSalir;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnActualizar;
        private ListBox lst_manager;
    }
}