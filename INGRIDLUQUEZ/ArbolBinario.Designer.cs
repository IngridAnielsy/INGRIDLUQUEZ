
namespace INGRIDLUQUEZ
{
    partial class ArbolBinario
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
            this.gIngrese = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gdatos = new System.Windows.Forms.GroupBox();
            this.txtcargo = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtagregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geliminar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtelimi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grecorridos = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listrecorrido = new System.Windows.Forms.ListBox();
            this.lblrecorrido = new System.Windows.Forms.Label();
            this.gIngrese.SuspendLayout();
            this.gdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.geliminar.SuspendLayout();
            this.grecorridos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gIngrese
            // 
            this.gIngrese.BackColor = System.Drawing.Color.Transparent;
            this.gIngrese.Controls.Add(this.label7);
            this.gIngrese.Controls.Add(this.txtn);
            this.gIngrese.Controls.Add(this.button1);
            this.gIngrese.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gIngrese.Location = new System.Drawing.Point(13, 13);
            this.gIngrese.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gIngrese.Name = "gIngrese";
            this.gIngrese.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gIngrese.Size = new System.Drawing.Size(279, 89);
            this.gIngrese.TabIndex = 31;
            this.gIngrese.TabStop = false;
            this.gIngrese.Text = "Ingrese cantidad";
            this.gIngrese.Enter += new System.EventHandler(this.gIngrese_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "cantidad de empleados";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(179, 21);
            this.txtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(91, 22);
            this.txtn.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(88, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gdatos
            // 
            this.gdatos.BackColor = System.Drawing.Color.Transparent;
            this.gdatos.Controls.Add(this.txtcargo);
            this.gdatos.Controls.Add(this.txtid);
            this.gdatos.Controls.Add(this.txtagregar);
            this.gdatos.Controls.Add(this.label2);
            this.gdatos.Controls.Add(this.txtnombre);
            this.gdatos.Controls.Add(this.label3);
            this.gdatos.Controls.Add(this.label6);
            this.gdatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdatos.Location = new System.Drawing.Point(14, 108);
            this.gdatos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gdatos.Name = "gdatos";
            this.gdatos.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gdatos.Size = new System.Drawing.Size(277, 163);
            this.gdatos.TabIndex = 32;
            this.gdatos.TabStop = false;
            this.gdatos.Text = "Ingrese la informacion que se le pide:";
            // 
            // txtcargo
            // 
            this.txtcargo.FormattingEnabled = true;
            this.txtcargo.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Bodeguero",
            "Cajero",
            "Gerente"});
            this.txtcargo.Location = new System.Drawing.Point(73, 93);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(180, 24);
            this.txtcargo.TabIndex = 23;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(143, 25);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(118, 22);
            this.txtid.TabIndex = 3;
            // 
            // txtagregar
            // 
            this.txtagregar.BackColor = System.Drawing.SystemColors.Control;
            this.txtagregar.ForeColor = System.Drawing.Color.Black;
            this.txtagregar.Location = new System.Drawing.Point(101, 124);
            this.txtagregar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(133, 33);
            this.txtagregar.TabIndex = 22;
            this.txtagregar.Text = "Agregar";
            this.txtagregar.UseVisualStyleBackColor = false;
            this.txtagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID del empleado:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(88, 58);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(173, 22);
            this.txtnombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cargo:";
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.SystemColors.Control;
            this.btnatras.Location = new System.Drawing.Point(8, 67);
            this.btnatras.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(99, 33);
            this.btnatras.TabIndex = 30;
            this.btnatras.Text = "InOrden";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(14, 464);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(270, 166);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 29;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IdEmpleado";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Salario";
            this.Column5.Name = "Column5";
            // 
            // geliminar
            // 
            this.geliminar.BackColor = System.Drawing.Color.Transparent;
            this.geliminar.Controls.Add(this.label1);
            this.geliminar.Controls.Add(this.txtelimi);
            this.geliminar.Controls.Add(this.button2);
            this.geliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geliminar.Location = new System.Drawing.Point(294, 545);
            this.geliminar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.geliminar.Name = "geliminar";
            this.geliminar.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.geliminar.Size = new System.Drawing.Size(279, 85);
            this.geliminar.TabIndex = 32;
            this.geliminar.TabStop = false;
            this.geliminar.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Elimine por Salario";
            // 
            // txtelimi
            // 
            this.txtelimi.Location = new System.Drawing.Point(140, 24);
            this.txtelimi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtelimi.Name = "txtelimi";
            this.txtelimi.Size = new System.Drawing.Size(91, 22);
            this.txtelimi.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(88, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grecorridos
            // 
            this.grecorridos.Controls.Add(this.button4);
            this.grecorridos.Controls.Add(this.button3);
            this.grecorridos.Controls.Add(this.btnatras);
            this.grecorridos.Location = new System.Drawing.Point(14, 277);
            this.grecorridos.Name = "grecorridos";
            this.grecorridos.Size = new System.Drawing.Size(277, 107);
            this.grecorridos.TabIndex = 33;
            this.grecorridos.TabStop = false;
            this.grecorridos.Text = "Recorridos";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(170, 67);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 32;
            this.button4.Text = "PostOrden";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(88, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 33);
            this.button3.TabIndex = 31;
            this.button3.Text = "PreOrden";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listrecorrido
            // 
            this.listrecorrido.FormattingEnabled = true;
            this.listrecorrido.ItemHeight = 16;
            this.listrecorrido.Location = new System.Drawing.Point(14, 405);
            this.listrecorrido.Name = "listrecorrido";
            this.listrecorrido.Size = new System.Drawing.Size(277, 52);
            this.listrecorrido.TabIndex = 34;
            // 
            // lblrecorrido
            // 
            this.lblrecorrido.AutoSize = true;
            this.lblrecorrido.Location = new System.Drawing.Point(73, 386);
            this.lblrecorrido.Name = "lblrecorrido";
            this.lblrecorrido.Size = new System.Drawing.Size(68, 16);
            this.lblrecorrido.TabIndex = 35;
            this.lblrecorrido.Text = "Recorrido";
            this.lblrecorrido.Click += new System.EventHandler(this.lblrecorrido_Click);
            // 
            // ArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1370, 640);
            this.Controls.Add(this.lblrecorrido);
            this.Controls.Add(this.listrecorrido);
            this.Controls.Add(this.grecorridos);
            this.Controls.Add(this.geliminar);
            this.Controls.Add(this.gIngrese);
            this.Controls.Add(this.gdatos);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ArbolBinario";
            this.Text = "ArbolBinario";
            this.Load += new System.EventHandler(this.ArbolBinario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ArbolBinario_Paint);
            this.gIngrese.ResumeLayout(false);
            this.gIngrese.PerformLayout();
            this.gdatos.ResumeLayout(false);
            this.gdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.geliminar.ResumeLayout(false);
            this.geliminar.PerformLayout();
            this.grecorridos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gIngrese;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gdatos;
        private System.Windows.Forms.ComboBox txtcargo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button txtagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox geliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtelimi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grecorridos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listrecorrido;
        private System.Windows.Forms.Label lblrecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}