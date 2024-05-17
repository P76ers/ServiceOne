using System.ComponentModel;

namespace ServiceOne.Views
{
  partial class UcKunden
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
      this.grpBox = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txtBoxEmail = new System.Windows.Forms.TextBox();
      this.txtBoxPostleitzahl = new System.Windows.Forms.TextBox();
      this.txtBoxTelefon = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.txtBoxOrt = new System.Windows.Forms.TextBox();
      this.txtBoxRabatt = new System.Windows.Forms.TextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtBoxVorname = new System.Windows.Forms.TextBox();
      this.txtBoxKundenID = new System.Windows.Forms.TextBox();
      this.txtBoxHausnummer = new System.Windows.Forms.TextBox();
      this.txtBoxNachname = new System.Windows.Forms.TextBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnInsert = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBoxFirma = new System.Windows.Forms.TextBox();
      this.txtBoxStrasse = new System.Windows.Forms.TextBox();
      this.panelArtikel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.grpBox.SuspendLayout();
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
      this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
      // 
      // grpBox
      // 
      this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.grpBox.Controls.Add(this.label9);
      this.grpBox.Controls.Add(this.label10);
      this.grpBox.Controls.Add(this.label11);
      this.grpBox.Controls.Add(this.txtBoxEmail);
      this.grpBox.Controls.Add(this.txtBoxPostleitzahl);
      this.grpBox.Controls.Add(this.txtBoxTelefon);
      this.grpBox.Controls.Add(this.label12);
      this.grpBox.Controls.Add(this.label13);
      this.grpBox.Controls.Add(this.txtBoxOrt);
      this.grpBox.Controls.Add(this.txtBoxRabatt);
      this.grpBox.Controls.Add(this.btnDelete);
      this.grpBox.Controls.Add(this.label2);
      this.grpBox.Controls.Add(this.label1);
      this.grpBox.Controls.Add(this.label4);
      this.grpBox.Controls.Add(this.btnUpdate);
      this.grpBox.Controls.Add(this.txtBoxVorname);
      this.grpBox.Controls.Add(this.txtBoxKundenID);
      this.grpBox.Controls.Add(this.txtBoxHausnummer);
      this.grpBox.Controls.Add(this.txtBoxNachname);
      this.grpBox.Controls.Add(this.btnReset);
      this.grpBox.Controls.Add(this.label3);
      this.grpBox.Controls.Add(this.btnInsert);
      this.grpBox.Controls.Add(this.label6);
      this.grpBox.Controls.Add(this.label5);
      this.grpBox.Controls.Add(this.txtBoxFirma);
      this.grpBox.Controls.Add(this.txtBoxStrasse);
      this.grpBox.Location = new System.Drawing.Point(10, 600);
      this.grpBox.Name = "grpBox";
      this.grpBox.Size = new System.Drawing.Size(2092, 870);
      this.grpBox.TabIndex = 32;
      this.grpBox.TabStop = false;
      this.grpBox.Text = "Artikel";
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(1070, 171);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(475, 71);
      this.label9.TabIndex = 29;
      this.label9.Text = "Ort";
      // 
      // label10
      // 
      this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(1070, 71);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(475, 71);
      this.label10.TabIndex = 23;
      this.label10.Text = "Postleitzahl";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(1070, 371);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(475, 71);
      this.label11.TabIndex = 31;
      this.label11.Text = "Telefon";
      // 
      // txtBoxEmail
      // 
      this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxEmail.Location = new System.Drawing.Point(1588, 271);
      this.txtBoxEmail.Name = "txtBoxEmail";
      this.txtBoxEmail.Size = new System.Drawing.Size(436, 71);
      this.txtBoxEmail.TabIndex = 9;
      // 
      // txtBoxPostleitzahl
      // 
      this.txtBoxPostleitzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxPostleitzahl.Location = new System.Drawing.Point(1588, 71);
      this.txtBoxPostleitzahl.Name = "txtBoxPostleitzahl";
      this.txtBoxPostleitzahl.Size = new System.Drawing.Size(436, 71);
      this.txtBoxPostleitzahl.TabIndex = 7;
      // 
      // txtBoxTelefon
      // 
      this.txtBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxTelefon.Location = new System.Drawing.Point(1588, 371);
      this.txtBoxTelefon.Name = "txtBoxTelefon";
      this.txtBoxTelefon.Size = new System.Drawing.Size(436, 71);
      this.txtBoxTelefon.TabIndex = 10;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(1070, 271);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(475, 71);
      this.label12.TabIndex = 30;
      this.label12.Text = "Email";
      // 
      // label13
      // 
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(1070, 471);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(475, 71);
      this.label13.TabIndex = 32;
      this.label13.Text = "Rabatt";
      // 
      // txtBoxOrt
      // 
      this.txtBoxOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxOrt.Location = new System.Drawing.Point(1588, 171);
      this.txtBoxOrt.Name = "txtBoxOrt";
      this.txtBoxOrt.Size = new System.Drawing.Size(436, 71);
      this.txtBoxOrt.TabIndex = 8;
      // 
      // txtBoxRabatt
      // 
      this.txtBoxRabatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxRabatt.Location = new System.Drawing.Point(1588, 471);
      this.txtBoxRabatt.Name = "txtBoxRabatt";
      this.txtBoxRabatt.Size = new System.Drawing.Size(436, 71);
      this.txtBoxRabatt.TabIndex = 11;
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
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // txtBoxVorname
      // 
      this.txtBoxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxVorname.Location = new System.Drawing.Point(548, 271);
      this.txtBoxVorname.Name = "txtBoxVorname";
      this.txtBoxVorname.Size = new System.Drawing.Size(436, 71);
      this.txtBoxVorname.TabIndex = 3;
      // 
      // txtBoxKundenID
      // 
      this.txtBoxKundenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxKundenID.Location = new System.Drawing.Point(548, 71);
      this.txtBoxKundenID.Name = "txtBoxKundenID";
      this.txtBoxKundenID.Size = new System.Drawing.Size(436, 71);
      this.txtBoxKundenID.TabIndex = 1;
      // 
      // txtBoxHausnummer
      // 
      this.txtBoxHausnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxHausnummer.Location = new System.Drawing.Point(548, 571);
      this.txtBoxHausnummer.Name = "txtBoxHausnummer";
      this.txtBoxHausnummer.Size = new System.Drawing.Size(436, 71);
      this.txtBoxHausnummer.TabIndex = 6;
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
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(30, 571);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(475, 71);
      this.label6.TabIndex = 19;
      this.label6.Text = "Hausnummer";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(30, 471);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(475, 71);
      this.label5.TabIndex = 17;
      this.label5.Text = "Strasse";
      // 
      // txtBoxFirma
      // 
      this.txtBoxFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxFirma.Location = new System.Drawing.Point(548, 171);
      this.txtBoxFirma.Name = "txtBoxFirma";
      this.txtBoxFirma.Size = new System.Drawing.Size(436, 71);
      this.txtBoxFirma.TabIndex = 2;
      // 
      // txtBoxStrasse
      // 
      this.txtBoxStrasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxStrasse.Location = new System.Drawing.Point(548, 471);
      this.txtBoxStrasse.Name = "txtBoxStrasse";
      this.txtBoxStrasse.Size = new System.Drawing.Size(436, 71);
      this.txtBoxStrasse.TabIndex = 5;
      // 
      // UcKunden
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.grpBox);
      this.Controls.Add(this.panelArtikel);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "UcKunden";
      this.Size = new System.Drawing.Size(4000, 1600);
      this.panelArtikel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.grpBox.ResumeLayout(false);
      this.grpBox.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtBoxEmail;
    private System.Windows.Forms.TextBox txtBoxPostleitzahl;
    private System.Windows.Forms.TextBox txtBoxTelefon;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtBoxOrt;
    private System.Windows.Forms.TextBox txtBoxRabatt;

    private System.Windows.Forms.GroupBox grpBox;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtBoxVorname;
    private System.Windows.Forms.TextBox txtBoxKundenID;
    private System.Windows.Forms.TextBox txtBoxHausnummer;
    private System.Windows.Forms.TextBox txtBoxNachname;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtBoxFirma;
    private System.Windows.Forms.TextBox txtBoxStrasse;

    private System.Windows.Forms.DataGridView dataGridView;

    private System.Windows.Forms.Panel panelArtikel;

    #endregion
  }
}