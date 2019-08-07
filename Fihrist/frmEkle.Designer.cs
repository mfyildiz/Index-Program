namespace Fihrist
{
    partial class frmEkle
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
            this.lblad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblbirim = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.txtbirim = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(13, 13);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(78, 17);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Ad-Soyad";
            this.lblad.UseWaitCursor = true;
            // 
            // txtad
            // 
            this.txtad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtad.Location = new System.Drawing.Point(13, 46);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(155, 20);
            this.txtad.TabIndex = 1;
            this.txtad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtad_KeyPress);
            // 
            // lblbirim
            // 
            this.lblbirim.AutoSize = true;
            this.lblbirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbirim.Location = new System.Drawing.Point(13, 79);
            this.lblbirim.Name = "lblbirim";
            this.lblbirim.Size = new System.Drawing.Size(44, 17);
            this.lblbirim.TabIndex = 2;
            this.lblbirim.Text = "Birim";
            this.lblbirim.UseWaitCursor = true;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Location = new System.Drawing.Point(13, 144);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(63, 17);
            this.lbltel.TabIndex = 3;
            this.lbltel.Text = "Telefon";
            this.lbltel.UseWaitCursor = true;
            // 
            // txtbirim
            // 
            this.txtbirim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbirim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbirim.Location = new System.Drawing.Point(13, 109);
            this.txtbirim.Name = "txtbirim";
            this.txtbirim.Size = new System.Drawing.Size(155, 20);
            this.txtbirim.TabIndex = 4;
            this.txtbirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbirim_KeyPress);
            // 
            // txttel
            // 
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.Location = new System.Drawing.Point(13, 170);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(155, 20);
            this.txttel.TabIndex = 5;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(53, 207);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // frmEkle
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(184, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtbirim);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblbirim);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblbirim;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txtbirim;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btnekle;
    }
}