using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Milestone_3
{

    public partial class InventoryMain : Form
    {

        public static InventoryMain mainInstance;

        public DataGridView DGV;
        public DataGridView storeData;

        public InventoryMain()
        {
            InitializeComponent();
            mainInstance = this;

        }



        DataTable inventory = new DataTable();
        DataTable inventorySave = new DataTable();

        private void InventoryMain_Load(object sender, EventArgs e)
        {

            inventory.Columns.Add("Name");
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Department");
            inventory.Columns.Add("Quantity");

            



            Edit_seachField.DataSource = inventory;

        }


        private void BTN_Search_Click(object sender, EventArgs e)
        {
            inventory = inventorySave;
        }



        private void BTN_add_Click_1(object sender, EventArgs e)
        {
            string name = TB_Name.Text;
            string price = TB_Price.Text;
            string sku = TB_Sku.Text;
            string quantity = TB_Quan.Text;
            string department = (string)CB_Department.SelectedItem;

            inventory.Rows.Add(name, sku, price, department, quantity);

            //clear after save
            BTN_ClearForm_Click_1(sender, e);
        }

        private void BTN_Save_Click_1(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:/Users/grigg/Desktop/test.txt");
            for (int i = 0; i < inventory.Rows.Count; i++)
            {
                int last = 0;
                for (int j = 0; j < inventory.Columns.Count-1; j++)
                {
                    writer.Write("" + Edit_seachField.Rows[i].Cells[j].Value.ToString() +"\t"+ "|");
                    last++;
                }
                writer.Write("" + Edit_seachField.Rows[i].Cells[last].Value.ToString() + "\t");
                writer.WriteLine("");
                

            }
            writer.Close();
            MessageBox.Show("Save Successful");

            //clear after save
            BTN_ClearForm_Click_1(sender, e);

        }

        private void BTN_Remove_Click_1(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[Edit_seachField.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err);
            }
        }

        private void BTN_Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                TB_Name.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[0].ToString();
                TB_Sku.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[1].ToString();
                TB_Price.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[2].ToString();
                TB_Quan.Text = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[4].ToString();


                string itemtolookfor = inventory.Rows[Edit_seachField.CurrentCell.RowIndex].ItemArray[3].ToString();
                CB_Department.SelectedIndex = CB_Department.Items.IndexOf(itemtolookfor);
            }
            catch (Exception err)
            {
                MessageBox.Show("This is an illegal move " + err);
            }
            try
            {
                inventory.Rows[Edit_seachField.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err);
            }
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:/Users/grigg/Desktop/test.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for(int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                inventory.Rows.Add(row);
            }
        }

        private void BTN_ClearForm_Click_1(object sender, EventArgs e)
        {
            TB_Name.Text = "";
            TB_Price.Text = "";
            TB_Sku.Text = "";
            TB_Quan.Text = "";
            CB_Department.SelectedIndex = -1;
        }

        private void TB_Sku_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
