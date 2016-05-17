namespace Agenda
{
    partial class VentanaTarea
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
            this.btModificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prioridad = new System.Windows.Forms.NumericUpDown();
            this.categoria = new System.Windows.Forms.TextBox();
            this.duracionMinuto = new System.Windows.Forms.NumericUpDown();
            this.duracionHora = new System.Windows.Forms.NumericUpDown();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.minutos = new System.Windows.Forms.NumericUpDown();
            this.horas = new System.Windows.Forms.NumericUpDown();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.prioridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracionMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracionHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas)).BeginInit();
            this.SuspendLayout();
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(336, 556);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(91, 40);
            this.btModificar.TabIndex = 44;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tarea";
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(336, 509);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(91, 40);
            this.btAnyadir.TabIndex = 42;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Los campos con * son obligatorios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Prioridad*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Categoria*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha*  ";
            // 
            // prioridad
            // 
            this.prioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.prioridad.Location = new System.Drawing.Point(135, 441);
            this.prioridad.Margin = new System.Windows.Forms.Padding(4);
            this.prioridad.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.prioridad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prioridad.Name = "prioridad";
            this.prioridad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prioridad.Size = new System.Drawing.Size(52, 26);
            this.prioridad.TabIndex = 34;
            this.prioridad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(135, 354);
            this.categoria.Multiline = true;
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(283, 69);
            this.categoria.TabIndex = 33;
            // 
            // duracionMinuto
            // 
            this.duracionMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.duracionMinuto.Location = new System.Drawing.Point(195, 299);
            this.duracionMinuto.Margin = new System.Windows.Forms.Padding(4);
            this.duracionMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.duracionMinuto.Name = "duracionMinuto";
            this.duracionMinuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.duracionMinuto.Size = new System.Drawing.Size(52, 26);
            this.duracionMinuto.TabIndex = 32;
            // 
            // duracionHora
            // 
            this.duracionHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.duracionHora.Location = new System.Drawing.Point(135, 299);
            this.duracionHora.Margin = new System.Windows.Forms.Padding(4);
            this.duracionHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.duracionHora.Name = "duracionHora";
            this.duracionHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.duracionHora.Size = new System.Drawing.Size(52, 26);
            this.duracionHora.TabIndex = 31;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(135, 208);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(283, 66);
            this.descripcion.TabIndex = 30;
            // 
            // minutos
            // 
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minutos.Location = new System.Drawing.Point(195, 136);
            this.minutos.Margin = new System.Windows.Forms.Padding(4);
            this.minutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutos.Name = "minutos";
            this.minutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minutos.Size = new System.Drawing.Size(52, 26);
            this.minutos.TabIndex = 29;
            // 
            // horas
            // 
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.horas.Location = new System.Drawing.Point(135, 136);
            this.horas.Margin = new System.Windows.Forms.Padding(4);
            this.horas.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.horas.Name = "horas";
            this.horas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.horas.Size = new System.Drawing.Size(52, 26);
            this.horas.TabIndex = 28;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(135, 73);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(283, 22);
            this.fecha.TabIndex = 27;
            // 
            // VentanaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 608);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAnyadir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prioridad);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.duracionMinuto);
            this.Controls.Add(this.duracionHora);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.fecha);
            this.Name = "VentanaTarea";
            this.Text = "VentanaTarea";
            ((System.ComponentModel.ISupportInitialize)(this.prioridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracionMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracionHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown prioridad;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.NumericUpDown duracionMinuto;
        private System.Windows.Forms.NumericUpDown duracionHora;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.NumericUpDown minutos;
        private System.Windows.Forms.NumericUpDown horas;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}