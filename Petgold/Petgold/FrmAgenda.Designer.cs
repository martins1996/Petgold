
namespace Petgold
{
    partial class FrmAgenda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblidanimal = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cbxid = new System.Windows.Forms.ComboBox();
            this.cbxidanimal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(67, 40);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "id";
            // 
            // lblidanimal
            // 
            this.lblidanimal.AutoSize = true;
            this.lblidanimal.Location = new System.Drawing.Point(67, 68);
            this.lblidanimal.Name = "lblidanimal";
            this.lblidanimal.Size = new System.Drawing.Size(53, 13);
            this.lblidanimal.TabIndex = 4;
            this.lblidanimal.Text = "Id_Animal";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(67, 99);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(30, 13);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(378, 103);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(120, 99);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(226, 20);
            this.dtpdata.TabIndex = 12;
            // 
            // cbxid
            // 
            this.cbxid.FormattingEnabled = true;
            this.cbxid.Location = new System.Drawing.Point(120, 40);
            this.cbxid.Name = "cbxid";
            this.cbxid.Size = new System.Drawing.Size(121, 21);
            this.cbxid.TabIndex = 13;
            // 
            // cbxidanimal
            // 
            this.cbxidanimal.FormattingEnabled = true;
            this.cbxidanimal.Location = new System.Drawing.Point(120, 70);
            this.cbxidanimal.Name = "cbxidanimal";
            this.cbxidanimal.Size = new System.Drawing.Size(121, 21);
            this.cbxidanimal.TabIndex = 14;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 312);
            this.Controls.Add(this.cbxidanimal);
            this.Controls.Add(this.cbxid);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblidanimal);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblidanimal;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cbxid;
        private System.Windows.Forms.ComboBox cbxidanimal;
    }
}