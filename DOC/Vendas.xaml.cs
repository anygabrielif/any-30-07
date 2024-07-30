using System;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class VendaProduto : ContentPage
    {
        public VendaProduto()
        {
            InitializeComponent();
        }

        private void OnVenderClicked(object sender, EventArgs e)
        {
            string cliente = clienteEntry.Text;
            string produto = produtoEntry.Text;
            string quantidade = quantidadeEntry.Text;

            // Lógica para processar a venda
            DisplayAlert("Venda Realizada", $"Cliente: {cliente}\nProduto: {produto}\nQuantidade: {quantidade}", "OK");
        }
    }
}