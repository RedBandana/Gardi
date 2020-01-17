namespace Gardi
{
    partial class FrmModifEmpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifEmpl));
            this.txtIDEmpl = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnAjoutEmpl = new System.Windows.Forms.Button();
            this.btnModifEmpl = new System.Windows.Forms.Button();
            this.btnSuppEmpl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenEmpl = new System.Windows.Forms.Button();
            this.lsvEmp = new System.Windows.Forms.ListView();
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDEmpl
            // 
            this.txtIDEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmpl.Location = new System.Drawing.Point(382, 52);
            this.txtIDEmpl.Name = "txtIDEmpl";
            this.txtIDEmpl.Size = new System.Drawing.Size(84, 23);
            this.txtIDEmpl.TabIndex = 3;
            this.txtIDEmpl.TextChanged += new System.EventHandler(this.TxtIDEmpl_TextChanged);
            this.txtIDEmpl.Enter += new System.EventHandler(this.TxtIDEmpl_Enter);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(113, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(192, 23);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.TxtNom_Enter);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(113, 50);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(192, 23);
            this.txtPrenom.TabIndex = 1;
            this.txtPrenom.TextChanged += new System.EventHandler(this.TxtPrenom_TextChanged);
            this.txtPrenom.Enter += new System.EventHandler(this.TxtPrenom_Enter);
            // 
            // btnAjoutEmpl
            // 
            this.btnAjoutEmpl.Enabled = false;
            this.btnAjoutEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutEmpl.Location = new System.Drawing.Point(6, 69);
            this.btnAjoutEmpl.Name = "btnAjoutEmpl";
            this.btnAjoutEmpl.Size = new System.Drawing.Size(84, 36);
            this.btnAjoutEmpl.TabIndex = 0;
            this.btnAjoutEmpl.Text = "Ajouter";
            this.btnAjoutEmpl.UseVisualStyleBackColor = true;
            this.btnAjoutEmpl.Click += new System.EventHandler(this.BtnAjoutEmpl_Click);
            // 
            // btnModifEmpl
            // 
            this.btnModifEmpl.Enabled = false;
            this.btnModifEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifEmpl.Location = new System.Drawing.Point(6, 195);
            this.btnModifEmpl.Name = "btnModifEmpl";
            this.btnModifEmpl.Size = new System.Drawing.Size(84, 36);
            this.btnModifEmpl.TabIndex = 3;
            this.btnModifEmpl.Text = "Modifier";
            this.btnModifEmpl.UseVisualStyleBackColor = true;
            this.btnModifEmpl.Click += new System.EventHandler(this.BtnModifEmpl_Click);
            // 
            // btnSuppEmpl
            // 
            this.btnSuppEmpl.Enabled = false;
            this.btnSuppEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppEmpl.Location = new System.Drawing.Point(6, 153);
            this.btnSuppEmpl.Name = "btnSuppEmpl";
            this.btnSuppEmpl.Size = new System.Drawing.Size(84, 36);
            this.btnSuppEmpl.TabIndex = 2;
            this.btnSuppEmpl.Text = "Supprimer";
            this.btnSuppEmpl.UseVisualStyleBackColor = true;
            this.btnSuppEmpl.Click += new System.EventHandler(this.BtnSuppEmpl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenEmpl);
            this.groupBox1.Controls.Add(this.btnSuppEmpl);
            this.groupBox1.Controls.Add(this.btnAjoutEmpl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModifEmpl);
            this.groupBox1.Location = new System.Drawing.Point(376, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnGenEmpl
            // 
            this.btnGenEmpl.Enabled = false;
            this.btnGenEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenEmpl.Location = new System.Drawing.Point(6, 111);
            this.btnGenEmpl.Name = "btnGenEmpl";
            this.btnGenEmpl.Size = new System.Drawing.Size(84, 36);
            this.btnGenEmpl.TabIndex = 1;
            this.btnGenEmpl.Text = "Générer";
            this.btnGenEmpl.UseVisualStyleBackColor = true;
            this.btnGenEmpl.Click += new System.EventHandler(this.BtnGenEmpl_Click);
            // 
            // lsvEmp
            // 
            this.lsvEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.clhDate});
            this.lsvEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEmp.FullRowSelect = true;
            this.lsvEmp.HideSelection = false;
            this.lsvEmp.Location = new System.Drawing.Point(12, 81);
            this.lsvEmp.Name = "lsvEmp";
            this.lsvEmp.Size = new System.Drawing.Size(346, 211);
            this.lsvEmp.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvEmp.TabIndex = 2;
            this.lsvEmp.UseCompatibleStateImageBehavior = false;
            this.lsvEmp.View = System.Windows.Forms.View.Details;
            this.lsvEmp.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvEmp_ColumnClick);
            this.lsvEmp.SelectedIndexChanged += new System.EventHandler(this.LsvEmp_SelectedIndexChanged);
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 52;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Période de garde";
            this.columnHeader3.Width = 89;
            // 
            // clhDate
            // 
            this.clhDate.Text = "Date de garde";
            this.clhDate.Width = 78;
            // 
            // FrmModifEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 304);
            this.Controls.Add(this.lsvEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtIDEmpl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmModifEmpl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDEmpl;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnAjoutEmpl;
        private System.Windows.Forms.Button btnModifEmpl;
        private System.Windows.Forms.Button btnSuppEmpl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenEmpl;
        private System.Windows.Forms.ListView lsvEmp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader clhDate;
        private System.Windows.Forms.ColumnHeader clhID;
    }
}