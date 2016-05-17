namespace Agenda
{
    partial class RetrasarTarea
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
            this.pregunta = new System.Windows.Forms.Label();
            this.nDias = new System.Windows.Forms.NumericUpDown();
            this.btGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).BeginInit();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.Location = new System.Drawing.Point(13, 9);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(568, 36);
            this.pregunta.TabIndex = 7;
            this.pregunta.Text = "¿Cuántos días quiere retrasar la tarea?";
            // 
            // nDias
            // 
            this.nDias.Location = new System.Drawing.Point(20, 96);
            this.nDias.Margin = new System.Windows.Forms.Padding(4);
            this.nDias.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDias.Name = "nDias";
            this.nDias.Size = new System.Drawing.Size(160, 22);
            this.nDias.TabIndex = 6;
            this.nDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(221, 78);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(115, 47);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RetrasarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 158);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.nDias);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.button1);
            this.Name = "RetrasarTarea";
            this.Text = "RetrasarTarea";
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.NumericUpDown nDias;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button button1;
    }
}