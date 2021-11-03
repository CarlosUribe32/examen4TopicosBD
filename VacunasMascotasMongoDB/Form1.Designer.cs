
namespace VacunasMascotasMongoDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridMascotas = new System.Windows.Forms.DataGridView();
            this.cbxRazaM2 = new System.Windows.Forms.ComboBox();
            this.cbxRazaM = new System.Windows.Forms.ComboBox();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAñoM2 = new System.Windows.Forms.TextBox();
            this.cbxEspecieM2 = new System.Windows.Forms.ComboBox();
            this.txtNombreM2 = new System.Windows.Forms.TextBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAñoM = new System.Windows.Forms.TextBox();
            this.cbxEspecieM = new System.Windows.Forms.ComboBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxVeterinaria2 = new System.Windows.Forms.ComboBox();
            this.cbxVacuna2 = new System.Windows.Forms.ComboBox();
            this.dataGridConsultas = new System.Windows.Forms.DataGridView();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxVeterinaria = new System.Windows.Forms.ComboBox();
            this.cbxVacuna = new System.Windows.Forms.ComboBox();
            this.dataGridMascotas2 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMascotas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMascotas2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 81);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 364);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridMascotas);
            this.tabPage1.Controls.Add(this.cbxRazaM2);
            this.tabPage1.Controls.Add(this.cbxRazaM);
            this.tabPage1.Controls.Add(this.btnEliminarM);
            this.tabPage1.Controls.Add(this.btnEditarM);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAñoM2);
            this.tabPage1.Controls.Add(this.cbxEspecieM2);
            this.tabPage1.Controls.Add(this.txtNombreM2);
            this.tabPage1.Controls.Add(this.btnAgregarM);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAñoM);
            this.tabPage1.Controls.Add(this.cbxEspecieM);
            this.tabPage1.Controls.Add(this.txtNombreM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mascotas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridMascotas
            // 
            this.dataGridMascotas.AllowUserToAddRows = false;
            this.dataGridMascotas.AllowUserToDeleteRows = false;
            this.dataGridMascotas.AllowUserToResizeColumns = false;
            this.dataGridMascotas.AllowUserToResizeRows = false;
            this.dataGridMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMascotas.Location = new System.Drawing.Point(6, 3);
            this.dataGridMascotas.MultiSelect = false;
            this.dataGridMascotas.Name = "dataGridMascotas";
            this.dataGridMascotas.ReadOnly = true;
            this.dataGridMascotas.RowHeadersVisible = false;
            this.dataGridMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMascotas.Size = new System.Drawing.Size(318, 318);
            this.dataGridMascotas.TabIndex = 22;
            this.dataGridMascotas.UseWaitCursor = true;
            this.dataGridMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMascotas_CellContentClick);
            this.dataGridMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMascotas_CellContentClick);
            // 
            // cbxRazaM2
            // 
            this.cbxRazaM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRazaM2.FormattingEnabled = true;
            this.cbxRazaM2.Location = new System.Drawing.Point(641, 158);
            this.cbxRazaM2.Name = "cbxRazaM2";
            this.cbxRazaM2.Size = new System.Drawing.Size(121, 21);
            this.cbxRazaM2.TabIndex = 21;
            // 
            // cbxRazaM
            // 
            this.cbxRazaM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRazaM.FormattingEnabled = true;
            this.cbxRazaM.Location = new System.Drawing.Point(641, 6);
            this.cbxRazaM.Name = "cbxRazaM";
            this.cbxRazaM.Size = new System.Drawing.Size(121, 21);
            this.cbxRazaM.TabIndex = 20;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Location = new System.Drawing.Point(641, 215);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarM.TabIndex = 19;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnEditarM
            // 
            this.btnEditarM.Location = new System.Drawing.Point(534, 215);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(75, 23);
            this.btnEditarM.TabIndex = 18;
            this.btnEditarM.Text = "Actualizar";
            this.btnEditarM.UseVisualStyleBackColor = true;
            this.btnEditarM.Click += new System.EventHandler(this.btnEditarM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Año de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Raza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Especie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre";
            // 
            // txtAñoM2
            // 
            this.txtAñoM2.Location = new System.Drawing.Point(786, 159);
            this.txtAñoM2.Name = "txtAñoM2";
            this.txtAñoM2.Size = new System.Drawing.Size(63, 20);
            this.txtAñoM2.TabIndex = 13;
            // 
            // cbxEspecieM2
            // 
            this.cbxEspecieM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecieM2.FormattingEnabled = true;
            this.cbxEspecieM2.Location = new System.Drawing.Point(494, 160);
            this.cbxEspecieM2.Name = "cbxEspecieM2";
            this.cbxEspecieM2.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecieM2.TabIndex = 11;
            this.cbxEspecieM2.SelectedIndexChanged += new System.EventHandler(this.cbxEspecieM2_SelectedIndexChanged);
            // 
            // txtNombreM2
            // 
            this.txtNombreM2.Location = new System.Drawing.Point(330, 160);
            this.txtNombreM2.Name = "txtNombreM2";
            this.txtNombreM2.Size = new System.Drawing.Size(138, 20);
            this.txtNombreM2.TabIndex = 10;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(585, 57);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarM.TabIndex = 9;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Especie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txtAñoM
            // 
            this.txtAñoM.Location = new System.Drawing.Point(786, 5);
            this.txtAñoM.Name = "txtAñoM";
            this.txtAñoM.Size = new System.Drawing.Size(63, 20);
            this.txtAñoM.TabIndex = 4;
            // 
            // cbxEspecieM
            // 
            this.cbxEspecieM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecieM.FormattingEnabled = true;
            this.cbxEspecieM.Location = new System.Drawing.Point(494, 6);
            this.cbxEspecieM.Name = "cbxEspecieM";
            this.cbxEspecieM.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecieM.TabIndex = 2;
            this.cbxEspecieM.SelectedIndexChanged += new System.EventHandler(this.cbxEspecieM_SelectedIndexChanged);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(330, 6);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(138, 20);
            this.txtNombreM.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminarCita);
            this.tabPage2.Controls.Add(this.btnEditarCita);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.cbxVeterinaria2);
            this.tabPage2.Controls.Add(this.cbxVacuna2);
            this.tabPage2.Controls.Add(this.dataGridConsultas);
            this.tabPage2.Controls.Add(this.btnAgregarCita);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.cbxVeterinaria);
            this.tabPage2.Controls.Add(this.cbxVacuna);
            this.tabPage2.Controls.Add(this.dataGridMascotas2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Location = new System.Drawing.Point(621, 216);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCita.TabIndex = 33;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.Location = new System.Drawing.Point(540, 216);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCita.TabIndex = 32;
            this.btnEditarCita.Text = "Editar";
            this.btnEditarCita.UseVisualStyleBackColor = true;
            this.btnEditarCita.Click += new System.EventHandler(this.btnEditarCita_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Location = new System.Drawing.Point(693, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // cbxVeterinaria2
            // 
            this.cbxVeterinaria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVeterinaria2.FormattingEnabled = true;
            this.cbxVeterinaria2.Location = new System.Drawing.Point(566, 189);
            this.cbxVeterinaria2.Name = "cbxVeterinaria2";
            this.cbxVeterinaria2.Size = new System.Drawing.Size(121, 21);
            this.cbxVeterinaria2.TabIndex = 30;
            // 
            // cbxVacuna2
            // 
            this.cbxVacuna2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVacuna2.FormattingEnabled = true;
            this.cbxVacuna2.Location = new System.Drawing.Point(439, 188);
            this.cbxVacuna2.Name = "cbxVacuna2";
            this.cbxVacuna2.Size = new System.Drawing.Size(121, 21);
            this.cbxVacuna2.TabIndex = 29;
            // 
            // dataGridConsultas
            // 
            this.dataGridConsultas.AllowUserToAddRows = false;
            this.dataGridConsultas.AllowUserToDeleteRows = false;
            this.dataGridConsultas.AllowUserToResizeColumns = false;
            this.dataGridConsultas.AllowUserToResizeRows = false;
            this.dataGridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultas.Location = new System.Drawing.Point(452, 6);
            this.dataGridConsultas.Name = "dataGridConsultas";
            this.dataGridConsultas.ReadOnly = true;
            this.dataGridConsultas.RowHeadersVisible = false;
            this.dataGridConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConsultas.Size = new System.Drawing.Size(357, 155);
            this.dataGridConsultas.TabIndex = 28;
            this.dataGridConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsultas_CellContentClick);
            this.dataGridConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsultas_CellContentClick);
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.Location = new System.Drawing.Point(159, 212);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCita.TabIndex = 27;
            this.btnAgregarCita.Text = "Agregar";
            this.btnAgregarCita.UseVisualStyleBackColor = true;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // cbxVeterinaria
            // 
            this.cbxVeterinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVeterinaria.FormattingEnabled = true;
            this.cbxVeterinaria.Location = new System.Drawing.Point(133, 185);
            this.cbxVeterinaria.Name = "cbxVeterinaria";
            this.cbxVeterinaria.Size = new System.Drawing.Size(121, 21);
            this.cbxVeterinaria.TabIndex = 25;
            // 
            // cbxVacuna
            // 
            this.cbxVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVacuna.FormattingEnabled = true;
            this.cbxVacuna.Location = new System.Drawing.Point(6, 184);
            this.cbxVacuna.Name = "cbxVacuna";
            this.cbxVacuna.Size = new System.Drawing.Size(121, 21);
            this.cbxVacuna.TabIndex = 24;
            // 
            // dataGridMascotas2
            // 
            this.dataGridMascotas2.AllowUserToAddRows = false;
            this.dataGridMascotas2.AllowUserToDeleteRows = false;
            this.dataGridMascotas2.AllowUserToResizeColumns = false;
            this.dataGridMascotas2.AllowUserToResizeRows = false;
            this.dataGridMascotas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMascotas2.Location = new System.Drawing.Point(33, 6);
            this.dataGridMascotas2.MultiSelect = false;
            this.dataGridMascotas2.Name = "dataGridMascotas2";
            this.dataGridMascotas2.ReadOnly = true;
            this.dataGridMascotas2.RowHeadersVisible = false;
            this.dataGridMascotas2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMascotas2.Size = new System.Drawing.Size(351, 155);
            this.dataGridMascotas2.TabIndex = 23;
            this.dataGridMascotas2.UseWaitCursor = true;
            this.dataGridMascotas2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMascotas2_CellContentClick);
            this.dataGridMascotas2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMascotas2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(894, 457);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(910, 496);
            this.MinimumSize = new System.Drawing.Size(910, 496);
            this.Name = "Form1";
            this.Text = "Vacunas Mascotas - MongoDB";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMascotas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMascotas2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAñoM2;
        private System.Windows.Forms.ComboBox cbxEspecieM2;
        private System.Windows.Forms.TextBox txtNombreM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAñoM;
        private System.Windows.Forms.ComboBox cbxEspecieM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.ComboBox cbxRazaM;
        private System.Windows.Forms.ComboBox cbxRazaM2;
        private System.Windows.Forms.DataGridView dataGridMascotas;
        private System.Windows.Forms.DataGridView dataGridMascotas2;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxVeterinaria;
        private System.Windows.Forms.ComboBox cbxVacuna;
        private System.Windows.Forms.DataGridView dataGridConsultas;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxVeterinaria2;
        private System.Windows.Forms.ComboBox cbxVacuna2;
    }
}

