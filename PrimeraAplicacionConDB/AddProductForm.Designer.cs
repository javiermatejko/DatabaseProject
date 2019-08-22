namespace PrimeraAplicacionConDB
{
    partial class AddProductForm
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
            this.tboxNewProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNewProdPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNewProdTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNewProdValidation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxNewProdName
            // 
            this.tboxNewProdName.Location = new System.Drawing.Point(61, 82);
            this.tboxNewProdName.Name = "tboxNewProdName";
            this.tboxNewProdName.Size = new System.Drawing.Size(252, 20);
            this.tboxNewProdName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tboxNewProdPrice
            // 
            this.tboxNewProdPrice.Location = new System.Drawing.Point(61, 133);
            this.tboxNewProdPrice.Name = "tboxNewProdPrice";
            this.tboxNewProdPrice.Size = new System.Drawing.Size(251, 20);
            this.tboxNewProdPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // tboxNewProdTag
            // 
            this.tboxNewProdTag.Location = new System.Drawing.Point(61, 180);
            this.tboxNewProdTag.Name = "tboxNewProdTag";
            this.tboxNewProdTag.Size = new System.Drawing.Size(251, 20);
            this.tboxNewProdTag.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tag:";
            // 
            // tboxNewProdValidation
            // 
            this.tboxNewProdValidation.Location = new System.Drawing.Point(79, 235);
            this.tboxNewProdValidation.Name = "tboxNewProdValidation";
            this.tboxNewProdValidation.Size = new System.Drawing.Size(233, 20);
            this.tboxNewProdValidation.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Validation:";
            // 
            // btnConfirmSave
            // 
            this.btnConfirmSave.Location = new System.Drawing.Point(20, 282);
            this.btnConfirmSave.Name = "btnConfirmSave";
            this.btnConfirmSave.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSave.TabIndex = 4;
            this.btnConfirmSave.Text = "Save";
            this.btnConfirmSave.UseVisualStyleBackColor = true;
            this.btnConfirmSave.Click += new System.EventHandler(this.btnConfirmSave_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(134, 282);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "NEW PRODUCT";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnConfirmSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxNewProdValidation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxNewProdPrice);
            this.Controls.Add(this.tboxNewProdTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNewProdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNewProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNewProdPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNewProdTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxNewProdValidation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
    }
}