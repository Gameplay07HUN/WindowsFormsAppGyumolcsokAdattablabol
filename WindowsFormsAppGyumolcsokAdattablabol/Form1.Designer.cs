namespace WindowsFormsAppGyumolcsokAdattablabol
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
            this.dataGridViewGyumolcsok = new System.Windows.Forms.DataGridView();
            this.groupBoxGyumolcs = new System.Windows.Forms.GroupBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonUj = new System.Windows.Forms.Button();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEgysegar = new System.Windows.Forms.NumericUpDown();
            this.textBoxGyumolcsnev = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGyumolcsok)).BeginInit();
            this.groupBoxGyumolcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGyumolcsok
            // 
            this.dataGridViewGyumolcsok.AllowUserToDeleteRows = false;
            this.dataGridViewGyumolcsok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGyumolcsok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewGyumolcsok.Location = new System.Drawing.Point(0, 103);
            this.dataGridViewGyumolcsok.Name = "dataGridViewGyumolcsok";
            this.dataGridViewGyumolcsok.ReadOnly = true;
            this.dataGridViewGyumolcsok.Size = new System.Drawing.Size(800, 347);
            this.dataGridViewGyumolcsok.TabIndex = 0;
            this.dataGridViewGyumolcsok.SelectionChanged += new System.EventHandler(this.dataGridViewGyumolcsok_SelectionChanged);
            // 
            // groupBoxGyumolcs
            // 
            this.groupBoxGyumolcs.Controls.Add(this.buttonTorles);
            this.groupBoxGyumolcs.Controls.Add(this.buttonModosit);
            this.groupBoxGyumolcs.Controls.Add(this.buttonUj);
            this.groupBoxGyumolcs.Controls.Add(this.numericUpDownMennyiseg);
            this.groupBoxGyumolcs.Controls.Add(this.numericUpDownEgysegar);
            this.groupBoxGyumolcs.Controls.Add(this.textBoxGyumolcsnev);
            this.groupBoxGyumolcs.Controls.Add(this.textBoxId);
            this.groupBoxGyumolcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGyumolcs.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGyumolcs.Name = "groupBoxGyumolcs";
            this.groupBoxGyumolcs.Size = new System.Drawing.Size(800, 103);
            this.groupBoxGyumolcs.TabIndex = 1;
            this.groupBoxGyumolcs.TabStop = false;
            this.groupBoxGyumolcs.Text = "Kiválasztott gyümölcs adatai";
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(433, 74);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 6;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(267, 74);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 5;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            // 
            // buttonUj
            // 
            this.buttonUj.Location = new System.Drawing.Point(80, 74);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(75, 23);
            this.buttonUj.TabIndex = 4;
            this.buttonUj.Text = "Új gyümölcs";
            this.buttonUj.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(624, 30);
            this.numericUpDownMennyiseg.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMennyiseg.TabIndex = 3;
            // 
            // numericUpDownEgysegar
            // 
            this.numericUpDownEgysegar.Location = new System.Drawing.Point(433, 31);
            this.numericUpDownEgysegar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownEgysegar.Name = "numericUpDownEgysegar";
            this.numericUpDownEgysegar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEgysegar.TabIndex = 2;
            // 
            // textBoxGyumolcsnev
            // 
            this.textBoxGyumolcsnev.Location = new System.Drawing.Point(174, 31);
            this.textBoxGyumolcsnev.Name = "textBoxGyumolcsnev";
            this.textBoxGyumolcsnev.Size = new System.Drawing.Size(168, 20);
            this.textBoxGyumolcsnev.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 30);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(143, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxGyumolcs);
            this.Controls.Add(this.dataGridViewGyumolcsok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGyumolcsok)).EndInit();
            this.groupBoxGyumolcs.ResumeLayout(false);
            this.groupBoxGyumolcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGyumolcsok;
        private System.Windows.Forms.GroupBox groupBoxGyumolcs;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDownEgysegar;
        private System.Windows.Forms.TextBox textBoxGyumolcsnev;
        private System.Windows.Forms.TextBox textBoxId;
    }
}

