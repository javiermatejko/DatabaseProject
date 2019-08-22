namespace PrimeraAplicacionConDB
{
    partial class ProgramForm
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
            this.dgvElements = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tboxModifyName = new System.Windows.Forms.TextBox();
            this.gboxModify = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxModifyPrice = new System.Windows.Forms.TextBox();
            this.tboxModifyTag = new System.Windows.Forms.TextBox();
            this.yboxModifyValidation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).BeginInit();
            this.gboxModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvElements
            // 
            this.dgvElements.AllowUserToAddRows = false;
            this.dgvElements.AllowUserToDeleteRows = false;
            this.dgvElements.AllowUserToResizeColumns = false;
            this.dgvElements.AllowUserToResizeRows = false;
            this.dgvElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElements.Location = new System.Drawing.Point(12, 131);
            this.dgvElements.Name = "dgvElements";
            this.dgvElements.ReadOnly = true;
            this.dgvElements.Size = new System.Drawing.Size(439, 307);
            this.dgvElements.TabIndex = 0;
            this.dgvElements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElements_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(63, 178);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(174, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tboxModifyName
            // 
            this.tboxModifyName.Location = new System.Drawing.Point(63, 36);
            this.tboxModifyName.Name = "tboxModifyName";
            this.tboxModifyName.Size = new System.Drawing.Size(131, 20);
            this.tboxModifyName.TabIndex = 4;
            // 
            // gboxModify
            // 
            this.gboxModify.Controls.Add(this.label4);
            this.gboxModify.Controls.Add(this.label3);
            this.gboxModify.Controls.Add(this.label2);
            this.gboxModify.Controls.Add(this.label1);
            this.gboxModify.Controls.Add(this.btnApply);
            this.gboxModify.Controls.Add(this.yboxModifyValidation);
            this.gboxModify.Controls.Add(this.tboxModifyTag);
            this.gboxModify.Controls.Add(this.tboxModifyPrice);
            this.gboxModify.Controls.Add(this.tboxModifyName);
            this.gboxModify.Location = new System.Drawing.Point(506, 131);
            this.gboxModify.Name = "gboxModify";
            this.gboxModify.Size = new System.Drawing.Size(200, 214);
            this.gboxModify.TabIndex = 4;
            this.gboxModify.TabStop = false;
            this.gboxModify.Text = "MODIFY OPTIONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Validation:";
            // 
            // tboxModifyPrice
            // 
            this.tboxModifyPrice.Location = new System.Drawing.Point(63, 72);
            this.tboxModifyPrice.Name = "tboxModifyPrice";
            this.tboxModifyPrice.Size = new System.Drawing.Size(131, 20);
            this.tboxModifyPrice.TabIndex = 5;
            // 
            // tboxModifyTag
            // 
            this.tboxModifyTag.Location = new System.Drawing.Point(63, 108);
            this.tboxModifyTag.Name = "tboxModifyTag";
            this.tboxModifyTag.Size = new System.Drawing.Size(131, 20);
            this.tboxModifyTag.TabIndex = 6;
            // 
            // yboxModifyValidation
            // 
            this.yboxModifyValidation.Location = new System.Drawing.Point(63, 141);
            this.yboxModifyValidation.Name = "yboxModifyValidation";
            this.yboxModifyValidation.Size = new System.Drawing.Size(131, 20);
            this.yboxModifyValidation.TabIndex = 7;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvElements);
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).EndInit();
            this.gboxModify.ResumeLayout(false);
            this.gboxModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElements;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tboxModifyName;
        private System.Windows.Forms.GroupBox gboxModify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yboxModifyValidation;
        private System.Windows.Forms.TextBox tboxModifyTag;
        private System.Windows.Forms.TextBox tboxModifyPrice;
    }
}