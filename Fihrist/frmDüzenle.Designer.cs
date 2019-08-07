namespace Fihrist
{
    partial class frmDüzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbladg = new System.Windows.Forms.Label();
            this.lblbirimg = new System.Windows.Forms.Label();
            this.lbltelg = new System.Windows.Forms.Label();
            this.txtAdg = new System.Windows.Forms.TextBox();
            this.txtBirimG = new System.Windows.Forms.TextBox();
            this.txttelG = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbladg
            // 
            this.lbladg.AutoSize = true;
            this.lbladg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladg.Location = new System.Drawing.Point(13, 13);
            this.lbladg.Name = "lbladg";
            this.lbladg.Size = new System.Drawing.Size(78, 17);
            this.lbladg.TabIndex = 1;
            this.lbladg.Text = "Ad-Soyad";
            // 
            // lblbirimg
            // 
            this.lblbirimg.AutoSize = true;
            this.lblbirimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbirimg.Location = new System.Drawing.Point(13, 79);
            this.lblbirimg.Name = "lblbirimg";
            this.lblbirimg.Size = new System.Drawing.Size(44, 17);
            this.lblbirimg.TabIndex = 3;
            this.lblbirimg.Text = "Birim";
            // 
            // lbltelg
            // 
            this.lbltelg.AutoSize = true;
            this.lbltelg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelg.Location = new System.Drawing.Point(13, 144);
            this.lbltelg.Name = "lbltelg";
            this.lbltelg.Size = new System.Drawing.Size(63, 17);
            this.lbltelg.TabIndex = 4;
            this.lbltelg.Text = "Telefon";
            // 
            // txtAdg
            // 
            this.txtAdg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdg.Location = new System.Drawing.Point(13, 46);
            this.txtAdg.Name = "txtAdg";
            this.txtAdg.Size = new System.Drawing.Size(155, 20);
            this.txtAdg.TabIndex = 5;
            this.txtAdg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdg_KeyPress);
            // 
            // txtBirimG
            // 
            this.txtBirimG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBirimG.Location = new System.Drawing.Point(13, 109);
            this.txtBirimG.Name = "txtBirimG";
            this.txtBirimG.Size = new System.Drawing.Size(155, 20);
            this.txtBirimG.TabIndex = 6;
            this.txtBirimG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimG_KeyPress);
            // 
            // txttelG
            // 
            this.txttelG.BackColor = System.Drawing.SystemColors.Window;
            this.txttelG.Location = new System.Drawing.Point(13, 170);
            this.txttelG.Name = "txttelG";
            this.txttelG.Size = new System.Drawing.Size(155, 20);
            this.txttelG.TabIndex = 7;
            this.txttelG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelG_KeyPress);
            // 
            // btnguncelle
            // 
            this.btnguncelle.AutoSize = true;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(39, 206);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(100, 27);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // frmDuzenle
            // 
            this.AcceptButton = this.btnguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(184, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txttelG);
            this.Controls.Add(this.txtBirimG);
            this.Controls.Add(this.txtAdg);
            this.Controls.Add(this.lbltelg);
            this.Controls.Add(this.lblbirimg);
            this.Controls.Add(this.lbladg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladg;
        private System.Windows.Forms.Label lblbirimg;
        private System.Windows.Forms.Label lbltelg;
        private System.Windows.Forms.TextBox txtAdg;
        private System.Windows.Forms.TextBox txtBirimG;
        private System.Windows.Forms.TextBox txttelG;
        private System.Windows.Forms.Button btnguncelle;
    }
}