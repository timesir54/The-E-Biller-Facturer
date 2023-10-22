namespace The_E_Biller_Facturer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            LogoBox = new PictureBox();
            btnImprimir = new Button();
            lblNombre = new Label();
            lblFecha = new Label();
            lblPago = new Label();
            lblDebe = new Label();
            lblTotal = new Label();
            textBoxN = new TextBox();
            textBoxF = new TextBox();
            textBoxP = new TextBox();
            textBoxD = new TextBox();
            textBoxO = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.E_biller;
            LogoBox.Location = new Point(416, 62);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(125, 68);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 0;
            LogoBox.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(499, 404);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 50);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(56, 124);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(56, 177);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(56, 237);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(34, 15);
            lblPago.TabIndex = 4;
            lblPago.Text = "Pago";
            // 
            // lblDebe
            // 
            lblDebe.AutoSize = true;
            lblDebe.Location = new Point(56, 302);
            lblDebe.Name = "lblDebe";
            lblDebe.Size = new Size(34, 15);
            lblDebe.TabIndex = 5;
            lblDebe.Text = "Debe";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(56, 360);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(124, 124);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(100, 23);
            textBoxN.TabIndex = 7;
            textBoxN.TextChanged += textBoxN_TextChanged;
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(124, 177);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new Size(100, 23);
            textBoxF.TabIndex = 8;
            textBoxF.TextChanged += textBoxF_TextChanged;
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(124, 229);
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(100, 23);
            textBoxP.TabIndex = 9;
            textBoxP.TextChanged += textBoxP_TextChanged;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(124, 294);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(100, 23);
            textBoxD.TabIndex = 10;
            textBoxD.TextChanged += textBoxD_TextChanged;
            // 
            // textBoxO
            // 
            textBoxO.Location = new Point(124, 352);
            textBoxO.Name = "textBoxO";
            textBoxO.Size = new Size(100, 23);
            textBoxO.TabIndex = 11;
            textBoxO.TextChanged += textBox5_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 497);
            Controls.Add(textBoxO);
            Controls.Add(textBoxD);
            Controls.Add(textBoxP);
            Controls.Add(textBoxF);
            Controls.Add(textBoxN);
            Controls.Add(lblTotal);
            Controls.Add(lblDebe);
            Controls.Add(lblPago);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(btnImprimir);
            Controls.Add(LogoBox);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoBox;
        private Button btnImprimir;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblPago;
        private Label lblDebe;
        private Label lblTotal;
        private TextBox textBoxN;
        private TextBox textBoxF;
        private TextBox textBoxP;
        private TextBox textBoxD;
        private TextBox textBoxO;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}