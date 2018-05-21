namespace SistemasDeCoordenadas
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.labelPuntoInicial = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxPuntos = new System.Windows.Forms.ListBox();
            this.numericUpDownGrados = new System.Windows.Forms.NumericUpDown();
            this.labelRotacion = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.numericUpDownTX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTY = new System.Windows.Forms.NumericUpDown();
            this.labelTraslacion = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEscalamiento = new System.Windows.Forms.Label();
            this.numericUpDownSX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 638);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(722, 25);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(70, 13);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "LABELcheck";
            // 
            // labelPuntoInicial
            // 
            this.labelPuntoInicial.AutoSize = true;
            this.labelPuntoInicial.Location = new System.Drawing.Point(678, 25);
            this.labelPuntoInicial.Name = "labelPuntoInicial";
            this.labelPuntoInicial.Size = new System.Drawing.Size(38, 13);
            this.labelPuntoInicial.TabIndex = 8;
            this.labelPuntoInicial.Text = "Punto:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(706, 391);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "DRAW!";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(706, 477);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "CLEAR!";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxPuntos
            // 
            this.listBoxPuntos.FormattingEnabled = true;
            this.listBoxPuntos.Location = new System.Drawing.Point(681, 41);
            this.listBoxPuntos.Name = "listBoxPuntos";
            this.listBoxPuntos.Size = new System.Drawing.Size(121, 121);
            this.listBoxPuntos.TabIndex = 12;
            // 
            // numericUpDownGrados
            // 
            this.numericUpDownGrados.DecimalPlaces = 2;
            this.numericUpDownGrados.Location = new System.Drawing.Point(681, 192);
            this.numericUpDownGrados.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownGrados.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownGrados.Name = "numericUpDownGrados";
            this.numericUpDownGrados.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownGrados.TabIndex = 1;
            // 
            // labelRotacion
            // 
            this.labelRotacion.AutoSize = true;
            this.labelRotacion.Location = new System.Drawing.Point(678, 176);
            this.labelRotacion.Name = "labelRotacion";
            this.labelRotacion.Size = new System.Drawing.Size(129, 13);
            this.labelRotacion.TabIndex = 14;
            this.labelRotacion.Text = "Rotacion horaria (grados):";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(706, 435);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // numericUpDownTX
            // 
            this.numericUpDownTX.Location = new System.Drawing.Point(725, 306);
            this.numericUpDownTX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownTX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownTX.Name = "numericUpDownTX";
            this.numericUpDownTX.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownTX.TabIndex = 4;
            // 
            // numericUpDownTY
            // 
            this.numericUpDownTY.Location = new System.Drawing.Point(725, 332);
            this.numericUpDownTY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownTY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownTY.Name = "numericUpDownTY";
            this.numericUpDownTY.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownTY.TabIndex = 5;
            // 
            // labelTraslacion
            // 
            this.labelTraslacion.AutoSize = true;
            this.labelTraslacion.Location = new System.Drawing.Point(678, 290);
            this.labelTraslacion.Name = "labelTraslacion";
            this.labelTraslacion.Size = new System.Drawing.Size(59, 13);
            this.labelTraslacion.TabIndex = 18;
            this.labelTraslacion.Text = "Traslacion:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(678, 308);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(33, 13);
            this.labelX.TabIndex = 19;
            this.labelX.Text = "En X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(678, 334);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(33, 13);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "En Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "En Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "En X:";
            // 
            // labelEscalamiento
            // 
            this.labelEscalamiento.AutoSize = true;
            this.labelEscalamiento.Location = new System.Drawing.Point(678, 215);
            this.labelEscalamiento.Name = "labelEscalamiento";
            this.labelEscalamiento.Size = new System.Drawing.Size(73, 13);
            this.labelEscalamiento.TabIndex = 23;
            this.labelEscalamiento.Text = "Escalamiento:";
            // 
            // numericUpDownSX
            // 
            this.numericUpDownSX.DecimalPlaces = 2;
            this.numericUpDownSX.Location = new System.Drawing.Point(725, 231);
            this.numericUpDownSX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownSX.Name = "numericUpDownSX";
            this.numericUpDownSX.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownSX.TabIndex = 2;
            this.numericUpDownSX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSY
            // 
            this.numericUpDownSY.DecimalPlaces = 2;
            this.numericUpDownSY.Location = new System.Drawing.Point(725, 257);
            this.numericUpDownSY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownSY.Name = "numericUpDownSY";
            this.numericUpDownSY.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownSY.TabIndex = 3;
            this.numericUpDownSY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 661);
            this.Controls.Add(this.numericUpDownSY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEscalamiento);
            this.Controls.Add(this.numericUpDownSX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelTraslacion);
            this.Controls.Add(this.numericUpDownTY);
            this.Controls.Add(this.numericUpDownTX);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelRotacion);
            this.Controls.Add(this.numericUpDownGrados);
            this.Controls.Add(this.listBoxPuntos);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelPuntoInicial);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Transformaciones Rígidas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label labelPuntoInicial;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxPuntos;
        private System.Windows.Forms.NumericUpDown numericUpDownGrados;
        private System.Windows.Forms.Label labelRotacion;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.NumericUpDown numericUpDownTX;
        private System.Windows.Forms.NumericUpDown numericUpDownTY;
        private System.Windows.Forms.Label labelTraslacion;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEscalamiento;
        private System.Windows.Forms.NumericUpDown numericUpDownSX;
        private System.Windows.Forms.NumericUpDown numericUpDownSY;
    }
}

