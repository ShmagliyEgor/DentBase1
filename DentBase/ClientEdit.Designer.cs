
namespace DentBase
{
    partial class ClientEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEdit));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NumberTalonTextBox = new System.Windows.Forms.TextBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dateTimePickerRegister = new System.Windows.Forms.DateTimePicker();
            this.AgePacientUpDown = new System.Windows.Forms.NumericUpDown();
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgePacientUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            articleNumberLabel.Location = new System.Drawing.Point(14, 82);
            articleNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(208, 35);
            articleNumberLabel.TabIndex = 42;
            articleNumberLabel.Text = "Время записи:";
            articleNumberLabel.Click += new System.EventHandler(this.articleNumberLabel_Click);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            descriptionLabel.Location = new System.Drawing.Point(14, 151);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(154, 35);
            descriptionLabel.TabIndex = 46;
            descriptionLabel.Text = "Пометка:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            minCostForAgentLabel.Location = new System.Drawing.Point(14, 334);
            minCostForAgentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(269, 35);
            minCostForAgentLabel.TabIndex = 52;
            minCostForAgentLabel.Text = "Стоимость услуг:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            productionPersonCountLabel.Location = new System.Drawing.Point(14, 213);
            productionPersonCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(287, 35);
            productionPersonCountLabel.TabIndex = 54;
            productionPersonCountLabel.Text = "Возраст пациента:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(14, 279);
            productionWorkshopNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(225, 35);
            productionWorkshopNumberLabel.TabIndex = 56;
            productionWorkshopNumberLabel.Text = "Номер талона:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            titleLabel.Location = new System.Drawing.Point(14, 19);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(229, 35);
            titleLabel.TabIndex = 58;
            titleLabel.Text = "Имя пациента:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(588, 393);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(155, 46);
            this.DeleteBtn.TabIndex = 60;
            this.DeleteBtn.Text = "Удалить ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.descriptionTextBox.Location = new System.Drawing.Point(309, 125);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(434, 76);
            this.descriptionTextBox.TabIndex = 47;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CostTextBox.Location = new System.Drawing.Point(309, 329);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(434, 42);
            this.CostTextBox.TabIndex = 53;
            // 
            // NumberTalonTextBox
            // 
            this.NumberTalonTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NumberTalonTextBox.Location = new System.Drawing.Point(309, 270);
            this.NumberTalonTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumberTalonTextBox.Name = "NumberTalonTextBox";
            this.NumberTalonTextBox.Size = new System.Drawing.Size(434, 42);
            this.NumberTalonTextBox.TabIndex = 57;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FIOTextBox.Location = new System.Drawing.Point(309, 17);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(434, 42);
            this.FIOTextBox.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(313, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 46);
            this.button2.TabIndex = 44;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightCoral;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(34, 393);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(198, 46);
            this.SaveBtn.TabIndex = 43;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dateTimePickerRegister
            // 
            this.dateTimePickerRegister.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePickerRegister.Location = new System.Drawing.Point(309, 73);
            this.dateTimePickerRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerRegister.Name = "dateTimePickerRegister";
            this.dateTimePickerRegister.Size = new System.Drawing.Size(434, 42);
            this.dateTimePickerRegister.TabIndex = 61;
            // 
            // AgePacientUpDown
            // 
            this.AgePacientUpDown.Font = new System.Drawing.Font("Constantia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AgePacientUpDown.Location = new System.Drawing.Point(309, 211);
            this.AgePacientUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgePacientUpDown.Name = "AgePacientUpDown";
            this.AgePacientUpDown.Size = new System.Drawing.Size(180, 42);
            this.AgePacientUpDown.TabIndex = 62;
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.Controls.Add(this.AgePacientUpDown);
            this.Controls.Add(this.dateTimePickerRegister);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.NumberTalonTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientEdit";
            this.Text = "ClientEdit";
            this.Load += new System.EventHandler(this.ClientEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgePacientUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NumberTalonTextBox;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegister;
        private System.Windows.Forms.NumericUpDown AgePacientUpDown;
    }
}