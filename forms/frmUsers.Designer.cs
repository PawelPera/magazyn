namespace Magazyn
{
    partial class frmUsers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshData = new System.Windows.Forms.Button();
            this.modyfiUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.refreshData);
            this.groupBox1.Controls.Add(this.modyfiUser);
            this.groupBox1.Controls.Add(this.deleteUser);
            this.groupBox1.Controls.Add(this.addUser);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 381);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel użytkowników";
            // 
            // refreshData
            // 
            this.refreshData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshData.Location = new System.Drawing.Point(641, 301);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(113, 74);
            this.refreshData.TabIndex = 5;
            this.refreshData.Text = "Odśwież widok";
            this.refreshData.UseVisualStyleBackColor = true;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // modyfiUser
            // 
            this.modyfiUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modyfiUser.Location = new System.Drawing.Point(244, 301);
            this.modyfiUser.Name = "modyfiUser";
            this.modyfiUser.Size = new System.Drawing.Size(113, 74);
            this.modyfiUser.TabIndex = 4;
            this.modyfiUser.Text = "Zmień dane użytkownika";
            this.modyfiUser.UseVisualStyleBackColor = true;
            this.modyfiUser.Click += new System.EventHandler(this.modyfiUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteUser.Location = new System.Drawing.Point(125, 301);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(113, 74);
            this.deleteUser.TabIndex = 3;
            this.deleteUser.Text = "Usuń użytkownika";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUser.Location = new System.Drawing.Point(6, 301);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(113, 74);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Dodaj użytkownika";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 19);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(748, 273);
            this.dataGridView.TabIndex = 1;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzanie Użytkownikami";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshData;
        private System.Windows.Forms.Button modyfiUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}