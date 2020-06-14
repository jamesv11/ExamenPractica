namespace ExamenPracticaGUI
{
    partial class CargueServicioForm
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
            this.AñoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CargarBtn = new System.Windows.Forms.Button();
            this.SedeCmbx = new System.Windows.Forms.ComboBox();
            this.MesCmbx = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AñoTxt
            // 
            this.AñoTxt.Location = new System.Drawing.Point(179, 151);
            this.AñoTxt.Name = "AñoTxt";
            this.AñoTxt.Size = new System.Drawing.Size(100, 20);
            this.AñoTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sede";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // CargarBtn
            // 
            this.CargarBtn.Location = new System.Drawing.Point(179, 243);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(75, 23);
            this.CargarBtn.TabIndex = 6;
            this.CargarBtn.Text = "Cargar";
            this.CargarBtn.UseVisualStyleBackColor = true;
            this.CargarBtn.Click += new System.EventHandler(this.CargarBtn_Click);
            // 
            // SedeCmbx
            // 
            this.SedeCmbx.FormattingEnabled = true;
            this.SedeCmbx.Items.AddRange(new object[] {
            "SucursalValledupar",
            "SucursalMedellin",
            "SucursalManizales"});
            this.SedeCmbx.Location = new System.Drawing.Point(179, 36);
            this.SedeCmbx.Name = "SedeCmbx";
            this.SedeCmbx.Size = new System.Drawing.Size(121, 21);
            this.SedeCmbx.TabIndex = 7;
            // 
            // MesCmbx
            // 
            this.MesCmbx.FormattingEnabled = true;
            this.MesCmbx.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.MesCmbx.Location = new System.Drawing.Point(179, 95);
            this.MesCmbx.Name = "MesCmbx";
            this.MesCmbx.Size = new System.Drawing.Size(121, 21);
            this.MesCmbx.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CargueServicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 319);
            this.Controls.Add(this.MesCmbx);
            this.Controls.Add(this.SedeCmbx);
            this.Controls.Add(this.CargarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AñoTxt);
            this.Name = "CargueServicioForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AñoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.ComboBox SedeCmbx;
        private System.Windows.Forms.ComboBox MesCmbx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

