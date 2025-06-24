namespace Ejercicio1
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnAgregarExpediente = new Button();
            btnVerListado = new Button();
            btnMayores = new Button();
            btnVerExpedientes = new Button();
            btnVerCausaPorNumero = new Button();
            label1 = new Label();
            label2 = new Label();
            tbDNI = new TextBox();
            tbNroCausa = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMayores);
            groupBox1.Controls.Add(btnVerListado);
            groupBox1.Controls.Add(btnAgregarExpediente);
            groupBox1.Location = new Point(66, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expedientes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbDNI);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnVerExpedientes);
            groupBox2.Location = new Point(66, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ver Expediente de una persona";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbNroCausa);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnVerCausaPorNumero);
            groupBox3.Location = new Point(66, 296);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(685, 123);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ver Expediente";
            // 
            // btnAgregarExpediente
            // 
            btnAgregarExpediente.Location = new Point(51, 43);
            btnAgregarExpediente.Name = "btnAgregarExpediente";
            btnAgregarExpediente.Size = new Size(98, 43);
            btnAgregarExpediente.TabIndex = 0;
            btnAgregarExpediente.Text = "Registrar Nuevo";
            btnAgregarExpediente.UseVisualStyleBackColor = true;
            // 
            // btnVerListado
            // 
            btnVerListado.Location = new Point(302, 43);
            btnVerListado.Name = "btnVerListado";
            btnVerListado.Size = new Size(91, 43);
            btnVerListado.TabIndex = 1;
            btnVerListado.Text = "Ver Todos";
            btnVerListado.UseVisualStyleBackColor = true;
            // 
            // btnMayores
            // 
            btnMayores.Location = new Point(536, 43);
            btnMayores.Name = "btnMayores";
            btnMayores.Size = new Size(85, 43);
            btnMayores.TabIndex = 2;
            btnMayores.Text = "Ver Mayores en Monto";
            btnMayores.UseVisualStyleBackColor = true;
            // 
            // btnVerExpedientes
            // 
            btnVerExpedientes.Location = new Point(536, 45);
            btnVerExpedientes.Name = "btnVerExpedientes";
            btnVerExpedientes.Size = new Size(85, 45);
            btnVerExpedientes.TabIndex = 0;
            btnVerExpedientes.Text = "Ver Expedientes";
            btnVerExpedientes.UseVisualStyleBackColor = true;
            // 
            // btnVerCausaPorNumero
            // 
            btnVerCausaPorNumero.Location = new Point(536, 70);
            btnVerCausaPorNumero.Name = "btnVerCausaPorNumero";
            btnVerCausaPorNumero.Size = new Size(85, 23);
            btnVerCausaPorNumero.TabIndex = 0;
            btnVerCausaPorNumero.Text = "Ver Causa";
            btnVerCausaPorNumero.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 60);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero Causa";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(97, 56);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(194, 23);
            tbDNI.TabIndex = 2;
            // 
            // tbNroCausa
            // 
            tbNroCausa.Location = new Point(136, 70);
            tbNroCausa.Name = "tbNroCausa";
            tbNroCausa.Size = new Size(155, 23);
            tbNroCausa.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnMayores;
        private Button btnVerListado;
        private Button btnAgregarExpediente;
        private TextBox tbDNI;
        private Label label1;
        private Button btnVerExpedientes;
        private TextBox tbNroCausa;
        private Label label2;
        private Button btnVerCausaPorNumero;
    }
}
