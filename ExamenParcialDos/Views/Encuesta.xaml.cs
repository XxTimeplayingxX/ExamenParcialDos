using ExamenParcialDos.ViewModels;

namespace ExamenParcialDos.Views;

public partial class Encuesta : ContentPage
{
	public Encuesta(EncuestaViewModel encuestaViewModel)
	{
		InitializeComponent();
		BindingContext = encuestaViewModel;
	}
}