namespace ArteEmpresarialPROY
{
    partial class frmUsuarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevoconsulta = new System.Windows.Forms.Button();
            this.dgconsultausuarios = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnnuevoman = new System.Windows.Forms.Button();
            this.dgUsuarioman = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgperfiles = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnperfiles = new System.Windows.Forms.Button();
            this.btnguardarperfiles = new System.Windows.Forms.Button();
            this.txtdescpPerfil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgconsultausuarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarioman)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgperfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 537);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.btnNuevoconsulta);
            this.tabPage1.Controls.Add(this.dgconsultausuarios);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            // 
            // btnNuevoconsulta
            // 
            this.btnNuevoconsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoconsulta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoconsulta.FlatAppearance.BorderSize = 0;
            this.btnNuevoconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoconsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoconsulta.ForeColor = System.Drawing.Color.White;
            this.btnNuevoconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoconsulta.Location = new System.Drawing.Point(513, 141);
            this.btnNuevoconsulta.Name = "btnNuevoconsulta";
            this.btnNuevoconsulta.Size = new System.Drawing.Size(132, 47);
            this.btnNuevoconsulta.TabIndex = 2;
            this.btnNuevoconsulta.Text = "NUEVO";
            this.btnNuevoconsulta.UseVisualStyleBackColor = false;
            this.btnNuevoconsulta.Click += new System.EventHandler(this.btnNuevoconsulta_Click);
            // 
            // dgconsultausuarios
            // 
            this.dgconsultausuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgconsultausuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgconsultausuarios.BackgroundColor = System.Drawing.Color.Gray;
            this.dgconsultausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgconsultausuarios.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgconsultausuarios.Location = new System.Drawing.Point(96, 231);
            this.dgconsultausuarios.Name = "dgconsultausuarios";
            this.dgconsultausuarios.Size = new System.Drawing.Size(516, 150);
            this.dgconsultausuarios.TabIndex = 1;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(96, 155);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(354, 22);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnnuevoman);
            this.tabPage2.Controls.Add(this.dgUsuarioman);
            this.tabPage2.Controls.Add(this.btnguardar);
            this.tabPage2.Controls.Add(this.cmbperfil);
            this.tabPage2.Controls.Add(this.txtcontrasena);
            this.tabPage2.Controls.Add(this.txtnombreusuario);
            this.tabPage2.Controls.Add(this.txtusuario);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnnuevoman
            // 
            this.btnnuevoman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevoman.BackColor = System.Drawing.Color.ForestGreen;
            this.btnnuevoman.FlatAppearance.BorderSize = 0;
            this.btnnuevoman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevoman.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoman.ForeColor = System.Drawing.Color.White;
            this.btnnuevoman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevoman.Location = new System.Drawing.Point(521, 79);
            this.btnnuevoman.Name = "btnnuevoman";
            this.btnnuevoman.Size = new System.Drawing.Size(132, 47);
            this.btnnuevoman.TabIndex = 14;
            this.btnnuevoman.Text = "NUEVO";
            this.btnnuevoman.UseVisualStyleBackColor = false;
            this.btnnuevoman.Click += new System.EventHandler(this.btnnuevoman_Click);
            // 
            // dgUsuarioman
            // 
            this.dgUsuarioman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuarioman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuarioman.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgUsuarioman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarioman.Location = new System.Drawing.Point(103, 274);
            this.dgUsuarioman.Name = "dgUsuarioman";
            this.dgUsuarioman.Size = new System.Drawing.Size(516, 166);
            this.dgUsuarioman.TabIndex = 13;
            this.dgUsuarioman.SelectionChanged += new System.EventHandler(this.dgUsuarioman_SelectionChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(521, 167);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 47);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cmbperfil
            // 
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Location = new System.Drawing.Point(240, 190);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(151, 24);
            this.cmbperfil.TabIndex = 9;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcontrasena.Location = new System.Drawing.Point(240, 141);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(222, 22);
            this.txtcontrasena.TabIndex = 8;
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombreusuario.Location = new System.Drawing.Point(240, 96);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(222, 22);
            this.txtnombreusuario.TabIndex = 7;
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusuario.Location = new System.Drawing.Point(240, 53);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(222, 22);
            this.txtusuario.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgperfiles);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.btnperfiles);
            this.tabPage3.Controls.Add(this.btnguardarperfiles);
            this.tabPage3.Controls.Add(this.txtdescpPerfil);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Perfiles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgperfiles
            // 
            this.dgperfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgperfiles.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgperfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgperfiles.Location = new System.Drawing.Point(131, 295);
            this.dgperfiles.Name = "dgperfiles";
            this.dgperfiles.Size = new System.Drawing.Size(388, 150);
            this.dgperfiles.TabIndex = 24;
            this.dgperfiles.SelectionChanged += new System.EventHandler(this.dgperfiles_SelectionChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(264, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnperfiles
            // 
            this.btnperfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnperfiles.BackColor = System.Drawing.Color.ForestGreen;
            this.btnperfiles.FlatAppearance.BorderSize = 0;
            this.btnperfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnperfiles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperfiles.ForeColor = System.Drawing.Color.White;
            this.btnperfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnperfiles.Location = new System.Drawing.Point(545, 124);
            this.btnperfiles.Name = "btnperfiles";
            this.btnperfiles.Size = new System.Drawing.Size(132, 47);
            this.btnperfiles.TabIndex = 22;
            this.btnperfiles.Text = "NUEVO";
            this.btnperfiles.UseVisualStyleBackColor = false;
            this.btnperfiles.Click += new System.EventHandler(this.btnperfiles_Click);
            // 
            // btnguardarperfiles
            // 
            this.btnguardarperfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardarperfiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnguardarperfiles.FlatAppearance.BorderSize = 0;
            this.btnguardarperfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarperfiles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarperfiles.ForeColor = System.Drawing.Color.White;
            this.btnguardarperfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarperfiles.Location = new System.Drawing.Point(545, 212);
            this.btnguardarperfiles.Name = "btnguardarperfiles";
            this.btnguardarperfiles.Size = new System.Drawing.Size(132, 47);
            this.btnguardarperfiles.TabIndex = 21;
            this.btnguardarperfiles.Text = "GUARDAR";
            this.btnguardarperfiles.UseVisualStyleBackColor = false;
            this.btnguardarperfiles.Click += new System.EventHandler(this.btnguardarperfiles_Click);
            // 
            // txtdescpPerfil
            // 
            this.txtdescpPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescpPerfil.Location = new System.Drawing.Point(264, 124);
            this.txtdescpPerfil.Name = "txtdescpPerfil";
            this.txtdescpPerfil.Size = new System.Drawing.Size(222, 22);
            this.txtdescpPerfil.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripcion de Perfil";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 537);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgconsultausuarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarioman)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgperfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgconsultausuarios;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnNuevoconsulta;
        private System.Windows.Forms.ComboBox cmbperfil;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgUsuarioman;
        private System.Windows.Forms.Button btnnuevoman;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgperfiles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnperfiles;
        private System.Windows.Forms.Button btnguardarperfiles;
        private System.Windows.Forms.TextBox txtdescpPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}