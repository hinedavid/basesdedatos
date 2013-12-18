namespace WindowsFormsApplication1
{
    partial class EditarMedico
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_tipo_id_sup = new System.Windows.Forms.Label();
            this.Bx_tipo_id_sup = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txt_codicoM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_codsup = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 553);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Guardar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_horario
            // 
            this.cmb_horario.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.cmb_horario.Location = new System.Drawing.Point(232, 254);
            this.cmb_horario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(217, 28);
            this.cmb_horario.TabIndex = 55;
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(232, 486);
            this.txt_salario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_salario.MaxLength = 10;
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(217, 26);
            this.txt_salario.TabIndex = 54;
            this.txt_salario.TextChanged += new System.EventHandler(this.txt_salario_TextChanged);
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(35, 492);
            this.lbl_salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(55, 20);
            this.lbl_salario.TabIndex = 53;
            this.lbl_salario.Text = "salario";
            // 
            // lbl_tipo_id_sup
            // 
            this.lbl_tipo_id_sup.AutoSize = true;
            this.lbl_tipo_id_sup.Location = new System.Drawing.Point(35, 378);
            this.lbl_tipo_id_sup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_id_sup.Name = "lbl_tipo_id_sup";
            this.lbl_tipo_id_sup.Size = new System.Drawing.Size(136, 20);
            this.lbl_tipo_id_sup.TabIndex = 52;
            this.lbl_tipo_id_sup.Text = "tipo_identificación";
            // 
            // Bx_tipo_id_sup
            // 
            this.Bx_tipo_id_sup.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.Bx_tipo_id_sup.FormattingEnabled = true;
            this.Bx_tipo_id_sup.Items.AddRange(new object[] {
            "ced",
            "res"});
            this.Bx_tipo_id_sup.Location = new System.Drawing.Point(232, 370);
            this.Bx_tipo_id_sup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bx_tipo_id_sup.Name = "Bx_tipo_id_sup";
            this.Bx_tipo_id_sup.Size = new System.Drawing.Size(217, 28);
            this.Bx_tipo_id_sup.TabIndex = 51;
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "ced",
            "res"});
            this.cboTipo.Location = new System.Drawing.Point(232, 81);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(217, 28);
            this.cboTipo.TabIndex = 50;
            // 
            // txt_codicoM
            // 
            this.txt_codicoM.Location = new System.Drawing.Point(232, 197);
            this.txt_codicoM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codicoM.MaxLength = 10;
            this.txt_codicoM.Name = "txt_codicoM";
            this.txt_codicoM.Size = new System.Drawing.Size(217, 26);
            this.txt_codicoM.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Código_Médico";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(232, 429);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tipo.MaxLength = 10;
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(217, 26);
            this.txt_tipo.TabIndex = 47;
            // 
            // txt_codsup
            // 
            this.txt_codsup.Location = new System.Drawing.Point(232, 313);
            this.txt_codsup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codsup.MaxLength = 9;
            this.txt_codsup.Name = "txt_codsup";
            this.txt_codsup.Size = new System.Drawing.Size(217, 26);
            this.txt_codsup.TabIndex = 46;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(232, 140);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(217, 26);
            this.txt_nombre.TabIndex = 45;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(232, 24);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.MaxLength = 9;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(217, 26);
            this.txt_id.TabIndex = 44;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Identificación Supervisor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo Identificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre:";
            // 
            // EditarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 613);
            this.Controls.Add(this.cmb_horario);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_tipo_id_sup);
            this.Controls.Add(this.Bx_tipo_id_sup);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txt_codicoM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_codsup);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar médico";
            this.Load += new System.EventHandler(this.EditarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_tipo_id_sup;
        private System.Windows.Forms.ComboBox Bx_tipo_id_sup;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txt_codicoM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_codsup;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}