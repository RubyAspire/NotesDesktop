using System;
using System.IO;
using System.Collections.Generic;
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
    /// Interaction logic for Notes.xaml
    /// </summary>
    public partial class Notes : Window
    {
        
        public Notes()
        {
            InitializeComponent();
            List<NoteModel> notes = new List<NoteModel>();
            var files = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "*.notes.txt");
            foreach (var file in files)
            {
                notes.Add(new NoteModel
                {
                    Filename = file,
                    Text = File.ReadAllText(file),
                    Date = File.GetCreationTime(file).ToLongDateString()
                }) ;
            }

            noteList.ItemsSource = notes;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var noteEntry = new  NoteEntry { DataContext = new NoteModel()};
            noteEntry.Show();
            this.Close();
        }

        private void noteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (noteList.SelectedItem != null)
            {
                var noteEntry = new EditNote { DataContext = noteList.SelectedItem as NoteModel };
                noteEntry.Show();
                this.Close();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var path = noteList.SelectedItem as NoteModel;
            if (File.Exists(path.Filename))
            {
                File.Delete(path.Filename);
                var note = new Notes();
                note.Show();
                this.Close();
            }
                
        }

        private void noteList_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

            ContextMenu cm = this.FindResource("cmList") as ContextMenu;
            cm.PlacementTarget = sender as ListBoxItem;
            cm.IsOpen = true;
        }

    }
}
