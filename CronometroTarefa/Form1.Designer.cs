namespace CronometroTarefa
{
    partial class frmMain
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
            this.lbTempo = new System.Windows.Forms.Label();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.txTempo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTempo
            // 
            this.lbTempo.BackColor = System.Drawing.Color.Black;
            this.lbTempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTempo.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTempo.Location = new System.Drawing.Point(0, 22);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(634, 50);
            this.lbTempo.TabIndex = 5;
            this.lbTempo.Text = "00:00:00:000";
            this.lbTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlayPause
            // 
            this.btPlayPause.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayPause.Location = new System.Drawing.Point(149, 3);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(155, 28);
            this.btPlayPause.TabIndex = 1;
            this.btPlayPause.Text = "Iniciar/Pausar";
            this.btPlayPause.UseVisualStyleBackColor = true;
            this.btPlayPause.Click += new System.EventHandler(this.btPlayPause_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tempo de tarefa...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txTempo);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btPlayPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 36);
            this.panel1.TabIndex = 6;
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(310, 3);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(155, 28);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Parar";
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(471, 3);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(155, 28);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Zerar";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // txTempo
            // 
            this.txTempo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTempo.Location = new System.Drawing.Point(61, 7);
            this.txTempo.Mask = "00:00";
            this.txTempo.Name = "txTempo";
            this.txTempo.Size = new System.Drawing.Size(47, 22);
            this.txTempo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tempo:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 112);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Cronometro de Tareda";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Button btPlayPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txTempo;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
    }
}

