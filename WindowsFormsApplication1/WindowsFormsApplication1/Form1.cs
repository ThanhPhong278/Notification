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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnNote.Click += btnNote_Click;
            btnTodo.Click += btnTodo_Click;
        }

        void btnTodo_Click(object sender, EventArgs e)
        {
            var TodolistForm = new TodolistForm();
            TodolistForm.ShowDialog();
            this.LoadAllTodolist();
        }

        private void LoadAllTodolist()
        {
           
        }

        private void LoadAllNote()
        {
            
        }

        void btnNote_Click(object sender, EventArgs e)
        {
            //var indexNoteForm = new IndexNoteForm();
            //indexNoteForm.ShowDialog();
            new IndexNoteForm().ShowDialog();
            this.LoadAllNote();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
