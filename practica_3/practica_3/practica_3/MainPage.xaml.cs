using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practica_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Informacion Del Alumno", "DATOS PERSONALES \n \n" + Nombre.Text + "\n" + APaterno.Text + "\n" + AMaterno.Text + "\n" + Direccion.Text + "\n" + Telefono.Text + "\n \n DATOS ESCOLARES \n \n" + Carrera.Text + "\n" + Semestre.Text + "\n" + Matricula.Text + "\n \n DATOS SOCIALES \n \n" + Correo.Text + "\n" + Github.Text + "", "OK");
            Nombre.IsEnabled = false;
            APaterno.IsEnabled = false;
            AMaterno.IsEnabled = false;
            Direccion.IsEnabled = false;
            Telefono.IsEnabled = false;
            Carrera.IsEnabled = false;
            Semestre.IsEnabled = false;
            Matricula.IsEnabled = false;
            Correo.IsEnabled = false;
            Github.IsEnabled = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Nombre.IsEnabled = true;
            APaterno.IsEnabled = true;
            AMaterno.IsEnabled = true;
            Direccion.IsEnabled = true;
            Telefono.IsEnabled = true;
            Carrera.IsEnabled = true;
            Semestre.IsEnabled = true;
            Matricula.IsEnabled = true;
            Correo.IsEnabled = true;
            Github.IsEnabled = true;
        }
    }
}
