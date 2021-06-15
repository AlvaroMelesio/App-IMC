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
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        string Usuario, Password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login);
            // Create your application here

            var btnIngresar = FindViewById<Button>(Resource.Id.btningresar);
            var txtUsuario = FindViewById<EditText>(Resource.Id.txtusuario);
            var Imagen = FindViewById<ImageView>(Resource.Id.imagen);
            var txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            var btnSignup = FindViewById<TextView>(Resource.Id.txtrsignup);
            Imagen.SetImageResource(Resource.Drawable.LogoLaSalle);


            txtUsuario.Click += delegate
            {
                txtUsuario.Text = null;
            };

            txtPassword.Click += delegate
            {
                txtPassword.Text = null;
            };

            btnIngresar.Click += delegate
            {
                try
                {
                    Usuario = txtUsuario.Text;
                    Password = txtPassword.Text;
                    if (Usuario == "Alvaro")
                        if (Password == "123")
                        {
                            Cargar();
                        }
                        else
                            Toast.MakeText(this, "Error en Password", ToastLength.Long).Show();
                    else
                        Toast.MakeText(this, "Error en Usuario", ToastLength.Long).Show();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
                }
            };

            btnSignup.Click += delegate
            {
                var Registro = new Intent(this, typeof(Registro));
                StartActivity(Registro);
            };
        }

        public void Cargar()
        {
            var Siguiente = new Intent(this, typeof(Pag1));
            Siguiente.PutExtra("Usuario", Usuario);
            StartActivity(Siguiente);
        }
    }
}