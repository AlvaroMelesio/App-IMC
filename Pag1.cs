using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_IMC
{
    [Activity(Label = "Pag1")]
    public class Pag1 : Activity
    {
        string Usuario;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pag1);

            var txtBienvenido = FindViewById<TextView>(Resource.Id.txtbienvenido);
            var txtSalir = FindViewById<TextView>(Resource.Id.txtsalir);
            var txtCambiarUsuario = FindViewById<TextView>(Resource.Id.txtcambiar);
            var btnCalcular = FindViewById<TextView>(Resource.Id.btncalcular);
            var btnBuscar = FindViewById<TextView>(Resource.Id.btnbuscar);

            Usuario = Intent.GetStringExtra("Usuario");
            txtBienvenido.Text = "Bienvenido " + Usuario + ".";

            txtSalir.Click += delegate
            {
                System.Environment.Exit(0);
            };

            txtCambiarUsuario.Click += delegate
            {
                var Volver = new Intent(this, typeof(Actualizar));
                StartActivity(Volver);
            };


            btnBuscar.Click += delegate
            {
                var Buscar = new Intent(this, typeof(Buscar));
                Buscar.PutExtra("Usuario", Usuario);
                StartActivity(Buscar);
            };

            btnCalcular.Click += delegate
            {
                var Calcular = new Intent(this, typeof(Guardar));
                Calcular.PutExtra("Usuario", Usuario);
                StartActivity(Calcular);
            };

            // Create your application here
        }
    }
}