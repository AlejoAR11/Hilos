namespace Hilos
{
    partial class frmHilos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimer1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimer2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimer3 = new MaterialSkin.Controls.MaterialLabel();
            this.tmrTimer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrTimer2 = new System.Windows.Forms.Timer(this.components);
            this.tmrTimer3 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.Depth = 0;
            this.lblTimer1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimer1.Location = new System.Drawing.Point(31, 92);
            this.lblTimer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(55, 19);
            this.lblTimer1.TabIndex = 0;
            this.lblTimer1.Text = "Timer 1";
            this.lblTimer1.Click += new System.EventHandler(this.lblTimer1_Click);
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.Depth = 0;
            this.lblTimer2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimer2.Location = new System.Drawing.Point(197, 92);
            this.lblTimer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(55, 19);
            this.lblTimer2.TabIndex = 1;
            this.lblTimer2.Text = "Timer 2";
            // 
            // lblTimer3
            // 
            this.lblTimer3.AutoSize = true;
            this.lblTimer3.Depth = 0;
            this.lblTimer3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimer3.Location = new System.Drawing.Point(31, 161);
            this.lblTimer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimer3.Name = "lblTimer3";
            this.lblTimer3.Size = new System.Drawing.Size(55, 19);
            this.lblTimer3.TabIndex = 2;
            this.lblTimer3.Text = "Timer 3";
   
            // 
            // tmrTimer1
            // 
            this.tmrTimer1.Tick += new System.EventHandler(this.tmrTimer1_Tick);
            // 
            // tmrTimer2
            // 
            this.tmrTimer2.Tick += new System.EventHandler(this.tmrTimer2_Tick);
            // 
            // tmrTimer3
            // 
            this.tmrTimer3.Tick += new System.EventHandler(this.tmrTimer3_Tick);
            // 
            // btnStart
            // 
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(76, 227);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(73, 36);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Iniciar";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 286);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer3);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer1);
            this.Name = "frmHilos";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.frmHilos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTimer1;
        private MaterialSkin.Controls.MaterialLabel lblTimer2;
        private MaterialSkin.Controls.MaterialLabel lblTimer3;
        private System.Windows.Forms.Timer tmrTimer1;
        private System.Windows.Forms.Timer tmrTimer2;
        private System.Windows.Forms.Timer tmrTimer3;
        private MaterialSkin.Controls.MaterialButton btnStart;
    }
}

