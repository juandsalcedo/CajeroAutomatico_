using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Consignacion
{
    partial class fondoPanelVertical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fondoPanelVertical));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConsignar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.fondoContenerdor = new System.Windows.Forms.Panel();
            this.textBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTransferirDinero = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNumDocumento = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxNombreReceptor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelConsignacion = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelVertical.SuspendLayout();
            this.fondoContenerdor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(821, 0);
            this.barraTitulo.TabIndex = 4;
            this.barraTitulo.UseWaitCursor = true;
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelVertical.Controls.Add(this.flowLayoutPanel4);
            this.panelVertical.Controls.Add(this.buttonTransferir);
            this.panelVertical.Controls.Add(this.flowLayoutPanel3);
            this.panelVertical.Controls.Add(this.buttonConsignar);
            this.panelVertical.Controls.Add(this.flowLayoutPanel2);
            this.panelVertical.Controls.Add(this.flowLayoutPanel1);
            this.panelVertical.Controls.Add(this.buttonRetirar);
            this.panelVertical.Controls.Add(this.buttonInicio);
            this.panelVertical.Controls.Add(this.pictureBoxLogo);
            this.panelVertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 0);
            this.panelVertical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(150, 457);
            this.panelVertical.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 279);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(9, 24);
            this.flowLayoutPanel4.TabIndex = 6;
            this.flowLayoutPanel4.UseWaitCursor = true;
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonTransferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransferir.FlatAppearance.BorderSize = 0;
            this.buttonTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferir.ForeColor = System.Drawing.Color.Snow;
            this.buttonTransferir.Location = new System.Drawing.Point(9, 279);
            this.buttonTransferir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(141, 24);
            this.buttonTransferir.TabIndex = 7;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 220);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(9, 24);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.UseWaitCursor = true;
            // 
            // buttonConsignar
            // 
            this.buttonConsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonConsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsignar.FlatAppearance.BorderSize = 0;
            this.buttonConsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsignar.ForeColor = System.Drawing.Color.Snow;
            this.buttonConsignar.Location = new System.Drawing.Point(9, 220);
            this.buttonConsignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConsignar.Name = "buttonConsignar";
            this.buttonConsignar.Size = new System.Drawing.Size(141, 24);
            this.buttonConsignar.TabIndex = 5;
            this.buttonConsignar.Text = "Consignar";
            this.buttonConsignar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 166);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(9, 24);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 109);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetirar.FlatAppearance.BorderSize = 0;
            this.buttonRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetirar.ForeColor = System.Drawing.Color.Snow;
            this.buttonRetirar.Location = new System.Drawing.Point(9, 166);
            this.buttonRetirar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(141, 24);
            this.buttonRetirar.TabIndex = 3;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.Snow;
            this.buttonInicio.Location = new System.Drawing.Point(9, 109);
            this.buttonInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(141, 24);
            this.buttonInicio.TabIndex = 1;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = false;
            // 
            // fondoContenerdor
            // 
            this.fondoContenerdor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fondoContenerdor.Controls.Add(this.textBoxNumeroCuenta);
            this.fondoContenerdor.Controls.Add(this.panel4);
            this.fondoContenerdor.Controls.Add(this.buttonTransferirDinero);
            this.fondoContenerdor.Controls.Add(this.textBoxValor);
            this.fondoContenerdor.Controls.Add(this.panel2);
            this.fondoContenerdor.Controls.Add(this.textBoxNumDocumento);
            this.fondoContenerdor.Controls.Add(this.panel3);
            this.fondoContenerdor.Controls.Add(this.textBoxNombreReceptor);
            this.fondoContenerdor.Controls.Add(this.panel1);
            this.fondoContenerdor.Controls.Add(this.labelValor);
            this.fondoContenerdor.Controls.Add(this.labelConsignacion);
            this.fondoContenerdor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fondoContenerdor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondoContenerdor.Location = new System.Drawing.Point(150, 0);
            this.fondoContenerdor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fondoContenerdor.Name = "fondoContenerdor";
            this.fondoContenerdor.Size = new System.Drawing.Size(671, 457);
            this.fondoContenerdor.TabIndex = 6;
            this.fondoContenerdor.Paint += new System.Windows.Forms.PaintEventHandler(this.fondoContenerdor_Paint_1);
            // 
            // textBoxNumeroCuenta
            // 
            this.textBoxNumeroCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxNumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumeroCuenta.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroCuenta.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxNumeroCuenta.Location = new System.Drawing.Point(28, 304);
            this.textBoxNumeroCuenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            this.textBoxNumeroCuenta.Size = new System.Drawing.Size(208, 17);
            this.textBoxNumeroCuenta.TabIndex = 16;
            this.textBoxNumeroCuenta.Text = "Numero de cuenta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(26, 326);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 4);
            this.panel4.TabIndex = 15;
            this.panel4.UseWaitCursor = true;
            // 
            // buttonTransferirDinero
            // 
            this.buttonTransferirDinero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransferirDinero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTransferirDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferirDinero.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferirDinero.ForeColor = System.Drawing.Color.Black;
            this.buttonTransferirDinero.Location = new System.Drawing.Point(418, 234);
            this.buttonTransferirDinero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTransferirDinero.Name = "buttonTransferirDinero";
            this.buttonTransferirDinero.Size = new System.Drawing.Size(157, 124);
            this.buttonTransferirDinero.TabIndex = 14;
            this.buttonTransferirDinero.Text = "Tranferir dinero";
            this.buttonTransferirDinero.UseVisualStyleBackColor = true;
            this.buttonTransferirDinero.Click += new System.EventHandler(this.buttonTransferirDinero_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxValor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxValor.Location = new System.Drawing.Point(396, 150);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(208, 17);
            this.textBoxValor.TabIndex = 13;
            this.textBoxValor.Text = "Valor a transferir";
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            this.textBoxValor.Enter += new System.EventHandler(this.textBoxValor_Enter);
            this.textBoxValor.Leave += new System.EventHandler(this.textBoxValor_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(393, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 4);
            this.panel2.TabIndex = 12;
            this.panel2.UseWaitCursor = true;
            // 
            // textBoxNumDocumento
            // 
            this.textBoxNumDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumDocumento.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumDocumento.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxNumDocumento.Location = new System.Drawing.Point(28, 236);
            this.textBoxNumDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumDocumento.Name = "textBoxNumDocumento";
            this.textBoxNumDocumento.Size = new System.Drawing.Size(208, 17);
            this.textBoxNumDocumento.TabIndex = 11;
            this.textBoxNumDocumento.Text = "Numero de documento";
            this.textBoxNumDocumento.TextChanged += new System.EventHandler(this.textBoxNumDocumento_TextChanged);
            this.textBoxNumDocumento.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBoxNumDocumento.Leave += new System.EventHandler(this.textBoxNumDocumento_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(26, 258);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 4);
            this.panel3.TabIndex = 10;
            this.panel3.UseWaitCursor = true;
            // 
            // textBoxNombreReceptor
            // 
            this.textBoxNombreReceptor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxNombreReceptor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreReceptor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombreReceptor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreReceptor.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxNombreReceptor.Location = new System.Drawing.Point(28, 150);
            this.textBoxNombreReceptor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreReceptor.Name = "textBoxNombreReceptor";
            this.textBoxNombreReceptor.Size = new System.Drawing.Size(208, 17);
            this.textBoxNombreReceptor.TabIndex = 7;
            this.textBoxNombreReceptor.Text = "Nombre de quien recibe";
            this.textBoxNombreReceptor.TextChanged += new System.EventHandler(this.textBoxNombreReceptor_TextChanged);
            this.textBoxNombreReceptor.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxNombreReceptor.Leave += new System.EventHandler(this.textBoxNombreReceptor_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(26, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 4);
            this.panel1.TabIndex = 6;
            this.panel1.UseWaitCursor = true;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.Black;
            this.labelValor.Location = new System.Drawing.Point(476, 119);
            this.labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(38, 14);
            this.labelValor.TabIndex = 5;
            this.labelValor.Text = "Valor";
            // 
            // labelConsignacion
            // 
            this.labelConsignacion.AutoSize = true;
            this.labelConsignacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelConsignacion.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsignacion.ForeColor = System.Drawing.Color.Black;
            this.labelConsignacion.Location = new System.Drawing.Point(249, 25);
            this.labelConsignacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsignacion.Name = "labelConsignacion";
            this.labelConsignacion.Size = new System.Drawing.Size(153, 36);
            this.labelConsignacion.TabIndex = 0;
            this.labelConsignacion.Text = "Consignar";
            this.labelConsignacion.Click += new System.EventHandler(this.labelConsignacion_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(143, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fondoPanelVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 457);
            this.Controls.Add(this.fondoContenerdor);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.barraTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fondoPanelVertical";
            this.Text = "Form1";
            this.panelVertical.ResumeLayout(false);
            this.fondoContenerdor.ResumeLayout(false);
            this.fondoContenerdor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void fondoContenerdor_Paint(object sender, PaintEventArgs e)
        {
            // Este código puedes eliminarlo, ya que no deseas hacer nada en este evento.
        }


        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel fondoContenerdor;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonConsignar;
        private System.Windows.Forms.Label labelConsignacion;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxNombreReceptor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNumDocumento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonTransferirDinero;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Panel panel2;
        private TextBox textBoxNumeroCuenta;
        private Panel panel4;
        private PictureBox pictureBoxLogo;
    }
}

