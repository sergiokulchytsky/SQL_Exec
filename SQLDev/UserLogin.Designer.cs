namespace SQLDev
{
    partial class UserLogin
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
            this.GroupCombo = new System.Windows.Forms.ComboBox();
            this.GroupLab = new System.Windows.Forms.Label();
            this.StudLab = new System.Windows.Forms.Label();
            this.StudCombo = new System.Windows.Forms.ComboBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.GroupStat = new System.Windows.Forms.Label();
            this.StudStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupCombo
            // 
            this.GroupCombo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupCombo.FormattingEnabled = true;
            this.GroupCombo.Location = new System.Drawing.Point(16, 41);
            this.GroupCombo.Name = "GroupCombo";
            this.GroupCombo.Size = new System.Drawing.Size(259, 23);
            this.GroupCombo.TabIndex = 1;
            this.GroupCombo.SelectedIndexChanged += new System.EventHandler(this.GroupCombo_SelectedIndexChanged);
            // 
            // GroupLab
            // 
            this.GroupLab.AutoSize = true;
            this.GroupLab.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLab.Location = new System.Drawing.Point(13, 13);
            this.GroupLab.Name = "GroupLab";
            this.GroupLab.Size = new System.Drawing.Size(49, 15);
            this.GroupLab.TabIndex = 2;
            this.GroupLab.Text = "Group:";
            // 
            // StudLab
            // 
            this.StudLab.AutoSize = true;
            this.StudLab.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudLab.Location = new System.Drawing.Point(13, 90);
            this.StudLab.Name = "StudLab";
            this.StudLab.Size = new System.Drawing.Size(56, 15);
            this.StudLab.TabIndex = 4;
            this.StudLab.Text = "Student";
            // 
            // StudCombo
            // 
            this.StudCombo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudCombo.FormattingEnabled = true;
            this.StudCombo.Location = new System.Drawing.Point(16, 118);
            this.StudCombo.Name = "StudCombo";
            this.StudCombo.Size = new System.Drawing.Size(259, 23);
            this.StudCombo.TabIndex = 3;
            this.StudCombo.SelectedIndexChanged += new System.EventHandler(this.StudCombo_SelectedIndexChanged);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.Location = new System.Drawing.Point(85, 173);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(102, 35);
            this.LogInBtn.TabIndex = 5;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // GroupStat
            // 
            this.GroupStat.AutoSize = true;
            this.GroupStat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupStat.Location = new System.Drawing.Point(68, 13);
            this.GroupStat.Name = "GroupStat";
            this.GroupStat.Size = new System.Drawing.Size(0, 15);
            this.GroupStat.TabIndex = 6;
            // 
            // StudStat
            // 
            this.StudStat.AutoSize = true;
            this.StudStat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudStat.Location = new System.Drawing.Point(75, 90);
            this.StudStat.Name = "StudStat";
            this.StudStat.Size = new System.Drawing.Size(0, 15);
            this.StudStat.TabIndex = 7;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 232);
            this.Controls.Add(this.StudStat);
            this.Controls.Add(this.GroupStat);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.StudLab);
            this.Controls.Add(this.StudCombo);
            this.Controls.Add(this.GroupLab);
            this.Controls.Add(this.GroupCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupCombo;
        private System.Windows.Forms.Label GroupLab;
        private System.Windows.Forms.Label StudLab;
        private System.Windows.Forms.ComboBox StudCombo;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label GroupStat;
        private System.Windows.Forms.Label StudStat;
    }
}