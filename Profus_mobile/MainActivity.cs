using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace Profus_mobile
{
<<<<<<< HEAD
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true)]

=======
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
>>>>>>> parent of 33b27d6... 1.1.1
    public class MainActivity : AppCompatActivity
    {
        int Nb_joueur;
        Spinner spinner;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            #region Initialisation des boutons
            FindViewById<Button>(Resource.Id.Bouton_Jouer).Click += this.Jouer;
            FindViewById<Button>(Resource.Id.Bouton_Info).Click += this.Info;
            FindViewById<Button>(Resource.Id.Bouton_Parametre).Click += this.Parametre;
            FindViewById<Button>(Resource.Id.Bouton_Inscription).Click += this.Inscription;
            FindViewById<Button>(Resource.Id.Bouton_Score).Click += this.Score;
            #endregion

            #region Initialisation spinner
            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            spinner.Prompt = "Nombre de joueurs?";
            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Player, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            #endregion


            #region
            //8 space
            //7 autre 2x plus haute que space

            int hauteur = FindViewById<LinearLayout>(Resource.Id.linearLayout1).Height;
            int largeur = FindViewById<LinearLayout>(Resource.Id.linearLayout2).Width;

            FindViewById<Space>(Resource.Id.space1).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space2).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space3).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space4).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space5).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space6).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space7).SetMinimumHeight(hauteur / 22);
            FindViewById<Space>(Resource.Id.space8).SetMinimumHeight(hauteur / 22);

            FindViewById<LinearLayout>(Resource.Id.linearLayout2).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Jouer).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Info).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Parametre).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Inscription).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Score).SetMinimumHeight(hauteur / 11);
            FindViewById<Button>(Resource.Id.Bouton_Quitter).SetMinimumHeight(hauteur / 11);

            FindViewById<TextView>(Resource.Id.textView1).SetMinimumWidth(largeur / 2);
            FindViewById<Spinner>(Resource.Id.spinner).SetMinimumWidth(largeur / 2);
            #endregion

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #region Boutons
        void Jouer(object sender, System.EventArgs e)
        {
            Mode_de_Jeu.Nb_joueur = Nb_joueur;
            StartActivity(new Intent(this, typeof(Mode_de_Jeu)));
        }


        void Info(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this, typeof(Info)));
        }

        void Parametre(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this, typeof(Parametre)));
        }

        void Inscription(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this, typeof(Inscription)));
        }

        void Score(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this, typeof(Leaderboard)));
        }
        #endregion

        #region Spinner
        private void spinner_ItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
        {
            Nb_joueur = int.Parse(spinner.SelectedItemPosition.ToString()) + 1;
        }
        #endregion
    }
}