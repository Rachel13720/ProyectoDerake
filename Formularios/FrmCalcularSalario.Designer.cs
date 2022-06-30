
namespace ProyectoDerake.Formularios
{
    partial class FrmCalcularSalario
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
            this.TxtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.TxtPrecioPorHora = new System.Windows.Forms.TextBox();
            this.LblHoras = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtHorasTrabajadas
            // 
            this.TxtHorasTrabajadas.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.TxtHorasTrabajadas.Location = new System.Drawing.Point(50, 132);
            this.TxtHorasTrabajadas.Name = "TxtHorasTrabajadas";
            this.TxtHorasTrabajadas.Size = new System.Drawing.Size(209, 23);
            this.TxtHorasTrabajadas.TabIndex = 0;
            // 
            // TxtPrecioPorHora
            // 
            this.TxtPrecioPorHora.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.TxtPrecioPorHora.Location = new System.Drawing.Point(50, 218);
            this.TxtPrecioPorHora.Name = "TxtPrecioPorHora";
            this.TxtPrecioPorHora.Size = new System.Drawing.Size(209, 23);
            this.TxtPrecioPorHora.TabIndex = 1;
            // 
            // LblHoras
            // 
            this.LblHoras.AutoSize = true;
            this.LblHoras.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.LblHoras.Location = new System.Drawing.Point(47, 116);
            this.LblHoras.Name = "LblHoras";
            this.LblHoras.Size = new System.Drawing.Size(166, 16);
            this.LblHoras.TabIndex = 2;
            this.LblHoras.Text = "Horas semanales trabajadas";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.LblPrecio.Location = new System.Drawing.Point(47, 202);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(95, 16);
            this.LblPrecio.TabIndex = 3;
            this.LblPrecio.Text = "Precio por hora";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAceptar.Location = new System.Drawing.Point(37, 303);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(98, 39);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(171, 303);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 39);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmCalcularSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 408);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblHoras);
            this.Controls.Add(this.TxtPrecioPorHora);
            this.Controls.Add(this.TxtHorasTrabajadas);
            this.Name = "FrmCalcularSalario";
            this.Text = "Calcular Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHorasTrabajadas;
        private System.Windows.Forms.TextBox TxtPrecioPorHora;
        private System.Windows.Forms.Label LblHoras;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}