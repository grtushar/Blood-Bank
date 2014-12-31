namespace BloodBank3._2_1
{
    partial class mainForm
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
            this.choicePanel = new System.Windows.Forms.Panel();
            this.cliPanel1 = new System.Windows.Forms.Panel();
            this.cliButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cliPanel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.strPanel1 = new System.Windows.Forms.Panel();
            this.strButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.strPanel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.donPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.donButton = new System.Windows.Forms.Button();
            this.donPanel2 = new System.Windows.Forms.Panel();
            this.deleteDonorButton = new System.Windows.Forms.Button();
            this.editDonorButton = new System.Windows.Forms.Button();
            this.newDonorButton = new System.Windows.Forms.Button();
            this.delLab = new System.Windows.Forms.Label();
            this.updLab = new System.Windows.Forms.Label();
            this.insLab = new System.Windows.Forms.Label();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.deleteForm1 = new BloodBank3._2_1.deleteForm();
            this.editForm1 = new BloodBank3._2_1.editForm();
            this.donorData1 = new BloodBank3._2_1.donorData();
            this.insForm = new BloodBank3._2_1.insertForm();
            this.choicePanel.SuspendLayout();
            this.cliPanel1.SuspendLayout();
            this.cliPanel2.SuspendLayout();
            this.strPanel1.SuspendLayout();
            this.strPanel2.SuspendLayout();
            this.donPanel1.SuspendLayout();
            this.donPanel2.SuspendLayout();
            this.operationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // choicePanel
            // 
            this.choicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.choicePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.choicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choicePanel.Controls.Add(this.cliPanel1);
            this.choicePanel.Controls.Add(this.strPanel1);
            this.choicePanel.Controls.Add(this.donPanel1);
            this.choicePanel.Location = new System.Drawing.Point(12, 12);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(196, 500);
            this.choicePanel.TabIndex = 0;
            // 
            // cliPanel1
            // 
            this.cliPanel1.Controls.Add(this.cliButton);
            this.cliPanel1.Controls.Add(this.label7);
            this.cliPanel1.Controls.Add(this.cliPanel2);
            this.cliPanel1.Location = new System.Drawing.Point(12, 53);
            this.cliPanel1.Name = "cliPanel1";
            this.cliPanel1.Size = new System.Drawing.Size(169, 100);
            this.cliPanel1.TabIndex = 11;
            // 
            // cliButton
            // 
            this.cliButton.Location = new System.Drawing.Point(3, 3);
            this.cliButton.Name = "cliButton";
            this.cliButton.Size = new System.Drawing.Size(10, 13);
            this.cliButton.TabIndex = 8;
            this.cliButton.Text = "+";
            this.cliButton.UseVisualStyleBackColor = true;
            this.cliButton.Click += new System.EventHandler(this.cliButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Client";
            // 
            // cliPanel2
            // 
            this.cliPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliPanel2.Controls.Add(this.label10);
            this.cliPanel2.Controls.Add(this.label9);
            this.cliPanel2.Controls.Add(this.label8);
            this.cliPanel2.Location = new System.Drawing.Point(16, 20);
            this.cliPanel2.Name = "cliPanel2";
            this.cliPanel2.Size = new System.Drawing.Size(153, 68);
            this.cliPanel2.TabIndex = 6;
            this.cliPanel2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Delete Client";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Edit Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "New Client";
            // 
            // strPanel1
            // 
            this.strPanel1.Controls.Add(this.strButton);
            this.strPanel1.Controls.Add(this.label2);
            this.strPanel1.Controls.Add(this.strPanel2);
            this.strPanel1.Location = new System.Drawing.Point(12, 35);
            this.strPanel1.Name = "strPanel1";
            this.strPanel1.Size = new System.Drawing.Size(169, 111);
            this.strPanel1.TabIndex = 10;
            // 
            // strButton
            // 
            this.strButton.Location = new System.Drawing.Point(3, 3);
            this.strButton.Name = "strButton";
            this.strButton.Size = new System.Drawing.Size(10, 13);
            this.strButton.TabIndex = 4;
            this.strButton.Text = "+";
            this.strButton.UseVisualStyleBackColor = true;
            this.strButton.Click += new System.EventHandler(this.strButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Storage";
            // 
            // strPanel2
            // 
            this.strPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strPanel2.Controls.Add(this.label6);
            this.strPanel2.Controls.Add(this.label5);
            this.strPanel2.Controls.Add(this.label4);
            this.strPanel2.Controls.Add(this.label3);
            this.strPanel2.Location = new System.Drawing.Point(16, 20);
            this.strPanel2.Name = "strPanel2";
            this.strPanel2.Size = new System.Drawing.Size(153, 85);
            this.strPanel2.TabIndex = 5;
            this.strPanel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expired Blood";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delete Storage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edit Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Storage";
            // 
            // donPanel1
            // 
            this.donPanel1.Controls.Add(this.label1);
            this.donPanel1.Controls.Add(this.donButton);
            this.donPanel1.Controls.Add(this.donPanel2);
            this.donPanel1.Location = new System.Drawing.Point(12, 17);
            this.donPanel1.Name = "donPanel1";
            this.donPanel1.Size = new System.Drawing.Size(169, 91);
            this.donPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donor";
            // 
            // donButton
            // 
            this.donButton.Location = new System.Drawing.Point(3, 3);
            this.donButton.Name = "donButton";
            this.donButton.Size = new System.Drawing.Size(10, 13);
            this.donButton.TabIndex = 2;
            this.donButton.Text = "+";
            this.donButton.UseVisualStyleBackColor = true;
            this.donButton.Click += new System.EventHandler(this.donButton_Click);
            // 
            // donPanel2
            // 
            this.donPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donPanel2.Controls.Add(this.deleteDonorButton);
            this.donPanel2.Controls.Add(this.editDonorButton);
            this.donPanel2.Controls.Add(this.newDonorButton);
            this.donPanel2.Controls.Add(this.delLab);
            this.donPanel2.Controls.Add(this.updLab);
            this.donPanel2.Controls.Add(this.insLab);
            this.donPanel2.Location = new System.Drawing.Point(16, 20);
            this.donPanel2.Name = "donPanel2";
            this.donPanel2.Size = new System.Drawing.Size(153, 65);
            this.donPanel2.TabIndex = 1;
            this.donPanel2.Visible = false;
            // 
            // deleteDonorButton
            // 
            this.deleteDonorButton.Location = new System.Drawing.Point(3, 48);
            this.deleteDonorButton.Name = "deleteDonorButton";
            this.deleteDonorButton.Size = new System.Drawing.Size(10, 10);
            this.deleteDonorButton.TabIndex = 5;
            this.deleteDonorButton.UseVisualStyleBackColor = true;
            this.deleteDonorButton.Click += new System.EventHandler(this.deleteDonorButton_Click);
            // 
            // editDonorButton
            // 
            this.editDonorButton.Location = new System.Drawing.Point(3, 26);
            this.editDonorButton.Name = "editDonorButton";
            this.editDonorButton.Size = new System.Drawing.Size(10, 10);
            this.editDonorButton.TabIndex = 4;
            this.editDonorButton.UseVisualStyleBackColor = true;
            this.editDonorButton.Click += new System.EventHandler(this.editDonorButton_Click);
            // 
            // newDonorButton
            // 
            this.newDonorButton.Location = new System.Drawing.Point(3, 3);
            this.newDonorButton.Name = "newDonorButton";
            this.newDonorButton.Size = new System.Drawing.Size(10, 10);
            this.newDonorButton.TabIndex = 3;
            this.newDonorButton.UseVisualStyleBackColor = true;
            this.newDonorButton.Click += new System.EventHandler(this.newDonorButton_Click);
            // 
            // delLab
            // 
            this.delLab.AutoSize = true;
            this.delLab.Location = new System.Drawing.Point(14, 47);
            this.delLab.Name = "delLab";
            this.delLab.Size = new System.Drawing.Size(70, 13);
            this.delLab.TabIndex = 2;
            this.delLab.Text = "Delete Donor";
            // 
            // updLab
            // 
            this.updLab.AutoSize = true;
            this.updLab.Location = new System.Drawing.Point(14, 25);
            this.updLab.Name = "updLab";
            this.updLab.Size = new System.Drawing.Size(57, 13);
            this.updLab.TabIndex = 1;
            this.updLab.Text = "Edit Donor";
            // 
            // insLab
            // 
            this.insLab.AutoSize = true;
            this.insLab.Location = new System.Drawing.Point(14, 2);
            this.insLab.Name = "insLab";
            this.insLab.Size = new System.Drawing.Size(61, 13);
            this.insLab.TabIndex = 0;
            this.insLab.Text = "New Donor";
            // 
            // operationPanel
            // 
            this.operationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.operationPanel.Controls.Add(this.deleteForm1);
            this.operationPanel.Controls.Add(this.editForm1);
            this.operationPanel.Controls.Add(this.donorData1);
            this.operationPanel.Controls.Add(this.insForm);
            this.operationPanel.Location = new System.Drawing.Point(214, 12);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(672, 503);
            this.operationPanel.TabIndex = 1;
            // 
            // deleteForm1
            // 
            this.deleteForm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteForm1.Location = new System.Drawing.Point(0, 0);
            this.deleteForm1.Name = "deleteForm1";
            this.deleteForm1.Size = new System.Drawing.Size(672, 233);
            this.deleteForm1.TabIndex = 3;
            this.deleteForm1.Visible = false;
            // 
            // editForm1
            // 
            this.editForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editForm1.BackColor = System.Drawing.SystemColors.Control;
            this.editForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editForm1.Location = new System.Drawing.Point(0, 0);
            this.editForm1.Name = "editForm1";
            this.editForm1.Size = new System.Drawing.Size(672, 233);
            this.editForm1.TabIndex = 2;
            this.editForm1.Visible = false;
            // 
            // donorData1
            // 
            this.donorData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donorData1.BackColor = System.Drawing.SystemColors.Control;
            this.donorData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            this.donorData1.Name = "donorData1";
            this.donorData1.Size = new System.Drawing.Size(672, 263);
            this.donorData1.TabIndex = 1;
            // 
            // insForm
            // 
            this.insForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insForm.BackColor = System.Drawing.SystemColors.Control;
            this.insForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insForm.Location = new System.Drawing.Point(0, 0);
            this.insForm.Name = "insForm";
            this.insForm.Size = new System.Drawing.Size(672, 233);
            this.insForm.TabIndex = 0;
            this.insForm.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 522);
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.choicePanel);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.choicePanel.ResumeLayout(false);
            this.cliPanel1.ResumeLayout(false);
            this.cliPanel1.PerformLayout();
            this.cliPanel2.ResumeLayout(false);
            this.cliPanel2.PerformLayout();
            this.strPanel1.ResumeLayout(false);
            this.strPanel1.PerformLayout();
            this.strPanel2.ResumeLayout(false);
            this.strPanel2.PerformLayout();
            this.donPanel1.ResumeLayout(false);
            this.donPanel1.PerformLayout();
            this.donPanel2.ResumeLayout(false);
            this.donPanel2.PerformLayout();
            this.operationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Panel donPanel2;
        private System.Windows.Forms.Label delLab;
        private System.Windows.Forms.Label updLab;
        private System.Windows.Forms.Label insLab;
        private System.Windows.Forms.Button donButton;
        private insertForm insForm;
        private donorData donorData1;
        private System.Windows.Forms.Panel cliPanel1;
        private System.Windows.Forms.Button cliButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel cliPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel donPanel1;
        private System.Windows.Forms.Panel strPanel1;
        private System.Windows.Forms.Button strButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel strPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newDonorButton;
        private System.Windows.Forms.Button deleteDonorButton;
        private System.Windows.Forms.Button editDonorButton;
        private editForm editForm1;
        private deleteForm deleteForm1;
    }
}