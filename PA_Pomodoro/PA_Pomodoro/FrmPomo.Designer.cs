
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPomo));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnShoBreak = new System.Windows.Forms.Button();
            this.btnLonBreak = new System.Windows.Forms.Button();
            this.lblPomodoro = new System.Windows.Forms.Label();
            this.lblShoBreak = new System.Windows.Forms.Label();
            this.lblLonBreak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.btnStart.Location = new System.Drawing.Point(136, 329);
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
            this.lblTime.Location = new System.Drawing.Point(70, 138);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(289, 115);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "25:00";
            // 
            // tTime
            // 
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.White;
            this.btnPomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPomodoro.FlatAppearance.BorderSize = 0;
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPomodoro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPomodoro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.btnPomodoro.Location = new System.Drawing.Point(12, 64);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(124, 32);
            this.btnPomodoro.TabIndex = 5;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnShoBreak
            // 
            this.btnShoBreak.BackColor = System.Drawing.Color.White;
            this.btnShoBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoBreak.FlatAppearance.BorderSize = 0;
            this.btnShoBreak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShoBreak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.btnShoBreak.Location = new System.Drawing.Point(152, 64);
            this.btnShoBreak.Name = "btnShoBreak";
            this.btnShoBreak.Size = new System.Drawing.Size(124, 32);
            this.btnShoBreak.TabIndex = 6;
            this.btnShoBreak.Text = "Short break";
            this.btnShoBreak.UseVisualStyleBackColor = false;
            this.btnShoBreak.Click += new System.EventHandler(this.btnShoBreak_Click);
            // 
            // btnLonBreak
            // 
            this.btnLonBreak.BackColor = System.Drawing.Color.White;
            this.btnLonBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLonBreak.FlatAppearance.BorderSize = 0;
            this.btnLonBreak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLonBreak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLonBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.btnLonBreak.Location = new System.Drawing.Point(294, 64);
            this.btnLonBreak.Name = "btnLonBreak";
            this.btnLonBreak.Size = new System.Drawing.Size(124, 32);
            this.btnLonBreak.TabIndex = 7;
            this.btnLonBreak.Text = "Long break";
            this.btnLonBreak.UseVisualStyleBackColor = false;
            this.btnLonBreak.Click += new System.EventHandler(this.btnLonBreak_Click);
            // 
            // lblPomodoro
            // 
            this.lblPomodoro.AutoSize = true;
            this.lblPomodoro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPomodoro.ForeColor = System.Drawing.Color.White;
            this.lblPomodoro.Location = new System.Drawing.Point(64, 38);
            this.lblPomodoro.Name = "lblPomodoro";
            this.lblPomodoro.Size = new System.Drawing.Size(20, 23);
            this.lblPomodoro.TabIndex = 8;
            this.lblPomodoro.Text = "0";
            // 
            // lblShoBreak
            // 
            this.lblShoBreak.AutoSize = true;
            this.lblShoBreak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShoBreak.ForeColor = System.Drawing.Color.White;
            this.lblShoBreak.Location = new System.Drawing.Point(204, 38);
            this.lblShoBreak.Name = "lblShoBreak";
            this.lblShoBreak.Size = new System.Drawing.Size(20, 23);
            this.lblShoBreak.TabIndex = 9;
            this.lblShoBreak.Text = "0";
            // 
            // lblLonBreak
            // 
            this.lblLonBreak.AutoSize = true;
            this.lblLonBreak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLonBreak.ForeColor = System.Drawing.Color.White;
            this.lblLonBreak.Location = new System.Drawing.Point(346, 38);
            this.lblLonBreak.Name = "lblLonBreak";
            this.lblLonBreak.Size = new System.Drawing.Size(20, 23);
            this.lblLonBreak.TabIndex = 10;
            this.lblLonBreak.Text = "0";
            // 
            // FrmPomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(60)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(430, 460);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLonBreak);
            this.Controls.Add(this.lblShoBreak);
            this.Controls.Add(this.lblPomodoro);
            this.Controls.Add(this.btnLonBreak);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnShoBreak);
            this.Controls.Add(this.btnPomodoro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmPomo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnShoBreak;
        private System.Windows.Forms.Button btnLonBreak;
        private System.Windows.Forms.Label lblPomodoro;
        private System.Windows.Forms.Label lblShoBreak;
        private System.Windows.Forms.Label lblLonBreak;
    }
}

