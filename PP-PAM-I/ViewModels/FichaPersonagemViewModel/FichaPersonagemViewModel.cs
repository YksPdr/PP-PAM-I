using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using PP_PAM_I.Models.FichaPersonagemModel;

namespace PP_PAM_I.ViewModel
{
    public class FichaPersonagemViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Personagem> Personagens { get; set; } = new ObservableCollection<Personagem>();
        public FichaPersonagemViewModel()
        {
            AdicionarPersonagemCommand = new Command(AdicionarPersonagem);
        }
        public ICommand AdicionarPersonagemCommand { get; }

        
        
        #region Propriedades
        private string nome;
        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        private string personagemClasse;
        public string PersonagemClasse
        {
            get => personagemClasse;
            set
            {
                personagemClasse = value;
                OnPropertyChanged(nameof(PersonagemClasse));
            }
        }

        private int nivel;
        public int Nivel
        {
            get => nivel;
            set
            {
                nivel = value;
                OnPropertyChanged(nameof(Nivel));
            }
        }

        private string raca;
        public string Raca
        {
            get => raca;
            set
            {
                raca = value;
                OnPropertyChanged(nameof(Raca));
            }
        }
        #endregion

        #region Métodos
        private void AdicionarPersonagem()
        {
            var novoPersonagem = new Personagem
            {
                Nome = Nome,
                Classe = PersonagemClasse,
                Nivel = Nivel,
                Raca = Raca
            };

            Personagens.Add(novoPersonagem);

            Nome = string.Empty;
            PersonagemClasse = string.Empty;
            Nivel = 0;
            Raca = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
