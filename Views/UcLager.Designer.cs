using System.ComponentModel;

namespace ServiceOne.Views
{
  partial class UcLager
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.panelArtikel = new System.Windows.Forms.Panel();
      this.txtBoxMindestbestand = new System.Windows.Forms.TextBox();
      this.txtBoxLagerNr = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btnInsert = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.txtBoxBestand = new System.Windows.Forms.TextBox();
      this.txtBoxArtikelNr = new System.Windows.Forms.TextBox();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.LagerNr = new System.Windows.Forms.Label();
      this.btnDelete = new System.Windows.Forms.Button();
      this.Kundendaten = new System.Windows.Forms.GroupBox();
      this.txtBoxLagername = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panelArtikel.SuspendLayout();
      this.Kundendaten.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView
      // 
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(0, 0);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.Height = 46;
      this.dataGridView.Size = new System.Drawing.Size(4000, 522);
      this.dataGridView.TabIndex = 3;
      this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
      // 
      // panelArtikel
      // 
      this.panelArtikel.Controls.Add(this.dataGridView);
      this.panelArtikel.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelArtikel.Location = new System.Drawing.Point(0, 0);
      this.panelArtikel.Name = "panelArtikel";
      this.panelArtikel.Size = new System.Drawing.Size(4000, 522);
      this.panelArtikel.TabIndex = 3;
      // 
      // txtBoxMindestbestand
      // 
      this.txtBoxMindestbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxMindestbestand.Location = new System.Drawing.Point(548, 471);
      this.txtBoxMindestbestand.Name = "txtBoxMindestbestand";
      this.txtBoxMindestbestand.Size = new System.Drawing.Size(436, 71);
      this.txtBoxMindestbestand.TabIndex = 5;
      // 
      // txtBoxLagerNr
      // 
      this.txtBoxLagerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxLagerNr.Location = new System.Drawing.Point(548, 171);
      this.txtBoxLagerNr.Name = "txtBoxLagerNr";
      this.txtBoxLagerNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxLagerNr.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(30, 471);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(475, 71);
      this.label5.TabIndex = 17;
      this.label5.Text = "Mindestbestand";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(30, 274);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(475, 71);
      this.label6.TabIndex = 19;
      this.label6.Text = "ArtikelNr";
      // 
      // btnInsert
      // 
      this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsert.Location = new System.Drawing.Point(548, 738);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(324, 103);
      this.btnInsert.TabIndex = 13;
      this.btnInsert.Text = "INSERT";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(30, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(475, 71);
      this.label3.TabIndex = 13;
      this.label3.Text = "Lagername";
      // 
      // btnReset
      // 
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.Location = new System.Drawing.Point(30, 738);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(324, 103);
      this.btnReset.TabIndex = 12;
      this.btnReset.Text = "RESET";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // txtBoxBestand
      // 
      this.txtBoxBestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxBestand.Location = new System.Drawing.Point(548, 371);
      this.txtBoxBestand.Name = "txtBoxBestand";
      this.txtBoxBestand.Size = new System.Drawing.Size(436, 71);
      this.txtBoxBestand.TabIndex = 4;
      // 
      // txtBoxArtikelNr
      // 
      this.txtBoxArtikelNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxArtikelNr.Location = new System.Drawing.Point(548, 274);
      this.txtBoxArtikelNr.Name = "txtBoxArtikelNr";
      this.txtBoxArtikelNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxArtikelNr.TabIndex = 6;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(1070, 738);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(324, 103);
      this.btnUpdate.TabIndex = 14;
      this.btnUpdate.Text = "UPDATE";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(30, 371);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(475, 71);
      this.label4.TabIndex = 15;
      this.label4.Text = "Bestand";
      // 
      // LagerNr
      // 
      this.LagerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LagerNr.Location = new System.Drawing.Point(30, 171);
      this.LagerNr.Name = "LagerNr";
      this.LagerNr.Size = new System.Drawing.Size(475, 71);
      this.LagerNr.TabIndex = 11;
      this.LagerNr.Text = "LagerNr";
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(1697, 738);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(324, 103);
      this.btnDelete.TabIndex = 15;
      this.btnDelete.Text = "DELETE";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // Kundendaten
      // 
      this.Kundendaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Kundendaten.Controls.Add(this.txtBoxLagername);
      this.Kundendaten.Controls.Add(this.btnDelete);
      this.Kundendaten.Controls.Add(this.LagerNr);
      this.Kundendaten.Controls.Add(this.label4);
      this.Kundendaten.Controls.Add(this.btnUpdate);
      this.Kundendaten.Controls.Add(this.txtBoxArtikelNr);
      this.Kundendaten.Controls.Add(this.txtBoxBestand);
      this.Kundendaten.Controls.Add(this.btnReset);
      this.Kundendaten.Controls.Add(this.label3);
      this.Kundendaten.Controls.Add(this.btnInsert);
      this.Kundendaten.Controls.Add(this.label6);
      this.Kundendaten.Controls.Add(this.label5);
      this.Kundendaten.Controls.Add(this.txtBoxLagerNr);
      this.Kundendaten.Controls.Add(this.txtBoxMindestbestand);
      this.Kundendaten.Location = new System.Drawing.Point(10, 600);
      this.Kundendaten.Name = "Kundendaten";
      this.Kundendaten.Size = new System.Drawing.Size(2092, 870);
      this.Kundendaten.TabIndex = 32;
      this.Kundendaten.TabStop = false;
      this.Kundendaten.Text = "Lager";
      // 
      // txtBoxLagername
      // 
      this.txtBoxLagername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxLagername.Location = new System.Drawing.Point(548, 74);
      this.txtBoxLagername.Name = "txtBoxLagername";
      this.txtBoxLagername.Size = new System.Drawing.Size(436, 71);
      this.txtBoxLagername.TabIndex = 20;
      // 
      // UcLager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.Kundendaten);
      this.Controls.Add(this.panelArtikel);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "UcLager";
      this.Size = new System.Drawing.Size(4000, 1600);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.panelArtikel.ResumeLayout(false);
      this.Kundendaten.ResumeLayout(false);
      this.Kundendaten.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtBoxLagername;

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Panel panelArtikel;
    private System.Windows.Forms.TextBox txtBoxMindestbestand;
    private System.Windows.Forms.TextBox txtBoxLagerNr;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.TextBox txtBoxBestand;
    private System.Windows.Forms.TextBox txtBoxArtikelNr;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label LagerNr;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.GroupBox Kundendaten;

    #endregion
  }
}