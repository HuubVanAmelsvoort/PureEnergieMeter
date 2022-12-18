namespace PureEnergieMeter {
  partial class HoofdScherm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoofdScherm));
      this.buttonOpvragenGegevens = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxBatch = new System.Windows.Forms.TextBox();
      this.labelModel = new System.Windows.Forms.Label();
      this.textBoxModel = new System.Windows.Forms.TextBox();
      this.textBoxHardwareVersie = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxLeverancier = new System.Windows.Forms.TextBox();
      this.textBoxSoftwareVersie = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxId = new System.Windows.Forms.TextBox();
      this.labelGebruikMomenteel = new System.Windows.Forms.Label();
      this.textBoxGebruikMomenteel = new System.Windows.Forms.TextBox();
      this.buttonContinue = new System.Windows.Forms.Button();
      this.Kwh = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.buttonStop = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Kwh)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonOpvragenGegevens
      // 
      this.buttonOpvragenGegevens.Location = new System.Drawing.Point(28, 326);
      this.buttonOpvragenGegevens.Name = "buttonOpvragenGegevens";
      this.buttonOpvragenGegevens.Size = new System.Drawing.Size(250, 39);
      this.buttonOpvragenGegevens.TabIndex = 0;
      this.buttonOpvragenGegevens.Text = "Vraag de gegevens op";
      this.buttonOpvragenGegevens.UseVisualStyleBackColor = true;
      this.buttonOpvragenGegevens.Click += new System.EventHandler(this.buttonOpvragenGegevens_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.textBoxBatch);
      this.panel1.Controls.Add(this.labelModel);
      this.panel1.Controls.Add(this.textBoxModel);
      this.panel1.Controls.Add(this.textBoxHardwareVersie);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.textBoxLeverancier);
      this.panel1.Controls.Add(this.textBoxSoftwareVersie);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.textBoxId);
      this.panel1.Location = new System.Drawing.Point(28, 28);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(456, 257);
      this.panel1.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(9, 133);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(138, 23);
      this.label5.TabIndex = 21;
      this.label5.Text = "Fabriek batch :";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBoxBatch
      // 
      this.textBoxBatch.Location = new System.Drawing.Point(166, 133);
      this.textBoxBatch.Name = "textBoxBatch";
      this.textBoxBatch.ReadOnly = true;
      this.textBoxBatch.Size = new System.Drawing.Size(235, 22);
      this.textBoxBatch.TabIndex = 22;
      // 
      // labelModel
      // 
      this.labelModel.Location = new System.Drawing.Point(9, 101);
      this.labelModel.Name = "labelModel";
      this.labelModel.Size = new System.Drawing.Size(138, 23);
      this.labelModel.TabIndex = 19;
      this.labelModel.Text = "Het model :";
      this.labelModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBoxModel
      // 
      this.textBoxModel.Location = new System.Drawing.Point(166, 101);
      this.textBoxModel.Name = "textBoxModel";
      this.textBoxModel.ReadOnly = true;
      this.textBoxModel.Size = new System.Drawing.Size(235, 22);
      this.textBoxModel.TabIndex = 20;
      // 
      // textBoxHardwareVersie
      // 
      this.textBoxHardwareVersie.Location = new System.Drawing.Point(166, 206);
      this.textBoxHardwareVersie.Name = "textBoxHardwareVersie";
      this.textBoxHardwareVersie.ReadOnly = true;
      this.textBoxHardwareVersie.Size = new System.Drawing.Size(235, 22);
      this.textBoxHardwareVersie.TabIndex = 18;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(9, 205);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(138, 23);
      this.label4.TabIndex = 17;
      this.label4.Text = "Hardware versie  :";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBoxLeverancier
      // 
      this.textBoxLeverancier.Location = new System.Drawing.Point(166, 65);
      this.textBoxLeverancier.Name = "textBoxLeverancier";
      this.textBoxLeverancier.ReadOnly = true;
      this.textBoxLeverancier.Size = new System.Drawing.Size(235, 22);
      this.textBoxLeverancier.TabIndex = 12;
      // 
      // textBoxSoftwareVersie
      // 
      this.textBoxSoftwareVersie.Location = new System.Drawing.Point(166, 171);
      this.textBoxSoftwareVersie.Name = "textBoxSoftwareVersie";
      this.textBoxSoftwareVersie.ReadOnly = true;
      this.textBoxSoftwareVersie.Size = new System.Drawing.Size(235, 22);
      this.textBoxSoftwareVersie.TabIndex = 16;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(9, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(138, 23);
      this.label3.TabIndex = 15;
      this.label3.Text = "Software versie  :";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(9, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(138, 23);
      this.label2.TabIndex = 13;
      this.label2.Text = "Unieke identificatie : ";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(9, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(138, 23);
      this.label1.TabIndex = 11;
      this.label1.Text = "Leverancier :";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBoxId
      // 
      this.textBoxId.Location = new System.Drawing.Point(166, 29);
      this.textBoxId.Name = "textBoxId";
      this.textBoxId.ReadOnly = true;
      this.textBoxId.Size = new System.Drawing.Size(235, 22);
      this.textBoxId.TabIndex = 14;
      // 
      // labelGebruikMomenteel
      // 
      this.labelGebruikMomenteel.Location = new System.Drawing.Point(346, 309);
      this.labelGebruikMomenteel.Name = "labelGebruikMomenteel";
      this.labelGebruikMomenteel.Size = new System.Drawing.Size(138, 23);
      this.labelGebruikMomenteel.TabIndex = 23;
      this.labelGebruikMomenteel.Text = "Gebruik momenteel : ";
      this.labelGebruikMomenteel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // textBoxGebruikMomenteel
      // 
      this.textBoxGebruikMomenteel.Location = new System.Drawing.Point(349, 335);
      this.textBoxGebruikMomenteel.Name = "textBoxGebruikMomenteel";
      this.textBoxGebruikMomenteel.ReadOnly = true;
      this.textBoxGebruikMomenteel.Size = new System.Drawing.Size(134, 22);
      this.textBoxGebruikMomenteel.TabIndex = 24;
      // 
      // buttonContinue
      // 
      this.buttonContinue.Location = new System.Drawing.Point(28, 375);
      this.buttonContinue.Name = "buttonContinue";
      this.buttonContinue.Size = new System.Drawing.Size(102, 39);
      this.buttonContinue.TabIndex = 25;
      this.buttonContinue.Text = "Continu";
      this.buttonContinue.UseVisualStyleBackColor = true;
      this.buttonContinue.Click += new System.EventHandler(this.buttonContinu_Click);
      // 
      // Kwh
      // 
      chartArea1.Name = "ChartArea1";
      this.Kwh.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.Kwh.Legends.Add(legend1);
      this.Kwh.Location = new System.Drawing.Point(527, 28);
      this.Kwh.Name = "Kwh";
      series1.BackImage = "D:\\huub\\data\\Downloads\\PE.png";
      series1.BorderColor = System.Drawing.Color.Cyan;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Legend = "Legend1";
      series1.Name = "Kwh";
      series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.Kwh.Series.Add(series1);
      this.Kwh.Size = new System.Drawing.Size(656, 329);
      this.Kwh.TabIndex = 26;
      this.Kwh.Text = "grafiek";
      // 
      // buttonStop
      // 
      this.buttonStop.Location = new System.Drawing.Point(176, 375);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(102, 39);
      this.buttonStop.TabIndex = 27;
      this.buttonStop.Text = "Stop continu";
      this.buttonStop.UseVisualStyleBackColor = true;
      this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // HoofdScherm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1218, 426);
      this.Controls.Add(this.buttonStop);
      this.Controls.Add(this.Kwh);
      this.Controls.Add(this.buttonContinue);
      this.Controls.Add(this.labelGebruikMomenteel);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBoxGebruikMomenteel);
      this.Controls.Add(this.buttonOpvragenGegevens);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "HoofdScherm";
      this.Text = "Pure Energie Meter versie 0.1 (Huub van Amelsvoort)";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Kwh)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button buttonOpvragenGegevens;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.TextBox textBoxLeverancier;
        protected internal System.Windows.Forms.TextBox textBoxSoftwareVersie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox textBoxBatch;
        private System.Windows.Forms.Label labelModel;
        protected internal System.Windows.Forms.TextBox textBoxModel;
        protected internal System.Windows.Forms.TextBox textBoxHardwareVersie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGebruikMomenteel;
        protected internal System.Windows.Forms.TextBox textBoxGebruikMomenteel;
        protected internal System.Windows.Forms.DataVisualization.Charting.Chart Kwh;
        public System.Windows.Forms.Button buttonContinue;
        public System.Windows.Forms.Button buttonStop;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

