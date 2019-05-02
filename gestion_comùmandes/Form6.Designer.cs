namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.afficher = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.DataGridView();
            this.dernier = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.premier = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g1)).BeginInit();
            this.SuspendLayout();
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(293, 241);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(112, 40);
            this.afficher.TabIndex = 63;
            this.afficher.Text = "afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // g1
            // 
            this.g1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g1.Location = new System.Drawing.Point(39, 327);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(498, 150);
            this.g1.TabIndex = 62;
            this.g1.SelectionChanged += new System.EventHandler(this.g1_SelectionChanged);
            // 
            // dernier
            // 
            this.dernier.Location = new System.Drawing.Point(208, 279);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(55, 31);
            this.dernier.TabIndex = 56;
            this.dernier.Text = ">>";
            this.dernier.UseVisualStyleBackColor = true;
            this.dernier.Click += new System.EventHandler(this.dernier_Click);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(147, 279);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(55, 31);
            this.suivant.TabIndex = 57;
            this.suivant.Text = ">";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(86, 279);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(55, 31);
            this.precedent.TabIndex = 54;
            this.precedent.Text = "<";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // premier
            // 
            this.premier.Location = new System.Drawing.Point(25, 279);
            this.premier.Name = "premier";
            this.premier.Size = new System.Drawing.Size(55, 31);
            this.premier.TabIndex = 55;
            this.premier.Text = "<<";
            this.premier.UseVisualStyleBackColor = true;
            this.premier.Click += new System.EventHandler(this.premier_Click);
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(293, 204);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(112, 31);
            this.rechercher.TabIndex = 60;
            this.rechercher.Text = "rechercher";
            this.rechercher.UseVisualStyleBackColor = true;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(293, 167);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 31);
            this.supprimer.TabIndex = 61;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(293, 130);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 31);
            this.modifier.TabIndex = 58;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(293, 93);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 31);
            this.ajouter.TabIndex = 59;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // nouveau
            // 
            this.nouveau.Location = new System.Drawing.Point(293, 61);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(112, 31);
            this.nouveau.TabIndex = 53;
            this.nouveau.Text = "nouveau";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(102, 103);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 52;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(102, 71);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "gestion des commandes";
            // 
            // t3
            // 
            this.t3.FormattingEnabled = true;
            this.t3.Location = new System.Drawing.Point(102, 135);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(121, 21);
            this.t3.TabIndex = 64;
            this.t3.SelectedIndexChanged += new System.EventHandler(this.t3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.premier);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.DataGridView g1;
        private System.Windows.Forms.Button dernier;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button premier;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox t3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}