using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            ClientEdit clientEdit = new ClientEdit(false);
            clientEdit.ShowDialog();

            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if(dataGridViewClient.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString());
                MainClient client = App.AModel.MainClient.ToList().Find(c => c.id == id);
                ClientEdit clientEdit = new ClientEdit(true, client);
                clientEdit.ShowDialog();

                UpdateGrid(App.AModel.MainClient.ToList());
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString());
                MainClient client = App.AModel.MainClient.ToList().Find(c => c.id == id);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить клиента " + client.FIO, "Удаление клиента", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    App.AModel.MainClient.Remove(client);
                    App.AModel.SaveChanges();
                }

                UpdateGrid(App.AModel.MainClient.ToList());
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if(SearchTxt.Text.Length == 0)
            {
                UpdateGrid(App.AModel.MainClient.ToList());
                return;
            }
            List<MainClient> clients = App.AModel.MainClient.ToList().FindAll(c => c.FIO.Contains(SearchTxt.Text));
            UpdateGrid(clients);
        }

        void UpdateGrid(List<MainClient> clients)
        {
            switch (SortBox.SelectedIndex)
            {
                default:
                    ClientBindingSource.DataSource = clients;
                    break;
                case 1:
                    ClientBindingSource.DataSource = (DownCheck.Checked)?clients.OrderBy(c => c.Cost):clients.OrderByDescending(c=> c.Cost);
                    break;
                case 2:
                    ClientBindingSource.DataSource = (DownCheck.Checked) ? clients.OrderBy(c => c.AgePacient): clients.OrderByDescending(c => c.AgePacient);
                    break;
            }
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void DownCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы дейстивтельно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
