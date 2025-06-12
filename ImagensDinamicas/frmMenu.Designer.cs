namespace ImagensDinamicas
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJog1 = new System.Windows.Forms.TextBox();
            this.txtJog2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picDados = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFotos = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlacarJog1 = new System.Windows.Forms.Label();
            this.lblPlacarJog2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador 2:";
            // 
            // txtJog1
            // 
            this.txtJog1.Location = new System.Drawing.Point(264, 222);
            this.txtJog1.Name = "txtJog1";
            this.txtJog1.Size = new System.Drawing.Size(100, 20);
            this.txtJog1.TabIndex = 2;
            // 
            // txtJog2
            // 
            this.txtJog2.Location = new System.Drawing.Point(264, 253);
            this.txtJog2.Name = "txtJog2";
            this.txtJog2.Size = new System.Drawing.Size(100, 20);
            this.txtJog2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picDados
            // 
            this.picDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDados.Image = ((System.Drawing.Image)(resources.GetObject("picDados.Image")));
            this.picDados.Location = new System.Drawing.Point(105, 70);
            this.picDados.Name = "picDados";
            this.picDados.Size = new System.Drawing.Size(124, 121);
            this.picDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDados.TabIndex = 5;
            this.picDados.TabStop = false;
            this.picDados.Click += new System.EventHandler(this.picDados_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dados";
            // 
            // picFotos
            // 
            this.picFotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotos.Image = ((System.Drawing.Image)(resources.GetObject("picFotos.Image")));
            this.picFotos.Location = new System.Drawing.Point(393, 70);
            this.picFotos.Name = "picFotos";
            this.picFotos.Size = new System.Drawing.Size(124, 121);
            this.picFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotos.TabIndex = 8;
            this.picFotos.TabStop = false;
            this.picFotos.Click += new System.EventHandler(this.picFotos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fotos";
            // 
            // lblPlacarJog1
            // 
            this.lblPlacarJog1.AutoSize = true;
            this.lblPlacarJog1.Location = new System.Drawing.Point(386, 225);
            this.lblPlacarJog1.Name = "lblPlacarJog1";
            this.lblPlacarJog1.Size = new System.Drawing.Size(0, 13);
            this.lblPlacarJog1.TabIndex = 10;
            // 
            // lblPlacarJog2
            // 
            this.lblPlacarJog2.AutoSize = true;
            this.lblPlacarJog2.Location = new System.Drawing.Point(386, 256);
            this.lblPlacarJog2.Name = "lblPlacarJog2";
            this.lblPlacarJog2.Size = new System.Drawing.Size(0, 13);
            this.lblPlacarJog2.TabIndex = 11;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.lblPlacarJog2);
            this.Controls.Add(this.lblPlacarJog1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picFotos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picDados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJog2);
            this.Controls.Add(this.txtJog1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Menu Images Dinâmicas";
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJog1;
        private System.Windows.Forms.TextBox txtJog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFotos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlacarJog1;
        private System.Windows.Forms.Label lblPlacarJog2;
    }
}