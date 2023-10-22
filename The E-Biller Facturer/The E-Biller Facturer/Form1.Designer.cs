namespace The_E_Biller_Facturer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titulo = new Label();
            btnPrint = new Button();
            btnIN = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Pay = new DataGridViewTextBoxColumn();
            ToHas = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnDGV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(414, 41);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(112, 15);
            Titulo.TabIndex = 0;
            Titulo.Text = "The E-Biller Facturer";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(66, 33);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Imprimir Factura";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnIN
            // 
            btnIN.Location = new Point(789, 38);
            btnIN.Name = "btnIN";
            btnIN.Size = new Size(75, 23);
            btnIN.TabIndex = 2;
            btnIN.Text = "Acceder";
            btnIN.UseVisualStyleBackColor = true;
            btnIN.Click += btnIN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Date, Pay, ToHas, Total });
            dataGridView1.Location = new Point(172, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 255);
            dataGridView1.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Date
            // 
            Date.HeaderText = "Fecha";
            Date.Name = "Date";
            // 
            // Pay
            // 
            Pay.HeaderText = "Pago";
            Pay.Name = "Pay";
            // 
            // ToHas
            // 
            ToHas.HeaderText = "Debe";
            ToHas.Name = "ToHas";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnDGV
            // 
            btnDGV.Location = new Point(414, 120);
            btnDGV.Name = "btnDGV";
            btnDGV.Size = new Size(112, 43);
            btnDGV.TabIndex = 4;
            btnDGV.Text = "Administracion de pagos";
            btnDGV.UseVisualStyleBackColor = true;
            btnDGV.Click += btnDGV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 499);
            Controls.Add(btnDGV);
            Controls.Add(dataGridView1);
            Controls.Add(btnIN);
            Controls.Add(btnPrint);
            Controls.Add(Titulo);
            Name = "Form1";
            Text = "The E-Biller Facturer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button btnPrint;
        private Button btnIN;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Pay;
        private DataGridViewTextBoxColumn ToHas;
        private DataGridViewTextBoxColumn Total;
        private Button btnDGV;
    }
}