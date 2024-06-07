using PP_PAM_I.Views.FichaPersonagemView;

namespace PP_PAM_I
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FichaPersonagemView();
        }
    }
}
