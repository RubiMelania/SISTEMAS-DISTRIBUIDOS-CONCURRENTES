﻿namespace AjpdSoftCapturaPantalla
{
    partial class formCapturarPantalla
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsFormatoImagen = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.bSelDestino = new System.Windows.Forms.Button();
            this.txtUbicacionCaptura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlGuardarImagen = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCapturarPantalla = new System.Windows.Forms.Button();
            this.imgCaptura = new System.Windows.Forms.PictureBox();
            this.linkAjpdSoft = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lsFormatoImagen);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.bSelDestino);
            this.groupBox1.Controls.Add(this.txtUbicacionCaptura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar imagen ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Formato";
            // 
            // lsFormatoImagen
            // 
            this.lsFormatoImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsFormatoImagen.FormattingEnabled = true;
            this.lsFormatoImagen.Items.AddRange(new object[] {
            "BMP",
            "JPEG",
            "PNG",
            "TIFF",
            "WMF"});
            this.lsFormatoImagen.Location = new System.Drawing.Point(63, 19);
            this.lsFormatoImagen.Name = "lsFormatoImagen";
            this.lsFormatoImagen.Size = new System.Drawing.Size(432, 21);
            this.lsFormatoImagen.Sorted = true;
            this.lsFormatoImagen.TabIndex = 0;
            this.lsFormatoImagen.SelectedValueChanged += new System.EventHandler(this.lsFormatoImagen_SelectedValueChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.Location = new System.Drawing.Point(535, 41);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(71, 35);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // bSelDestino
            // 
            this.bSelDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelDestino.Location = new System.Drawing.Point(501, 41);
            this.bSelDestino.Name = "bSelDestino";
            this.bSelDestino.Size = new System.Drawing.Size(28, 35);
            this.bSelDestino.TabIndex = 2;
            this.bSelDestino.Text = "...";
            this.bSelDestino.UseVisualStyleBackColor = true;
            this.bSelDestino.Click += new System.EventHandler(this.bSelDestino_Click);
            // 
            // txtUbicacionCaptura
            // 
            this.txtUbicacionCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUbicacionCaptura.Location = new System.Drawing.Point(63, 49);
            this.txtUbicacionCaptura.Name = "txtUbicacionCaptura";
            this.txtUbicacionCaptura.Size = new System.Drawing.Size(432, 20);
            this.txtUbicacionCaptura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ubicación";
            // 
            // dlGuardarImagen
            // 
            this.dlGuardarImagen.OverwritePrompt = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btCapturarPantalla);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btCapturarPantalla
            // 
            this.btCapturarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCapturarPantalla.Location = new System.Drawing.Point(206, 19);
            this.btCapturarPantalla.Name = "btCapturarPantalla";
            this.btCapturarPantalla.Size = new System.Drawing.Size(225, 40);
            this.btCapturarPantalla.TabIndex = 5;
            this.btCapturarPantalla.Text = "Capturar pantalla";
            this.btCapturarPantalla.UseVisualStyleBackColor = true;
            this.btCapturarPantalla.Click += new System.EventHandler(this.btCapturarPantalla_Click);
            // 
            // imgCaptura
            // 
            this.imgCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCaptura.Location = new System.Drawing.Point(15, 90);
            this.imgCaptura.Name = "imgCaptura";
            this.imgCaptura.Size = new System.Drawing.Size(609, 334);
            this.imgCaptura.TabIndex = 7;
            this.imgCaptura.TabStop = false;
            // 
            // linkAjpdSoft
            // 
            this.linkAjpdSoft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAjpdSoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAjpdSoft.Location = new System.Drawing.Point(12, 515);
            this.linkAjpdSoft.Name = "linkAjpdSoft";
            this.linkAjpdSoft.Size = new System.Drawing.Size(615, 13);
            this.linkAjpdSoft.TabIndex = 12;
            this.linkAjpdSoft.TabStop = true;
            this.linkAjpdSoft.Text = "Más aplicaciones gratuitas y nuevas versiones en www.ajpdsoft.com";
            this.linkAjpdSoft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkAjpdSoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAjpdSoft_LinkClicked);
            // 
            // formCapturarPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 535);
            this.Controls.Add(this.linkAjpdSoft);
            this.Controls.Add(this.imgCaptura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formCapturarPantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjpdSoft Capturar Pantalla C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog dlGuardarImagen;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button bSelDestino;
        private System.Windows.Forms.TextBox txtUbicacionCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCapturarPantalla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lsFormatoImagen;
        private System.Windows.Forms.PictureBox imgCaptura;
        internal System.Windows.Forms.LinkLabel linkAjpdSoft;
    }
}

