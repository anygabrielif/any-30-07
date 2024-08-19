using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace any3007
{
  public partial class ClientesPage : ContentPage
  {
    ObservableCollection<Cliente> Clientes;

    public ClientesPage()
    {
      InitializeComponent();
      Clientes = new ObservableCollection<Cliente>
        {
                new Cliente { Nome = "Larissa Gomes", Endereco = "Rua A, 123", Gmail = "larissa@gmail.com", CPF = "123.456.789-00" },
                new Cliente { Nome = "Gabriel Costa", Endereco = "Rua B, 456", Gmail = "gabriel@gmail.com", CPF = "987.654.321-00" }
            };
      ClientesCollectionView.ItemsSource = Clientes;
    }

    private void OnCadastrarClienteClicked(object sender, EventArgs e)
    {
      if (await VerificaSeDadosEstaoCorretos())
      {

        var cliente = new Modelos.Cliente();
        if (!String.IsNullOrEmpty(IdLabel.Text))
          cliente.Id = int.Parse(IdLabel.Text);
        else
          cliente.Id = 0;
        cliente.Nome = NomeEntry.Text;
        cliente.Endereço = EndereçoEntry.Text;
        cliente.CPF = CPFEntry.Text;
        clienteControle.CriarOuAtualizar(cliente);

        await DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
      }
    }

  }

  private void removerclienteclicado(object sender, EventArgs e)
  {
    var button = sender as Button;
    var cliente = button?.BindingContext as Cliente;
    if (cliente != null)
    {
      Clientes.Remove(cliente);
      DisplayAlert("Remover", "Cliente removido com sucesso!", "OK");
    }
  }

   private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(NomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Sobrenome está vazia
    else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Telefone está vazia
    else if (String.IsNullOrEmpty(TelefoneEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
      return false;
    }
    else
      return true;
  }
}
