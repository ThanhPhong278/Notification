using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TodolistForm : Form
    {
       private TodolistManagement Business;
        public TodolistForm()
        {
            InitializeComponent();
            this.Business = new TodolistManagement();
            this.Load += TodolistForm_Load; 
            this.btnsave.Click += btnsave_Click; 
            this.btndelete.Click += btnDelete_Click;
            this.grdTodo.DoubleClick += grdTodo_DoubleClick; 
        }

        private void LoadAllTodolist()
        {
            var note = this.Business.GetTodo();
            this.grdTodo.DataSource = note;
        }

        void grdTodo_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdTodo.SelectedRows.Count == 1)
            {
                var @todo = (TODOLIST)this.grdTodo.SelectedRows[0].DataBoundItem;

                var updateForm = new UpdateTodolist(@todo.TODO_Id);
                updateForm.ShowDialog();
                this.LoadAllTodolist();
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdTodo.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @todo = (TODOLIST)this.grdTodo.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteTodo(@todo.TODO_Id);
                    MessageBox.Show("Delete Todolist successfully.");
                    this.LoadAllTodolist();
                }
            }
        }

        void btnsave_Click(object sender, EventArgs e)
        {
            var createForm = new CreateTodolist();
            createForm.ShowDialog();
            this.LoadAllTodolist();
        }
        

        void TodolistForm_Load(object sender, EventArgs e)
        {
            this.LoadAllTodolist();
        }
    }
}
