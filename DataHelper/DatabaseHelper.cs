using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public static class DatabaseHelper
    {
        private static readonly string cnnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\ANDJE\\SOURCE\\REPOS\\ZADATAK3API\\DATAHELPER\\BAZA.MDF";
        public static void SaveData(AnswerModel answer)
        {
            using (SqlConnection cnn=new SqlConnection(cnnString))
            {
                cnn.Open();
                string text = $"INSERT INTO ANSWERS (p1,p2,p3,p4,p5,p6,p7,p8) values ('{answer.p1}','{answer.p2}','{answer.p3}','{answer.p4}','{answer.p5}','{answer.p6}','{answer.p7}','{answer.p8}')";
                SqlCommand cmd = new(text, cnn);
                cmd.ExecuteNonQuery();
            
            }
        }
    }
}
