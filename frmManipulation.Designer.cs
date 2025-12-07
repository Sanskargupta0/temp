namespace Phase1_G1
{
    partial class frmManipulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restCusine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restDiscrption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmMainpulation = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestName,
            this.restImage,
            this.restCusine,
            this.restDiscrption,
            this.restMap});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // RestName
            // 
            this.RestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RestName.HeaderText = "Name";
            this.RestName.MinimumWidth = 8;
            this.RestName.Name = "RestName";
            // 
            // restImage
            // 
            this.restImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.restImage.HeaderText = "Image";
            this.restImage.MinimumWidth = 8;
            this.restImage.Name = "restImage";
            // 
            // restCusine
            // 
            this.restCusine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.restCusine.HeaderText = "Cusine";
            this.restCusine.MinimumWidth = 8;
            this.restCusine.Name = "restCusine";
            // 
            // restDiscrption
            // 
            this.restDiscrption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.restDiscrption.HeaderText = "Discription";
            this.restDiscrption.MinimumWidth = 8;
            this.restDiscrption.Name = "restDiscrption";
            // 
            // restMap
            // 
            this.restMap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.restMap.HeaderText = "Map";
            this.restMap.MinimumWidth = 8;
            this.restMap.Name = "restMap";
            // 
            // frmMainpulation
            // 
            this.frmMainpulation.Filter = "Text files|*.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManipulation";
            this.Text = "frmMainPopulation";
            this.Load += new System.EventHandler(this.frmManipulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn restImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn restCusine;
        private System.Windows.Forms.DataGridViewTextBoxColumn restDiscrption;
        private System.Windows.Forms.DataGridViewTextBoxColumn restMap;
        private System.Windows.Forms.SaveFileDialog frmMainpulation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}