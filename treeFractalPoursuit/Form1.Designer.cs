namespace treeFractalPoursuit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAngleA = new System.Windows.Forms.Label();
            this.lblAngleB = new System.Windows.Forms.Label();
            this.lblprofondeurA = new System.Windows.Forms.Label();
            this.lblProfondeurB = new System.Windows.Forms.Label();
            this.nudAngleB = new System.Windows.Forms.NumericUpDown();
            this.nudLongueurB = new System.Windows.Forms.NumericUpDown();
            this.nudAngleA = new System.Windows.Forms.NumericUpDown();
            this.nudLongueurA = new System.Windows.Forms.NumericUpDown();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.nudNiveau = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomVersion = new System.Windows.Forms.Label();
            this.Fenetre = new System.Windows.Forms.Timer(this.components);
            this.rbtnHiver = new System.Windows.Forms.RadioButton();
            this.rbtnAutomne = new System.Windows.Forms.RadioButton();
            this.rbtnPrintemps = new System.Windows.Forms.RadioButton();
            this.rbtnEte = new System.Windows.Forms.RadioButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAleatoire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAngleA
            // 
            this.lblAngleA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAngleA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAngleA.Location = new System.Drawing.Point(229, 22);
            this.lblAngleA.Name = "lblAngleA";
            this.lblAngleA.Size = new System.Drawing.Size(100, 13);
            this.lblAngleA.TabIndex = 3;
            this.lblAngleA.Text = "Angle A";
            // 
            // lblAngleB
            // 
            this.lblAngleB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAngleB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAngleB.Location = new System.Drawing.Point(471, 22);
            this.lblAngleB.Name = "lblAngleB";
            this.lblAngleB.Size = new System.Drawing.Size(100, 13);
            this.lblAngleB.TabIndex = 4;
            this.lblAngleB.Text = "Angle B";
            // 
            // lblprofondeurA
            // 
            this.lblprofondeurA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblprofondeurA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblprofondeurA.Location = new System.Drawing.Point(335, 23);
            this.lblprofondeurA.Name = "lblprofondeurA";
            this.lblprofondeurA.Size = new System.Drawing.Size(129, 13);
            this.lblprofondeurA.TabIndex = 5;
            this.lblprofondeurA.Text = "Longueur des branches A";
            // 
            // lblProfondeurB
            // 
            this.lblProfondeurB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfondeurB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfondeurB.Location = new System.Drawing.Point(577, 22);
            this.lblProfondeurB.Name = "lblProfondeurB";
            this.lblProfondeurB.Size = new System.Drawing.Size(129, 13);
            this.lblProfondeurB.TabIndex = 8;
            this.lblProfondeurB.Text = "Longueur des branches B";
            // 
            // nudAngleB
            // 
            this.nudAngleB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAngleB.Location = new System.Drawing.Point(471, 38);
            this.nudAngleB.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAngleB.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.nudAngleB.Name = "nudAngleB";
            this.nudAngleB.Size = new System.Drawing.Size(100, 20);
            this.nudAngleB.TabIndex = 3;
            this.nudAngleB.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAngleB.ValueChanged += new System.EventHandler(this.nudAngleB_ValueChanged);
            // 
            // nudLongueurB
            // 
            this.nudLongueurB.DecimalPlaces = 2;
            this.nudLongueurB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLongueurB.Location = new System.Drawing.Point(577, 38);
            this.nudLongueurB.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.nudLongueurB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLongueurB.Name = "nudLongueurB";
            this.nudLongueurB.Size = new System.Drawing.Size(129, 20);
            this.nudLongueurB.TabIndex = 4;
            this.nudLongueurB.Value = new decimal(new int[] {
            67,
            0,
            0,
            131072});
            this.nudLongueurB.ValueChanged += new System.EventHandler(this.nudLongueurB_ValueChanged);
            // 
            // nudAngleA
            // 
            this.nudAngleA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAngleA.Location = new System.Drawing.Point(229, 38);
            this.nudAngleA.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAngleA.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.nudAngleA.Name = "nudAngleA";
            this.nudAngleA.Size = new System.Drawing.Size(100, 20);
            this.nudAngleA.TabIndex = 1;
            this.nudAngleA.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudAngleA.ValueChanged += new System.EventHandler(this.nudAngleA_ValueChanged);
            // 
            // nudLongueurA
            // 
            this.nudLongueurA.DecimalPlaces = 2;
            this.nudLongueurA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLongueurA.Location = new System.Drawing.Point(335, 38);
            this.nudLongueurA.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.nudLongueurA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLongueurA.Name = "nudLongueurA";
            this.nudLongueurA.Size = new System.Drawing.Size(129, 20);
            this.nudLongueurA.TabIndex = 2;
            this.nudLongueurA.Value = new decimal(new int[] {
            67,
            0,
            0,
            131072});
            this.nudLongueurA.ValueChanged += new System.EventHandler(this.nudLongueurA_ValueChanged);
            // 
            // btnGenerer
            // 
            this.btnGenerer.ForeColor = System.Drawing.Color.Black;
            this.btnGenerer.Location = new System.Drawing.Point(12, 12);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(127, 70);
            this.btnGenerer.TabIndex = 0;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // nudNiveau
            // 
            this.nudNiveau.Location = new System.Drawing.Point(712, 38);
            this.nudNiveau.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNiveau.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNiveau.Name = "nudNiveau";
            this.nudNiveau.Size = new System.Drawing.Size(120, 20);
            this.nudNiveau.TabIndex = 5;
            this.nudNiveau.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(711, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Niveau de feuilles";
            // 
            // lblNomVersion
            // 
            this.lblNomVersion.AutoSize = true;
            this.lblNomVersion.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVersion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNomVersion.Location = new System.Drawing.Point(7, 85);
            this.lblNomVersion.Name = "lblNomVersion";
            this.lblNomVersion.Size = new System.Drawing.Size(143, 25);
            this.lblNomVersion.TabIndex = 17;
            this.lblNomVersion.Text = "By M.A. V1";
            this.lblNomVersion.LocationChanged += new System.EventHandler(this.btnGenerer_Click);
            // 
            // Fenetre
            // 
            this.Fenetre.Enabled = true;
            this.Fenetre.Tick += new System.EventHandler(this.Fenetre_Tick);
            // 
            // rbtnHiver
            // 
            this.rbtnHiver.AutoSize = true;
            this.rbtnHiver.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnHiver.ForeColor = System.Drawing.Color.White;
            this.rbtnHiver.Location = new System.Drawing.Point(426, 65);
            this.rbtnHiver.Name = "rbtnHiver";
            this.rbtnHiver.Size = new System.Drawing.Size(50, 17);
            this.rbtnHiver.TabIndex = 9;
            this.rbtnHiver.Text = "Hiver";
            this.rbtnHiver.UseVisualStyleBackColor = false;
            // 
            // rbtnAutomne
            // 
            this.rbtnAutomne.AutoSize = true;
            this.rbtnAutomne.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnAutomne.Checked = true;
            this.rbtnAutomne.ForeColor = System.Drawing.Color.White;
            this.rbtnAutomne.Location = new System.Drawing.Point(353, 65);
            this.rbtnAutomne.Name = "rbtnAutomne";
            this.rbtnAutomne.Size = new System.Drawing.Size(67, 17);
            this.rbtnAutomne.TabIndex = 8;
            this.rbtnAutomne.TabStop = true;
            this.rbtnAutomne.Text = "Automne";
            this.rbtnAutomne.UseVisualStyleBackColor = false;
            // 
            // rbtnPrintemps
            // 
            this.rbtnPrintemps.AutoSize = true;
            this.rbtnPrintemps.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnPrintemps.ForeColor = System.Drawing.Color.White;
            this.rbtnPrintemps.Location = new System.Drawing.Point(229, 65);
            this.rbtnPrintemps.Name = "rbtnPrintemps";
            this.rbtnPrintemps.Size = new System.Drawing.Size(71, 17);
            this.rbtnPrintemps.TabIndex = 6;
            this.rbtnPrintemps.Text = "Printemps";
            this.rbtnPrintemps.UseVisualStyleBackColor = false;
            // 
            // rbtnEte
            // 
            this.rbtnEte.AutoSize = true;
            this.rbtnEte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnEte.ForeColor = System.Drawing.Color.White;
            this.rbtnEte.Location = new System.Drawing.Point(306, 65);
            this.rbtnEte.Name = "rbtnEte";
            this.rbtnEte.Size = new System.Drawing.Size(41, 17);
            this.rbtnEte.TabIndex = 7;
            this.rbtnEte.Text = "Été";
            this.rbtnEte.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 122);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(222, 64);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // btnAleatoire
            // 
            this.btnAleatoire.ForeColor = System.Drawing.Color.Black;
            this.btnAleatoire.Location = new System.Drawing.Point(145, 12);
            this.btnAleatoire.Name = "btnAleatoire";
            this.btnAleatoire.Size = new System.Drawing.Size(78, 70);
            this.btnAleatoire.TabIndex = 10;
            this.btnAleatoire.Text = "Aléatoire";
            this.btnAleatoire.UseVisualStyleBackColor = true;
            this.btnAleatoire.Click += new System.EventHandler(this.btnAleatoire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(842, 595);
            this.Controls.Add(this.btnAleatoire);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.rbtnEte);
            this.Controls.Add(this.rbtnPrintemps);
            this.Controls.Add(this.rbtnAutomne);
            this.Controls.Add(this.rbtnHiver);
            this.Controls.Add(this.lblNomVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNiveau);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.nudLongueurA);
            this.Controls.Add(this.nudAngleA);
            this.Controls.Add(this.nudLongueurB);
            this.Controls.Add(this.nudAngleB);
            this.Controls.Add(this.lblProfondeurB);
            this.Controls.Add(this.lblprofondeurA);
            this.Controls.Add(this.lblAngleB);
            this.Controls.Add(this.lblAngleA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(858, 634);
            this.Name = "Form1";
            this.Text = "TreeFractalePoursuite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAngleA;
        private System.Windows.Forms.Label lblAngleB;
        private System.Windows.Forms.Label lblprofondeurA;
        private System.Windows.Forms.Label lblProfondeurB;
        private System.Windows.Forms.NumericUpDown nudAngleB;
        private System.Windows.Forms.NumericUpDown nudLongueurB;
        private System.Windows.Forms.NumericUpDown nudAngleA;
        private System.Windows.Forms.NumericUpDown nudLongueurA;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.NumericUpDown nudNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomVersion;
        private System.Windows.Forms.Timer Fenetre;
        private System.Windows.Forms.RadioButton rbtnHiver;
        private System.Windows.Forms.RadioButton rbtnAutomne;
        private System.Windows.Forms.RadioButton rbtnPrintemps;
        private System.Windows.Forms.RadioButton rbtnEte;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAleatoire;
    }
}

