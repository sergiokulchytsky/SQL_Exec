namespace Task_Generation
{
    partial class AdminMainForm
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
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskBtn.Location = new System.Drawing.Point(354, 79);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(125, 30);
            this.AddTaskBtn.TabIndex = 0;
            this.AddTaskBtn.Text = "Add new task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtnClick);
            // 
            // TaskList
            // 
            this.TaskList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 15;
            this.TaskList.Location = new System.Drawing.Point(73, 79);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(275, 199);
            this.TaskList.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(354, 115);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(125, 30);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete task";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.Location = new System.Drawing.Point(354, 151);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(125, 30);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.AddTaskBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}