using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornTone_WPF.Datas
{
    public class Photo : ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                SetProperty(ref _id, value);
            }
        }

        private string? _title;
        public string? Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }
    }
}
