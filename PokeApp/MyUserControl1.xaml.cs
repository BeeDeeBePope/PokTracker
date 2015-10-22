using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeApp
{
    

    public sealed partial class MyUserControl1 : UserControl
    {
        List<string> zapis_PokID;

        public MyUserControl1(string userName)
        {
            
            zapis_PokID = new List<string>();
            this.InitializeComponent();
            textUsrName.Text = userName;
        }
    }

    
}
