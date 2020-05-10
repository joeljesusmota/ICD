using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaseballScout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    {

        public IList<Player> Players { get; private set; }

        public PlayerPage()
        {
            InitializeComponent();

            Players = new List<Player>();

            Players.Add(new Player
            {
                Name = "Mora Montero",
                Classification = 1,
                Categorie = "Catcher"
            });

            Players.Add(new Player
            {
                Name = "Hector Luis",
                Classification = 3,
                Categorie = "Catcher"
            });

            Players.Add(new Player
            {
                Name = "Jorge Isidro",
                Classification = 4,
                Categorie = "Catcher"
            });

            BindingContext = this;
        }
    }
}