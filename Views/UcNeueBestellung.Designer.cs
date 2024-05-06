using System.ComponentModel;

namespace ServiceOne.Views
{
  partial class UcNeueBestellung
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panelArtikel = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.Kundendaten = new System.Windows.Forms.GroupBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtBoxEmail = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtBoxVorname = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtBoxKundenID = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtBoxNachname = new System.Windows.Forms.TextBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtBoxOrt = new System.Windows.Forms.TextBox();
      this.btnInsert = new System.Windows.Forms.Button();
      this.txtBoxTelefon = new System.Windows.Forms.TextBox();
      this.txtBoxRabatt = new System.Windows.Forms.TextBox();
      this.txtBoxFirma = new System.Windows.Forms.TextBox();
      this.txtBoxPlz = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.dataGridViewEinkaufswagen = new System.Windows.Forms.DataGridView();
      this.panelArtikel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.Kundendaten.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEinkaufswagen)).BeginInit();
      this.SuspendLayout();
      // 
      // panelArtikel
      // 
      this.panelArtikel.Controls.Add(this.dataGridView);
      this.panelArtikel.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelArtikel.Location = new System.Drawing.Point(0, 0);
      this.panelArtikel.Name = "panelArtikel";
      this.panelArtikel.Size = new System.Drawing.Size(4000, 522);
      this.panelArtikel.TabIndex = 4;
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
      this.dataGridView.TabIndex = 5;
      // 
      // Kundendaten
      // 
      this.Kundendaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.Kundendaten.Controls.Add(this.btnDelete);
      this.Kundendaten.Controls.Add(this.label2);
      this.Kundendaten.Controls.Add(this.label1);
      this.Kundendaten.Controls.Add(this.txtBoxEmail);
      this.Kundendaten.Controls.Add(this.label4);
      this.Kundendaten.Controls.Add(this.btnUpdate);
      this.Kundendaten.Controls.Add(this.txtBoxVorname);
      this.Kundendaten.Controls.Add(this.label9);
      this.Kundendaten.Controls.Add(this.txtBoxKundenID);
      this.Kundendaten.Controls.Add(this.label10);
      this.Kundendaten.Controls.Add(this.txtBoxNachname);
      this.Kundendaten.Controls.Add(this.btnReset);
      this.Kundendaten.Controls.Add(this.label3);
      this.Kundendaten.Controls.Add(this.label7);
      this.Kundendaten.Controls.Add(this.txtBoxOrt);
      this.Kundendaten.Controls.Add(this.btnInsert);
      this.Kundendaten.Controls.Add(this.txtBoxTelefon);
      this.Kundendaten.Controls.Add(this.txtBoxRabatt);
      this.Kundendaten.Controls.Add(this.txtBoxFirma);
      this.Kundendaten.Controls.Add(this.txtBoxPlz);
      this.Kundendaten.Controls.Add(this.label8);
      this.Kundendaten.Controls.Add(this.label11);
      this.Kundendaten.Location = new System.Drawing.Point(10, 600);
      this.Kundendaten.Name = "Kundendaten";
      this.Kundendaten.Size = new System.Drawing.Size(2092, 870);
      this.Kundendaten.TabIndex = 32;
      this.Kundendaten.TabStop = false;
      this.Kundendaten.Text = "Neue Bestellung";
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
      this.label2.Text = "Firma";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(475, 71);
      this.label1.TabIndex = 0;
      this.label1.Text = "KundenID";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtBoxEmail
      // 
      this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxEmail.Location = new System.Drawing.Point(1585, 268);
      this.txtBoxEmail.Name = "txtBoxEmail";
      this.txtBoxEmail.Size = new System.Drawing.Size(436, 71);
      this.txtBoxEmail.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(30, 371);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(475, 71);
      this.label4.TabIndex = 15;
      this.label4.Text = "Nachname";
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
      // txtBoxVorname
      // 
      this.txtBoxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxVorname.Location = new System.Drawing.Point(548, 271);
      this.txtBoxVorname.Name = "txtBoxVorname";
      this.txtBoxVorname.Size = new System.Drawing.Size(436, 71);
      this.txtBoxVorname.TabIndex = 3;
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(1070, 271);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(475, 71);
      this.label9.TabIndex = 25;
      this.label9.Text = "Einzelpreis";
      // 
      // txtBoxKundenID
      // 
      this.txtBoxKundenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxKundenID.Location = new System.Drawing.Point(548, 71);
      this.txtBoxKundenID.Name = "txtBoxKundenID";
      this.txtBoxKundenID.Size = new System.Drawing.Size(436, 71);
      this.txtBoxKundenID.TabIndex = 1;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(1070, 371);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(475, 71);
      this.label10.TabIndex = 27;
      this.label10.Text = "Anzahl";
      // 
      // txtBoxNachname
      // 
      this.txtBoxNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxNachname.Location = new System.Drawing.Point(548, 371);
      this.txtBoxNachname.Name = "txtBoxNachname";
      this.txtBoxNachname.Size = new System.Drawing.Size(436, 71);
      this.txtBoxNachname.TabIndex = 4;
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
      this.label3.Text = "Vorname";
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(1070, 71);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(475, 71);
      this.label7.TabIndex = 21;
      this.label7.Text = "ArtikelID";
      // 
      // txtBoxOrt
      // 
      this.txtBoxOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxOrt.Location = new System.Drawing.Point(1588, 171);
      this.txtBoxOrt.Name = "txtBoxOrt";
      this.txtBoxOrt.Size = new System.Drawing.Size(436, 71);
      this.txtBoxOrt.TabIndex = 7;
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
      // txtBoxTelefon
      // 
      this.txtBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxTelefon.Location = new System.Drawing.Point(1588, 368);
      this.txtBoxTelefon.Name = "txtBoxTelefon";
      this.txtBoxTelefon.Size = new System.Drawing.Size(436, 71);
      this.txtBoxTelefon.TabIndex = 9;
      // 
      // txtBoxRabatt
      // 
      this.txtBoxRabatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxRabatt.Location = new System.Drawing.Point(548, 471);
      this.txtBoxRabatt.Name = "txtBoxRabatt";
      this.txtBoxRabatt.Size = new System.Drawing.Size(436, 71);
      this.txtBoxRabatt.TabIndex = 5;
      // 
      // txtBoxFirma
      // 
      this.txtBoxFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxFirma.Location = new System.Drawing.Point(548, 171);
      this.txtBoxFirma.Name = "txtBoxFirma";
      this.txtBoxFirma.Size = new System.Drawing.Size(436, 71);
      this.txtBoxFirma.TabIndex = 2;
      // 
      // txtBoxPlz
      // 
      this.txtBoxPlz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxPlz.Location = new System.Drawing.Point(1588, 71);
      this.txtBoxPlz.Name = "txtBoxPlz";
      this.txtBoxPlz.Size = new System.Drawing.Size(436, 71);
      this.txtBoxPlz.TabIndex = 6;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(1070, 171);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(475, 71);
      this.label8.TabIndex = 23;
      this.label8.Text = "Artikelname";
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(30, 471);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(475, 71);
      this.label11.TabIndex = 29;
      this.label11.Text = "Rabatt";
      // 
      // dataGridViewEinkaufswagen
      // 
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewEinkaufswagen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridViewEinkaufswagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewEinkaufswagen.DefaultCellStyle = dataGridViewCellStyle5;
      this.dataGridViewEinkaufswagen.Location = new System.Drawing.Point(2290, 625);
      this.dataGridViewEinkaufswagen.Name = "dataGridViewEinkaufswagen";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewEinkaufswagen.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.dataGridViewEinkaufswagen.RowTemplate.Height = 46;
      this.dataGridViewEinkaufswagen.Size = new System.Drawing.Size(1581, 884);
      this.dataGridViewEinkaufswagen.TabIndex = 10;
      // 
      // UcNeueBestellung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.Kundendaten);
      this.Controls.Add(this.dataGridViewEinkaufswagen);
      this.Controls.Add(this.panelArtikel);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "UcNeueBestellung";
      this.Size = new System.Drawing.Size(4000, 1600);
      this.panelArtikel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.Kundendaten.ResumeLayout(false);
      this.Kundendaten.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEinkaufswagen)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridViewEinkaufswagen;

    private System.Windows.Forms.GroupBox Kundendaten;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBoxEmail;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtBoxVorname;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtBoxKundenID;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtBoxNachname;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtBoxOrt;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.TextBox txtBoxTelefon;
    private System.Windows.Forms.TextBox txtBoxRabatt;
    private System.Windows.Forms.TextBox txtBoxFirma;
    private System.Windows.Forms.TextBox txtBoxPlz;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.DataGridView dataGridView;

    private System.Windows.Forms.Panel panelArtikel;

    #endregion
  }
}