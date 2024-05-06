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
      this.panelArtikel = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.Kundendaten = new System.Windows.Forms.GroupBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtBoxTechnikerNr = new System.Windows.Forms.TextBox();
      this.txtBoxLagerID = new System.Windows.Forms.TextBox();
      this.txtBoxArtikelNr = new System.Windows.Forms.TextBox();
      this.txtBoxBestand = new System.Windows.Forms.TextBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnInsert = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBoxLagername = new System.Windows.Forms.TextBox();
      this.txtBoxMindestbestand = new System.Windows.Forms.TextBox();
      this.panelArtikel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.Kundendaten.SuspendLayout();
      this.SuspendLayout();
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
      // dataGridView
      // 
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(0, 0);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.Height = 46;
      this.dataGridView.Size = new System.Drawing.Size(4000, 522);
      this.dataGridView.TabIndex = 3;
      // 
      // Kundendaten
      // 
      this.Kundendaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Kundendaten.Controls.Add(this.btnDelete);
      this.Kundendaten.Controls.Add(this.label2);
      this.Kundendaten.Controls.Add(this.label1);
      this.Kundendaten.Controls.Add(this.label4);
      this.Kundendaten.Controls.Add(this.btnUpdate);
      this.Kundendaten.Controls.Add(this.txtBoxTechnikerNr);
      this.Kundendaten.Controls.Add(this.txtBoxLagerID);
      this.Kundendaten.Controls.Add(this.txtBoxArtikelNr);
      this.Kundendaten.Controls.Add(this.txtBoxBestand);
      this.Kundendaten.Controls.Add(this.btnReset);
      this.Kundendaten.Controls.Add(this.label3);
      this.Kundendaten.Controls.Add(this.btnInsert);
      this.Kundendaten.Controls.Add(this.label6);
      this.Kundendaten.Controls.Add(this.label5);
      this.Kundendaten.Controls.Add(this.txtBoxLagername);
      this.Kundendaten.Controls.Add(this.txtBoxMindestbestand);
      this.Kundendaten.Location = new System.Drawing.Point(10, 600);
      this.Kundendaten.Name = "Kundendaten";
      this.Kundendaten.Size = new System.Drawing.Size(2092, 870);
      this.Kundendaten.TabIndex = 32;
      this.Kundendaten.TabStop = false;
      this.Kundendaten.Text = "Lager";
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
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(30, 171);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(475, 71);
      this.label2.TabIndex = 11;
      this.label2.Text = "Lagername";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(475, 71);
      this.label1.TabIndex = 0;
      this.label1.Text = "LagerID";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(1070, 738);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(324, 103);
      this.btnUpdate.TabIndex = 14;
      this.btnUpdate.Text = "UPDATE";
      this.btnUpdate.UseVisualStyleBackColor = true;
      // 
      // txtBoxTechnikerNr
      // 
      this.txtBoxTechnikerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxTechnikerNr.Location = new System.Drawing.Point(548, 271);
      this.txtBoxTechnikerNr.Name = "txtBoxTechnikerNr";
      this.txtBoxTechnikerNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxTechnikerNr.TabIndex = 3;
      // 
      // txtBoxLagerID
      // 
      this.txtBoxLagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxLagerID.Location = new System.Drawing.Point(548, 71);
      this.txtBoxLagerID.Name = "txtBoxLagerID";
      this.txtBoxLagerID.Size = new System.Drawing.Size(436, 71);
      this.txtBoxLagerID.TabIndex = 1;
      // 
      // txtBoxArtikelNr
      // 
      this.txtBoxArtikelNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxArtikelNr.Location = new System.Drawing.Point(548, 571);
      this.txtBoxArtikelNr.Name = "txtBoxArtikelNr";
      this.txtBoxArtikelNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxArtikelNr.TabIndex = 6;
      // 
      // txtBoxBestand
      // 
      this.txtBoxBestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxBestand.Location = new System.Drawing.Point(548, 371);
      this.txtBoxBestand.Name = "txtBoxBestand";
      this.txtBoxBestand.Size = new System.Drawing.Size(436, 71);
      this.txtBoxBestand.TabIndex = 4;
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
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(30, 271);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(475, 71);
      this.label3.TabIndex = 13;
      this.label3.Text = "TechnikerNr";
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
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(30, 571);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(475, 71);
      this.label6.TabIndex = 19;
      this.label6.Text = "ArtikelNr";
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
      // txtBoxLagername
      // 
      this.txtBoxLagername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxLagername.Location = new System.Drawing.Point(548, 171);
      this.txtBoxLagername.Name = "txtBoxLagername";
      this.txtBoxLagername.Size = new System.Drawing.Size(436, 71);
      this.txtBoxLagername.TabIndex = 2;
      // 
      // txtBoxMindestbestand
      // 
      this.txtBoxMindestbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxMindestbestand.Location = new System.Drawing.Point(548, 471);
      this.txtBoxMindestbestand.Name = "txtBoxMindestbestand";
      this.txtBoxMindestbestand.Size = new System.Drawing.Size(436, 71);
      this.txtBoxMindestbestand.TabIndex = 5;
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
      this.panelArtikel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.Kundendaten.ResumeLayout(false);
      this.Kundendaten.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox Kundendaten;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtBoxTechnikerNr;
    private System.Windows.Forms.TextBox txtBoxLagerID;
    private System.Windows.Forms.TextBox txtBoxArtikelNr;
    private System.Windows.Forms.TextBox txtBoxBestand;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtBoxLagername;
    private System.Windows.Forms.TextBox txtBoxMindestbestand;

    private System.Windows.Forms.DataGridView dataGridView;

    private System.Windows.Forms.Panel panelArtikel;

    #endregion
  }
}