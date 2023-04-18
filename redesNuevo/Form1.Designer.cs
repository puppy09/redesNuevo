namespace redesNuevo
{
    partial class Form1
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
            this.btnCal = new System.Windows.Forms.Button();
            this.gbxOpc = new System.Windows.Forms.GroupBox();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.tbxSubredes = new System.Windows.Forms.TextBox();
            this.rbnHost = new System.Windows.Forms.RadioButton();
            this.rbnSubredes = new System.Windows.Forms.RadioButton();
            this.tbxIdRed = new System.Windows.Forms.TextBox();
            this.lbIdRed = new System.Windows.Forms.Label();
            this.gbxRes = new System.Windows.Forms.GroupBox();
            this.tbxNewMasc = new System.Windows.Forms.TextBox();
            this.lblMasc = new System.Windows.Forms.Label();
            this.tbxHosPra = new System.Windows.Forms.TextBox();
            this.tbxHosTe = new System.Windows.Forms.TextBox();
            this.lblHosT = new System.Windows.Forms.Label();
            this.lblHosPra = new System.Windows.Forms.Label();
            this.lblHos = new System.Windows.Forms.Label();
            this.tbxSubPr = new System.Windows.Forms.TextBox();
            this.tbxSubT = new System.Windows.Forms.TextBox();
            this.lblPrac = new System.Windows.Forms.Label();
            this.lblTeo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.gbxOpc.SuspendLayout();
            this.gbxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(239, 372);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 39);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // gbxOpc
            // 
            this.gbxOpc.Controls.Add(this.tbxHost);
            this.gbxOpc.Controls.Add(this.tbxSubredes);
            this.gbxOpc.Controls.Add(this.rbnHost);
            this.gbxOpc.Controls.Add(this.rbnSubredes);
            this.gbxOpc.Location = new System.Drawing.Point(66, 185);
            this.gbxOpc.Name = "gbxOpc";
            this.gbxOpc.Size = new System.Drawing.Size(412, 156);
            this.gbxOpc.TabIndex = 1;
            this.gbxOpc.TabStop = false;
            this.gbxOpc.Text = "Ingrese una Opción";
            // 
            // tbxHost
            // 
            this.tbxHost.Enabled = false;
            this.tbxHost.Location = new System.Drawing.Point(192, 83);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(106, 22);
            this.tbxHost.TabIndex = 3;
            // 
            // tbxSubredes
            // 
            this.tbxSubredes.Enabled = false;
            this.tbxSubredes.Location = new System.Drawing.Point(192, 39);
            this.tbxSubredes.Name = "tbxSubredes";
            this.tbxSubredes.Size = new System.Drawing.Size(106, 22);
            this.tbxSubredes.TabIndex = 2;
            // 
            // rbnHost
            // 
            this.rbnHost.AutoSize = true;
            this.rbnHost.Location = new System.Drawing.Point(22, 83);
            this.rbnHost.Name = "rbnHost";
            this.rbnHost.Size = new System.Drawing.Size(126, 20);
            this.rbnHost.TabIndex = 1;
            this.rbnHost.TabStop = true;
            this.rbnHost.Text = "Host por Subred";
            this.rbnHost.UseVisualStyleBackColor = true;
            this.rbnHost.CheckedChanged += new System.EventHandler(this.rbnHost_CheckedChanged);
            // 
            // rbnSubredes
            // 
            this.rbnSubredes.AutoSize = true;
            this.rbnSubredes.Location = new System.Drawing.Point(22, 36);
            this.rbnSubredes.Name = "rbnSubredes";
            this.rbnSubredes.Size = new System.Drawing.Size(87, 20);
            this.rbnSubredes.TabIndex = 0;
            this.rbnSubredes.TabStop = true;
            this.rbnSubredes.Text = "Subredes";
            this.rbnSubredes.UseVisualStyleBackColor = true;
            this.rbnSubredes.CheckedChanged += new System.EventHandler(this.rbnSubredes_CheckedChanged);
            // 
            // tbxIdRed
            // 
            this.tbxIdRed.Location = new System.Drawing.Point(66, 100);
            this.tbxIdRed.Name = "tbxIdRed";
            this.tbxIdRed.Size = new System.Drawing.Size(216, 22);
            this.tbxIdRed.TabIndex = 2;
            // 
            // lbIdRed
            // 
            this.lbIdRed.AutoSize = true;
            this.lbIdRed.Location = new System.Drawing.Point(63, 75);
            this.lbIdRed.Name = "lbIdRed";
            this.lbIdRed.Size = new System.Drawing.Size(128, 16);
            this.lbIdRed.TabIndex = 3;
            this.lbIdRed.Text = "Identificador de Red";
            // 
            // gbxRes
            // 
            this.gbxRes.Controls.Add(this.tbxNewMasc);
            this.gbxRes.Controls.Add(this.lblMasc);
            this.gbxRes.Controls.Add(this.tbxHosPra);
            this.gbxRes.Controls.Add(this.tbxHosTe);
            this.gbxRes.Controls.Add(this.lblHosT);
            this.gbxRes.Controls.Add(this.lblHosPra);
            this.gbxRes.Controls.Add(this.lblHos);
            this.gbxRes.Controls.Add(this.tbxSubPr);
            this.gbxRes.Controls.Add(this.tbxSubT);
            this.gbxRes.Controls.Add(this.lblPrac);
            this.gbxRes.Controls.Add(this.lblTeo);
            this.gbxRes.Controls.Add(this.lblSub);
            this.gbxRes.Location = new System.Drawing.Point(551, 57);
            this.gbxRes.Name = "gbxRes";
            this.gbxRes.Size = new System.Drawing.Size(405, 354);
            this.gbxRes.TabIndex = 5;
            this.gbxRes.TabStop = false;
            this.gbxRes.Text = "Resultados";
            // 
            // tbxNewMasc
            // 
            this.tbxNewMasc.Location = new System.Drawing.Point(171, 262);
            this.tbxNewMasc.Name = "tbxNewMasc";
            this.tbxNewMasc.Size = new System.Drawing.Size(193, 22);
            this.tbxNewMasc.TabIndex = 11;
            // 
            // lblMasc
            // 
            this.lblMasc.AutoSize = true;
            this.lblMasc.Location = new System.Drawing.Point(46, 262);
            this.lblMasc.Name = "lblMasc";
            this.lblMasc.Size = new System.Drawing.Size(106, 16);
            this.lblMasc.TabIndex = 10;
            this.lblMasc.Text = "Nueva Máscara:";
            // 
            // tbxHosPra
            // 
            this.tbxHosPra.Location = new System.Drawing.Point(185, 192);
            this.tbxHosPra.Name = "tbxHosPra";
            this.tbxHosPra.Size = new System.Drawing.Size(132, 22);
            this.tbxHosPra.TabIndex = 9;
            // 
            // tbxHosTe
            // 
            this.tbxHosTe.Location = new System.Drawing.Point(185, 164);
            this.tbxHosTe.Name = "tbxHosTe";
            this.tbxHosTe.Size = new System.Drawing.Size(132, 22);
            this.tbxHosTe.TabIndex = 8;
            // 
            // lblHosT
            // 
            this.lblHosT.AutoSize = true;
            this.lblHosT.Location = new System.Drawing.Point(115, 170);
            this.lblHosT.Name = "lblHosT";
            this.lblHosT.Size = new System.Drawing.Size(64, 16);
            this.lblHosT.TabIndex = 7;
            this.lblHosT.Text = "Teóricos:";
            // 
            // lblHosPra
            // 
            this.lblHosPra.AutoSize = true;
            this.lblHosPra.Location = new System.Drawing.Point(115, 195);
            this.lblHosPra.Name = "lblHosPra";
            this.lblHosPra.Size = new System.Drawing.Size(66, 16);
            this.lblHosPra.TabIndex = 6;
            this.lblHosPra.Text = "Prácticos:";
            // 
            // lblHos
            // 
            this.lblHos.AutoSize = true;
            this.lblHos.Location = new System.Drawing.Point(46, 127);
            this.lblHos.Name = "lblHos";
            this.lblHos.Size = new System.Drawing.Size(105, 16);
            this.lblHos.TabIndex = 5;
            this.lblHos.Text = "Host por Subred";
            // 
            // tbxSubPr
            // 
            this.tbxSubPr.Location = new System.Drawing.Point(185, 72);
            this.tbxSubPr.Name = "tbxSubPr";
            this.tbxSubPr.Size = new System.Drawing.Size(132, 22);
            this.tbxSubPr.TabIndex = 4;
            // 
            // tbxSubT
            // 
            this.tbxSubT.Location = new System.Drawing.Point(185, 45);
            this.tbxSubT.Name = "tbxSubT";
            this.tbxSubT.Size = new System.Drawing.Size(132, 22);
            this.tbxSubT.TabIndex = 3;
            // 
            // lblPrac
            // 
            this.lblPrac.AutoSize = true;
            this.lblPrac.Location = new System.Drawing.Point(115, 78);
            this.lblPrac.Name = "lblPrac";
            this.lblPrac.Size = new System.Drawing.Size(66, 16);
            this.lblPrac.TabIndex = 2;
            this.lblPrac.Text = "Prácticas:";
            // 
            // lblTeo
            // 
            this.lblTeo.AutoSize = true;
            this.lblTeo.Location = new System.Drawing.Point(115, 48);
            this.lblTeo.Name = "lblTeo";
            this.lblTeo.Size = new System.Drawing.Size(64, 16);
            this.lblTeo.TabIndex = 1;
            this.lblTeo.Text = "Teóricas:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(46, 18);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(66, 16);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "Subredes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 559);
            this.Controls.Add(this.gbxRes);
            this.Controls.Add(this.lbIdRed);
            this.Controls.Add(this.tbxIdRed);
            this.Controls.Add(this.gbxOpc);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "Redes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxOpc.ResumeLayout(false);
            this.gbxOpc.PerformLayout();
            this.gbxRes.ResumeLayout(false);
            this.gbxRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.GroupBox gbxOpc;
        private System.Windows.Forms.RadioButton rbnHost;
        private System.Windows.Forms.RadioButton rbnSubredes;
        private System.Windows.Forms.TextBox tbxIdRed;
        private System.Windows.Forms.Label lbIdRed;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.TextBox tbxSubredes;
        private System.Windows.Forms.GroupBox gbxRes;
        private System.Windows.Forms.TextBox tbxNewMasc;
        private System.Windows.Forms.Label lblMasc;
        private System.Windows.Forms.TextBox tbxHosPra;
        private System.Windows.Forms.TextBox tbxHosTe;
        private System.Windows.Forms.Label lblHosT;
        private System.Windows.Forms.Label lblHosPra;
        private System.Windows.Forms.Label lblHos;
        private System.Windows.Forms.TextBox tbxSubPr;
        private System.Windows.Forms.TextBox tbxSubT;
        private System.Windows.Forms.Label lblPrac;
        private System.Windows.Forms.Label lblTeo;
        private System.Windows.Forms.Label lblSub;
    }
}

