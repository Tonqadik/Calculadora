namespace Calculadora
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
            txtDisplay = new TextBox();
            lblEstado = new Label();
            lblTitulo = new Label();
            btn4 = new Button();
            btn3 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btnMas = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            btnMenos = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnBack = new Button();
            btnPunto = new Button();
            btnC = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Share Tech Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(89, 90);
            txtDisplay.MaxLength = 12;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(212, 24);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(2, 117);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(299, 72);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "label1";
            lblEstado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(127, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(134, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Calculadora Básica";
            // 
            // btn4
            // 
            btn4.Font = new Font("Share Tech Mono", 8.999999F);
            btn4.Location = new Point(19, 258);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Share Tech Mono", 8.999999F);
            btn3.Location = new Point(151, 192);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Share Tech Mono", 8.999999F);
            btn9.Location = new Point(151, 324);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Share Tech Mono", 8.999999F);
            btn7.Location = new Point(19, 324);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Share Tech Mono", 8.999999F);
            btn1.Location = new Point(19, 192);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Share Tech Mono", 8.999999F);
            btn2.Location = new Point(85, 192);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Share Tech Mono", 8.999999F);
            btn5.Location = new Point(85, 258);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Share Tech Mono", 11.999999F);
            btnMas.Location = new Point(241, 324);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(60, 60);
            btnMas.TabIndex = 10;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Share Tech Mono", 8.999999F);
            btn8.Location = new Point(85, 324);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Share Tech Mono", 8.999999F);
            btn6.Location = new Point(151, 258);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Share Tech Mono", 11.999999F);
            btnMulti.Location = new Point(241, 258);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(60, 60);
            btnMulti.TabIndex = 13;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Share Tech Mono", 11.999999F);
            btnDivision.Location = new Point(307, 258);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(60, 60);
            btnDivision.TabIndex = 14;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Share Tech Mono", 11.999999F);
            btnMenos.Location = new Point(307, 324);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(60, 60);
            btnMenos.TabIndex = 15;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Share Tech Mono", 8.999999F);
            btn0.Location = new Point(19, 390);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Share Tech Mono", 11.999999F);
            btnIgual.Location = new Point(241, 390);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(60, 60);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Share Tech Mono", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(241, 192);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 60);
            btnBack.TabIndex = 18;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Share Tech Mono", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(85, 390);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(60, 60);
            btnPunto.TabIndex = 19;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Share Tech Mono", 8.999999F);
            btnC.Location = new Point(307, 192);
            btnC.Name = "btnC";
            btnC.Size = new Size(60, 60);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 588);
            Controls.Add(btnC);
            Controls.Add(btnPunto);
            Controls.Add(btnBack);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnMenos);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btnMas);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn7);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(lblTitulo);
            Controls.Add(lblEstado);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Label lblEstado;
        private Label lblTitulo;
        private Button btn4;
        private Button btn3;
        private Button btn9;
        private Button btn7;
        private Button btn1;
        private Button btn2;
        private Button btn5;
        private Button btnMas;
        private Button btn8;
        private Button btn6;
        private Button btnMulti;
        private Button btnDivision;
        private Button btnMenos;
        private Button btn0;
        private Button btnIgual;
        private Button btnBack;
        private Button btnPunto;
        private Button btnC;
    }
}
