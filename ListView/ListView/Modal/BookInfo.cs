using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public class BookInfo : INotifyPropertyChanged
    {
        private string bookName;
        private string bookDesc;
        private bool isAnimated;

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public bool IsAnimated
        {
            get { return isAnimated; }
            set
            {
                this.isAnimated = value;
                OnPropertyChanged("IsAnimated");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
