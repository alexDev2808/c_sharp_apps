namespace CursoCSharp.Listas
{
    partial class frmListas_Arrays
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpTeclado = new System.Windows.Forms.GroupBox();
            this.lbListasArrays = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.panelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPantalla = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpTeclado.SuspendLayout();
            this.panelNumerico.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1157, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listas y Arrays";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lbListasArrays);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 655);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listas y Arrays";
            // 
            // gpTeclado
            // 
            this.gpTeclado.Controls.Add(this.tbPantalla);
            this.gpTeclado.Controls.Add(this.panelNumerico);
            this.gpTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTeclado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(149)))), ((int)(((byte)(150)))));
            this.gpTeclado.Location = new System.Drawing.Point(557, 64);
            this.gpTeclado.Name = "gpTeclado";
            this.gpTeclado.Size = new System.Drawing.Size(577, 655);
            this.gpTeclado.TabIndex = 2;
            this.gpTeclado.TabStop = false;
            this.gpTeclado.Text = "Teclado numerico";
            // 
            // lbListasArrays
            // 
            this.lbListasArrays.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lbListasArrays.HideSelection = false;
            this.lbListasArrays.Location = new System.Drawing.Point(22, 77);
            this.lbListasArrays.Name = "lbListasArrays";
            this.lbListasArrays.Size = new System.Drawing.Size(336, 515);
            this.lbListasArrays.TabIndex = 1;
            this.lbListasArrays.UseCompatibleStateImageBehavior = false;
            this.lbListasArrays.View = System.Windows.Forms.View.List;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(364, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 58);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnNum.Location = new System.Drawing.Point(3, 3);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(83, 72);
            this.btnNum.TabIndex = 0;
            this.btnNum.Text = "0";
            this.btnNum.UseVisualStyleBackColor = false;
            // 
            // panelNumerico
            // 
            this.panelNumerico.Controls.Add(this.btnNum);
            this.panelNumerico.Location = new System.Drawing.Point(32, 165);
            this.panelNumerico.Name = "panelNumerico";
            this.panelNumerico.Size = new System.Drawing.Size(518, 451);
            this.panelNumerico.TabIndex = 1;
            // 
            // tbPantalla
            // 
            this.tbPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPantalla.Location = new System.Drawing.Point(146, 77);
            this.tbPantalla.Name = "tbPantalla";
            this.tbPantalla.Size = new System.Drawing.Size(297, 28);
            this.tbPantalla.TabIndex = 2;
            // 
            // frmListas_Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1157, 752);
            this.Controls.Add(this.gpTeclado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.Name = "frmListas_Arrays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListas";
            this.Load += new System.EventHandler(this.frmListas_Arrays_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpTeclado.ResumeLayout(false);
            this.gpTeclado.PerformLayout();
            this.panelNumerico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpTeclado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lbListasArrays;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.FlowLayoutPanel panelNumerico;
        private System.Windows.Forms.TextBox tbPantalla;
    }
}