using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace praktikum_week_12
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string sql1;
        string kerja;
        string libur;
        string remplayer;
        DataTable qq = new DataTable();
        DataTable ww = new DataTable();
        DataTable ee = new DataTable();
        DataTable mm = new DataTable();
        DataTable nn = new DataTable();
        DataTable bb = new DataTable();
        DataTable aa = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = "SELECT nationality_id as `nation_id`,nation as `nation`\r\nfrom nationality;";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(ww);
            cboxnegara.DataSource = ww;
            cboxnegara.DisplayMember = "nation";
            cboxnegara.ValueMember = "nation_id";
            //////////////////////////////////////////////
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = "SELECT team_id as `id`,team_name as `team`\r\nfrom team;";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(ee);
            cboxteam.DataSource = ee;
            cboxteam.DisplayMember = "team";
            cboxteam.ValueMember = "id";
            //////////////////////////////////////////////
            cbokedit.DataSource = ee;
            cbokedit.DisplayMember = "team";
            cbokedit.ValueMember = "id";
            //////////////////////////////////////////////
            cbokremove.DataSource = ee;
            cbokremove.DisplayMember = "team";
            cbokremove.ValueMember = "id";
        }

        private void editMenagerFoATeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = "SELECT * FROM player p;";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(qq);
            dgv1.DataSource = qq;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string dtp = dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string namaplayer = tboxnama.Text;
            int nomerteam = Convert.ToInt32(tboxnopung.Text);
            string pos = tboxposisi.Text;
            int height = Convert.ToInt32(tboxtinggi.Text);
            int weight = Convert.ToInt32(tboxberat.Text);
            string nation = cboxnegara.SelectedValue.ToString();
            string teamname = cboxteam.SelectedValue.ToString();
            string id = tboxid.Text;
            string apa = $"insert into player value ('{id}',{nomerteam},'{namaplayer}','{nation}','{pos}',{height},{weight},'{dtp}','{teamname}',1,0);";
            SqlConnection = new MySqlConnection(connection);
            SqlCommand = new MySqlCommand(apa, SqlConnection);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            qq= new DataTable();
            sql1 = "SELECT * FROM player p;";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(qq);
            dgv1.DataSource = qq;
        }

        private void cbokedit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = $"select m.manager_id,m.manager_name,t.team_name,m.birthdate, m.nationality_id, m.working from manager m\r\nleft join team t on m.manager_id = t.manager_id where t.team_id = '{cbokedit.SelectedValue}';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(mm);
            dgv2.DataSource = mm;
            ////////////////////////////////////////////////////
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = $"select m.manager_id,m.manager_name,m.birthdate, m.nationality_id, m.working from manager m  where m.working = '0';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(nn);
            dgv3.DataSource = nn;
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            sql1 = $"update team set manager_id = '{libur}' where team_id = '{cbokedit.SelectedValue}';";
            SqlConnection = new MySqlConnection(connection);
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            ////////////////////////////////////////////////////////////////////
            sql1 = $"update manager set working = '0' where manager_id = '{kerja}';";
            SqlConnection = new MySqlConnection(connection);
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            ///////////////////////////////////////////////////////////////////
            sql1 = $"update manager set working = '1' where manager_id = '{libur}';";
            SqlConnection = new MySqlConnection(connection);
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
            //////////////////////////////////////////////////////////////////
            mm = new DataTable();
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = $"select m.manager_id,m.manager_name,t.team_name,m.birthdate, m.nationality_id, m.working from manager m\r\nleft join team t on m.manager_id = t.manager_id where t.team_id = '{cbokedit.SelectedValue}';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(mm);
            dgv2.DataSource = mm;
            ////////////////////////////////////////////////////
            nn = new DataTable();
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = $"select m.manager_id,m.manager_name,m.birthdate, m.nationality_id, m.working from manager m  where m.working = '0';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(nn);
            dgv3.DataSource = nn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(aa.Rows.Count <= 11)
            {
                MessageBox.Show("player kurang dari 11!!");
            }
            else
            {
                sql1 = $"update player set status = '0' where player_id = '{remplayer}';";
                SqlConnection = new MySqlConnection(connection);
                SqlCommand = new MySqlCommand(sql1, SqlConnection);
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                ////////////////////////////////////////////////////////////////////////////
                aa = new DataTable();
                SqlConnection = new MySqlConnection(connection);
                SqlConnection.Open();
                sql1 = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{cbokremove.SelectedValue}' and n.nationality_id = p.nationality_id and p.status = '1';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(aa);
                dgv4.DataSource = aa;
            }
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kerja = dgv2.SelectedCells[0].Value.ToString();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            libur = dgv3.SelectedCells[0].Value.ToString();
        }

        private void cbokremove_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql1 = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{cbokremove.SelectedValue}' and n.nationality_id = p.nationality_id and p.status = '1';";
            SqlCommand = new MySqlCommand(sql1, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(aa);
            dgv4.DataSource = aa;
        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           remplayer = dgv4.SelectedCells[0].Value.ToString();
        }
    }
}
