using NarvaezEstebanExamen.Interfaces;
using NarvaezEstebanExamen.Models;
using NarvaezEstebanExamen.Repositories;

namespace NarvaezEstebanExamen;

public partial class Pagina1 : ContentPage
{
	IRecargaTelefonicaRepository _recargaTelefonicaRepository;
	RecargaTelefonica recarga = new RecargaTelefonica();
	public Pagina1()
	{
		_recargaTelefonicaRepository = new RecargaTelefonicaArchivos();
		InitializeComponent();

		recarga = _recargaTelefonicaRepository.DevuelveRecargaTelefonica(1);
		BindingContext = recarga;
	}
	private async void GuardarRecarga_Clicked(object sender, EventArgs e)
	{
		RecargaTelefonica recarga = new RecargaTelefonica
		{
			Nombre = editor_nombre.Text,
			Numero = editor_numero.Text
		};
		bool guardar_recarga = _recargaTelefonicaRepository.CrearRecargaTelefonica(recarga);

		if (guardar_recarga)
		{
			await DisplayAlert("Alerta", "Recarga guardada", "OK");
		}
		else
		{
            await DisplayAlert("Alerta", "Recarga NO guardada", "OK");
        }
	}
}