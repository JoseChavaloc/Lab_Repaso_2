namespace Lab_Repaso_2
{
    partial class FormAlquiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNIT = new System.Windows.Forms.ComboBox();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtKmRecorridos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLACA ALQUILER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE ALQUILER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FIN DE ALQUILER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KILOMETROS RECORRIDOS";
            // 
            // cmbNIT
            // 
            this.cmbNIT.FormattingEnabled = true;
            this.cmbNIT.Location = new System.Drawing.Point(82, 33);
            this.cmbNIT.Name = "cmbNIT";
            this.cmbNIT.Size = new System.Drawing.Size(121, 24);
            this.cmbNIT.TabIndex = 5;
            this.cmbNIT.SelectedIndexChanged += new System.EventHandler(this.cmbNIT_SelectedIndexChanged);
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(365, 36);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(121, 24);
            this.cmbPlaca.TabIndex = 6;
            this.cmbPlaca.SelectedIndexChanged += new System.EventHandler(this.cmbPlaca_SelectedIndexChanged);
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(221, 90);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerAlquiler.TabIndex = 7;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(686, 90);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerDevolucion.TabIndex = 8;
            // 
            // txtKmRecorridos
            // 
            this.txtKmRecorridos.Location = new System.Drawing.Point(259, 143);
            this.txtKmRecorridos.Name = "txtKmRecorridos";
            this.txtKmRecorridos.Size = new System.Drawing.Size(133, 22);
            this.txtKmRecorridos.TabIndex = 9;
            this.txtKmRecorridos.TextChanged += new System.EventHandler(this.txtKmRecorridos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGISTAR ALQUILER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 182);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(824, 287);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 43);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 436);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKmRecorridos);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.dateTimePickerAlquiler);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.cmbNIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNIT;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.TextBox txtKmRecorridos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
    }
}