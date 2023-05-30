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
    public partial class ClientEdit : Form
    {
        public bool EditMode;
        MainClient mainclient;
        public ClientEdit(bool editMode, MainClient client = null)
        {
            InitializeComponent();
            EditMode = editMode;
            if (editMode)
            {
                AgePacientUpDown.Value = (decimal)client.AgePacient;
                CostTextBox.Text = client.Cost.ToString();
                FIOTextBox.Text = client.FIO;
                descriptionTextBox.Text = client.Description;
                NumberTalonTextBox.Text = client.NumberTalon.ToString();
                dateTimePickerRegister.Value = client.TimeRegister;
            }
            else
            {
                DeleteBtn.Visible = false;
            }

            if(client != null)
            {
                mainclient = client;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            decimal cost;
            int number;
            if (decimal.TryParse(CostTextBox.Text, out cost))
            {
                if (int.TryParse(NumberTalonTextBox.Text, out number))
                {
                    MainClient mc = new MainClient()
                    {
                        AgePacient = (int)AgePacientUpDown.Value,
                        Cost = decimal.Parse(CostTextBox.Text),
                        FIO = FIOTextBox.Text,
                        Description = descriptionTextBox.Text,
                        NumberTalon = int.Parse(NumberTalonTextBox.Text),
                        TimeRegister = dateTimePickerRegister.Value
                    };
                    if (EditMode)
                    {
                        try
                        {
                            App.AModel.MainClient.ToList().Find(c => c.id == mainclient.id).UpdateValue(mc);
                            App.AModel.SaveChanges();
                            MessageBox.Show("Клиент успешно сохранён");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            App.AModel.MainClient.Add(mc);
                            App.AModel.SaveChanges();
                            MessageBox.Show("Клиент успешно добавлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("в поле \"Номер талона\" могут быть только десятичные дроби");
                }

            }
            else
            {
                MessageBox.Show("в поле \"Цена\" могут быть только десятичные дроби");
            }
                      
        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить клиента " + mainclient.FIO, "Удаление клиента", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                App.AModel.MainClient.Remove(mainclient);
                App.AModel.SaveChanges();
            }
            this.Close();
        }

        private void articleNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
