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
    [Activity(Label = "Guardar")]
    public class Guardar : Activity
    {
        string Usuario;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Guardar);
            var txtVolver = FindViewById<TextView>(Resource.Id.txtvolver);
            var btnGuardar = FindViewById<Button>(Resource.Id.brnguardar);
            var txtPeso = FindViewById<EditText>(Resource.Id.txtpeso);
            var txtEstatura = FindViewById<EditText>(Resource.Id.txtestatura);
            var txtUsuario = FindViewById<TextView>(Resource.Id.txt);
            var txtIMC = FindViewById<TextView>(Resource.Id.txtimc);
            var txtEstado = FindViewById<TextView>(Resource.Id.txtestado);
            Usuario = Intent.GetStringExtra("Usuario");
            txtUsuario.Text = "Ingresa los datos " + Usuario + ".";

            

            txtVolver.Click += delegate
            {
                var Volver = new Intent(this, typeof(Pag1));
                Volver.PutExtra("Usuario", Usuario);
                StartActivity(Volver);
            };

            btnGuardar.Click += delegate
            {
                try
                {
                    double Resultado;
                    string Estado = "-";
                    double Peso;
                    double Estatura;
                    Peso = double.Parse(txtPeso.Text);
                    Estatura = double.Parse(txtEstatura.Text);
                    Resultado = (Peso / (Estatura * Estatura));
                    string Nombre = Usuario;
                    if (Resultado <= 18.5)
                    {
                        Estado = "Bajo Peso";
                    }
                    else
                    {
                        if (Resultado > 18.5 && Resultado <= 24.9)
                        {
                            Estado = "Normal";
                        }
                        else
                        {
                            if (Resultado >= 25 && Resultado <= 29.9)
                            {
                                Estado = "Sobrepeso";
                            }
                            else
                            {
                                if (Resultado >= 30)
                                {
                                    Estado = "Obeso";
                                }
                            }
                        }
                    }
                    txtEstado.Text = "Tu estado es: " + Estado + ".";
                    txtIMC.Text = "Tu IMC es de: " + Resultado.ToString() + ".";

                    //var WS = new WebService.WebService1();
                    var WS = new Azure.WebService1();
                    if (WS.GuardarIMC(Nombre, Peso, Estatura, Resultado, Estado))
                        Toast.MakeText(this, "Guardado correctamente en SQL Server", ToastLength.Long).Show();
                    else
                        Toast.MakeText(this, "No Guardado", ToastLength.Long).Show();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
                }
            };

            // Create your application here
        }
    }
}