using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transactions_Optimistic
{
    public partial class UserControl1: UserControl
    {
        private byte[] rowVersion;
        private const string username = "user id = dbpractice1001;";
        private const string server = "server = den1.mssql7.gear.host;";
        private const string pwd = "password=Fj1XBUQ6Up??";
        private const string db = "database = dbpractice1001;";

        public UserControl1()
        {
            InitializeComponent();
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            using ( SqlConnection conn = new SqlConnection(server + db + username + pwd))
            {
                string sqlCmdText = $"Select model, speed, Rowversion " +
                                    $"from PC Where " +
                                    $"model = @model";

                SqlParameter paramOne = new SqlParameter("@model", SqlDbType.VarChar, 4);
                paramOne.Value = textBox1.Text;
                SqlCommand cmd = new SqlCommand(sqlCmdText, conn);
                cmd.Parameters.Add(paramOne);
                
                cmd.Connection.Open();
                using (SqlDataReader reader  = cmd.ExecuteReader() )
                {
                    try {
                        reader.Read();
                        rowVersion = (byte[])reader["Rowversion"];
                        textBox2.Text = reader["speed"].ToString();
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.StackTrace);
                    }
                    finally {
                        reader.Close();
                        cmd.Connection.Close();
                    }
                }
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(server + db + username + pwd))
            {
                string sqlCmdText = $"UPDATE PC " +
                                    $"SET speed = @speed " +
                                    $"WHERE model = @model AND Rowversion = @Rowversion";

                SqlParameter paramOne = new SqlParameter("@model", SqlDbType.VarChar, 4);
                paramOne.Value = textBox1.Text;

                SqlParameter paramTwo = new SqlParameter("@speed", SqlDbType.Int);
                paramTwo.Value = int.Parse(textBox2.Text);

                SqlParameter paramThree = new SqlParameter("@Rowversion", SqlDbType.Timestamp);
                paramThree.Value = rowVersion;


                SqlCommand cmd = new SqlCommand(sqlCmdText, conn);
                cmd.Parameters.Add(paramOne);
                cmd.Parameters.Add(paramTwo);
                cmd.Parameters.Add(paramThree);
                cmd.Connection.Open();

                int antal = cmd.ExecuteNonQuery();
                if (antal > 0)
                    MessageBox.Show("Success - Changes_Made", "Update_Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failure - No_Changes_Made", "Update_Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                cmd.Connection.Close();
            }

        }
    }
}