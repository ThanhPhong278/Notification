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
    public partial class CreateNoteForm : Form
    {
        private NoteManagement Business;
        public CreateNoteForm()
        {
            InitializeComponent();
            this.Business = new NoteManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtTitle.Text;
            var description = this.txtContent.Text;

            this.Business.Create(name, description);
            MessageBox.Show("Add new Note successfully.");
            this.Close();

        }
    }
}
