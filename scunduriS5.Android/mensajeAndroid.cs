using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using scunduriS5.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//para que se lea la clase cuando se ejecute la aplicacion xq esta fuera del archivo rpincipal
[assembly: Xamarin.Forms.Dependency(typeof(mensajeAndroid))]
namespace scunduriS5.Droid
{
    //despues de los dos puntos hace referencia a la clase que creamos en la carpeta principal
    public class mensajeAndroid : Mensaje
    {
        //se genera la clase para le mensaje largo
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();  
            //throw new NotImplementedException();
        }
        //clase para el mensaje corto
        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}