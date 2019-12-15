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
    public partial class UpdateNoteForm : Form
    {

        private int NoteId;
        private NoteManagement Business;
        public UpdateNoteForm(int id)
        {
            InitializeComponent();
            this.NoteId = id;
            this.Business = new NoteManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateNoteForm_Load;
        }

        void UpdateNoteForm_Load(object sender, EventArgs e)
        {
            var oldNote = this.Business.GetNote(this.NoteId);
            this.txtTitle.Text = oldNote.TITLE;
            this.txtContent.Text = oldNote.CONTENT;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var title = this.txtTitle.Text;
            var content = this.txtContent.Text;
            this.Business.UpdateNote(this.NoteId, title, content);
            MessageBox.Show("Update Note successfully.");
        }
    }
}
