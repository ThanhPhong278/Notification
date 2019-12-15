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
    public partial class IndexNoteForm : Form
    {
        private NoteManagement Business;
        public IndexNoteForm()
        {
            InitializeComponent();
            this.Business = new NoteManagement();
            this.Load += IndexNoteForm_Load; 
            this.btnAdd.Click += btnAdd_Click; 
            this.BtnDelete.Click += btnDelete_Click;
            this.grdNote.DoubleClick += grdClasses_DoubleClick; 
        }

        private void LoadAllNote()
        {
            var note = this.Business.GetNote();
            this.grdNote.DataSource = note;
        }

        void grdClasses_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdNote.SelectedRows.Count == 1)
            {
                var @note = (NOTE)this.grdNote.SelectedRows[0].DataBoundItem;

                var updateForm = new UpdateNoteForm(@note.Id);
                updateForm.ShowDialog();
                this.LoadAllNote();
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdNote.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @note = (NOTE)this.grdNote.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteNote(@note.Id);
                    MessageBox.Show("Delete class successfully.");
                    this.LoadAllNote();
                }
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new CreateNoteForm();
            createForm.ShowDialog();
            this.LoadAllNote();
        }

        void IndexNoteForm_Load(object sender, EventArgs e)
        {
            this.LoadAllNote();
        }
    }
}
