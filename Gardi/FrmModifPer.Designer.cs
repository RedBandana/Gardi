namespace Gardi
{
    partial class FrmModifPer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifPer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenPer = new System.Windows.Forms.Button();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuppPer = new System.Windows.Forms.Button();
            this.btnModifPer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjoutEPer = new System.Windows.Forms.Button();
            this.txtFinHr = new System.Windows.Forms.TextBox();
            this.txtDebHr = new System.Windows.Forms.TextBox();
            this.txtFinMn = new System.Windows.Forms.TextBox();
            this.txtDebMn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvPer = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clbJours = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenPer);
            this.groupBox1.Controls.Add(this.txtPer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuppPer);
            this.groupBox1.Controls.Add(this.btnModifPer);
            this.groupBox1.Location = new System.Drawing.Point(349, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnGenPer
            // 
            this.btnGenPer.Enabled = false;
            this.btnGenPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPer.Location = new System.Drawing.Point(6, 70);
            this.btnGenPer.Name = "btnGenPer";
            this.btnGenPer.Size = new System.Drawing.Size(80, 36);
            this.btnGenPer.TabIndex = 1;
            this.btnGenPer.Text = "Générer";
            this.btnGenPer.UseVisualStyleBackColor = true;
            this.btnGenPer.Click += new System.EventHandler(this.BtnGenPer_Click);
            // 
            // txtPer
            // 
            this.txtPer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPer.Location = new System.Drawing.Point(6, 45);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(80, 22);
            this.txtPer.TabIndex = 0;
            this.txtPer.TextChanged += new System.EventHandler(this.TxtPer_TextChanged);
            this.txtPer.Enter += new System.EventHandler(this.TxtPer_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Période";
            // 
            // btnSuppPer
            // 
            this.btnSuppPer.Enabled = false;
            this.btnSuppPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppPer.Location = new System.Drawing.Point(6, 112);
            this.btnSuppPer.Name = "btnSuppPer";
            this.btnSuppPer.Size = new System.Drawing.Size(80, 36);
            this.btnSuppPer.TabIndex = 2;
            this.btnSuppPer.Text = "Supprimer";
            this.btnSuppPer.UseVisualStyleBackColor = true;
            this.btnSuppPer.Click += new System.EventHandler(this.BtnSuppPer_Click);
            // 
            // btnModifPer
            // 
            this.btnModifPer.Enabled = false;
            this.btnModifPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPer.Location = new System.Drawing.Point(6, 154);
            this.btnModifPer.Name = "btnModifPer";
            this.btnModifPer.Size = new System.Drawing.Size(80, 36);
            this.btnModifPer.TabIndex = 3;
            this.btnModifPer.Text = "Modifier";
            this.btnModifPer.UseVisualStyleBackColor = true;
            this.btnModifPer.Click += new System.EventHandler(this.BtnModifPer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fin";
            // 
            // btnAjoutEPer
            // 
            this.btnAjoutEPer.Enabled = false;
            this.btnAjoutEPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutEPer.Location = new System.Drawing.Point(355, 258);
            this.btnAjoutEPer.Name = "btnAjoutEPer";
            this.btnAjoutEPer.Size = new System.Drawing.Size(80, 36);
            this.btnAjoutEPer.TabIndex = 6;
            this.btnAjoutEPer.Text = "Ajouter";
            this.btnAjoutEPer.UseVisualStyleBackColor = true;
            this.btnAjoutEPer.Click += new System.EventHandler(this.BtnAjoutEPer_Click);
            // 
            // txtFinHr
            // 
            this.txtFinHr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinHr.Location = new System.Drawing.Point(80, 51);
            this.txtFinHr.Name = "txtFinHr";
            this.txtFinHr.Size = new System.Drawing.Size(50, 22);
            this.txtFinHr.TabIndex = 2;
            this.txtFinHr.Text = "heure";
            this.txtFinHr.TextChanged += new System.EventHandler(this.TxtFinHr_TextChanged);
            this.txtFinHr.Enter += new System.EventHandler(this.TxtFinHr_Enter);
            this.txtFinHr.Leave += new System.EventHandler(this.TxtFinHr_Leave);
            // 
            // txtDebHr
            // 
            this.txtDebHr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebHr.Location = new System.Drawing.Point(80, 22);
            this.txtDebHr.Name = "txtDebHr";
            this.txtDebHr.Size = new System.Drawing.Size(50, 22);
            this.txtDebHr.TabIndex = 0;
            this.txtDebHr.Text = "heure";
            this.txtDebHr.TextChanged += new System.EventHandler(this.TxtDebHr_TextChanged);
            this.txtDebHr.Enter += new System.EventHandler(this.TxtDebHr_Enter);
            this.txtDebHr.Leave += new System.EventHandler(this.TxtDebHr_Leave);
            // 
            // txtFinMn
            // 
            this.txtFinMn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinMn.Location = new System.Drawing.Point(144, 51);
            this.txtFinMn.Name = "txtFinMn";
            this.txtFinMn.Size = new System.Drawing.Size(50, 22);
            this.txtFinMn.TabIndex = 3;
            this.txtFinMn.Text = "minute";
            this.txtFinMn.TextChanged += new System.EventHandler(this.TxtFinMn_TextChanged);
            this.txtFinMn.Enter += new System.EventHandler(this.TxtFinMn_Enter);
            this.txtFinMn.Leave += new System.EventHandler(this.TxtFinMn_Leave);
            // 
            // txtDebMn
            // 
            this.txtDebMn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebMn.Location = new System.Drawing.Point(144, 22);
            this.txtDebMn.Name = "txtDebMn";
            this.txtDebMn.Size = new System.Drawing.Size(50, 22);
            this.txtDebMn.TabIndex = 1;
            this.txtDebMn.Text = "minute";
            this.txtDebMn.TextChanged += new System.EventHandler(this.TxtDebMn_TextChanged);
            this.txtDebMn.Enter += new System.EventHandler(this.TxtDebMn_Enter);
            this.txtDebMn.Leave += new System.EventHandler(this.TxtDebMn_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = ":";
            // 
            // lsvPer
            // 
            this.lsvPer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvPer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPer.FullRowSelect = true;
            this.lsvPer.HideSelection = false;
            this.lsvPer.Location = new System.Drawing.Point(16, 82);
            this.lsvPer.Name = "lsvPer";
            this.lsvPer.Size = new System.Drawing.Size(219, 212);
            this.lsvPer.TabIndex = 4;
            this.lsvPer.UseCompatibleStateImageBehavior = false;
            this.lsvPer.View = System.Windows.Forms.View.Details;
            this.lsvPer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvPer_ColumnClick);
            this.lsvPer.SelectedIndexChanged += new System.EventHandler(this.LsvPer_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            this.columnHeader4.Width = 41;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Début";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fin";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Durée";
            // 
            // clbJours
            // 
            this.clbJours.CheckOnClick = true;
            this.clbJours.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbJours.FormattingEnabled = true;
            this.clbJours.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.clbJours.Location = new System.Drawing.Point(241, 82);
            this.clbJours.Name = "clbJours";
            this.clbJours.Size = new System.Drawing.Size(102, 166);
            this.clbJours.TabIndex = 5;
            // 
            // FrmModifPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 306);
            this.Controls.Add(this.clbJours);
            this.Controls.Add(this.lsvPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinMn);
            this.Controls.Add(this.txtDebMn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjoutEPer);
            this.Controls.Add(this.txtFinHr);
            this.Controls.Add(this.txtDebHr);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmModifPer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuppPer;
        private System.Windows.Forms.Button btnModifPer;
        private System.Windows.Forms.Button btnAjoutEPer;
        private System.Windows.Forms.TextBox txtFinHr;
        private System.Windows.Forms.TextBox txtDebHr;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.TextBox txtFinMn;
        private System.Windows.Forms.TextBox txtDebMn;
        private System.Windows.Forms.Button btnGenPer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsvPer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckedListBox clbJours;
    }
}