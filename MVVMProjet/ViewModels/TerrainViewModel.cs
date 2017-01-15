using MVVMProjet.Models;
using MVVMProjet.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMProjet.ViewModels
{
    class TerrainViewModel : INotifyPropertyChanged
    {
        private List<Terrain> _TerrainsList;
        public List<Terrain> TerrainsList
        {
            get
            {
                return _TerrainsList;
            }
            set
            {
                _TerrainsList = value;
                OnPropertyChanged();
            }
        }
        private Terrain _TerrainsAdd = new Terrain();
        public Terrain TerrainsAdd
        {
            get
            {
                return _TerrainsAdd;
            }
            set
            {
                _TerrainsAdd = value;
                OnPropertyChanged();
            }
        }
        public Command PostCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new TerrainServices();
                    await u.PostTerrainsAsync(_TerrainsAdd);
                });
            }
        }
        public TerrainViewModel()
        {
            InitializerDataASYNC();
        }

        private async Task InitializerDataASYNC()
        {
            var TerrainsServ = new TerrainServices();
            TerrainsList = await TerrainsServ.getTerrainsAsync();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public Command PutCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new TerrainServices();
                    await u.PutTerrainsAsync(_TerrainsAdd.Id, _TerrainsAdd);
                });
            }
        }
        public Command DeletetCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new TerrainServices();
                    await u.DeleteTerrainsAsync(_TerrainsAdd.Id);
                });
            }
        }

    }
}
