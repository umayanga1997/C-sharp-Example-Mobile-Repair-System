using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobile_Ririer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //get the database connection
        MySqlConnection conn = new MySqlConnection("server=localhost;database=mobile_repair;userid=root;password=;");


        //automatically id inserting method
        public void autoID()
        {
           
            String repid, itemid;
            String sql = "select id from mobile order by id desc";
            conn.Open();
            
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader = commandDatabase.ExecuteReader();

            if(reader.Read())
            {

                int id = int.Parse(reader[0].ToString())+1;
                itemid = id.ToString("00000");

            }else if(Convert.IsDBNull(reader))
            {

                itemid = "00001";

            }
            else
            {

                itemid = "00001";

            }

            id_txt.Text = itemid.ToString();
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoID();
            this.ActiveControl = name_txt; // set mouse typing icon defoultly in name textbox
            balance_txt.Enabled = false;
            status_cmbo.SelectedIndex = 0;
        }

        private void repairPrice_txt_TextChanged(object sender, EventArgs e)
        {
            stotal_txt.Text = repairPrice_txt.Text;
        }

        private void paid_txt_TextChanged(object sender, EventArgs e)
        {
           
            if ((stotal_txt.Text == "") && (paid_txt.Text == ""))
            {
                balance_txt.Text = "";

            }
            else
            {
                try
                {

                    int total;
                    int subtotal = int.Parse(stotal_txt.Text);
                    int pay = int.Parse(paid_txt.Text);

                    total = subtotal - pay;

                    balance_txt.Text = total.ToString();

                }
                catch(FormatException ex)
                {
                    balance_txt.Text = "";
                    MessageBox.Show(ex.Message);
                }
            

            }
            

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            try{

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO mobile(id,cname,mobile,deviceSN,pattern,status,batry,poweron,waterdmg,phydmg,memorycrd,phoneno,rerPrice,subtotal,paid,balnce,assign,date) VALUES (@id,@cname,@mobile,@deviceSN,@pattern,@status,@batry,@poweron,@waterdmg,@phydmg,@memorycrd,@phoneno,@rerPrice,@subtotal,@paid,@balnce,@assign,@date)";

                cmd.Parameters.AddWithValue("@id",id_txt.Text);
                cmd.Parameters.AddWithValue("@cname", name_txt.Text);
                cmd.Parameters.AddWithValue("@mobile", mobile_txt.Text);
                cmd.Parameters.AddWithValue("@deviceSN", sn_txt.Text);
                cmd.Parameters.AddWithValue("@pattern", pattern_txt.Text);
                cmd.Parameters.AddWithValue("@status", status_cmbo.SelectedItem);

                cmd.Parameters.AddWithValue("@batry", btry_chck.Checked);
                cmd.Parameters.AddWithValue("@poweron", power_chck.Checked);
                cmd.Parameters.AddWithValue("@waterdmg", waterdmage_chck.Checked);
                cmd.Parameters.AddWithValue("@phydmg", physicl_chck.Checked);
                cmd.Parameters.AddWithValue("@memorycrd", mcard_chck.Checked);

                cmd.Parameters.AddWithValue("@phoneno", phone_txt.Text);
                cmd.Parameters.AddWithValue("@rerPrice", repairPrice_txt.Text);
                cmd.Parameters.AddWithValue("@subtotal", stotal_txt.Text);
                cmd.Parameters.AddWithValue("@paid", paid_txt.Text);
                cmd.Parameters.AddWithValue("@balnce", balance_txt.Text);
                cmd.Parameters.AddWithValue("@assign", assign_txt.Text);
                cmd.Parameters.AddWithValue("@date", datetime_choser.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is Added...");

                //its insert to required for conection close to early
                Print pr = new Print();
                pr.Id = id_txt.Text;
                pr.Show();

                conn.Close();
                name_txt.Focus();

                clearAll();
                autoID();

            }
            catch(Exception ex)
            {


                MessageBox.Show(ex.Message);

            }
            conn.Close();
        }

        // all details filler clear
        public void clearAll()
        {

            id_txt.Text = "";
            name_txt.Text = "";
            mobile_txt.Text = "";
            sn_txt.Text = "";
            pattern_txt.Text = "";
            status_cmbo.SelectedIndex = 0;
            phone_txt.Text = "";
            repairPrice_txt.Text = "";
            paid_txt.Text = "";
            balance_txt.Text = "";
            assign_txt.Text = "";
            //datetime_choser;

            btry_chck.Checked = false;
            power_chck.Checked = false;
            waterdmage_chck.Checked = false;
            physicl_chck.Checked = false;
            mcard_chck.Checked = false;



        }

        private void repairPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void stotal_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void paid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void SendPrint()
        {

            Print pr = new Print();
            pr.Show();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home hm = new Home();
            hm.Show();
        }
    }
}
