namespace SQLDev
{
    partial class TaskView
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
            this.Static_label1 = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.Static_label2 = new System.Windows.Forms.Label();
            this.ERDpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ERDpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Static_label1
            // 
            this.Static_label1.AutoSize = true;
            this.Static_label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Static_label1.Location = new System.Drawing.Point(693, 9);
            this.Static_label1.Name = "Static_label1";
            this.Static_label1.Size = new System.Drawing.Size(180, 22);
            this.Static_label1.TabIndex = 0;
            this.Static_label1.Text = "Task description:";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescLabel.Location = new System.Drawing.Point(693, 46);
            this.DescLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(0, 22);
            this.DescLabel.TabIndex = 1;
            // 
            // Static_label2
            // 
            this.Static_label2.AutoSize = true;
            this.Static_label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Static_label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Static_label2.Location = new System.Drawing.Point(8, 9);
            this.Static_label2.Name = "Static_label2";
            this.Static_label2.Size = new System.Drawing.Size(50, 22);
            this.Static_label2.TabIndex = 2;
            this.Static_label2.Text = "ERD:";
            // 
            // ERDpictureBox
            // 
            this.ERDpictureBox.Location = new System.Drawing.Point(12, 34);
            this.ERDpictureBox.Name = "ERDpictureBox";
            this.ERDpictureBox.Size = new System.Drawing.Size(659, 416);
            this.ERDpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ERDpictureBox.TabIndex = 3;
            this.ERDpictureBox.TabStop = false;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 462);
            this.Controls.Add(this.ERDpictureBox);
            this.Controls.Add(this.Static_label2);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.Static_label1);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.Load += new System.EventHandler(this.TaskView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERDpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Static_label1;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label Static_label2;
        private System.Windows.Forms.PictureBox ERDpictureBox;
    }
}