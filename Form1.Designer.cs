namespace WhoIsIt
{
    partial class WhoIsIt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpPerso = new FlowLayoutPanel();
            lblConsigne = new Label();
            cmbBoxQuestions = new ComboBox();
            btnPoserQuestion = new Button();
            lblReponse = new Label();
            btnRelancer = new Button();
            pboxLogo = new PictureBox();
            btnReafficher = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // flpPerso
            // 
            flpPerso.Anchor = AnchorStyles.None;
            flpPerso.Location = new Point(469, 211);
            flpPerso.Margin = new Padding(3, 4, 3, 4);
            flpPerso.Name = "flpPerso";
            flpPerso.Size = new Size(863, 545);
            flpPerso.TabIndex = 0;
            // 
            // lblConsigne
            // 
            lblConsigne.Anchor = AnchorStyles.None;
            lblConsigne.AutoSize = true;
            lblConsigne.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConsigne.Location = new Point(566, 774);
            lblConsigne.Name = "lblConsigne";
            lblConsigne.Size = new Size(667, 28);
            lblConsigne.TabIndex = 1;
            lblConsigne.Text = "Clic gauche sur un personnage pour deviner, clic droit pour l'éliminer";
            // 
            // cmbBoxQuestions
            // 
            cmbBoxQuestions.Anchor = AnchorStyles.None;
            cmbBoxQuestions.FormattingEnabled = true;
            cmbBoxQuestions.Items.AddRange(new object[] { "Est-ce que ton personnage a des cheveux ?", "Est-ce que ton personnage a une moustache ?", "Est-ce que ton personnage a une barbe ?", "Est-ce que ses cheveux sont blanc ?", "Est-ce que ses cheveux sont marron ?", "Est-ce que ses cheveux sont noir ?", "Est-ce que ses cheveux sont rouge ?", "Est-ce que ses cheveux sont jaune ?", "Est-ce que ses yeux sont bleu ?", "Est-ce que ses yeux sont noirs ?", "Est-ce que ses yeux sont marrons ?", "Ton personnage a t-il des lunettes ?", "Ton personnage a t-il un chapeau ?", "Est-ce un homme ?", "Est-ce une femme ?" });
            cmbBoxQuestions.Location = new Point(53, 217);
            cmbBoxQuestions.Margin = new Padding(3, 4, 3, 4);
            cmbBoxQuestions.Name = "cmbBoxQuestions";
            cmbBoxQuestions.Size = new Size(357, 28);
            cmbBoxQuestions.TabIndex = 2;
            // 
            // btnPoserQuestion
            // 
            btnPoserQuestion.Anchor = AnchorStyles.None;
            btnPoserQuestion.Location = new Point(147, 253);
            btnPoserQuestion.Margin = new Padding(3, 4, 3, 4);
            btnPoserQuestion.Name = "btnPoserQuestion";
            btnPoserQuestion.Size = new Size(160, 31);
            btnPoserQuestion.TabIndex = 3;
            btnPoserQuestion.Text = "Valider la question";
            btnPoserQuestion.UseVisualStyleBackColor = true;
            btnPoserQuestion.Click += btnPoserQuestion_Click;
            // 
            // lblReponse
            // 
            lblReponse.Anchor = AnchorStyles.None;
            lblReponse.AutoSize = true;
            lblReponse.Location = new Point(53, 283);
            lblReponse.Name = "lblReponse";
            lblReponse.Size = new Size(0, 20);
            lblReponse.TabIndex = 4;
            // 
            // btnRelancer
            // 
            btnRelancer.Anchor = AnchorStyles.None;
            btnRelancer.Location = new Point(107, 727);
            btnRelancer.Margin = new Padding(3, 4, 3, 4);
            btnRelancer.Name = "btnRelancer";
            btnRelancer.Size = new Size(123, 57);
            btnRelancer.TabIndex = 5;
            btnRelancer.Text = "Relancer";
            btnRelancer.UseVisualStyleBackColor = true;
            btnRelancer.Click += btnRelancer_Click;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.None;
            pboxLogo.Location = new Point(514, 12);
            pboxLogo.Margin = new Padding(3, 4, 3, 4);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(319, 187);
            pboxLogo.TabIndex = 6;
            pboxLogo.TabStop = false;
            // 
            // btnReafficher
            // 
            btnReafficher.Anchor = AnchorStyles.None;
            btnReafficher.Location = new Point(263, 727);
            btnReafficher.Name = "btnReafficher";
            btnReafficher.Size = new Size(106, 57);
            btnReafficher.TabIndex = 7;
            btnReafficher.Text = "Afficher tout";
            btnReafficher.UseVisualStyleBackColor = true;
            btnReafficher.Click += btnReafficher_Click;
            // 
            // WhoIsIt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1358, 815);
            Controls.Add(btnReafficher);
            Controls.Add(pboxLogo);
            Controls.Add(btnRelancer);
            Controls.Add(lblReponse);
            Controls.Add(btnPoserQuestion);
            Controls.Add(cmbBoxQuestions);
            Controls.Add(lblConsigne);
            Controls.Add(flpPerso);
            ForeColor = Color.Red;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WhoIsIt";
            Text = "Qui est-ce ?";
            Load += WhoIsIt_Load;
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpPerso;
        private Label lblConsigne;
        private ComboBox cmbBoxQuestions;
        private Button btnPoserQuestion;
        private Label lblReponse;
        private Button btnRelancer;
        private PictureBox pboxLogo;
        private Button btnReafficher;
    }
}
