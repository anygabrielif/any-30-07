using System;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private async void Cadastrar_Clicked(object sender, EventArgs e)
        {
            // Aqui você implementaria a lógica para salvar os dados do fornecedor
            // Por exemplo, enviando para um banco de dados ou serviço web

            await DisplayAlert("Sucesso", "Fornecedor cadastrado com sucesso!", "OK");
            // Limpar os campos após o cadastro (opcional)
        }
    }
}