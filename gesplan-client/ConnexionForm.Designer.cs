namespace gesplan_client
{
    partial class ConnexionForm
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
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uid
            // 
            this.txt_uid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Location = new System.Drawing.Point(507, 41);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(150, 35);
            this.txt_uid.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(507, 93);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(150, 35);
            this.txt_password.TabIndex = 1;
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uid.Location = new System.Drawing.Point(317, 46);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(133, 29);
            this.lbl_uid.TabIndex = 2;
            this.lbl_uid.Text = "Matricule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe :";
            // 
            // btn_connexion
            // 
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.Location = new System.Drawing.Point(507, 185);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(150, 45);
            this.btn_connexion.TabIndex = 2;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.Location = new System.Drawing.Point(322, 185);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(166, 45);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Text = "Annuler";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // pcb_logo
            // 
            this.pcb_logo.Image = global::gesplan_client.Properties.Resources.logo;
            this.pcb_logo.Location = new System.Drawing.Point(0, 0);
            this.pcb_logo.Margin = new System.Windows.Forms.Padding(0);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(285, 263);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_logo.TabIndex = 6;
            this.pcb_logo.TabStop = false;
            // 
            // ConnexionForm
            // 
            this.AcceptButton = this.btn_connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quitter;
            this.ClientSize = new System.Drawing.Size(695, 267);
            this.ControlBox = false;
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_uid);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_uid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnexionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrez vos identifiants";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.PictureBox pcb_logo;
    }
}