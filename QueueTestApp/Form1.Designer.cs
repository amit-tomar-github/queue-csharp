namespace QueueTestApp
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAdd = new System.Windows.Forms.ListBox();
            this.lbRemove = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbCurrent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.FormattingEnabled = true;
            this.lbAdd.ItemHeight = 16;
            this.lbAdd.Location = new System.Drawing.Point(105, 99);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(200, 196);
            this.lbAdd.TabIndex = 1;
            // 
            // lbRemove
            // 
            this.lbRemove.FormattingEnabled = true;
            this.lbRemove.ItemHeight = 16;
            this.lbRemove.Location = new System.Drawing.Point(374, 99);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(200, 196);
            this.lbRemove.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(374, 55);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 38);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbCurrent
            // 
            this.lbCurrent.FormattingEnabled = true;
            this.lbCurrent.ItemHeight = 16;
            this.lbCurrent.Location = new System.Drawing.Point(249, 340);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(200, 196);
            this.lbCurrent.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbAdd;
        private System.Windows.Forms.ListBox lbRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbCurrent;
    }
}

