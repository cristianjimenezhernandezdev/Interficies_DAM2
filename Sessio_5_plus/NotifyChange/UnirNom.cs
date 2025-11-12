using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotifyChange
{
    public class UnirNom:INotifyPropertyChanged
    {
        private string _nom;
        private string _cognom;
        private string _nomcomplet;

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value;OnPropertyChanged(nameof(NomComplet)); }
        }
        public string Cognom
        {
            get { return _cognom; }
            set { _cognom = value;OnPropertyChanged(nameof(NomComplet)); }
        }
        public string NomComplet
        {
           get {
                _nomcomplet = _nom + " "+ _cognom;
                return _nomcomplet; }
            set 
            {
                
                _nomcomplet = value;
                //Fer el Split, StringName??
                
            }
        }
 

    }
}
