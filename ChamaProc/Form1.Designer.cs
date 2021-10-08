
namespace ChamaProc
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnChamaProc2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCadastrarNomeNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 164);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(154, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 2;
            this.id.Text = "id";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(189, 55);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 3;
            // 
            // BtnChamaProc2
            // 
            this.BtnChamaProc2.Location = new System.Drawing.Point(348, 51);
            this.BtnChamaProc2.Name = "BtnChamaProc2";
            this.BtnChamaProc2.Size = new System.Drawing.Size(75, 23);
            this.BtnChamaProc2.TabIndex = 4;
            this.BtnChamaProc2.Text = "button2";
            this.BtnChamaProc2.UseVisualStyleBackColor = true;
            this.BtnChamaProc2.Click += new System.EventHandler(this.BtnChamaProc2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(189, 121);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salario";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(189, 152);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(100, 20);
            this.TxtSalario.TabIndex = 8;
            // 
            // BtnCadastrarNomeNovo
            // 
            this.BtnCadastrarNomeNovo.Location = new System.Drawing.Point(330, 123);
            this.BtnCadastrarNomeNovo.Name = "BtnCadastrarNomeNovo";
            this.BtnCadastrarNomeNovo.Size = new System.Drawing.Size(118, 49);
            this.BtnCadastrarNomeNovo.TabIndex = 9;
            this.BtnCadastrarNomeNovo.Text = "Cadastrar Nome e Salario";
            this.BtnCadastrarNomeNovo.UseVisualStyleBackColor = true;
            this.BtnCadastrarNomeNovo.Click += new System.EventHandler(this.BtnCadastrarNomeNovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.BtnCadastrarNomeNovo);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChamaProc2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnChamaProc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Button BtnCadastrarNomeNovo;
    }
}

