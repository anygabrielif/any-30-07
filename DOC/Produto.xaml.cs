using System;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class CadastroProduto : ContentPage
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            // Aqui você implementaria a lógica para salvar os dados do produto
            // Por exemplo, enviando para um banco de dados ou serviço web

            string codigo = entryCodigo.Text;
            string nome = entryNome.Text;
            string telefone = entryTelefone.Text;
            string endereco = entryEndereco.Text;
            int estoque = int.Parse(entryEstoque.Text);

            // Lógica para salvar os dados

            await DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");
            // Limpar os campos após o cadastro (opcional)
        }
    }
}