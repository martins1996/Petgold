
namespace Petgold
{
    partial class FrmCliente
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
            this.lblid = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.btnlocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 18);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(440, 12);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(73, 28);
            this.btninserir.TabIndex = 1;
            this.btninserir.Text = "inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(33, 15);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(35, 20);
            this.txtid.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(74, 18);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(12, 113);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "E-mail";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(12, 55);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(53, 13);
            this.lblendereco.TabIndex = 5;
            this.lblendereco.Text = "Endereço";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(172, 149);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(102, 13);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "Data de nascimento";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(12, 83);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(40, 13);
            this.lblcidade.TabIndex = 7;
            this.lblcidade.Text = "Cidade";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(115, 15);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(159, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(71, 113);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(279, 20);
            this.txtemail.TabIndex = 9;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(71, 52);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(279, 20);
            this.txtendereco.TabIndex = 10;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(71, 83);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(279, 20);
            this.txtcidade.TabIndex = 11;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(280, 146);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 20);
            this.txtdata.TabIndex = 12;
            // 
            // dgvcliente
            // 
            this.dgvcliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(2, 191);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(547, 158);
            this.dgvcliente.TabIndex = 13;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(440, 55);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(73, 28);
            this.btnatualizar.TabIndex = 14;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(440, 98);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(73, 28);
            this.btnapagar.TabIndex = 15;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(440, 141);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(73, 28);
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(12, 149);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(39, 13);
            this.lblcelular.TabIndex = 17;
            this.lblcelular.Text = "Celular";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(71, 146);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(87, 20);
            this.txtcelular.TabIndex = 18;
            // 
            // btnlocalizar
            // 
            this.btnlocalizar.Location = new System.Drawing.Point(280, 15);
            this.btnlocalizar.Name = "btnlocalizar";
            this.btnlocalizar.Size = new System.Drawing.Size(73, 28);
            this.btnlocalizar.TabIndex = 19;
            this.btnlocalizar.Text = "localizar";
            this.btnlocalizar.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.btnlocalizar);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.lblid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Button btnlocalizar;
    }
}