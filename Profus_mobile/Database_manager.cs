using Android.App;
using Android.Content.PM;
using Android.OS;
using SQLite;

namespace Profus_mobile
{
    [Activity(Label = "People", Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class Database_manager : Activity
    {
        [Table ("Question")]
        public class Question
        {
            [PrimaryKey, Unique, Column("Numero")]
            public int Numero { get; set; }

            [Unique, Column("Niveau")]
            public int Niveau { get; set; }

            [MaxLength(50),Unique,Column("Categorie")]
            public string Categorie { get; set; }

            [MaxLength(200), Unique, Column("Question")]
            public string Question_val { get; set; }

            [Unique, Column("Num_Reponse")]
            public int Num_Reponse { get; set; }

            [MaxLength(200), Unique, Column("Reponse1")]
            public string Reponse1 { get; set; }

            [MaxLength(200), Unique, Column("Reponse2")]
            public string Reponse2 { get; set; }

            [MaxLength(200), Unique, Column("Reponse3")]
            public string Reponse3 { get; set; }

            [MaxLength(200), Unique, Column("Reponse4")]
            public string Reponse4 { get; set; }
        }
    }
}