using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kevinTs3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;

        }
    
    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double dato1 = Convert.ToDouble(txtDatoUno.Text);
        double dato2 = Convert.ToDouble(txtDatoDos.Text);
        /*double dato3 = Convert.ToDouble(txtDatoTres.Text);*/
        double operacion = dato1 * 0.3 + dato2 * 0.2;
        txtResultado.Text = operacion.ToString();


        double dato3 = Convert.ToDouble(txtDatoTres.Text);
        double dato4 = Convert.ToDouble(txtDatoCuatro.Text);
        double operacion2 = dato3 * 0.3 + dato4 * 0.2;
        txtResultado2.Text = operacion2.ToString();
        double operacion3 = operacion + operacion2;
        txtNotaFinal.Text = operacion3.ToString();
        if (operacion3 < 4.9)
        {
            DisplayAlert("Aviso", "El estudiante Pierde Semestre", "cerrar");
        }

        if (operacion3 > 7)
        {
            DisplayAlert("Aviso", "El estudiante Aprueba Semestre", "cerrar");
        }

        if (operacion3 < 6.9)
        {
            DisplayAlert("Aviso", "El estudiante rinde exam complementario", "cerrar");
        }

    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
    {
        double dato2 = Convert.ToDouble(txtDatoDos.Text);
        if (dato2 > 10)
        {
            DisplayAlert("Validacion", "ingrse numeros del 1-10", "cerrar");
        }

    }

    private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
    {
        double dato1 = Convert.ToDouble(txtDatoUno.Text);
        if (dato1 > 10)
        {
            DisplayAlert("Validacion", "ingrse numeros del 1-10", "cerrar");
        }
    }

    private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
    {
        double dato3 = Convert.ToDouble(txtDatoTres.Text);
        if (dato3 > 10)
        {
            DisplayAlert("Validacion", "ingrse numeros del 1-10", "cerrar");
        }
    }

    private void txtDatoCuatro_TextChanged(object sender, TextChangedEventArgs e)
    {
        double dato4 = Convert.ToDouble(txtDatoCuatro.Text);
        if (dato4 > 10)
        {
            DisplayAlert("Validacion", "ingrse numeros del 1-10", "cerrar");
        }
    }


}
}

