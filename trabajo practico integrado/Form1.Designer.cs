
namespace trabajo_practico_integrado
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
            this.cmdmayor = new System.Windows.Forms.Button();
            this.cmdigual = new System.Windows.Forms.Button();
            this.cmdmenor = new System.Windows.Forms.Button();
            this.imgoso = new System.Windows.Forms.PictureBox();
            this.imgnumero1 = new System.Windows.Forms.PictureBox();
            this.imgnumero2 = new System.Windows.Forms.PictureBox();
            this.imgelegida = new System.Windows.Forms.PictureBox();
            this.cmdjugar = new System.Windows.Forms.Button();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblpuntajefinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblaciertos = new System.Windows.Forms.Label();
            this.lblfallas = new System.Windows.Forms.Label();
            this.cmdvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnumero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgelegida)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdmayor
            // 
            this.cmdmayor.Enabled = false;
            this.cmdmayor.Image = global::trabajo_practico_integrado.Properties.Resources.Mayor;
            this.cmdmayor.Location = new System.Drawing.Point(120, 386);
            this.cmdmayor.Name = "cmdmayor";
            this.cmdmayor.Size = new System.Drawing.Size(133, 127);
            this.cmdmayor.TabIndex = 0;
            this.cmdmayor.UseVisualStyleBackColor = true;
            this.cmdmayor.Click += new System.EventHandler(this.cmdmayor_Click);
            // 
            // cmdigual
            // 
            this.cmdigual.Enabled = false;
            this.cmdigual.Image = global::trabajo_practico_integrado.Properties.Resources.Igual;
            this.cmdigual.Location = new System.Drawing.Point(357, 386);
            this.cmdigual.Name = "cmdigual";
            this.cmdigual.Size = new System.Drawing.Size(133, 127);
            this.cmdigual.TabIndex = 1;
            this.cmdigual.UseVisualStyleBackColor = true;
            this.cmdigual.Click += new System.EventHandler(this.cmdigual_Click);
            // 
            // cmdmenor
            // 
            this.cmdmenor.Enabled = false;
            this.cmdmenor.Image = global::trabajo_practico_integrado.Properties.Resources.Menor;
            this.cmdmenor.Location = new System.Drawing.Point(582, 386);
            this.cmdmenor.Name = "cmdmenor";
            this.cmdmenor.Size = new System.Drawing.Size(133, 127);
            this.cmdmenor.TabIndex = 2;
            this.cmdmenor.UseVisualStyleBackColor = true;
            this.cmdmenor.Click += new System.EventHandler(this.cmdmenor_Click);
            // 
            // imgoso
            // 
            this.imgoso.Image = global::trabajo_practico_integrado.Properties.Resources.Coco;
            this.imgoso.Location = new System.Drawing.Point(3, 1);
            this.imgoso.Name = "imgoso";
            this.imgoso.Size = new System.Drawing.Size(149, 135);
            this.imgoso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgoso.TabIndex = 3;
            this.imgoso.TabStop = false;
            this.imgoso.Click += new System.EventHandler(this.imgoso_Click);
            // 
            // imgnumero1
            // 
            this.imgnumero1.Image = global::trabajo_practico_integrado.Properties.Resources._0;
            this.imgnumero1.Location = new System.Drawing.Point(144, 129);
            this.imgnumero1.Name = "imgnumero1";
            this.imgnumero1.Size = new System.Drawing.Size(134, 128);
            this.imgnumero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgnumero1.TabIndex = 4;
            this.imgnumero1.TabStop = false;
            // 
            // imgnumero2
            // 
            this.imgnumero2.Image = global::trabajo_practico_integrado.Properties.Resources._0;
            this.imgnumero2.Location = new System.Drawing.Point(576, 129);
            this.imgnumero2.Name = "imgnumero2";
            this.imgnumero2.Size = new System.Drawing.Size(139, 128);
            this.imgnumero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgnumero2.TabIndex = 5;
            this.imgnumero2.TabStop = false;
            // 
            // imgelegida
            // 
            this.imgelegida.Location = new System.Drawing.Point(366, 141);
            this.imgelegida.Name = "imgelegida";
            this.imgelegida.Size = new System.Drawing.Size(99, 89);
            this.imgelegida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgelegida.TabIndex = 6;
            this.imgelegida.TabStop = false;
            // 
            // cmdjugar
            // 
            this.cmdjugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdjugar.Location = new System.Drawing.Point(275, 279);
            this.cmdjugar.Name = "cmdjugar";
            this.cmdjugar.Size = new System.Drawing.Size(278, 78);
            this.cmdjugar.TabIndex = 7;
            this.cmdjugar.Text = "jugar";
            this.cmdjugar.UseVisualStyleBackColor = true;
            this.cmdjugar.Click += new System.EventHandler(this.cmdjugar_Click);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.Location = new System.Drawing.Point(744, 150);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(115, 24);
            this.lblpuntaje.TabIndex = 8;
            this.lblpuntaje.Text = "puntaje:";
            // 
            // lblpuntajefinal
            // 
            this.lblpuntajefinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntajefinal.Location = new System.Drawing.Point(832, 150);
            this.lblpuntajefinal.Name = "lblpuntajefinal";
            this.lblpuntajefinal.Size = new System.Drawing.Size(37, 24);
            this.lblpuntajefinal.TabIndex = 9;
            this.lblpuntajefinal.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "aciertos:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "fallas:";
            // 
            // lblaciertos
            // 
            this.lblaciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaciertos.Location = new System.Drawing.Point(832, 185);
            this.lblaciertos.Name = "lblaciertos";
            this.lblaciertos.Size = new System.Drawing.Size(37, 24);
            this.lblaciertos.TabIndex = 12;
            this.lblaciertos.Text = "0";
            // 
            // lblfallas
            // 
            this.lblfallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfallas.Location = new System.Drawing.Point(813, 221);
            this.lblfallas.Name = "lblfallas";
            this.lblfallas.Size = new System.Drawing.Size(37, 24);
            this.lblfallas.TabIndex = 13;
            this.lblfallas.Text = "0";
            // 
            // cmdvolver
            // 
            this.cmdvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvolver.Location = new System.Drawing.Point(255, 279);
            this.cmdvolver.Name = "cmdvolver";
            this.cmdvolver.Size = new System.Drawing.Size(394, 78);
            this.cmdvolver.TabIndex = 14;
            this.cmdvolver.Text = "volver a jugar";
            this.cmdvolver.UseVisualStyleBackColor = true;
            this.cmdvolver.Visible = false;
            this.cmdvolver.Click += new System.EventHandler(this.cmdvolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::trabajo_practico_integrado.Properties.Resources.pngtree_lively_fresh_stage_advertising_background_backgroundfreshstagelightlight_bulbred_curtainperformanceshow_image_55865;
            this.ClientSize = new System.Drawing.Size(951, 535);
            this.Controls.Add(this.cmdvolver);
            this.Controls.Add(this.lblfallas);
            this.Controls.Add(this.lblaciertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpuntajefinal);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.cmdjugar);
            this.Controls.Add(this.imgelegida);
            this.Controls.Add(this.imgnumero2);
            this.Controls.Add(this.imgnumero1);
            this.Controls.Add(this.imgoso);
            this.Controls.Add(this.cmdmenor);
            this.Controls.Add(this.cmdigual);
            this.Controls.Add(this.cmdmayor);
            this.Name = "Form1";
            this.Text = "mayor o menor";
            ((System.ComponentModel.ISupportInitialize)(this.imgoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgnumero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgelegida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdmayor;
        private System.Windows.Forms.Button cmdigual;
        private System.Windows.Forms.Button cmdmenor;
        private System.Windows.Forms.PictureBox imgoso;
        private System.Windows.Forms.PictureBox imgnumero1;
        private System.Windows.Forms.PictureBox imgnumero2;
        private System.Windows.Forms.PictureBox imgelegida;
        private System.Windows.Forms.Button cmdjugar;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblpuntajefinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblaciertos;
        private System.Windows.Forms.Label lblfallas;
        private System.Windows.Forms.Button cmdvolver;
    }
}

