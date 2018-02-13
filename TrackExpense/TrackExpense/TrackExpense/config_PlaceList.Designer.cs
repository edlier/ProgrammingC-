namespace TrackExpense
{
    partial class config_PlaceList
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
            this.dgv_PlaceB = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_InputPage = new System.Windows.Forms.Button();
            this.tb_insertPlaceB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddPlaceB = new System.Windows.Forms.Button();
            this.btn_EditPlaceB_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PlaceB
            // 
            this.dgv_PlaceB.AllowUserToAddRows = false;
            this.dgv_PlaceB.AllowUserToDeleteRows = false;
            this.dgv_PlaceB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlaceB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.btn_Edit,
            this.btn_Delete});
            this.dgv_PlaceB.Location = new System.Drawing.Point(72, 128);
            this.dgv_PlaceB.Name = "dgv_PlaceB";
            this.dgv_PlaceB.ReadOnly = true;
            this.dgv_PlaceB.RowTemplate.Height = 27;
            this.dgv_PlaceB.Size = new System.Drawing.Size(661, 138);
            this.dgv_PlaceB.TabIndex = 0;
            this.dgv_PlaceB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PlaceB_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "地點分類";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "修改";
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ReadOnly = true;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.ToolTipText = "修改";
            this.btn_Edit.UseColumnTextForButtonValue = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "刪除";
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ReadOnly = true;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.ToolTipText = "刪除";
            this.btn_Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_InputPage
            // 
            this.btn_InputPage.BackColor = System.Drawing.SystemColors.Info;
            this.btn_InputPage.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_InputPage.Location = new System.Drawing.Point(917, 55);
            this.btn_InputPage.Name = "btn_InputPage";
            this.btn_InputPage.Size = new System.Drawing.Size(128, 51);
            this.btn_InputPage.TabIndex = 27;
            this.btn_InputPage.Text = "輸入資料";
            this.btn_InputPage.UseVisualStyleBackColor = false;
            this.btn_InputPage.Click += new System.EventHandler(this.btn_InputPage_Click);
            // 
            // tb_insertPlaceB
            // 
            this.tb_insertPlaceB.Location = new System.Drawing.Point(142, 307);
            this.tb_insertPlaceB.Name = "tb_insertPlaceB";
            this.tb_insertPlaceB.Size = new System.Drawing.Size(155, 34);
            this.tb_insertPlaceB.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "地點 : ";
            // 
            // btn_AddPlaceB
            // 
            this.btn_AddPlaceB.BackColor = System.Drawing.SystemColors.Info;
            this.btn_AddPlaceB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AddPlaceB.Location = new System.Drawing.Point(335, 297);
            this.btn_AddPlaceB.Name = "btn_AddPlaceB";
            this.btn_AddPlaceB.Size = new System.Drawing.Size(128, 51);
            this.btn_AddPlaceB.TabIndex = 30;
            this.btn_AddPlaceB.Text = "New Add";
            this.btn_AddPlaceB.UseVisualStyleBackColor = false;
            this.btn_AddPlaceB.Click += new System.EventHandler(this.btn_AddPlaceB_Click);
            // 
            // btn_EditPlaceB_Cancel
            // 
            this.btn_EditPlaceB_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_EditPlaceB_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_EditPlaceB_Cancel.Location = new System.Drawing.Point(469, 297);
            this.btn_EditPlaceB_Cancel.Name = "btn_EditPlaceB_Cancel";
            this.btn_EditPlaceB_Cancel.Size = new System.Drawing.Size(128, 51);
            this.btn_EditPlaceB_Cancel.TabIndex = 31;
            this.btn_EditPlaceB_Cancel.Text = "Cancel";
            this.btn_EditPlaceB_Cancel.UseVisualStyleBackColor = false;
            this.btn_EditPlaceB_Cancel.Visible = false;
            // 
            // config_PlaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.btn_EditPlaceB_Cancel);
            this.Controls.Add(this.btn_AddPlaceB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_insertPlaceB);
            this.Controls.Add(this.btn_InputPage);
            this.Controls.Add(this.dgv_PlaceB);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "config_PlaceList";
            this.Text = "Place List";
            this.Load += new System.EventHandler(this.config_PlaceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PlaceB;
        private System.Windows.Forms.Button btn_InputPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.TextBox tb_insertPlaceB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddPlaceB;
        private System.Windows.Forms.Button btn_EditPlaceB_Cancel;
    }
}