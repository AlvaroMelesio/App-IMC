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
    [Activity(Label = "Registro")]
    public class Registro : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Registro);

            var txtUsuario = FindViewById<EditText>(Resource.Id.txtusuario);
            var txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            var btnSignup = FindViewById<Button>(Resource.Id.btnsignup);
            var txtVolver = FindViewById<TextView>(Resource.Id.txtvolver);

            txtVolver.Click += delegate
            {
                var Volver = new Intent(this, typeof(Login));
                StartActivity(Volver);
            };
            // Create your application here
        }
    }
}