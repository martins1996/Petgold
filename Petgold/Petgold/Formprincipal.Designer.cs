
namespace Petgold
{
    partial class Formprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            this.btninicio = new System.Windows.Forms.Button();
            this.panecentral = new System.Windows.Forms.Panel();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnfuncionarios = new System.Windows.Forms.Button();
            this.btnanimais = new System.Windows.Forms.Button();
            this.btnagenda = new System.Windows.Forms.Button();
            this.btnservico = new System.Windows.Forms.Button();
            this.btnraca = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsair = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.White;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Location = new System.Drawing.Point(45, 3);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 23);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "inicio";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panecentral
            // 
            this.panecentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panecentral.BackgroundImage")));
            this.panecentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panecentral.Location = new System.Drawing.Point(145, 34);
            this.panecentral.Name = "panecentral";
            this.panecentral.Size = new System.Drawing.Size(552, 351);
            this.panecentral.TabIndex = 2;
            this.panecentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panecentral_Paint);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.White;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Location = new System.Drawing.Point(45, 48);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(75, 23);
            this.btncliente.TabIndex = 4;
            this.btncliente.Text = "cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnfuncionarios
            // 
            this.btnfuncionarios.BackColor = System.Drawing.Color.White;
            this.btnfuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfuncionarios.Location = new System.Drawing.Point(45, 102);
            this.btnfuncionarios.Name = "btnfuncionarios";
            this.btnfuncionarios.Size = new System.Drawing.Size(75, 23);
            this.btnfuncionarios.TabIndex = 5;
            this.btnfuncionarios.Text = "funcionarios";
            this.btnfuncionarios.UseVisualStyleBackColor = false;
            this.btnfuncionarios.Click += new System.EventHandler(this.btnfuncionarios_Click);
            // 
            // btnanimais
            // 
            this.btnanimais.BackColor = System.Drawing.Color.White;
            this.btnanimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanimais.Location = new System.Drawing.Point(45, 156);
            this.btnanimais.Name = "btnanimais";
            this.btnanimais.Size = new System.Drawing.Size(75, 23);
            this.btnanimais.TabIndex = 6;
            this.btnanimais.Text = "animais";
            this.btnanimais.UseVisualStyleBackColor = false;
            this.btnanimais.Click += new System.EventHandler(this.btnanimais_Click);
            // 
            // btnagenda
            // 
            this.btnagenda.BackColor = System.Drawing.Color.White;
            this.btnagenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagenda.Location = new System.Drawing.Point(45, 210);
            this.btnagenda.Name = "btnagenda";
            this.btnagenda.Size = new System.Drawing.Size(75, 23);
            this.btnagenda.TabIndex = 7;
            this.btnagenda.Text = "agenda";
            this.btnagenda.UseVisualStyleBackColor = false;
            this.btnagenda.Click += new System.EventHandler(this.btnagenda_Click);
            // 
            // btnservico
            // 
            this.btnservico.BackColor = System.Drawing.Color.White;
            this.btnservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservico.Location = new System.Drawing.Point(45, 264);
            this.btnservico.Name = "btnservico";
            this.btnservico.Size = new System.Drawing.Size(75, 23);
            this.btnservico.TabIndex = 8;
            this.btnservico.Text = "serviço";
            this.btnservico.UseVisualStyleBackColor = false;
            this.btnservico.Click += new System.EventHandler(this.btnservico_Click);
            // 
            // btnraca
            // 
            this.btnraca.BackColor = System.Drawing.Color.White;
            this.btnraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnraca.Location = new System.Drawing.Point(45, 309);
            this.btnraca.Name = "btnraca";
            this.btnraca.Size = new System.Drawing.Size(75, 23);
            this.btnraca.TabIndex = 0;
            this.btnraca.Text = "raça";
            this.btnraca.UseVisualStyleBackColor = false;
            this.btnraca.Click += new System.EventHandler(this.btnraca_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.btnsair);
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 24);
            this.panel2.TabIndex = 9;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(622, 3);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(709, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnraca);
            this.Controls.Add(this.btnservico);
            this.Controls.Add(this.btnagenda);
            this.Controls.Add(this.btnanimais);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnfuncionarios);
            this.Controls.Add(this.panecentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formprincipal";
            this.Text = "Formprincipal";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panecentral;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnfuncionarios;
        private System.Windows.Forms.Button btnanimais;
        private System.Windows.Forms.Button btnagenda;
        private System.Windows.Forms.Button btnservico;
        private System.Windows.Forms.Button btnraca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsair;
    }
}