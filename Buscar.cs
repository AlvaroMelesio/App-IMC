using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace App_IMC
{
    [Activity(Label = "Buscar")]
    public class Buscar : Activity
    {
        string Usuario;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Buscar);
            var txtDia = FindViewById<EditText>(Resource.Id.txtdia);
            var txtMes = FindViewById<EditText>(Resource.Id.txtmes);
            var txtVolver = FindViewById<TextView>(Resource.Id.txtvolver);
            var btnBuscar = FindViewById<Button>(Resource.Id.btnbuscar);
            var txtUsuario = FindViewById<TextView>(Resource.Id.txt);
            var txtPeso = FindViewById<TextView>(Resource.Id.txtpeso);
            var txtEstatura = FindViewById<TextView>(Resource.Id.txtestatura);
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
            // Create your application here

            btnBuscar.Click += delegate
            {
                var Conjunto = new DataSet();
                DataRow Renglon;
                try
                {
                    //var WS = new WebService.WebService1(); Peso Estatura IMC Estado
                    var WS = new Azure.WebService1();
                    Conjunto = WS.BuscarIMC(Usuario, int.Parse(txtDia.Text), (txtMes.Text));
                    Renglon = Conjunto.Tables["Datos"].Rows[0];
                    txtPeso.Text = "Peso de: " + Renglon["Peso"].ToString() + "kg.";
                    txtEstatura.Text = "Estatura de: " + Renglon["Estatura"].ToString() + "mts." ;
                    txtIMC.Text = "IMC = " + Renglon["IMC"].ToString();
                    txtEstado.Text = "Tu IMC es " + Renglon["Estado"].ToString() + ".";
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
                }
            };
        }
    }
}