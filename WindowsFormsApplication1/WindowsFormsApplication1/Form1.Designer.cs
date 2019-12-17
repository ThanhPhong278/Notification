namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNote = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNote.Location = new System.Drawing.Point(221, 192);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(141, 86);
            this.btnNote.TabIndex = 0;
            this.btnNote.Text = "Notification";
            this.btnNote.UseVisualStyleBackColor = false;
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTodo.Location = new System.Drawing.Point(436, 192);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(133, 86);
            this.btnTodo.TabIndex = 1;
            this.btnTodo.Text = "To Do List";
            this.btnTodo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Notification";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnNote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Label label1;

    }
}

