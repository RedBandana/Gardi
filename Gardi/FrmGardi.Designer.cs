namespace Gardi
{
    partial class FrmGardi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGardi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViderPer = new System.Windows.Forms.Button();
            this.lsvPer = new System.Windows.Forms.ListView();
            this.clhNoPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDebut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDuree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifPer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlusHor = new System.Windows.Forms.Button();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.lblPerGrd = new System.Windows.Forms.Label();
            this.lblNbPerGrd = new System.Windows.Forms.Label();
            this.lblEmplEnr = new System.Windows.Forms.Label();
            this.lblPerEnr = new System.Windows.Forms.Label();
            this.lblNbPer = new System.Windows.Forms.Label();
            this.lblNbEmpl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenHor = new System.Windows.Forms.Button();
            this.btnModifEmpl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvEmp = new System.Windows.Forms.ListView();
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPeriode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViderEmpl = new System.Windows.Forms.Button();
            this.icnOvr = new System.Windows.Forms.PictureBox();
            this.icnExp = new System.Windows.Forms.PictureBox();
            this.icnEnr = new System.Windows.Forms.PictureBox();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnOvr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnEnr)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.mnuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.EnregistrerToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.ExporterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViderPer);
            this.groupBox2.Controls.Add(this.lsvPer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnModifPer);
            this.groupBox2.Location = new System.Drawing.Point(551, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnViderPer
            // 
            this.btnViderPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViderPer.Location = new System.Drawing.Point(19, 248);
            this.btnViderPer.Name = "btnViderPer";
            this.btnViderPer.Size = new System.Drawing.Size(106, 37);
            this.btnViderPer.TabIndex = 1;
            this.btnViderPer.Text = "Vider";
            this.btnViderPer.UseVisualStyleBackColor = true;
            this.btnViderPer.Click += new System.EventHandler(this.btnViderPer_Click);
            // 
            // lsvPer
            // 
            this.lsvPer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNoPer,
            this.clhDebut,
            this.clhFin,
            this.clhDuree});
            this.lsvPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPer.FullRowSelect = true;
            this.lsvPer.HideSelection = false;
            this.lsvPer.Location = new System.Drawing.Point(19, 59);
            this.lsvPer.Name = "lsvPer";
            this.lsvPer.Size = new System.Drawing.Size(286, 183);
            this.lsvPer.TabIndex = 0;
            this.lsvPer.UseCompatibleStateImageBehavior = false;
            this.lsvPer.View = System.Windows.Forms.View.Details;
            this.lsvPer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvPer_ColumnClick);
            this.lsvPer.DoubleClick += new System.EventHandler(this.LsvPer_DoubleClick);
            // 
            // clhNoPer
            // 
            this.clhNoPer.Text = "No";
            this.clhNoPer.Width = 50;
            // 
            // clhDebut
            // 
            this.clhDebut.Text = "Début";
            this.clhDebut.Width = 87;
            // 
            // clhFin
            // 
            this.clhFin.Text = "Fin";
            this.clhFin.Width = 74;
            // 
            // clhDuree
            // 
            this.clhDuree.Text = "Durée";
            this.clhDuree.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "PÉRIODES";
            // 
            // btnModifPer
            // 
            this.btnModifPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPer.Location = new System.Drawing.Point(131, 248);
            this.btnModifPer.Name = "btnModifPer";
            this.btnModifPer.Size = new System.Drawing.Size(174, 37);
            this.btnModifPer.TabIndex = 2;
            this.btnModifPer.Text = "Modifier";
            this.btnModifPer.UseVisualStyleBackColor = true;
            this.btnModifPer.Click += new System.EventHandler(this.BtnModifPer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlusHor);
            this.groupBox3.Controls.Add(this.pnlGeneral);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnGenHor);
            this.groupBox3.Location = new System.Drawing.Point(551, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnPlusHor
            // 
            this.btnPlusHor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusHor.Location = new System.Drawing.Point(19, 155);
            this.btnPlusHor.Name = "btnPlusHor";
            this.btnPlusHor.Size = new System.Drawing.Size(106, 44);
            this.btnPlusHor.TabIndex = 0;
            this.btnPlusHor.Text = "Plus";
            this.btnPlusHor.UseVisualStyleBackColor = true;
            this.btnPlusHor.Click += new System.EventHandler(this.BtnPlusHor_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.lblPerGrd);
            this.pnlGeneral.Controls.Add(this.lblNbPerGrd);
            this.pnlGeneral.Controls.Add(this.lblEmplEnr);
            this.pnlGeneral.Controls.Add(this.lblPerEnr);
            this.pnlGeneral.Controls.Add(this.lblNbPer);
            this.pnlGeneral.Controls.Add(this.lblNbEmpl);
            this.pnlGeneral.Location = new System.Drawing.Point(19, 56);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(286, 93);
            this.pnlGeneral.TabIndex = 8;
            // 
            // lblPerGrd
            // 
            this.lblPerGrd.AutoSize = true;
            this.lblPerGrd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerGrd.Location = new System.Drawing.Point(47, 63);
            this.lblPerGrd.Name = "lblPerGrd";
            this.lblPerGrd.Size = new System.Drawing.Size(207, 20);
            this.lblPerGrd.TabIndex = 7;
            this.lblPerGrd.Text = "Période de garde générée";
            // 
            // lblNbPerGrd
            // 
            this.lblNbPerGrd.AutoSize = true;
            this.lblNbPerGrd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPerGrd.Location = new System.Drawing.Point(13, 63);
            this.lblNbPerGrd.Name = "lblNbPerGrd";
            this.lblNbPerGrd.Size = new System.Drawing.Size(17, 20);
            this.lblNbPerGrd.TabIndex = 6;
            this.lblNbPerGrd.Text = "0";
            // 
            // lblEmplEnr
            // 
            this.lblEmplEnr.AutoSize = true;
            this.lblEmplEnr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplEnr.Location = new System.Drawing.Point(47, 10);
            this.lblEmplEnr.Name = "lblEmplEnr";
            this.lblEmplEnr.Size = new System.Drawing.Size(148, 20);
            this.lblEmplEnr.TabIndex = 5;
            this.lblEmplEnr.Text = "Employé enregistré";
            // 
            // lblPerEnr
            // 
            this.lblPerEnr.AutoSize = true;
            this.lblPerEnr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerEnr.Location = new System.Drawing.Point(47, 36);
            this.lblPerEnr.Name = "lblPerEnr";
            this.lblPerEnr.Size = new System.Drawing.Size(153, 20);
            this.lblPerEnr.TabIndex = 4;
            this.lblPerEnr.Text = "Période enregistrée";
            // 
            // lblNbPer
            // 
            this.lblNbPer.AutoSize = true;
            this.lblNbPer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPer.Location = new System.Drawing.Point(13, 36);
            this.lblNbPer.Name = "lblNbPer";
            this.lblNbPer.Size = new System.Drawing.Size(17, 20);
            this.lblNbPer.TabIndex = 1;
            this.lblNbPer.Text = "0";
            // 
            // lblNbEmpl
            // 
            this.lblNbEmpl.AutoSize = true;
            this.lblNbEmpl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbEmpl.Location = new System.Drawing.Point(13, 10);
            this.lblNbEmpl.Name = "lblNbEmpl";
            this.lblNbEmpl.Size = new System.Drawing.Size(17, 20);
            this.lblNbEmpl.TabIndex = 0;
            this.lblNbEmpl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "STATISTIQUES";
            // 
            // btnGenHor
            // 
            this.btnGenHor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenHor.Location = new System.Drawing.Point(131, 155);
            this.btnGenHor.Name = "btnGenHor";
            this.btnGenHor.Size = new System.Drawing.Size(174, 44);
            this.btnGenHor.TabIndex = 1;
            this.btnGenHor.Text = "Générer [date]";
            this.btnGenHor.UseVisualStyleBackColor = true;
            this.btnGenHor.Click += new System.EventHandler(this.BtnGenHor_Click);
            // 
            // btnModifEmpl
            // 
            this.btnModifEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifEmpl.Location = new System.Drawing.Point(259, 493);
            this.btnModifEmpl.Name = "btnModifEmpl";
            this.btnModifEmpl.Size = new System.Drawing.Size(274, 44);
            this.btnModifEmpl.TabIndex = 2;
            this.btnModifEmpl.Text = "Modifier";
            this.btnModifEmpl.UseVisualStyleBackColor = true;
            this.btnModifEmpl.Click += new System.EventHandler(this.BtnModifEmpl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "EMPLOYÉS";
            // 
            // lsvEmp
            // 
            this.lsvEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.clhNom,
            this.clhPrenom,
            this.clhPeriode,
            this.clhDate});
            this.lsvEmp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEmp.FullRowSelect = true;
            this.lsvEmp.HideSelection = false;
            this.lsvEmp.Location = new System.Drawing.Point(36, 86);
            this.lsvEmp.Name = "lsvEmp";
            this.lsvEmp.Size = new System.Drawing.Size(497, 401);
            this.lsvEmp.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvEmp.TabIndex = 0;
            this.lsvEmp.UseCompatibleStateImageBehavior = false;
            this.lsvEmp.View = System.Windows.Forms.View.Details;
            this.lsvEmp.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvEmp_ColumnClick);
            this.lsvEmp.DoubleClick += new System.EventHandler(this.LsvEmp_DoubleClick);
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            // 
            // clhNom
            // 
            this.clhNom.Text = "Nom";
            this.clhNom.Width = 105;
            // 
            // clhPrenom
            // 
            this.clhPrenom.Text = "Prénom";
            this.clhPrenom.Width = 108;
            // 
            // clhPeriode
            // 
            this.clhPeriode.Text = "Période de garde";
            this.clhPeriode.Width = 119;
            // 
            // clhDate
            // 
            this.clhDate.Text = "Date de garde";
            this.clhDate.Width = 100;
            // 
            // btnViderEmpl
            // 
            this.btnViderEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViderEmpl.Location = new System.Drawing.Point(36, 493);
            this.btnViderEmpl.Name = "btnViderEmpl";
            this.btnViderEmpl.Size = new System.Drawing.Size(217, 44);
            this.btnViderEmpl.TabIndex = 1;
            this.btnViderEmpl.Text = "Vider";
            this.btnViderEmpl.UseVisualStyleBackColor = true;
            this.btnViderEmpl.Click += new System.EventHandler(this.btnViderEmpl_Click);
            // 
            // icnOvr
            // 
            this.icnOvr.Image = global::Gardi.Properties.Resources.open_icon;
            this.icnOvr.Location = new System.Drawing.Point(36, 44);
            this.icnOvr.Name = "icnOvr";
            this.icnOvr.Size = new System.Drawing.Size(37, 30);
            this.icnOvr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnOvr.TabIndex = 11;
            this.icnOvr.TabStop = false;
            this.icnOvr.Click += new System.EventHandler(this.icnOvr_Click);
            this.icnOvr.MouseEnter += new System.EventHandler(this.icnOvr_MouseEnter);
            this.icnOvr.MouseLeave += new System.EventHandler(this.icnOvr_MouseLeave);
            // 
            // icnExp
            // 
            this.icnExp.Image = global::Gardi.Properties.Resources.export_icon;
            this.icnExp.Location = new System.Drawing.Point(122, 44);
            this.icnExp.Name = "icnExp";
            this.icnExp.Size = new System.Drawing.Size(37, 30);
            this.icnExp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnExp.TabIndex = 10;
            this.icnExp.TabStop = false;
            this.icnExp.Click += new System.EventHandler(this.IcnExp_Click);
            this.icnExp.MouseEnter += new System.EventHandler(this.IcnExp_MouseEnter);
            this.icnExp.MouseLeave += new System.EventHandler(this.IcnExp_MouseLeave);
            // 
            // icnEnr
            // 
            this.icnEnr.Image = global::Gardi.Properties.Resources.save_icon;
            this.icnEnr.Location = new System.Drawing.Point(79, 44);
            this.icnEnr.Name = "icnEnr";
            this.icnEnr.Size = new System.Drawing.Size(37, 30);
            this.icnEnr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnEnr.TabIndex = 8;
            this.icnEnr.TabStop = false;
            this.icnEnr.Click += new System.EventHandler(this.IcnEnr_Click);
            this.icnEnr.MouseEnter += new System.EventHandler(this.IcnEnr_MouseEnter);
            this.icnEnr.MouseLeave += new System.EventHandler(this.IcnEnr_MouseLeave);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(45, 20);
            this.mnuInfo.Text = "Infos";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmGardi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 567);
            this.Controls.Add(this.icnOvr);
            this.Controls.Add(this.btnViderEmpl);
            this.Controls.Add(this.icnExp);
            this.Controls.Add(this.lsvEmp);
            this.Controls.Add(this.icnEnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifEmpl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmGardi";
            this.Text = "Gardi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnOvr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnEnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModifPer;
        private System.Windows.Forms.Button btnGenHor;
        private System.Windows.Forms.Button btnModifEmpl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmplEnr;
        private System.Windows.Forms.Label lblPerEnr;
        private System.Windows.Forms.Label lblNbPer;
        private System.Windows.Forms.Label lblNbEmpl;
        private System.Windows.Forms.Button btnPlusHor;
        private System.Windows.Forms.PictureBox icnEnr;
        private System.Windows.Forms.ListView lsvPer;
        private System.Windows.Forms.ListView lsvEmp;
        private System.Windows.Forms.ColumnHeader clhNom;
        private System.Windows.Forms.ColumnHeader clhPrenom;
        private System.Windows.Forms.ColumnHeader clhPeriode;
        private System.Windows.Forms.ColumnHeader clhDebut;
        private System.Windows.Forms.ColumnHeader clhFin;
        private System.Windows.Forms.ColumnHeader clhDuree;
        private System.Windows.Forms.ColumnHeader clhDate;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhNoPer;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.PictureBox icnExp;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.Button btnViderPer;
        private System.Windows.Forms.Button btnViderEmpl;
        private System.Windows.Forms.Label lblPerGrd;
        private System.Windows.Forms.Label lblNbPerGrd;
        private System.Windows.Forms.PictureBox icnOvr;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

