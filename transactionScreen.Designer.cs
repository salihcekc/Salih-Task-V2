namespace Task_Level2_Test_App2
{
    partial class transactionScreen
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.personalID_txt = new System.Windows.Forms.TextBox();
            this.hireDate_txt = new System.Windows.Forms.TextBox();
            this.deleteID_txt = new System.Windows.Forms.TextBox();
            this.updateLname_txt = new System.Windows.Forms.TextBox();
            this.updateFname_txt = new System.Windows.Forms.TextBox();
            this.updatePid_txt = new System.Windows.Forms.TextBox();
            this.updateHdate_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.personalID_lbl = new System.Windows.Forms.Label();
            this.hireDate_lbl = new System.Windows.Forms.Label();
            this.deleteID_lbl = new System.Windows.Forms.Label();
            this.updatePid_lbl = new System.Windows.Forms.Label();
            this.updateLname_lbl = new System.Windows.Forms.Label();
            this.updateFname_lbl = new System.Windows.Forms.Label();
            this.updateHdate_lbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(0, 0);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(558, 246);
            this.dataTable.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(259, 266);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 471);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(140, 266);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(8, 266);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(113, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(871, 471);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(871, 331);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(100, 20);
            this.ID_txt.TabIndex = 8;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(871, 357);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(100, 20);
            this.lastName_txt.TabIndex = 9;
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(871, 383);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(100, 20);
            this.firstName_txt.TabIndex = 10;
            // 
            // personalID_txt
            // 
            this.personalID_txt.Location = new System.Drawing.Point(871, 409);
            this.personalID_txt.Name = "personalID_txt";
            this.personalID_txt.Size = new System.Drawing.Size(100, 20);
            this.personalID_txt.TabIndex = 11;
            // 
            // hireDate_txt
            // 
            this.hireDate_txt.Location = new System.Drawing.Point(871, 437);
            this.hireDate_txt.Name = "hireDate_txt";
            this.hireDate_txt.Size = new System.Drawing.Size(100, 20);
            this.hireDate_txt.TabIndex = 12;
            // 
            // deleteID_txt
            // 
            this.deleteID_txt.Location = new System.Drawing.Point(604, 441);
            this.deleteID_txt.Name = "deleteID_txt";
            this.deleteID_txt.Size = new System.Drawing.Size(113, 20);
            this.deleteID_txt.TabIndex = 13;
            // 
            // updateLname_txt
            // 
            this.updateLname_txt.Location = new System.Drawing.Point(287, 393);
            this.updateLname_txt.Name = "updateLname_txt";
            this.updateLname_txt.Size = new System.Drawing.Size(100, 20);
            this.updateLname_txt.TabIndex = 15;
            // 
            // updateFname_txt
            // 
            this.updateFname_txt.Location = new System.Drawing.Point(287, 419);
            this.updateFname_txt.Name = "updateFname_txt";
            this.updateFname_txt.Size = new System.Drawing.Size(100, 20);
            this.updateFname_txt.TabIndex = 16;
            // 
            // updatePid_txt
            // 
            this.updatePid_txt.Location = new System.Drawing.Point(287, 367);
            this.updatePid_txt.Name = "updatePid_txt";
            this.updatePid_txt.Size = new System.Drawing.Size(100, 20);
            this.updatePid_txt.TabIndex = 17;
            // 
            // updateHdate_txt
            // 
            this.updateHdate_txt.Location = new System.Drawing.Point(287, 445);
            this.updateHdate_txt.Name = "updateHdate_txt";
            this.updateHdate_txt.Size = new System.Drawing.Size(100, 20);
            this.updateHdate_txt.TabIndex = 18;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(788, 338);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(21, 13);
            this.ID_lbl.TabIndex = 19;
            this.ID_lbl.Text = "ID:";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(788, 364);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(61, 13);
            this.lastName_lbl.TabIndex = 20;
            this.lastName_lbl.Text = "Last Name:";
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.Location = new System.Drawing.Point(788, 390);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(60, 13);
            this.firstName_lbl.TabIndex = 21;
            this.firstName_lbl.Text = "First Name:";
            // 
            // personalID_lbl
            // 
            this.personalID_lbl.AutoSize = true;
            this.personalID_lbl.Location = new System.Drawing.Point(788, 416);
            this.personalID_lbl.Name = "personalID_lbl";
            this.personalID_lbl.Size = new System.Drawing.Size(65, 13);
            this.personalID_lbl.TabIndex = 22;
            this.personalID_lbl.Text = "Personal ID:";
            // 
            // hireDate_lbl
            // 
            this.hireDate_lbl.AutoSize = true;
            this.hireDate_lbl.Location = new System.Drawing.Point(788, 444);
            this.hireDate_lbl.Name = "hireDate_lbl";
            this.hireDate_lbl.Size = new System.Drawing.Size(55, 13);
            this.hireDate_lbl.TabIndex = 23;
            this.hireDate_lbl.Text = "Hire Date:";
            // 
            // deleteID_lbl
            // 
            this.deleteID_lbl.AutoSize = true;
            this.deleteID_lbl.Location = new System.Drawing.Point(523, 448);
            this.deleteID_lbl.Name = "deleteID_lbl";
            this.deleteID_lbl.Size = new System.Drawing.Size(55, 13);
            this.deleteID_lbl.TabIndex = 24;
            this.deleteID_lbl.Text = "Delete ID:";
            // 
            // updatePid_lbl
            // 
            this.updatePid_lbl.AutoSize = true;
            this.updatePid_lbl.Location = new System.Drawing.Point(168, 374);
            this.updatePid_lbl.Name = "updatePid_lbl";
            this.updatePid_lbl.Size = new System.Drawing.Size(65, 13);
            this.updatePid_lbl.TabIndex = 25;
            this.updatePid_lbl.Text = "Personal ID:";
            // 
            // updateLname_lbl
            // 
            this.updateLname_lbl.AutoSize = true;
            this.updateLname_lbl.Location = new System.Drawing.Point(168, 400);
            this.updateLname_lbl.Name = "updateLname_lbl";
            this.updateLname_lbl.Size = new System.Drawing.Size(99, 13);
            this.updateLname_lbl.TabIndex = 26;
            this.updateLname_lbl.Text = "Update Last Name:";
            // 
            // updateFname_lbl
            // 
            this.updateFname_lbl.AutoSize = true;
            this.updateFname_lbl.Location = new System.Drawing.Point(168, 426);
            this.updateFname_lbl.Name = "updateFname_lbl";
            this.updateFname_lbl.Size = new System.Drawing.Size(98, 13);
            this.updateFname_lbl.TabIndex = 27;
            this.updateFname_lbl.Text = "Update First Name:";
            // 
            // updateHdate_lbl
            // 
            this.updateHdate_lbl.AutoSize = true;
            this.updateHdate_lbl.Location = new System.Drawing.Point(168, 452);
            this.updateHdate_lbl.Name = "updateHdate_lbl";
            this.updateHdate_lbl.Size = new System.Drawing.Size(93, 13);
            this.updateHdate_lbl.TabIndex = 28;
            this.updateHdate_lbl.Text = "Update Hire Date:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(656, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 78);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // transactionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.updateHdate_lbl);
            this.Controls.Add(this.updateFname_lbl);
            this.Controls.Add(this.updateLname_lbl);
            this.Controls.Add(this.updatePid_lbl);
            this.Controls.Add(this.deleteID_lbl);
            this.Controls.Add(this.hireDate_lbl);
            this.Controls.Add(this.personalID_lbl);
            this.Controls.Add(this.firstName_lbl);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.updateHdate_txt);
            this.Controls.Add(this.updatePid_txt);
            this.Controls.Add(this.updateFname_txt);
            this.Controls.Add(this.updateLname_txt);
            this.Controls.Add(this.deleteID_txt);
            this.Controls.Add(this.hireDate_txt);
            this.Controls.Add(this.personalID_txt);
            this.Controls.Add(this.firstName_txt);
            this.Controls.Add(this.lastName_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataTable);
            this.Name = "transactionScreen";
            this.Text = "transactionScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.TextBox personalID_txt;
        private System.Windows.Forms.TextBox hireDate_txt;
        private System.Windows.Forms.TextBox deleteID_txt;
        private System.Windows.Forms.TextBox updateLname_txt;
        private System.Windows.Forms.TextBox updateFname_txt;
        private System.Windows.Forms.TextBox updatePid_txt;
        private System.Windows.Forms.TextBox updateHdate_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.Label personalID_lbl;
        private System.Windows.Forms.Label hireDate_lbl;
        private System.Windows.Forms.Label deleteID_lbl;
        private System.Windows.Forms.Label updatePid_lbl;
        private System.Windows.Forms.Label updateLname_lbl;
        private System.Windows.Forms.Label updateFname_lbl;
        private System.Windows.Forms.Label updateHdate_lbl;
        private System.Windows.Forms.Button btnExit;
    }
}