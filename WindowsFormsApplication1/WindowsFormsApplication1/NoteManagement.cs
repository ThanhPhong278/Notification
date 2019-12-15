using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApplication1
{
    public class NoteManagement
    {
        

        
        public NOTE[] GetNote()
        {
            var db = new Notification_SoftwareEntities();
            var notes = db.NOTE.ToArray();
            return notes;

        }

        public void CreateNote(string title, string content)
        {
            var newNote = new NOTE();
            newNote.TITLE = title;
            newNote.CONTENT = content;
            newNote.DTIME = DateTime.Now;
            

            var db = new Notification_SoftwareEntities();
            db.NOTE.Add(newNote);
            db.SaveChanges();
        }

        public void UpdateNote(int id, string title, string content)
        {
            var db = new Notification_SoftwareEntities();
            var oldNote = db.NOTE.Find(id);

            oldNote.TITLE= title;
            oldNote.CONTENT = content;

            db.Entry(oldNote).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteNote(int id)
        {
            var db = new Notification_SoftwareEntities();
            var @note = db.NOTE.Find(id);
            db.NOTE.Remove(@note);
            db.SaveChanges();
        }

        public NOTE GetNote(int id)
        {
            var db = new Notification_SoftwareEntities();
            var @note = db.NOTE.Find(id);
            return @note;
        }
    }
}
