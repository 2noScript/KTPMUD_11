using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace h25.Model
{
    class TableName
    {
        public static string Saltyfood = "saltyfood";
        public static string Drink = "drink";
        public static string Desserts = "desserts";
        public static string Administration = "administration";
        public static string Userz = "userz";
        public static string historyOfData = "historyOfData";
    }
    class Administration
    {
        public string userName { get; set; }
        public string passwordz { get; set; }
        public string fullName { get; set; }
        public string gmail { get; set; }
        public string pathImage { get; set; }
        public string timeLine { get; set; }
        public string repaiTime { get; set; }
        public Administration(MySqlDataReader sqlReader)
        {
            Data(sqlReader);
        }
        public Administration()
        {

        }
        public void Data(MySqlDataReader sqlReader)
        {
            userName = sqlReader.GetString("userName");
            fullName = sqlReader.GetString("fullName");
            passwordz = sqlReader.GetString("passwordz");
            pathImage = sqlReader.GetString("pathImage");
            timeLine = sqlReader.GetString("timeLine");
            gmail = sqlReader.GetString("gmail");
            repaiTime = sqlReader.GetString("repaiTime");
        }
        public void ClearData()
        {
            userName = fullName = passwordz = pathImage = timeLine = gmail = repaiTime = null;
        }
    }

    
    //class administration
    //{
    //    public string userName { get; set; }
    //    public string passwordz { get; set; }
    //    public string fullName { get; set; }
    //    public string gmail { get; set; }
    //    public string pathImage { get; set; }
    //    public string timeLine { get; set; }
    //    public void copydata(MySqlDataReader sqlReader)
    //    {
    //        userName = sqlReader.GetString("userName");
    //        fullName = sqlReader.GetString("fullName");
    //        passwordz = sqlReader.GetString("passwordz");
    //        pathImage = sqlReader.GetString("pathImage");
    //        timeLine = sqlReader.GetString("timeLine");
    //        gmail = sqlReader.GetString("gmail");
    //    }
    //    public void display()
    //    {
    //        MessageBox.Show($"{userName} + {passwordz} +{fullName}+{gmail}+{pathImage}+{timeLine}");
    //    }
    //}
    class userz
    {
        public int id { get; set; }
        public int MyProperty { get; set; }
    }

    class Itemz
    {
        public string userAdmin { get; set; }
        public string  id { get; set; }//  primary key
        public string namez { get; set; }// primary key
        public string price { get; set; }
        public string pathImage { get; set; }
        public string information { get; set; }
        public string sale { get; set; }
        public string timeLine { get; set; }
        public string repaiTime { get; set; }
        public Itemz()
        {

        }
        public Itemz(MySqlDataReader sqlReader)
        {
            copydata(sqlReader);
        }

        void copydata(MySqlDataReader sqlReader)
        {
            userAdmin= sqlReader.GetString("userAdmin");
            id = sqlReader.GetString("id");
            namez = sqlReader.GetString("namez");
            price = sqlReader.GetString("price");
            pathImage = sqlReader.GetString("pathImage");
            information = sqlReader.GetString("information");
            sale = sqlReader.GetString("sale");
            timeLine = sqlReader.GetString("timeLine");
            repaiTime = sqlReader.GetString("repaiTime");
        }
    }
}
