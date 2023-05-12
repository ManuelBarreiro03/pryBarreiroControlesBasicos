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
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.optFreezer = new System.Windows.Forms.RadioButton();
            this.optAlacena = new System.Windows.Forms.RadioButton();
            this.lstLugar = new System.Windows.Forms.ListBox();
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
            this.lblCopia.Location = new System.Drawing.Point(82, 142);
            this.lblCopia.Name = "lblCopia";
            this.lblCopia.Size = new System.Drawing.Size(66, 25);
            this.lblCopia.TabIndex = 1;
            this.lblCopia.Text = "Texto";
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(316, 224);
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
            this.optRojo.Location = new System.Drawing.Point(62, 236);
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
            this.optAzul.Location = new System.Drawing.Point(194, 236);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 4;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Location = new System.Drawing.Point(62, 325);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(68, 17);
            this.optHeladera.TabIndex = 5;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "Heladera";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // optFreezer
            // 
            this.optFreezer.AutoSize = true;
            this.optFreezer.Location = new System.Drawing.Point(211, 325);
            this.optFreezer.Name = "optFreezer";
            this.optFreezer.Size = new System.Drawing.Size(60, 17);
            this.optFreezer.TabIndex = 6;
            this.optFreezer.TabStop = true;
            this.optFreezer.Text = "Freezer";
            this.optFreezer.UseVisualStyleBackColor = true;
            // 
            // optAlacena
            // 
            this.optAlacena.AutoSize = true;
            this.optAlacena.Location = new System.Drawing.Point(374, 325);
            this.optAlacena.Name = "optAlacena";
            this.optAlacena.Size = new System.Drawing.Size(64, 17);
            this.optAlacena.TabIndex = 7;
            this.optAlacena.TabStop = true;
            this.optAlacena.Text = "Alacena";
            this.optAlacena.UseVisualStyleBackColor = true;
            // 
            // lstLugar
            // 
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Location = new System.Drawing.Point(12, 348);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(482, 82);
            this.lstLugar.TabIndex = 8;
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.lstLugar);
            this.Controls.Add(this.optAlacena);
            this.Controls.Add(this.optFreezer);
            this.Controls.Add(this.optHeladera);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.lblCopia);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmTexto";
            this.Text = "frmTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblCopia;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optHeladera;
        private System.Windows.Forms.RadioButton optFreezer;
        private System.Windows.Forms.RadioButton optAlacena;
        private System.Windows.Forms.ListBox lstLugar;
    }
}