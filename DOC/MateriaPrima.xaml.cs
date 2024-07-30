using System;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            // Aqui você implementaria a lógica para salvar os dados da matéria-prima
            // Por exemplo, enviando para um banco de dados ou serviço web

            await DisplayAlert("Sucesso", "Matéria-prima cadastrada com sucesso!", "OK");
            // Limpar os campos após o cadastro (opcional)
        }
    }
}