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
    [Activity(Label = "Actualizar")]
    public class Actualizar : Activity
    {
        string Usuario;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Actualizar);
            var txtUsername = FindViewById<EditText>(Resource.Id.txtusuario);
            var txtNewUsername = FindViewById<EditText>(Resource.Id.txtusuarionuevo);
            var txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            var txtVolver = FindViewById<TextView>(Resource.Id.txtvolver);

            txtVolver.Click += delegate
            {
                var Volver = new Intent(this, typeof(Pag1));
                StartActivity(Volver);
            };
            // Create your application here
        }
    }
}