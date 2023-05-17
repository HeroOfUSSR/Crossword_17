
namespace Crossword_Game
{
    partial class Hints
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
            this.hint_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hint_table)).BeginInit();
            this.SuspendLayout();
            // 
            // hint_table
            // 
            this.hint_table.AllowUserToAddRows = false;
            this.hint_table.AllowUserToDeleteRows = false;
            this.hint_table.AllowUserToResizeColumns = false;
            this.hint_table.AllowUserToResizeRows = false;
            this.hint_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hint_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.hint_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hint_table.Location = new System.Drawing.Point(0, 0);
            this.hint_table.Name = "hint_table";
            this.hint_table.RowHeadersVisible = false;
            this.hint_table.RowTemplate.Height = 25;
            this.hint_table.Size = new System.Drawing.Size(384, 491);
            this.hint_table.TabIndex = 0;
            this.hint_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hint_table_CellContentClick);
            this.hint_table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.hint_table_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Направление";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Вопрос";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Hints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 491);
            this.Controls.Add(this.hint_table);
            this.MaximumSize = new System.Drawing.Size(1000, 530);
            this.MinimumSize = new System.Drawing.Size(400, 530);
            this.Name = "Hints";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Вопросы";
            ((System.ComponentModel.ISupportInitialize)(this.hint_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView hint_table;
    }
}