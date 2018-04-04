namespace Vueling.Presentation.WinSite
{
    partial class AlumnosShowForm
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
            this.btnShTxt = new System.Windows.Forms.Button();
            this.btnShJson = new System.Windows.Forms.Button();
            this.btnShXML = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShTxt
            // 
            this.btnShTxt.Location = new System.Drawing.Point(87, 307);
            this.btnShTxt.Name = "btnShTxt";
            this.btnShTxt.Size = new System.Drawing.Size(75, 23);
            this.btnShTxt.TabIndex = 1;
            this.btnShTxt.Text = "TXT";
            this.btnShTxt.UseVisualStyleBackColor = true;
            // 
            // btnShJson
            // 
            this.btnShJson.Location = new System.Drawing.Point(258, 307);
            this.btnShJson.Name = "btnShJson";
            this.btnShJson.Size = new System.Drawing.Size(75, 23);
            this.btnShJson.TabIndex = 2;
            this.btnShJson.Text = "JSON";
            this.btnShJson.UseVisualStyleBackColor = true;
            this.btnShJson.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShXML
            // 
            this.btnShXML.Location = new System.Drawing.Point(460, 307);
            this.btnShXML.Name = "btnShXML";
            this.btnShXML.Size = new System.Drawing.Size(75, 23);
            this.btnShXML.TabIndex = 3;
            this.btnShXML.Text = "XML";
            this.btnShXML.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona un campo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // AlumnosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 379);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnShXML);
            this.Controls.Add(this.btnShJson);
            this.Controls.Add(this.btnShTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlumnosShowForm";
            this.Text = "AlumnosShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShTxt;
        private System.Windows.Forms.Button btnShJson;
        private System.Windows.Forms.Button btnShXML;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}