using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace DOC
{
    public partial class Clientes : ContentPage
    {
        private ObservableCollection<string> clientes;

        public Clientes()
        {
            InitializeComponent();

            clientes = new ObservableCollection<string>
            {
                "João",
                "Maria",
                "José",
                "Pedro",
                "Thiago"
            };

            clientesCollectionView.ItemsSource = clientes;
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            clientes.Add("Novo Cliente");
        }

        private void OnRemoveClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string cliente = button.CommandParameter as string;
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }
    }
}