namespace ex1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_bonjour = new System.Windows.Forms.Button();
            this.txt_nom_prenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomprenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_bonjour
            // 
            this.btn_bonjour.Location = new System.Drawing.Point(253, 198);
            this.btn_bonjour.Name = "btn_bonjour";
            this.btn_bonjour.Size = new System.Drawing.Size(75, 23);
            this.btn_bonjour.TabIndex = 0;
            this.btn_bonjour.Text = "Bonjour";
            this.btn_bonjour.UseVisualStyleBackColor = true;
            this.btn_bonjour.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nom_prenom
            // 
            this.txt_nom_prenom.AutoSize = true;
            this.txt_nom_prenom.Location = new System.Drawing.Point(250, 96);
            this.txt_nom_prenom.Name = "txt_nom_prenom";
            this.txt_nom_prenom.Size = new System.Drawing.Size(103, 17);
            this.txt_nom_prenom.TabIndex = 1;
            this.txt_nom_prenom.Text = "nom et prenom";
            this.txt_nom_prenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txt_nomprenom
            // 
            this.txt_nomprenom.Location = new System.Drawing.Point(253, 131);
            this.txt_nomprenom.Name = "txt_nomprenom";
            this.txt_nomprenom.Size = new System.Drawing.Size(100, 22);
            this.txt_nomprenom.TabIndex = 3;
            this.txt_nomprenom.TextChanged += new System.EventHandler(this.txt_nomprenom_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 338);
            this.Controls.Add(this.txt_nomprenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom_prenom);
            this.Controls.Add(this.btn_bonjour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bonjour;
        private System.Windows.Forms.Label txt_nom_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomprenom;
    }
}

