namespace Practico4
{
    partial class formulario4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnImpar = new System.Windows.Forms.Button();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.chartNumeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(36, 79);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(36, 138);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(101, 76);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(158, 22);
            this.txtDesde.TabIndex = 2;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(101, 135);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(158, 22);
            this.txtHasta.TabIndex = 3;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(101, 180);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(158, 36);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Funcion";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // listNumeros
            // 
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.ItemHeight = 16;
            this.listNumeros.Location = new System.Drawing.Point(332, 76);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(313, 308);
            this.listNumeros.TabIndex = 5;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(436, 44);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(112, 16);
            this.lblLista.TabIndex = 6;
            this.lblLista.Text = "Lista de Numeros";
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(102, 236);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(156, 35);
            this.btnPar.TabIndex = 7;
            this.btnPar.Text = "Numero Pares";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnImpar
            // 
            this.btnImpar.Location = new System.Drawing.Point(102, 289);
            this.btnImpar.Name = "btnImpar";
            this.btnImpar.Size = new System.Drawing.Size(155, 34);
            this.btnImpar.TabIndex = 8;
            this.btnImpar.Text = "Numero Impares";
            this.btnImpar.UseVisualStyleBackColor = true;
            this.btnImpar.Click += new System.EventHandler(this.btnImpar_Click);
            // 
            // btnPrimos
            // 
            this.btnPrimos.Location = new System.Drawing.Point(101, 341);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(155, 35);
            this.btnPrimos.TabIndex = 9;
            this.btnPrimos.Text = "Numero Primos";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // chartNumeros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNumeros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNumeros.Legends.Add(legend1);
            this.chartNumeros.Location = new System.Drawing.Point(702, 76);
            this.chartNumeros.Name = "chartNumeros";
            this.chartNumeros.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNumeros.Series.Add(series1);
            this.chartNumeros.Size = new System.Drawing.Size(342, 308);
            this.chartNumeros.TabIndex = 10;
            this.chartNumeros.Text = "chart1";
            // 
            // formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.chartNumeros);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.btnImpar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.listNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Name = "formulario4";
            this.Text = "Formulario4";
            ((System.ComponentModel.ISupportInitialize)(this.chartNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox listNumeros;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnImpar;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumeros;
    }
}

