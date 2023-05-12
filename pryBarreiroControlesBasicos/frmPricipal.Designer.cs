namespace pryBarreiroControlesBasicos
{
    partial class frmPricipal
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
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.cmdTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEjeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeY.Location = new System.Drawing.Point(474, 9);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(20, 20);
            this.lblEjeY.TabIndex = 0;
            this.lblEjeY.Text = "Y";
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjeX.Location = new System.Drawing.Point(474, 48);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(20, 20);
            this.lblEjeX.TabIndex = 1;
            this.lblEjeX.Text = "X";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(211, 196);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(60, 13);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenida";
            this.lblBienvenida.Visible = false;
            // 
            // cmdTexto
            // 
            this.cmdTexto.Location = new System.Drawing.Point(184, 314);
            this.cmdTexto.Name = "cmdTexto";
            this.cmdTexto.Size = new System.Drawing.Size(146, 52);
            this.cmdTexto.TabIndex = 3;
            this.cmdTexto.Text = "texto";
            this.cmdTexto.UseVisualStyleBackColor = true;
            this.cmdTexto.Click += new System.EventHandler(this.cmdTexto_Click);
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 434);
            this.Controls.Add(this.cmdTexto);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.lblEjeY);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPricipal";
            this.Text = "frmPricipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPricipal_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPricipal_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPricipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button cmdTexto;
    }
}