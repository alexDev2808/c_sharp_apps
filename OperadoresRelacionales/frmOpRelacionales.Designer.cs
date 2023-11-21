
namespace CursoCSharp.OperadoresRelacionales
{
    partial class frmOpRelacionales
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnmayor = new System.Windows.Forms.Button();
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnmayorigual = new System.Windows.Forms.Button();
            this.btnmenorigual = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btndiferente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnmayor);
            this.flowLayoutPanel1.Controls.Add(this.btnmenor);
            this.flowLayoutPanel1.Controls.Add(this.btnmayorigual);
            this.flowLayoutPanel1.Controls.Add(this.btnmenorigual);
            this.flowLayoutPanel1.Controls.Add(this.btnigual);
            this.flowLayoutPanel1.Controls.Add(this.btndiferente);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 55);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnmayor
            // 
            this.btnmayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btnmayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayor.Location = new System.Drawing.Point(3, 3);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(77, 43);
            this.btnmayor.TabIndex = 0;
            this.btnmayor.Text = ">";
            this.btnmayor.UseVisualStyleBackColor = false;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // btnmenor
            // 
            this.btnmenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(136)))), ((int)(((byte)(123)))));
            this.btnmenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenor.Location = new System.Drawing.Point(86, 3);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(77, 43);
            this.btnmenor.TabIndex = 0;
            this.btnmenor.Text = "<";
            this.btnmenor.UseVisualStyleBackColor = false;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnmayorigual
            // 
            this.btnmayorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.btnmayorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayorigual.Location = new System.Drawing.Point(169, 3);
            this.btnmayorigual.Name = "btnmayorigual";
            this.btnmayorigual.Size = new System.Drawing.Size(77, 43);
            this.btnmayorigual.TabIndex = 0;
            this.btnmayorigual.Text = ">=";
            this.btnmayorigual.UseVisualStyleBackColor = false;
            this.btnmayorigual.Click += new System.EventHandler(this.btnmayorigual_Click);
            // 
            // btnmenorigual
            // 
            this.btnmenorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnmenorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenorigual.Location = new System.Drawing.Point(252, 3);
            this.btnmenorigual.Name = "btnmenorigual";
            this.btnmenorigual.Size = new System.Drawing.Size(77, 43);
            this.btnmenorigual.TabIndex = 0;
            this.btnmenorigual.Text = "<=";
            this.btnmenorigual.UseVisualStyleBackColor = false;
            this.btnmenorigual.Click += new System.EventHandler(this.btnmenorigual_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(119)))), ((int)(((byte)(132)))));
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(335, 3);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(77, 43);
            this.btnigual.TabIndex = 0;
            this.btnigual.Text = "==";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btndiferente
            // 
            this.btndiferente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.btndiferente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiferente.Location = new System.Drawing.Point(418, 3);
            this.btndiferente.Name = "btndiferente";
            this.btndiferente.Size = new System.Drawing.Size(77, 43);
            this.btndiferente.TabIndex = 0;
            this.btndiferente.Text = "!=";
            this.btndiferente.UseVisualStyleBackColor = false;
            this.btndiferente.Click += new System.EventHandler(this.btndiferente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(332, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(332, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 14;
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.txtnumero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero2.ForeColor = System.Drawing.Color.White;
            this.txtnumero2.Location = new System.Drawing.Point(332, 131);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(191, 27);
            this.txtnumero2.TabIndex = 11;
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.txtnumero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero1.ForeColor = System.Drawing.Color.White;
            this.txtnumero1.Location = new System.Drawing.Point(332, 72);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(191, 27);
            this.txtnumero1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero 2:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(336, 353);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(20, 25);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(214, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Operadores Relacionales";
            // 
            // frmOpRelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmOpRelacionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpRelacionales";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnmayor;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnmayorigual;
        private System.Windows.Forms.Button btnmenorigual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btndiferente;
    }
}