using System;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class CadastroTransportadora : ContentPage
    {
        public CadastroTransportadora()
        {
            InitializeComponent();
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            // Aqui você implementaria a lógica para salvar os dados da transportadora
            // Por exemplo, enviando para um banco de dados ou serviço web

            // Obtendo os valores dos campos
            string nome = entryNome.Text;
            string telefone = entryTelefone.Text;
            string endereco = entryEndereco.Text;
            string cnpj = entryCnpj.Text;

            // Lógica para salvar os dados

            await DisplayAlert("Sucesso", "Transportadora cadastrada com sucesso!", "OK");
            // Limpar os campos após o cadastro (opcional)
        }
    }
}
