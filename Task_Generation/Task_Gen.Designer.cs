namespace Task_Generation
{
    partial class Task_Gen
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
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.Attach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.corrSqlBox = new System.Windows.Forms.RichTextBox();
            this.Create = new System.Windows.Forms.Button();
            this.fileStatus = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(13, 32);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(490, 125);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            // 
            // Attach
            // 
            this.Attach.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attach.Location = new System.Drawing.Point(12, 184);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(130, 29);
            this.Attach.TabIndex = 2;
            this.Attach.Text = "Attach ERD";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correct SQL:";
            // 
            // corrSqlBox
            // 
            this.corrSqlBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corrSqlBox.Location = new System.Drawing.Point(12, 249);
            this.corrSqlBox.MaximumSize = new System.Drawing.Size(1500, 300);
            this.corrSqlBox.Name = "corrSqlBox";
            this.corrSqlBox.Size = new System.Drawing.Size(490, 125);
            this.corrSqlBox.TabIndex = 4;
            this.corrSqlBox.Text = "";
            this.corrSqlBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Create
            // 
            this.Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Create.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(542, 345);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(130, 29);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create Task";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // fileStatus
            // 
            this.fileStatus.AutoSize = true;
            this.fileStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileStatus.Location = new System.Drawing.Point(148, 191);
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(0, 15);
            this.fileStatus.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(509, 32);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(150, 300);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 7;
            // 
            // Task_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.fileStatus);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.corrSqlBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Task_Gen";
            this.Text = "Task_Generation";
            this.Load += new System.EventHandler(this.Task_Gen_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox corrSqlBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label fileStatus;
        private System.Windows.Forms.Label StatusLabel;
    }
}

