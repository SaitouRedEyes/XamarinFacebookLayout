using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace FacebookLayout
{
    [Activity(Label = "FacebookLayout", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private EditText editLogin;
        private EditText editPass;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Button buttonLogin = FindViewById<Button>(Resource.Id.button_login);
            editLogin = FindViewById<EditText>(Resource.Id.edit_login);
            editPass = FindViewById<EditText>(Resource.Id.edit_pass);

            buttonLogin.Click += OnButtonLoginClicked;
        }

        private void OnButtonLoginClicked(object sender, EventArgs e)
        {
            if(!editLogin.Text.Equals("") && !editPass.Text.Equals(""))
            {
                Toast.MakeText(this, "Usuário logado com sucesso!", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Faltam informações para log in", ToastLength.Long).Show();
            }
        }
    }
}

