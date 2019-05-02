namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.g1 = new System.Windows.Forms.DataGridView();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g1)).BeginInit();
            this.SuspendLayout();
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(139, 53);
            this.t2.Name = "t2";
            this.t2.ReadOnly = true;
            this.t2.Size = new System.Drawing.Size(100, 26);
            this.t2.TabIndex = 6;
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(139, 12);
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Size = new System.Drawing.Size(100, 26);
            this.t1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comande N° ";
            // 
            // t4
            // 
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.Location = new System.Drawing.Point(462, 97);
            this.t4.Name = "t4";
            this.t4.ReadOnly = true;
            this.t4.Size = new System.Drawing.Size(100, 26);
            this.t4.TabIndex = 12;
            // 
            // t3
            // 
            this.t3.AcceptsReturn = true;
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.Location = new System.Drawing.Point(462, 53);
            this.t3.Name = "t3";
            this.t3.ReadOnly = true;
            this.t3.Size = new System.Drawing.Size(100, 26);
            this.t3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "quantité en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "accessoire";
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.FormattingEnabled = true;
            this.c1.Location = new System.Drawing.Point(466, 12);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 28);
            this.c1.TabIndex = 8;
            this.c1.SelectedIndexChanged += new System.EventHandler(this.c1_SelectedIndexChanged);
            // 
            // t5
            // 
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.Location = new System.Drawing.Point(462, 138);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 26);
            this.t5.TabIndex = 15;
            this.t5.TextChanged += new System.EventHandler(this.t5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "quantité commandé";
            // 
            // g1
            // 
            this.g1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g1.Location = new System.Drawing.Point(24, 312);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(563, 150);
            this.g1.TabIndex = 16;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(450, 184);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 31);
            this.ajouter.TabIndex = 17;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(450, 231);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 31);
            this.supprimer.TabIndex = 24;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 510);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox t2;
        public System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.DataGridView g1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
    }
}