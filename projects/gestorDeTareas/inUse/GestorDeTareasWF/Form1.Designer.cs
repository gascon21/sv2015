namespace Agenda
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
            this.bDiaAnterior = new System.Windows.Forms.Button();
            this.bDiaSiguiente = new System.Windows.Forms.Button();
            this.bAnyadirTarea = new System.Windows.Forms.Button();
            this.bRetrasarTarea = new System.Windows.Forms.Button();
            this.listaTareas = new System.Windows.Forms.CheckedListBox();
            this.bModificarTarea = new System.Windows.Forms.Button();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDiaAnterior
            // 
            this.bDiaAnterior.Location = new System.Drawing.Point(44, 324);
            this.bDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDiaAnterior.Name = "bDiaAnterior";
            this.bDiaAnterior.Size = new System.Drawing.Size(164, 47);
            this.bDiaAnterior.TabIndex = 0;
            this.bDiaAnterior.Text = "DIA ANTERIOR";
            this.bDiaAnterior.UseVisualStyleBackColor = true;
            // 
            // bDiaSiguiente
            // 
            this.bDiaSiguiente.Location = new System.Drawing.Point(376, 324);
            this.bDiaSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDiaSiguiente.Name = "bDiaSiguiente";
            this.bDiaSiguiente.Size = new System.Drawing.Size(156, 47);
            this.bDiaSiguiente.TabIndex = 1;
            this.bDiaSiguiente.Text = "DIA SIGUIENTE";
            this.bDiaSiguiente.UseVisualStyleBackColor = true;
            // 
            // bAnyadirTarea
            // 
            this.bAnyadirTarea.Location = new System.Drawing.Point(216, 324);
            this.bAnyadirTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAnyadirTarea.Name = "bAnyadirTarea";
            this.bAnyadirTarea.Size = new System.Drawing.Size(152, 47);
            this.bAnyadirTarea.TabIndex = 2;
            this.bAnyadirTarea.Text = "AÑADIR TAREA";
            this.bAnyadirTarea.UseVisualStyleBackColor = true;
            this.bAnyadirTarea.Click += new System.EventHandler(this.bAnyadirTarea_Click);
            // 
            // bRetrasarTarea
            // 
            this.bRetrasarTarea.Location = new System.Drawing.Point(372, 126);
            this.bRetrasarTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRetrasarTarea.Name = "bRetrasarTarea";
            this.bRetrasarTarea.Size = new System.Drawing.Size(155, 28);
            this.bRetrasarTarea.TabIndex = 3;
            this.bRetrasarTarea.Text = "RETRASAR TAREA";
            this.bRetrasarTarea.UseVisualStyleBackColor = true;
            this.bRetrasarTarea.Click += new System.EventHandler(this.bRetrasarTarea_Click);
            // 
            // listaTareas
            // 
            this.listaTareas.FormattingEnabled = true;
            this.listaTareas.Items.AddRange(new object[] {
            "tarea1",
            "tarea2"});
            this.listaTareas.Location = new System.Drawing.Point(44, 75);
            this.listaTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaTareas.Name = "listaTareas";
            this.listaTareas.Size = new System.Drawing.Size(303, 191);
            this.listaTareas.TabIndex = 4;
            this.listaTareas.SelectedIndexChanged += new System.EventHandler(this.listaTareas_SelectedIndexChanged);
            // 
            // bModificarTarea
            // 
            this.bModificarTarea.Location = new System.Drawing.Point(372, 90);
            this.bModificarTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bModificarTarea.Name = "bModificarTarea";
            this.bModificarTarea.Size = new System.Drawing.Size(160, 28);
            this.bModificarTarea.TabIndex = 5;
            this.bModificarTarea.Text = "MODIFICAR TAREA";
            this.bModificarTarea.UseVisualStyleBackColor = true;
            this.bModificarTarea.Click += new System.EventHandler(this.bModificarTarea_Click);
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Location = new System.Drawing.Point(241, 16);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(147, 17);
            this.lTitulo.TabIndex = 6;
            this.lTitulo.Text = "FECHA DE LA TAREA";
            this.lTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(216, 379);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(152, 46);
            this.btBorrar.TabIndex = 7;
            this.btBorrar.Text = "BORRAR TAREA";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 458);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.bModificarTarea);
            this.Controls.Add(this.listaTareas);
            this.Controls.Add(this.bRetrasarTarea);
            this.Controls.Add(this.bAnyadirTarea);
            this.Controls.Add(this.bDiaSiguiente);
            this.Controls.Add(this.bDiaAnterior);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDiaAnterior;
        private System.Windows.Forms.Button bDiaSiguiente;
        private System.Windows.Forms.Button bAnyadirTarea;
        private System.Windows.Forms.Button bRetrasarTarea;
        private System.Windows.Forms.CheckedListBox listaTareas;
        private System.Windows.Forms.Button bModificarTarea;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button btBorrar;
    }
}

