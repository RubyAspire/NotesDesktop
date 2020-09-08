using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace NotesDesktop
{
    /// <summary>
    /// Interaction logic for EditNote.xaml
    /// </summary>
    public partial class EditNote : Window
    {
 
        public EditNote()
        {
            InitializeComponent();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var note = (NoteModel)DataContext;
            File.WriteAllText(note.Filename, note.Text);
            var notes = new Notes();
            notes.Show();
            this.Close();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var note = (NoteModel)DataContext;
            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }
            var notes = new Notes();
            notes.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var notes = new Notes();
            notes.Show();
            this.Close();
        }
    }
}
