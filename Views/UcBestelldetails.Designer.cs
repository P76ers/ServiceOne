using System.ComponentModel;

namespace ServiceOne.Views
{
  partial class UcBestelldetails
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panelArtikel = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.Kundendaten = new System.Windows.Forms.GroupBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtBoxArtikelNr = new System.Windows.Forms.TextBox();
      this.txtBoxBestellNr = new System.Windows.Forms.TextBox();
      this.txtBoxAnzahl = new System.Windows.Forms.TextBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnInsert = new System.Windows.Forms.Button();
      this.txtBoxTechnikerNr = new System.Windows.Forms.TextBox();
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
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(0, 0);
      this.dataGridView.Name = "dataGridView";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView.RowTemplate.Height = 46;
      this.dataGridView.Size = new System.Drawing.Size(4000, 522);
      this.dataGridView.TabIndex = 3;
      this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
      // 
      // Kundendaten
      // 
      this.Kundendaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Kundendaten.Controls.Add(this.btnDelete);
      this.Kundendaten.Controls.Add(this.label2);
      this.Kundendaten.Controls.Add(this.label1);
      this.Kundendaten.Controls.Add(this.label4);
      this.Kundendaten.Controls.Add(this.btnUpdate);
      this.Kundendaten.Controls.Add(this.txtBoxArtikelNr);
      this.Kundendaten.Controls.Add(this.txtBoxBestellNr);
      this.Kundendaten.Controls.Add(this.txtBoxAnzahl);
      this.Kundendaten.Controls.Add(this.btnReset);
      this.Kundendaten.Controls.Add(this.label3);
      this.Kundendaten.Controls.Add(this.btnInsert);
      this.Kundendaten.Controls.Add(this.txtBoxTechnikerNr);
      this.Kundendaten.Location = new System.Drawing.Point(10, 600);
      this.Kundendaten.Name = "Kundendaten";
      this.Kundendaten.Size = new System.Drawing.Size(2092, 870);
      this.Kundendaten.TabIndex = 32;
      this.Kundendaten.TabStop = false;
      this.Kundendaten.Text = "Bestelldetails";
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
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(30, 171);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(475, 71);
      this.label2.TabIndex = 11;
      this.label2.Text = "TechnikerNr";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(475, 71);
      this.label1.TabIndex = 0;
      this.label1.Text = "BestellNr";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(30, 371);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(475, 71);
      this.label4.TabIndex = 15;
      this.label4.Text = "Anzahl";
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
      // txtBoxArtikelNr
      // 
      this.txtBoxArtikelNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxArtikelNr.Location = new System.Drawing.Point(548, 271);
      this.txtBoxArtikelNr.Name = "txtBoxArtikelNr";
      this.txtBoxArtikelNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxArtikelNr.TabIndex = 3;
      // 
      // txtBoxBestellNr
      // 
      this.txtBoxBestellNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxBestellNr.Location = new System.Drawing.Point(548, 71);
      this.txtBoxBestellNr.Name = "txtBoxBestellNr";
      this.txtBoxBestellNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxBestellNr.TabIndex = 1;
      // 
      // txtBoxAnzahl
      // 
      this.txtBoxAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxAnzahl.Location = new System.Drawing.Point(548, 371);
      this.txtBoxAnzahl.Name = "txtBoxAnzahl";
      this.txtBoxAnzahl.Size = new System.Drawing.Size(436, 71);
      this.txtBoxAnzahl.TabIndex = 4;
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
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(30, 271);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(475, 71);
      this.label3.TabIndex = 13;
      this.label3.Text = "ArtikelNr";
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
      // txtBoxTechnikerNr
      // 
      this.txtBoxTechnikerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxTechnikerNr.Location = new System.Drawing.Point(548, 171);
      this.txtBoxTechnikerNr.Name = "txtBoxTechnikerNr";
      this.txtBoxTechnikerNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxTechnikerNr.TabIndex = 2;
      // 
      // UcBestelldetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.Kundendaten);
      this.Controls.Add(this.panelArtikel);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "UcBestelldetails";
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
    private System.Windows.Forms.TextBox txtBoxArtikelNr;
    private System.Windows.Forms.TextBox txtBoxBestellNr;
    private System.Windows.Forms.TextBox txtBoxAnzahl;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.TextBox txtBoxTechnikerNr;

    private System.Windows.Forms.DataGridView dataGridView;

    private System.Windows.Forms.Panel panelArtikel;

    #endregion
  }
}