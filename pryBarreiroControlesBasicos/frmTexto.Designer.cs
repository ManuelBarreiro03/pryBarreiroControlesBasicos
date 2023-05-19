namespace pryBarreiroControlesBasicos
{
    partial class frmTexto
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblCopia = new System.Windows.Forms.Label();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.cmdAsignarAdicional = new System.Windows.Forms.Button();
            this.lblAdons = new System.Windows.Forms.Label();
            this.cboAdcional = new System.Windows.Forms.ComboBox();
            this.mrcAdicionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(87, 82);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(285, 31);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // lblCopia
            // 
            this.lblCopia.AutoSize = true;
            this.lblCopia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopia.Location = new System.Drawing.Point(105, 135);
            this.lblCopia.Name = "lblCopia";
            this.lblCopia.Size = new System.Drawing.Size(267, 25);
            this.lblCopia.TabIndex = 1;
            this.lblCopia.Text = "Texto escrito aparece aqui";
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(241, 170);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(131, 40);
            this.cmdAsignar.TabIndex = 2;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(110, 182);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 3;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(184, 182);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 4;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(9, 13);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(62, 17);
            this.chkPicante.TabIndex = 5;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(9, 36);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 6;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(9, 59);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(66, 17);
            this.chkKetchup.TabIndex = 7;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkKetchup);
            this.mrcAdicionales.Controls.Add(this.chkMayonesa);
            this.mrcAdicionales.Controls.Add(this.chkPicante);
            this.mrcAdicionales.Location = new System.Drawing.Point(125, 257);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(103, 87);
            this.mrcAdicionales.TabIndex = 8;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // cmdAsignarAdicional
            // 
            this.cmdAsignarAdicional.Location = new System.Drawing.Point(272, 264);
            this.cmdAsignarAdicional.Name = "cmdAsignarAdicional";
            this.cmdAsignarAdicional.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignarAdicional.TabIndex = 9;
            this.cmdAsignarAdicional.Text = "Asignar";
            this.cmdAsignarAdicional.UseVisualStyleBackColor = true;
            this.cmdAsignarAdicional.Click += new System.EventHandler(this.cmdAsignarAdicional_Click);
            // 
            // lblAdons
            // 
            this.lblAdons.AutoSize = true;
            this.lblAdons.Location = new System.Drawing.Point(269, 316);
            this.lblAdons.Name = "lblAdons";
            this.lblAdons.Size = new System.Drawing.Size(60, 13);
            this.lblAdons.TabIndex = 10;
            this.lblAdons.Text = "adicionales";
            // 
            // cboAdcional
            // 
            this.cboAdcional.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAdcional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdcional.FormattingEnabled = true;
            this.cboAdcional.Location = new System.Drawing.Point(128, 351);
            this.cboAdcional.Name = "cboAdcional";
            this.cboAdcional.Size = new System.Drawing.Size(90, 21);
            this.cboAdcional.TabIndex = 11;
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.cboAdcional);
            this.Controls.Add(this.lblAdons);
            this.Controls.Add(this.cmdAsignarAdicional);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.lblCopia);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmTexto";
            this.Text = "frmTexto";
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblCopia;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.Button cmdAsignarAdicional;
        private System.Windows.Forms.Label lblAdons;
        private System.Windows.Forms.ComboBox cboAdcional;
    }
}