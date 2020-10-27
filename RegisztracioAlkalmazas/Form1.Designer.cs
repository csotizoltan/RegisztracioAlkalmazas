namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lblSzulDatum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNem = new System.Windows.Forms.Label();
            this.rdoFerfi = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.lblKHobbi = new System.Windows.Forms.Label();
            this.listHobbi = new System.Windows.Forms.ListBox();
            this.lblUjHobbi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHozzad = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Calibri", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(13, 22);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(45, 26);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(157, 26);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(200, 22);
            this.txtNev.TabIndex = 1;
            // 
            // lblSzulDatum
            // 
            this.lblSzulDatum.AutoSize = true;
            this.lblSzulDatum.Font = new System.Drawing.Font("Calibri", 12.096F);
            this.lblSzulDatum.Location = new System.Drawing.Point(13, 79);
            this.lblSzulDatum.Name = "lblSzulDatum";
            this.lblSzulDatum.Size = new System.Drawing.Size(112, 26);
            this.lblSzulDatum.TabIndex = 2;
            this.lblSzulDatum.Text = "Szül. dátum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Calibri", 12.096F);
            this.lblNem.Location = new System.Drawing.Point(13, 148);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(59, 26);
            this.lblNem.TabIndex = 4;
            this.lblNem.Text = "Nem:";
            // 
            // rdoFerfi
            // 
            this.rdoFerfi.AutoSize = true;
            this.rdoFerfi.Location = new System.Drawing.Point(157, 153);
            this.rdoFerfi.Name = "rdoFerfi";
            this.rdoFerfi.Size = new System.Drawing.Size(55, 20);
            this.rdoFerfi.TabIndex = 5;
            this.rdoFerfi.TabStop = true;
            this.rdoFerfi.Text = "Férfi";
            this.rdoFerfi.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(237, 153);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(47, 20);
            this.rdoNo.TabIndex = 6;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "Nő";
            this.rdoNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // lblKHobbi
            // 
            this.lblKHobbi.AutoSize = true;
            this.lblKHobbi.Font = new System.Drawing.Font("Calibri", 12.096F);
            this.lblKHobbi.Location = new System.Drawing.Point(525, 31);
            this.lblKHobbi.Name = "lblKHobbi";
            this.lblKHobbi.Size = new System.Drawing.Size(137, 26);
            this.lblKHobbi.TabIndex = 7;
            this.lblKHobbi.Text = "Kedvenc hobbi";
            // 
            // listHobbi
            // 
            this.listHobbi.FormattingEnabled = true;
            this.listHobbi.ItemHeight = 16;
            this.listHobbi.Location = new System.Drawing.Point(530, 60);
            this.listHobbi.Name = "listHobbi";
            this.listHobbi.Size = new System.Drawing.Size(120, 148);
            this.listHobbi.TabIndex = 8;
            // 
            // lblUjHobbi
            // 
            this.lblUjHobbi.AutoSize = true;
            this.lblUjHobbi.Font = new System.Drawing.Font("Calibri", 12.096F);
            this.lblUjHobbi.Location = new System.Drawing.Point(404, 233);
            this.lblUjHobbi.Name = "lblUjHobbi";
            this.lblUjHobbi.Size = new System.Drawing.Size(84, 26);
            this.lblUjHobbi.TabIndex = 9;
            this.lblUjHobbi.Text = "Új hobbi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 10;
            // 
            // btnHozzad
            // 
            this.btnHozzad.Location = new System.Drawing.Point(557, 282);
            this.btnHozzad.Name = "btnHozzad";
            this.btnHozzad.Size = new System.Drawing.Size(93, 32);
            this.btnHozzad.TabIndex = 11;
            this.btnHozzad.Text = "Hozzáad";
            this.btnHozzad.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(439, 375);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(95, 40);
            this.btnMentes.TabIndex = 12;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(557, 375);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(95, 40);
            this.btnBetoltes.TabIndex = 13;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnHozzad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUjHobbi);
            this.Controls.Add(this.listHobbi);
            this.Controls.Add(this.lblKHobbi);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoFerfi);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSzulDatum);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.lblNev);
            this.Name = "Form1";
            this.Text = "Regisztració Alkalmazás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblSzulDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.RadioButton rdoFerfi;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.Label lblKHobbi;
        private System.Windows.Forms.ListBox listHobbi;
        private System.Windows.Forms.Label lblUjHobbi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHozzad;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
    }
}

