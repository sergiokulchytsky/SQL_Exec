namespace SQLDev
{
    partial class TaskMenu
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
            this.EndBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.StudLab = new System.Windows.Forms.Label();
            this.StudentMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndBtn
            // 
            this.EndBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndBtn.Location = new System.Drawing.Point(620, 372);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(122, 37);
            this.EndBtn.TabIndex = 10;
            this.EndBtn.Text = "Complete";
            this.EndBtn.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutBtn.Location = new System.Drawing.Point(648, 12);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(94, 36);
            this.LogOutBtn.TabIndex = 11;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // StudLab
            // 
            this.StudLab.AutoSize = true;
            this.StudLab.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudLab.Location = new System.Drawing.Point(13, 13);
            this.StudLab.Name = "StudLab";
            this.StudLab.Size = new System.Drawing.Size(56, 15);
            this.StudLab.TabIndex = 12;
            this.StudLab.Text = "Hello: ";
            // 
            // StudentMark
            // 
            this.StudentMark.AutoSize = true;
            this.StudentMark.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentMark.Location = new System.Drawing.Point(362, 13);
            this.StudentMark.Name = "StudentMark";
            this.StudentMark.Size = new System.Drawing.Size(56, 15);
            this.StudentMark.TabIndex = 13;
            this.StudentMark.Text = "Mark: 0";
            // 
            // TaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(this.StudentMark);
            this.Controls.Add(this.StudLab);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.EndBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskMenu";
            this.Load += new System.EventHandler(this.TaskMenu_Load);
            this.SizeChanged += new System.EventHandler(this.TaskMenu_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label StudLab;
        private System.Windows.Forms.Label StudentMark;
    }
}