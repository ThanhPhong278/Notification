namespace WindowsFormsApplication1
{
    partial class IndexNoteForm
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
            this.grdNote = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTodolist = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdNote)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdNote
            // 
            this.grdNote.AllowUserToAddRows = false;
            this.grdNote.AllowUserToDeleteRows = false;
            this.grdNote.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grdNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNote.Location = new System.Drawing.Point(0, 28);
            this.grdNote.Name = "grdNote";
            this.grdNote.ReadOnly = true;
            this.grdNote.RowTemplate.Height = 24;
            this.grdNote.Size = new System.Drawing.Size(1050, 421);
            this.grdNote.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.BtnDelete,
            this.btnTodolist});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 24);
            this.btnAdd.Text = "Add";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(65, 24);
            this.BtnDelete.Text = "Delete";
            // 
            // btnTodolist
            // 
            this.btnTodolist.BackColor = System.Drawing.SystemColors.Info;
            this.btnTodolist.Name = "btnTodolist";
            this.btnTodolist.Size = new System.Drawing.Size(74, 24);
            this.btnTodolist.Text = "Todolist";
            // 
            // IndexNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 449);
            this.Controls.Add(this.grdNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexNoteForm";
            this.Text = "IndexNoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdNote)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem BtnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnTodolist;
    }
}