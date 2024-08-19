using System;
using Microsoft.Maui.Controls;

namespace DOC
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="LiteDBExample.ListaClientesPage"
             BackgroundColor="LightBlue"
             Title="Cadastrar Fornecedor">
  <VerticalStackLayout>
  <Button Text="Criar Novo Cliente"
          BackgroundColor="Orange"
          FontSize="16"
          TextColor="Black"
          Clicked="NovoClienteClicked"/>
    <ListView x:Name="ListaClientes"
              HasUnevenRows="True"
              ItemSelected="QuandoSelecionarUmItemNaLista"
              HorizontalOptions="Fill"
              VerticalOptions="Fill">
      <ListView.ItemTemplate>
        <DataTemplate>
          <ViewCell>
            <VerticalStackLayout Padding="20"
                                BackgroundColor="Pink">
              <HorizontalStackLayout>
                <Label Text="{Binding Nome}"
                      FontSize="20"/>
                <Label Text="{Binding Sobrenome}"
                      FontSize="20"
                      Margin="10,0,0,0"/>
              </HorizontalStackLayout>
              <Label Text="{Binding Telefone}"
                      FontSize="20"/>
            </VerticalStackLayout>
          </ViewCell>
        </DataTemplate>
      </ListView.ItemTemplate>
    </ListView>
  </VerticalStackLayout>
</ContentPage>