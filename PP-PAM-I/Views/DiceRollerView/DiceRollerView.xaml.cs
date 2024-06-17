using System.Text;

namespace PP_PAM_I.Views.DiceRoller;

public partial class DiceRollerView : ContentPage
{
    private Random rnd = new Random();
    public DiceRollerView()
    {
        InitializeComponent();
    }

    private void onDiceRoll(object sender, EventArgs e)
    {
        if (ladoDado.SelectedItem != null && quantidadeDado.SelectedItem != null)
        {
            int faces = (int)ladoDado.SelectedItem;
            int quantity = (int)quantidadeDado.SelectedItem;
            int total = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < quantity; i++)
            {
                int roll = rnd.Next(1, faces + 1);
                total += roll;
                result.Append($"Dado {i + 1}: {roll}\n");
            }

            result.Append($"\nTotal: {total}");
            valorDado.Text = result.ToString();
        }
        else
        {
            DisplayAlert("Erro", "Por favor, selecione a quantidade de lados e a quantidade de dados.", "OK");
        }
    }
}