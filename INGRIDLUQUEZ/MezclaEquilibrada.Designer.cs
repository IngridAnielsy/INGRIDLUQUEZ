
namespace INGRIDLUQUEZ
{
    partial class MezclaEquilibrada
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
            this.txtcan = new System.Windows.Forms.TextBox();
            this.btninic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguarda = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnordenar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtcan
            // 
            this.txtcan.Location = new System.Drawing.Point(190, 121);
            this.txtcan.Name = "txtcan";
            this.txtcan.Size = new System.Drawing.Size(100, 20);
            this.txtcan.TabIndex = 0;
            // 
            // btninic
            // 
            this.btninic.Location = new System.Drawing.Point(205, 145);
            this.btninic.Name = "btninic";
            this.btninic.Size = new System.Drawing.Size(75, 23);
            this.btninic.TabIndex = 1;
            this.btninic.Text = "Iniciar";
            this.btninic.UseVisualStyleBackColor = true;
            this.btninic.Click += new System.EventHandler(this.btninic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese Id:";
            // 
            // btnguarda
            // 
            this.btnguarda.Location = new System.Drawing.Point(117, 239);
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.Size = new System.Drawing.Size(75, 23);
            this.btnguarda.TabIndex = 5;
            this.btnguarda.Text = "Guardar";
            this.btnguarda.UseVisualStyleBackColor = true;
            this.btnguarda.Click += new System.EventHandler(this.btnguarda_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 215);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(205, 302);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 23);
            this.btnordenar.TabIndex = 8;
            this.btnordenar.Text = "Ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Atrás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(219, 174);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(120, 95);
            this.Lista.TabIndex = 10;
            // 
            // MezclaEquilibrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguarda);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninic);
            this.Controls.Add(this.txtcan);
            this.DoubleBuffered = true;
            this.Name = "MezclaEquilibrada";
            this.Text = "MezclaEquilibrada";
            this.Load += new System.EventHandler(this.MezclaEquilibrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcan;
        private System.Windows.Forms.Button btninic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox Lista;
    }
}