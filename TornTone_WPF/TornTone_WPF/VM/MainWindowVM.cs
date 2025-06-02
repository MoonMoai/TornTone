using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornTone_WPF.Datas;
using TornTone_WPF.VM.Bases;

namespace TornTone_WPF.VM
{
    public class MainWindowVM : ViewModelBase
    {
        private IList<Photo>? _photo;
        public IList<Photo>? Photo
        {
            get => _photo;
            set => SetProperty(ref _photo, value);
        }

        private Photo? _selectedPhoto;
        public Photo? SelectedPhoto
        {
            get => _selectedPhoto;
            set => SetProperty(ref _selectedPhoto, value);
        }

        public MainWindowVM()
        {
            Photo = new List<Photo>
            {
                new Photo {Id = 111, Title = "Spring"},
                new Photo {Id = 222, Title = "Summer"},
                new Photo {Id = 333, Title = "Autumn"},
                new Photo {Id = 444, Title = "Winter"},
            };
        }
    }
}
