using System.ComponentModel;

namespace ServiceOne.Views
{
  partial class UcArtikel
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
      this.txtBoxRichBeschreibung = new System.Windows.Forms.RichTextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtBoxArtikelname = new System.Windows.Forms.TextBox();
      this.txtBoxArtikelID = new System.Windows.Forms.TextBox();
      this.txtBoxBild = new System.Windows.Forms.TextBox();
      this.txtBoxEinzelpreis = new System.Windows.Forms.TextBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.btnInsert = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBoxMaterialNr = new System.Windows.Forms.TextBox();
      this.txtBoxKategorieNr = new System.Windows.Forms.TextBox();
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
      this.grpBox.Controls.Add(this.txtBoxRichBeschreibung);
      this.grpBox.Controls.Add(this.btnDelete);
      this.grpBox.Controls.Add(this.label2);
      this.grpBox.Controls.Add(this.label1);
      this.grpBox.Controls.Add(this.label4);
      this.grpBox.Controls.Add(this.btnUpdate);
      this.grpBox.Controls.Add(this.txtBoxArtikelname);
      this.grpBox.Controls.Add(this.txtBoxArtikelID);
      this.grpBox.Controls.Add(this.txtBoxBild);
      this.grpBox.Controls.Add(this.txtBoxEinzelpreis);
      this.grpBox.Controls.Add(this.btnReset);
      this.grpBox.Controls.Add(this.label3);
      this.grpBox.Controls.Add(this.label7);
      this.grpBox.Controls.Add(this.btnInsert);
      this.grpBox.Controls.Add(this.label6);
      this.grpBox.Controls.Add(this.label5);
      this.grpBox.Controls.Add(this.txtBoxMaterialNr);
      this.grpBox.Controls.Add(this.txtBoxKategorieNr);
      this.grpBox.Location = new System.Drawing.Point(10, 600);
      this.grpBox.Name = "grpBox";
      this.grpBox.Size = new System.Drawing.Size(2092, 870);
      this.grpBox.TabIndex = 32;
      this.grpBox.TabStop = false;
      this.grpBox.Text = "Artikel";
      // 
      // txtBoxRichBeschreibung
      // 
      this.txtBoxRichBeschreibung.Location = new System.Drawing.Point(1588, 71);
      this.txtBoxRichBeschreibung.Name = "txtBoxRichBeschreibung";
      this.txtBoxRichBeschreibung.Size = new System.Drawing.Size(436, 571);
      this.txtBoxRichBeschreibung.TabIndex = 7;
      this.txtBoxRichBeschreibung.Text = "";
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
      this.label2.Text = "MaterialNr";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(475, 71);
      this.label1.TabIndex = 0;
      this.label1.Text = "ArtikelID";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(30, 371);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(475, 71);
      this.label4.TabIndex = 15;
      this.label4.Text = "Einzelpreis";
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
      // txtBoxArtikelname
      // 
      this.txtBoxArtikelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxArtikelname.Location = new System.Drawing.Point(548, 271);
      this.txtBoxArtikelname.Name = "txtBoxArtikelname";
      this.txtBoxArtikelname.Size = new System.Drawing.Size(436, 71);
      this.txtBoxArtikelname.TabIndex = 3;
      // 
      // txtBoxArtikelID
      // 
      this.txtBoxArtikelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxArtikelID.Location = new System.Drawing.Point(548, 71);
      this.txtBoxArtikelID.Name = "txtBoxArtikelID";
      this.txtBoxArtikelID.Size = new System.Drawing.Size(436, 71);
      this.txtBoxArtikelID.TabIndex = 1;
      // 
      // txtBoxBild
      // 
      this.txtBoxBild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxBild.Location = new System.Drawing.Point(548, 571);
      this.txtBoxBild.Name = "txtBoxBild";
      this.txtBoxBild.Size = new System.Drawing.Size(436, 71);
      this.txtBoxBild.TabIndex = 6;
      // 
      // txtBoxEinzelpreis
      // 
      this.txtBoxEinzelpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxEinzelpreis.Location = new System.Drawing.Point(548, 371);
      this.txtBoxEinzelpreis.Name = "txtBoxEinzelpreis";
      this.txtBoxEinzelpreis.Size = new System.Drawing.Size(436, 71);
      this.txtBoxEinzelpreis.TabIndex = 4;
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
      this.label3.Text = "Artikelname";
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(1070, 71);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(475, 71);
      this.label7.TabIndex = 21;
      this.label7.Text = "Beschreibung";
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
      this.label6.Text = "Bild";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(30, 471);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(475, 71);
      this.label5.TabIndex = 17;
      this.label5.Text = "KategorieNr";
      // 
      // txtBoxMaterialNr
      // 
      this.txtBoxMaterialNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxMaterialNr.Location = new System.Drawing.Point(548, 171);
      this.txtBoxMaterialNr.Name = "txtBoxMaterialNr";
      this.txtBoxMaterialNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxMaterialNr.TabIndex = 2;
      // 
      // txtBoxKategorieNr
      // 
      this.txtBoxKategorieNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxKategorieNr.Location = new System.Drawing.Point(548, 471);
      this.txtBoxKategorieNr.Name = "txtBoxKategorieNr";
      this.txtBoxKategorieNr.Size = new System.Drawing.Size(436, 71);
      this.txtBoxKategorieNr.TabIndex = 5;
      // 
      // UcArtikel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.grpBox);
      this.Controls.Add(this.panelArtikel);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "UcArtikel";
      this.Size = new System.Drawing.Size(4000, 1600);
      this.panelArtikel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.grpBox.ResumeLayout(false);
      this.grpBox.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox txtBoxRichBeschreibung;

    private System.Windows.Forms.GroupBox grpBox;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtBoxArtikelname;
    private System.Windows.Forms.TextBox txtBoxArtikelID;
    private System.Windows.Forms.TextBox txtBoxBild;
    private System.Windows.Forms.TextBox txtBoxEinzelpreis;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtBoxMaterialNr;
    private System.Windows.Forms.TextBox txtBoxKategorieNr;

    private System.Windows.Forms.DataGridView dataGridView;

    private System.Windows.Forms.Panel panelArtikel;

    #endregion
  }
}