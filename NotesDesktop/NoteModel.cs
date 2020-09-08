using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotesDesktop
{
    public class NoteModel
    {
        private string title;
        public string Title 
        {
            get 
            {
                title = Text;
                var splitIndex = title.Split();//Regex.Replace(title.Split()[0], @"^[0-9a-zA-Z\ ]+","");
                return splitIndex[0];
            }
            set { title = value; } 
        }
        public string Filename { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
    }
}
