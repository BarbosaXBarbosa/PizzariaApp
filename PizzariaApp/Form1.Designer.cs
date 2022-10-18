namespace PizzariaApp
{
    partial class frmPizzaria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaria));
            this.gpbSize = new System.Windows.Forms.GroupBox();
            this.rdbBig = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbSprout = new System.Windows.Forms.RadioButton();
            this.gpbFlavors = new System.Windows.Forms.GroupBox();
            this.rdbCheese = new System.Windows.Forms.RadioButton();
            this.rdbMargherita = new System.Windows.Forms.RadioButton();
            this.rdbPepperoni = new System.Windows.Forms.RadioButton();
            this.rdbBuffalo = new System.Windows.Forms.RadioButton();
            this.gpbAddons = new System.Windows.Forms.GroupBox();
            this.ckbAddons = new System.Windows.Forms.CheckBox();
            this.ckbCheddar = new System.Windows.Forms.CheckBox();
            this.ckbOlive = new System.Windows.Forms.CheckBox();
            this.ckbLeek = new System.Windows.Forms.CheckBox();
            this.ckbTomato = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbSize.SuspendLayout();
            this.gpbFlavors.SuspendLayout();
            this.gpbAddons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSize
            // 
            this.gpbSize.Controls.Add(this.rdbSprout);
            this.gpbSize.Controls.Add(this.rdbSmall);
            this.gpbSize.Controls.Add(this.rdbMedium);
            this.gpbSize.Controls.Add(this.rdbBig);
            this.gpbSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gpbSize.Location = new System.Drawing.Point(12, 12);
            this.gpbSize.Name = "gpbSize";
            this.gpbSize.Size = new System.Drawing.Size(195, 226);
            this.gpbSize.TabIndex = 0;
            this.gpbSize.TabStop = false;
            this.gpbSize.Text = "Size";
            // 
            // rdbBig
            // 
            this.rdbBig.AutoSize = true;
            this.rdbBig.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBig.ForeColor = System.Drawing.Color.Moccasin;
            this.rdbBig.Location = new System.Drawing.Point(15, 32);
            this.rdbBig.Name = "rdbBig";
            this.rdbBig.Size = new System.Drawing.Size(143, 22);
            this.rdbBig.TabIndex = 0;
            this.rdbBig.TabStop = true;
            this.rdbBig.Text = "Big - R$ 100,00";
            this.rdbBig.UseVisualStyleBackColor = false;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.ForeColor = System.Drawing.Color.Moccasin;
            this.rdbMedium.Location = new System.Drawing.Point(15, 71);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(168, 22);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium - R$ 75,00";
            this.rdbMedium.UseVisualStyleBackColor = false;
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSmall.ForeColor = System.Drawing.Color.Moccasin;
            this.rdbSmall.Location = new System.Drawing.Point(15, 111);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(151, 22);
            this.rdbSmall.TabIndex = 2;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small - R$ 50,00";
            this.rdbSmall.UseVisualStyleBackColor = false;
            // 
            // rdbSprout
            // 
            this.rdbSprout.AutoSize = true;
            this.rdbSprout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSprout.ForeColor = System.Drawing.Color.Moccasin;
            this.rdbSprout.Location = new System.Drawing.Point(15, 195);
            this.rdbSprout.Name = "rdbSprout";
            this.rdbSprout.Size = new System.Drawing.Size(157, 22);
            this.rdbSprout.TabIndex = 3;
            this.rdbSprout.TabStop = true;
            this.rdbSprout.Text = "Sprout - R$ 30,00";
            this.rdbSprout.UseVisualStyleBackColor = false;
            // 
            // gpbFlavors
            // 
            this.gpbFlavors.Controls.Add(this.rdbBuffalo);
            this.gpbFlavors.Controls.Add(this.rdbPepperoni);
            this.gpbFlavors.Controls.Add(this.rdbMargherita);
            this.gpbFlavors.Controls.Add(this.rdbCheese);
            this.gpbFlavors.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFlavors.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gpbFlavors.Location = new System.Drawing.Point(236, 12);
            this.gpbFlavors.Name = "gpbFlavors";
            this.gpbFlavors.Size = new System.Drawing.Size(215, 161);
            this.gpbFlavors.TabIndex = 1;
            this.gpbFlavors.TabStop = false;
            this.gpbFlavors.Text = "Flavors";
            this.gpbFlavors.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbCheese
            // 
            this.rdbCheese.AutoSize = true;
            this.rdbCheese.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheese.Location = new System.Drawing.Point(17, 32);
            this.rdbCheese.Name = "rdbCheese";
            this.rdbCheese.Size = new System.Drawing.Size(133, 22);
            this.rdbCheese.TabIndex = 0;
            this.rdbCheese.TabStop = true;
            this.rdbCheese.Text = "Cheese - R$ 5,50";
            this.rdbCheese.UseVisualStyleBackColor = false;
            // 
            // rdbMargherita
            // 
            this.rdbMargherita.AutoSize = true;
            this.rdbMargherita.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMargherita.Location = new System.Drawing.Point(16, 60);
            this.rdbMargherita.Name = "rdbMargherita";
            this.rdbMargherita.Size = new System.Drawing.Size(170, 22);
            this.rdbMargherita.TabIndex = 1;
            this.rdbMargherita.TabStop = true;
            this.rdbMargherita.Text = "Margherita - R$ 10,50";
            this.rdbMargherita.UseVisualStyleBackColor = false;
            // 
            // rdbPepperoni
            // 
            this.rdbPepperoni.AutoSize = true;
            this.rdbPepperoni.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPepperoni.Location = new System.Drawing.Point(17, 88);
            this.rdbPepperoni.Name = "rdbPepperoni";
            this.rdbPepperoni.Size = new System.Drawing.Size(163, 22);
            this.rdbPepperoni.TabIndex = 2;
            this.rdbPepperoni.TabStop = true;
            this.rdbPepperoni.Text = "Pepperoni - R$ 12,50";
            this.rdbPepperoni.UseVisualStyleBackColor = true;
            // 
            // rdbBuffalo
            // 
            this.rdbBuffalo.AutoSize = true;
            this.rdbBuffalo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBuffalo.Location = new System.Drawing.Point(16, 116);
            this.rdbBuffalo.Name = "rdbBuffalo";
            this.rdbBuffalo.Size = new System.Drawing.Size(141, 22);
            this.rdbBuffalo.TabIndex = 3;
            this.rdbBuffalo.TabStop = true;
            this.rdbBuffalo.Text = "Buffalo - R$ 8,75";
            this.rdbBuffalo.UseVisualStyleBackColor = true;
            // 
            // gpbAddons
            // 
            this.gpbAddons.Controls.Add(this.ckbBanana);
            this.gpbAddons.Controls.Add(this.ckbTomato);
            this.gpbAddons.Controls.Add(this.ckbLeek);
            this.gpbAddons.Controls.Add(this.ckbOlive);
            this.gpbAddons.Controls.Add(this.ckbCheddar);
            this.gpbAddons.Controls.Add(this.ckbAddons);
            this.gpbAddons.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddons.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gpbAddons.Location = new System.Drawing.Point(12, 274);
            this.gpbAddons.Name = "gpbAddons";
            this.gpbAddons.Size = new System.Drawing.Size(439, 121);
            this.gpbAddons.TabIndex = 2;
            this.gpbAddons.TabStop = false;
            this.gpbAddons.Text = "Add-ons";
            // 
            // ckbAddons
            // 
            this.ckbAddons.AutoSize = true;
            this.ckbAddons.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAddons.Location = new System.Drawing.Point(15, 32);
            this.ckbAddons.Name = "ckbAddons";
            this.ckbAddons.Size = new System.Drawing.Size(66, 21);
            this.ckbAddons.TabIndex = 0;
            this.ckbAddons.Text = "Bacon";
            this.ckbAddons.UseVisualStyleBackColor = true;
            // 
            // ckbCheddar
            // 
            this.ckbCheddar.AutoSize = true;
            this.ckbCheddar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCheddar.Location = new System.Drawing.Point(158, 32);
            this.ckbCheddar.Name = "ckbCheddar";
            this.ckbCheddar.Size = new System.Drawing.Size(76, 21);
            this.ckbCheddar.TabIndex = 1;
            this.ckbCheddar.Text = "Cheddar";
            this.ckbCheddar.UseVisualStyleBackColor = true;
            // 
            // ckbOlive
            // 
            this.ckbOlive.AutoSize = true;
            this.ckbOlive.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOlive.Location = new System.Drawing.Point(313, 32);
            this.ckbOlive.Name = "ckbOlive";
            this.ckbOlive.Size = new System.Drawing.Size(59, 21);
            this.ckbOlive.TabIndex = 2;
            this.ckbOlive.Text = "Olive";
            this.ckbOlive.UseVisualStyleBackColor = true;
            // 
            // ckbLeek
            // 
            this.ckbLeek.AutoSize = true;
            this.ckbLeek.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLeek.Location = new System.Drawing.Point(15, 76);
            this.ckbLeek.Name = "ckbLeek";
            this.ckbLeek.Size = new System.Drawing.Size(57, 21);
            this.ckbLeek.TabIndex = 3;
            this.ckbLeek.Text = "Leek";
            this.ckbLeek.UseVisualStyleBackColor = true;
            // 
            // ckbTomato
            // 
            this.ckbTomato.AutoSize = true;
            this.ckbTomato.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTomato.Location = new System.Drawing.Point(158, 76);
            this.ckbTomato.Name = "ckbTomato";
            this.ckbTomato.Size = new System.Drawing.Size(112, 21);
            this.ckbTomato.TabIndex = 4;
            this.ckbTomato.Text = "Dried Tomato";
            this.ckbTomato.UseVisualStyleBackColor = true;
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBanana.Location = new System.Drawing.Point(313, 76);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(75, 21);
            this.ckbBanana.TabIndex = 5;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(170, 414);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 27);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblRequest
            // 
            this.lblRequest.BackColor = System.Drawing.Color.Moccasin;
            this.lblRequest.Location = new System.Drawing.Point(24, 458);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(427, 134);
            this.lblRequest.TabIndex = 4;
            this.lblRequest.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRequest.Location = new System.Drawing.Point(27, 605);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(157, 23);
            this.btnNewRequest.TabIndex = 5;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(360, 605);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(463, 640);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gpbAddons);
            this.Controls.Add(this.gpbFlavors);
            this.Controls.Add(this.gpbSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPizzaria";
            this.Text = "Eletronic System of Pizza";
            this.gpbSize.ResumeLayout(false);
            this.gpbSize.PerformLayout();
            this.gpbFlavors.ResumeLayout(false);
            this.gpbFlavors.PerformLayout();
            this.gpbAddons.ResumeLayout(false);
            this.gpbAddons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSize;
        private System.Windows.Forms.RadioButton rdbSprout;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbBig;
        private System.Windows.Forms.GroupBox gpbFlavors;
        private System.Windows.Forms.RadioButton rdbBuffalo;
        private System.Windows.Forms.RadioButton rdbPepperoni;
        private System.Windows.Forms.RadioButton rdbMargherita;
        private System.Windows.Forms.RadioButton rdbCheese;
        private System.Windows.Forms.GroupBox gpbAddons;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbTomato;
        private System.Windows.Forms.CheckBox ckbLeek;
        private System.Windows.Forms.CheckBox ckbOlive;
        private System.Windows.Forms.CheckBox ckbCheddar;
        private System.Windows.Forms.CheckBox ckbAddons;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnExit;
    }
}

