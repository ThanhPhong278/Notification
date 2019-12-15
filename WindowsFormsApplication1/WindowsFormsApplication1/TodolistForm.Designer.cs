namespace WindowsFormsApplication1
{
    partial class TodolistForm
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
            this.grdTodo = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnsave = new System.Windows.Forms.ToolStripMenuItem();
            this.btndelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTodo
            // 
            this.grdTodo.AllowUserToAddRows = false;
            this.grdTodo.AllowUserToDeleteRows = false;
            this.grdTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTodo.Location = new System.Drawing.Point(0, 28);
            this.grdTodo.Name = "grdTodo";
            this.grdTodo.ReadOnly = true;
            this.grdTodo.RowTemplate.Height = 24;
            this.grdTodo.Size = new System.Drawing.Size(940, 419);
            this.grdTodo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsave,
            this.btndelete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnsave
            // 
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(52, 24);
            this.btnsave.Text = "Save";
            // 
            // btndelete
            // 
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(65, 24);
            this.btndelete.Text = "Delete";
            // 
            // TodolistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 447);
            this.Controls.Add(this.grdTodo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TodolistForm";
            this.Text = "TodolistForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdTodo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTodo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnsave;
        private System.Windows.Forms.ToolStripMenuItem btndelete;

    }
}