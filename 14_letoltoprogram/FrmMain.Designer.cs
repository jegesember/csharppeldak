namespace _14_letoltoprogram
{
    partial class FrmMain
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
            this.DlgMappaValaszto = new System.Windows.Forms.FolderBrowserDialog();
            this.TbKimenet = new System.Windows.Forms.TextBox();
            this.TbURL = new System.Windows.Forms.TextBox();
            this.PbAllapot = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbKimenet
            // 
            this.TbKimenet.Location = new System.Drawing.Point(25, 80);
            this.TbKimenet.Name = "TbKimenet";
            this.TbKimenet.Size = new System.Drawing.Size(392, 20);
            this.TbKimenet.TabIndex = 0;
            // 
            // TbURL
            // 
            this.TbURL.Location = new System.Drawing.Point(25, 25);
            this.TbURL.Name = "TbURL";
            this.TbURL.Size = new System.Drawing.Size(475, 20);
            this.TbURL.TabIndex = 1;
            // 
            // PbAllapot
            // 
            this.PbAllapot.Location = new System.Drawing.Point(25, 139);
            this.PbAllapot.Name = "PbAllapot";
            this.PbAllapot.Size = new System.Drawing.Size(475, 23);
            this.PbAllapot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letöltendő File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kimeneti mappa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Letöltés Állapota:";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(208, 199);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(143, 23);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Letöltés Indítása";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(357, 199);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(143, 23);
            this.BtnStop.TabIndex = 7;
            this.BtnStop.Text = "Letöltés Megállítása";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Választ...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbAllapot);
            this.Controls.Add(this.TbURL);
            this.Controls.Add(this.TbKimenet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letöltő 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog DlgMappaValaszto;
        private System.Windows.Forms.TextBox TbKimenet;
        private System.Windows.Forms.TextBox TbURL;
        private System.Windows.Forms.ProgressBar PbAllapot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button button3;
    }
}

