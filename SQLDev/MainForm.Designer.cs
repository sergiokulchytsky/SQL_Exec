namespace SQLDev
{
    partial class MainForm
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
            this.Execute = new System.Windows.Forms.Button();
            this.querySqlBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Execute.Location = new System.Drawing.Point(531, 60);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(211, 27);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // querySqlBox
            // 
            this.querySqlBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.querySqlBox.Location = new System.Drawing.Point(12, 27);
            this.querySqlBox.Name = "querySqlBox";
            this.querySqlBox.Size = new System.Drawing.Size(513, 125);
            this.querySqlBox.TabIndex = 3;
            this.querySqlBox.Text = "";
            this.querySqlBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.querySqlBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 184);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(730, 221);
            this.dataGridView.TabIndex = 4;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StatusLabel.Location = new System.Drawing.Point(531, 92);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(225, 90);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your SQL query:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result:";
            // 
            // TaskButton
            // 
            this.TaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskButton.Location = new System.Drawing.Point(531, 27);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(211, 27);
            this.TaskButton.TabIndex = 8;
            this.TaskButton.Text = "View Task";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 418);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.querySqlBox);
            this.Controls.Add(this.Execute);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(581, 456);
            this.Name = "MainForm";
            this.Text = "SQLDev";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.RichTextBox querySqlBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TaskButton;
    }
}

