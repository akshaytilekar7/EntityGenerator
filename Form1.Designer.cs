namespace EntityGenerator
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
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtEntityLocation = new System.Windows.Forms.TextBox();
            this.lblEntityLocation = new System.Windows.Forms.Label();
            this.cmbDBNames = new System.Windows.Forms.ComboBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lblNameSpaceName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(74, 120);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 27;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(72, 104);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(331, 373);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(223, 312);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtEntityLocation
            // 
            this.txtEntityLocation.Location = new System.Drawing.Point(303, 314);
            this.txtEntityLocation.Name = "txtEntityLocation";
            this.txtEntityLocation.Size = new System.Drawing.Size(398, 20);
            this.txtEntityLocation.TabIndex = 22;
            // 
            // lblEntityLocation
            // 
            this.lblEntityLocation.AutoSize = true;
            this.lblEntityLocation.Location = new System.Drawing.Point(72, 317);
            this.lblEntityLocation.Name = "lblEntityLocation";
            this.lblEntityLocation.Size = new System.Drawing.Size(77, 13);
            this.lblEntityLocation.TabIndex = 21;
            this.lblEntityLocation.Text = "Entity Location";
            // 
            // cmbDBNames
            // 
            this.cmbDBNames.FormattingEnabled = true;
            this.cmbDBNames.Location = new System.Drawing.Point(223, 249);
            this.cmbDBNames.Name = "cmbDBNames";
            this.cmbDBNames.Size = new System.Drawing.Size(478, 21);
            this.cmbDBNames.TabIndex = 20;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(72, 258);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatabaseName.TabIndex = 19;
            this.lblDatabaseName.Text = "Database Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(223, 203);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(478, 20);
            this.txtServerName.TabIndex = 18;
            this.txtServerName.Leave += new System.EventHandler(this.txtServerName_Leave);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(72, 203);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 17;
            this.lblServerName.Text = "Server Name";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(223, 146);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(478, 20);
            this.txtNamespace.TabIndex = 16;
            // 
            // lblNameSpaceName
            // 
            this.lblNameSpaceName.AutoSize = true;
            this.lblNameSpaceName.Location = new System.Drawing.Point(72, 146);
            this.lblNameSpaceName.Name = "lblNameSpaceName";
            this.lblNameSpaceName.Size = new System.Drawing.Size(97, 13);
            this.lblNameSpaceName.TabIndex = 15;
            this.lblNameSpaceName.Text = "NameSpace Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 23);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Entity Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 453);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtEntityLocation);
            this.Controls.Add(this.lblEntityLocation);
            this.Controls.Add(this.cmbDBNames);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.lblNameSpaceName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtEntityLocation;
        private System.Windows.Forms.Label lblEntityLocation;
        private System.Windows.Forms.ComboBox cmbDBNames;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label lblNameSpaceName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

