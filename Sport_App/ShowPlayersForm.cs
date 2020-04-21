using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_App
{
    public partial class ShowPlayersForm : Form
    {
        public ShowPlayersForm()
        {
            InitializeComponent();
        }

       

        private void bt_Find_Click(object sender, EventArgs e)
        {
            string request="";
            switch (cmb_FindBy.Text)
            {
                case "Tshirt Number":
                    request = "select * from player where  TshirtNumber = "+ int.Parse(txt_CriterionValue.Text);
                    break;
                case "Scored Goals":
                    request = "select * from player where  goalsCount >= "+int.Parse(txt_CriterionValue.Text);
                    break;
                case "Name":                   
                    request = "select * from player where name like '"+txt_CriterionValue.Text+"'";
                    break;
                default:
                    request = "select * from player where position = '" + txt_CriterionValue.Text + "'";
                    break;
            }
            List <Player> lstPlayers=GetPlayers(request);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstPlayers;











            /*string findby = cmb_FindBy.Text
            request = findby switch
            {
                "Tshirt Number"=> "select * from player where  Tshirt Number = @tshirtnumber",
                _ => ""

            }*/
        }
        private SqlConnection con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        SqlDataReader DR;

        private List<Player> GetPlayers(string request)
        {
            List<Player> lstPlayers = new List<Player>();
            try
            {
                con.ConnectionString = @"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SportDB;Integrated Security=True;Pooling=False";
                con.Open();
                cmd.CommandText = request;
                cmd.Connection = con;
                DR = cmd.ExecuteReader();
                 
                while (DR.Read())
                {
                    Player p1 = new Player();
                    p1.TshirtNumber = DR.GetInt32(0);
                    p1.Name = DR.GetString(1);
                    p1.Position = DR.GetString(2);
                    p1.ScoredGoals = DR.GetInt32(3);
                    lstPlayers.Add(p1);
                }              



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step 5 : close the connection 
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return lstPlayers;

        }

        private void ShowPlayersForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = @"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SportDB;Integrated Security=True;Pooling=False";
                con.Open();
                cmd.CommandText = "select * from player";
                cmd.Connection = con;
                DR=cmd.ExecuteReader();
                List<Player> lstPlayers = new List<Player>();
                while(DR.Read())
                {
                    Player p1 = new Player();
                    p1.TshirtNumber = DR.GetInt32(0);
                    p1.Name = DR.GetString(1);
                    p1.Position = DR.GetString(2);
                    p1.ScoredGoals = DR.GetInt32(3);
                    lstPlayers.Add(p1);
                }
                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lstPlayers;



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step 5 : close the connection 
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }
    }
}
