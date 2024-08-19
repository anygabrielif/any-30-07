using Microsoft.Maui.Controls;

namespace any3007
{
    public partial class FornecedorPage: ContentPage
    {
        public FornecedorPage()
        {
            InitializeComponent();
        }
    
        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Cadastrado", "Fornecedor cadastrado com sucesso!", "OK");
        }
    }

}