namespace GestionDeGarage
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
            this.voitBtn = new System.Windows.Forms.RadioButton();
            this.motBtn = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imm = new System.Windows.Forms.Label();
            this.ann = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.ajoute = new System.Windows.Forms.Button();
            this.supprime = new System.Windows.Forms.Button();
            this.characteristique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voitBtn
            // 
            this.voitBtn.AutoSize = true;
            this.voitBtn.Location = new System.Drawing.Point(40, 55);
            this.voitBtn.Name = "voitBtn";
            this.voitBtn.Size = new System.Drawing.Size(58, 17);
            this.voitBtn.TabIndex = 0;
            this.voitBtn.TabStop = true;
            this.voitBtn.Text = "Voiture";
            this.voitBtn.UseVisualStyleBackColor = true;
            // 
            // motBtn
            // 
            this.motBtn.AutoSize = true;
            this.motBtn.Location = new System.Drawing.Point(118, 55);
            this.motBtn.Name = "motBtn";
            this.motBtn.Size = new System.Drawing.Size(49, 17);
            this.motBtn.TabIndex = 1;
            this.motBtn.TabStop = true;
            this.motBtn.Text = "Moto";
            this.motBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 95);
            this.listBox1.TabIndex = 2;
            // 
            // imm
            // 
            this.imm.AutoSize = true;
            this.imm.Location = new System.Drawing.Point(249, 110);
            this.imm.Name = "imm";
            this.imm.Size = new System.Drawing.Size(77, 13);
            this.imm.TabIndex = 3;
            this.imm.Text = "Immatriculation";
            // 
            // ann
            // 
            this.ann.AutoSize = true;
            this.ann.Location = new System.Drawing.Point(249, 150);
            this.ann.Name = "ann";
            this.ann.Size = new System.Drawing.Size(38, 13);
            this.ann.TabIndex = 4;
            this.ann.Text = "Annee";
            this.ann.Click += new System.EventHandler(this.label2_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(249, 192);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 5;
            this.type.Text = "Type";
            // 
            // ajoute
            // 
            this.ajoute.Location = new System.Drawing.Point(40, 255);
            this.ajoute.Name = "ajoute";
            this.ajoute.Size = new System.Drawing.Size(75, 23);
            this.ajoute.TabIndex = 6;
            this.ajoute.Text = "Ajouter";
            this.ajoute.UseVisualStyleBackColor = true;
            // 
            // supprime
            // 
            this.supprime.Location = new System.Drawing.Point(134, 255);
            this.supprime.Name = "supprime";
            this.supprime.Size = new System.Drawing.Size(75, 23);
            this.supprime.TabIndex = 7;
            this.supprime.Text = "Supprimer";
            this.supprime.UseVisualStyleBackColor = true;
            // 
            // characteristique
            // 
            this.characteristique.Location = new System.Drawing.Point(358, 255);
            this.characteristique.Name = "characteristique";
            this.characteristique.Size = new System.Drawing.Size(100, 23);
            this.characteristique.TabIndex = 8;
            this.characteristique.Text = "Charactéristiques";
            this.characteristique.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characteristique);
            this.Controls.Add(this.supprime);
            this.Controls.Add(this.ajoute);
            this.Controls.Add(this.type);
            this.Controls.Add(this.ann);
            this.Controls.Add(this.imm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.motBtn);
            this.Controls.Add(this.voitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton voitBtn;
        private System.Windows.Forms.RadioButton motBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label imm;
        private System.Windows.Forms.Label ann;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Button ajoute;
        private System.Windows.Forms.Button supprime;
        private System.Windows.Forms.Button characteristique;
    }
}

