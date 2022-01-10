
namespace PA_Pomodoro
{
    partial class FrmPomo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(232)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(112, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 58);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(46, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(289, 115);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "25:00";
            // 
            // tTime
            // 
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(187, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 240);
            this.panel2.TabIndex = 5;
            // 
            // FrmPomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(232)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPomo";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.FrmPomo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Panel panel2;
    }
}

