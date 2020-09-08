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
    /// Interaction logic for NoteEntry.xaml
    /// </summary>
    public partial class NoteEntry : Window
    {
        string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"{Path.GetRandomFileName()}.notes.txt");
        public NoteEntry()
        {
            InitializeComponent();
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var note = (NoteModel)DataContext;
            if (string.IsNullOrWhiteSpace(note.Text))
            {
                MessageBox.Show("Nothing to save");
            }
            else
            {
                File.WriteAllText(filename, note.Text);
                var notes = new Notes();
                notes.Show();
                this.Close();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var notes = new Notes();
            notes.Show();
            this.Close();
        }
    }
}
