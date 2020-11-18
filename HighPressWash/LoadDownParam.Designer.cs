namespace HighPressWash
{
    partial class LoadDownParam
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
            this.label25 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSearch = new HslCommunication.Controls.UserButton();
            this.btnLoadDownParam = new HslCommunication.Controls.UserButton();
            this.btnForbidden = new HslCommunication.Controls.UserButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(8, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "产品型号：";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProductName.Location = new System.Drawing.Point(114, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(187, 29);
            this.txtProductName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CustomerInformation = "";
            this.btnSearch.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnSearch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(312, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UIText = "搜 索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoadDownParam
            // 
            this.btnLoadDownParam.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadDownParam.CustomerInformation = "";
            this.btnLoadDownParam.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLoadDownParam.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadDownParam.Location = new System.Drawing.Point(312, 102);
            this.btnLoadDownParam.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnLoadDownParam.Name = "btnLoadDownParam";
            this.btnLoadDownParam.Size = new System.Drawing.Size(121, 36);
            this.btnLoadDownParam.TabIndex = 6;
            this.btnLoadDownParam.UIText = "下载参数";
            this.btnLoadDownParam.Click += new System.EventHandler(this.btnLoadDownParam_Click);
            // 
            // btnForbidden
            // 
            this.btnForbidden.BackColor = System.Drawing.Color.Transparent;
            this.btnForbidden.CustomerInformation = "";
            this.btnForbidden.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnForbidden.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForbidden.Location = new System.Drawing.Point(312, 178);
            this.btnForbidden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForbidden.Name = "btnForbidden";
            this.btnForbidden.Size = new System.Drawing.Size(121, 36);
            this.btnForbidden.TabIndex = 6;
            this.btnForbidden.UIText = "禁用参数";
            this.btnForbidden.Click += new System.EventHandler(this.btnForbidden_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(23, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 251);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // LoadDownParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(454, 353);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnForbidden);
            this.Controls.Add(this.btnLoadDownParam);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label25);
            this.Name = "LoadDownParam";
            this.Text = "参数管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtProductName;
        private HslCommunication.Controls.UserButton btnSearch;
        private HslCommunication.Controls.UserButton btnLoadDownParam;
        private HslCommunication.Controls.UserButton btnForbidden;
        private System.Windows.Forms.ListBox listBox1;
    }
}