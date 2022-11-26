namespace ex2
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.bnt_quiter = new System.Windows.Forms.Button();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 0;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(199, 32);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(40, 17);
            this.txt.TabIndex = 1;
            this.txt.Text = "Nom";
            this.txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(187, 69);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 22);
            this.txt_nom.TabIndex = 2;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.Location = new System.Drawing.Point(187, 129);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 3;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_quiter
            // 
            this.bnt_quiter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_quiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_quiter.Location = new System.Drawing.Point(119, 357);
            this.bnt_quiter.Name = "bnt_quiter";
            this.bnt_quiter.Size = new System.Drawing.Size(75, 23);
            this.bnt_quiter.TabIndex = 4;
            this.bnt_quiter.Text = "Quiter";
            this.bnt_quiter.UseVisualStyleBackColor = true;
            this.bnt_quiter.Click += new System.EventHandler(this.bnt_quiter_Click);
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(64, 173);
            this.txt_area.Multiline = true;
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(405, 123);
            this.txt_area.TabIndex = 5;
            this.txt_area.TextChanged += new System.EventHandler(this.txt_area_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ajout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnt_quiter;
            this.ClientSize = new System.Drawing.Size(512, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.bnt_quiter);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button bnt_quiter;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Button button1;
    }
}

