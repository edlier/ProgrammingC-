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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Hide_PlaceB_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_SearchPlaceS_Des = new System.Windows.Forms.TextBox();
            this.cb_SearchPlaceS_BID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_EditS_TypeBList = new System.Windows.Forms.ComboBox();
            this.dgv_PlaceS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_btn_SEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dg_btn_SDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LinkBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddPlaceS = new System.Windows.Forms.Button();
            this.btn_EditPlaceS_Cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_insertPlaceS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceS)).BeginInit();
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
            this.dgv_PlaceB.Location = new System.Drawing.Point(19, 21);
            this.dgv_PlaceB.Name = "dgv_PlaceB";
            this.dgv_PlaceB.ReadOnly = true;
            this.dgv_PlaceB.RowTemplate.Height = 27;
            this.dgv_PlaceB.Size = new System.Drawing.Size(661, 288);
            this.dgv_PlaceB.TabIndex = 0;
            this.dgv_PlaceB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PlaceB_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "地點分類";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
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
            this.tb_insertPlaceB.Location = new System.Drawing.Point(96, 339);
            this.tb_insertPlaceB.Name = "tb_insertPlaceB";
            this.tb_insertPlaceB.Size = new System.Drawing.Size(155, 34);
            this.tb_insertPlaceB.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "地點 : ";
            // 
            // btn_AddPlaceB
            // 
            this.btn_AddPlaceB.BackColor = System.Drawing.SystemColors.Info;
            this.btn_AddPlaceB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AddPlaceB.Location = new System.Drawing.Point(263, 329);
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
            this.btn_EditPlaceB_Cancel.Location = new System.Drawing.Point(397, 329);
            this.btn_EditPlaceB_Cancel.Name = "btn_EditPlaceB_Cancel";
            this.btn_EditPlaceB_Cancel.Size = new System.Drawing.Size(128, 51);
            this.btn_EditPlaceB_Cancel.TabIndex = 31;
            this.btn_EditPlaceB_Cancel.Text = "Cancel";
            this.btn_EditPlaceB_Cancel.UseVisualStyleBackColor = false;
            this.btn_EditPlaceB_Cancel.Click += new System.EventHandler(this.btn_EditPlaceB_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "地點B ID : ";
            this.label2.Visible = false;
            // 
            // tb_Hide_PlaceB_ID
            // 
            this.tb_Hide_PlaceB_ID.Location = new System.Drawing.Point(640, 338);
            this.tb_Hide_PlaceB_ID.Name = "tb_Hide_PlaceB_ID";
            this.tb_Hide_PlaceB_ID.Size = new System.Drawing.Size(155, 34);
            this.tb_Hide_PlaceB_ID.TabIndex = 33;
            this.tb_Hide_PlaceB_ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 529);
            this.panel1.TabIndex = 34;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 512);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_PlaceB);
            this.tabPage1.Controls.Add(this.btn_AddPlaceB);
            this.tabPage1.Controls.Add(this.btn_EditPlaceB_Cancel);
            this.tabPage1.Controls.Add(this.tb_Hide_PlaceB_ID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_insertPlaceB);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地點 - 大分類";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_SearchPlaceS_Des);
            this.tabPage3.Controls.Add(this.cb_SearchPlaceS_BID);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cb_EditS_TypeBList);
            this.tabPage3.Controls.Add(this.dgv_PlaceS);
            this.tabPage3.Controls.Add(this.btn_AddPlaceS);
            this.tabPage3.Controls.Add(this.btn_EditPlaceS_Cancel);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tb_insertPlaceS);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(864, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "地點 - 小分類";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_SearchPlaceS_Des
            // 
            this.tb_SearchPlaceS_Des.Location = new System.Drawing.Point(232, 17);
            this.tb_SearchPlaceS_Des.Name = "tb_SearchPlaceS_Des";
            this.tb_SearchPlaceS_Des.Size = new System.Drawing.Size(155, 34);
            this.tb_SearchPlaceS_Des.TabIndex = 37;
            this.tb_SearchPlaceS_Des.TextChanged += new System.EventHandler(this.SearchPlaceS_Event);
            // 
            // cb_SearchPlaceS_BID
            // 
            this.cb_SearchPlaceS_BID.FormattingEnabled = true;
            this.cb_SearchPlaceS_BID.Location = new System.Drawing.Point(83, 18);
            this.cb_SearchPlaceS_BID.Name = "cb_SearchPlaceS_BID";
            this.cb_SearchPlaceS_BID.Size = new System.Drawing.Size(143, 33);
            this.cb_SearchPlaceS_BID.TabIndex = 36;
            this.cb_SearchPlaceS_BID.SelectedIndexChanged += new System.EventHandler(this.SearchPlaceS_Event);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "搜尋 : ";
            // 
            // cb_EditS_TypeBList
            // 
            this.cb_EditS_TypeBList.FormattingEnabled = true;
            this.cb_EditS_TypeBList.Location = new System.Drawing.Point(93, 391);
            this.cb_EditS_TypeBList.Name = "cb_EditS_TypeBList";
            this.cb_EditS_TypeBList.Size = new System.Drawing.Size(143, 33);
            this.cb_EditS_TypeBList.TabIndex = 34;
            // 
            // dgv_PlaceS
            // 
            this.dgv_PlaceS.AllowUserToAddRows = false;
            this.dgv_PlaceS.AllowUserToDeleteRows = false;
            this.dgv_PlaceS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlaceS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.PlaceBType,
            this.Des,
            this.dg_btn_SEdit,
            this.dg_btn_SDel,
            this.LinkBID});
            this.dgv_PlaceS.Location = new System.Drawing.Point(18, 73);
            this.dgv_PlaceS.Name = "dgv_PlaceS";
            this.dgv_PlaceS.ReadOnly = true;
            this.dgv_PlaceS.RowTemplate.Height = 27;
            this.dgv_PlaceS.Size = new System.Drawing.Size(661, 288);
            this.dgv_PlaceS.TabIndex = 0;
            this.dgv_PlaceS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PlaceS_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // PlaceBType
            // 
            this.PlaceBType.DataPropertyName = "PlaceBType";
            this.PlaceBType.HeaderText = "地點大分類";
            this.PlaceBType.Name = "PlaceBType";
            this.PlaceBType.ReadOnly = true;
            this.PlaceBType.Width = 125;
            // 
            // Des
            // 
            this.Des.DataPropertyName = "Des";
            this.Des.HeaderText = "地點小分類";
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            this.Des.Width = 150;
            // 
            // dg_btn_SEdit
            // 
            this.dg_btn_SEdit.HeaderText = "修改";
            this.dg_btn_SEdit.Name = "dg_btn_SEdit";
            this.dg_btn_SEdit.ReadOnly = true;
            this.dg_btn_SEdit.Text = "修改";
            this.dg_btn_SEdit.ToolTipText = "修改";
            this.dg_btn_SEdit.UseColumnTextForButtonValue = true;
            // 
            // dg_btn_SDel
            // 
            this.dg_btn_SDel.HeaderText = "刪除";
            this.dg_btn_SDel.Name = "dg_btn_SDel";
            this.dg_btn_SDel.ReadOnly = true;
            this.dg_btn_SDel.Text = "刪除";
            this.dg_btn_SDel.ToolTipText = "刪除";
            this.dg_btn_SDel.UseColumnTextForButtonValue = true;
            // 
            // LinkBID
            // 
            this.LinkBID.DataPropertyName = "LinkBID";
            this.LinkBID.HeaderText = "大分類ID";
            this.LinkBID.Name = "LinkBID";
            this.LinkBID.ReadOnly = true;
            this.LinkBID.Visible = false;
            // 
            // btn_AddPlaceS
            // 
            this.btn_AddPlaceS.BackColor = System.Drawing.SystemColors.Info;
            this.btn_AddPlaceS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AddPlaceS.Location = new System.Drawing.Point(403, 381);
            this.btn_AddPlaceS.Name = "btn_AddPlaceS";
            this.btn_AddPlaceS.Size = new System.Drawing.Size(128, 51);
            this.btn_AddPlaceS.TabIndex = 30;
            this.btn_AddPlaceS.Text = "New Add";
            this.btn_AddPlaceS.UseVisualStyleBackColor = false;
            // 
            // btn_EditPlaceS_Cancel
            // 
            this.btn_EditPlaceS_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_EditPlaceS_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_EditPlaceS_Cancel.Location = new System.Drawing.Point(537, 381);
            this.btn_EditPlaceS_Cancel.Name = "btn_EditPlaceS_Cancel";
            this.btn_EditPlaceS_Cancel.Size = new System.Drawing.Size(128, 51);
            this.btn_EditPlaceS_Cancel.TabIndex = 31;
            this.btn_EditPlaceS_Cancel.Text = "Cancel";
            this.btn_EditPlaceS_Cancel.UseVisualStyleBackColor = false;
            this.btn_EditPlaceS_Cancel.Click += new System.EventHandler(this.btn_EditPlaceS_Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 34);
            this.textBox1.TabIndex = 33;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "地點 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "地點S ID : ";
            this.label4.Visible = false;
            // 
            // tb_insertPlaceS
            // 
            this.tb_insertPlaceS.Location = new System.Drawing.Point(242, 391);
            this.tb_insertPlaceS.Name = "tb_insertPlaceS";
            this.tb_insertPlaceS.Size = new System.Drawing.Size(155, 34);
            this.tb_insertPlaceS.TabIndex = 28;
            // 
            // config_PlaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_InputPage);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "config_PlaceList";
            this.Text = "Place List";
            this.Load += new System.EventHandler(this.config_PlaceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PlaceB;
        private System.Windows.Forms.Button btn_InputPage;
        private System.Windows.Forms.TextBox tb_insertPlaceB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddPlaceB;
        private System.Windows.Forms.Button btn_EditPlaceB_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Hide_PlaceB_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_PlaceS;
        private System.Windows.Forms.Button btn_AddPlaceS;
        private System.Windows.Forms.Button btn_EditPlaceS_Cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_insertPlaceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.ComboBox cb_EditS_TypeBList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewButtonColumn dg_btn_SEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dg_btn_SDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkBID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_SearchPlaceS_BID;
        private System.Windows.Forms.TextBox tb_SearchPlaceS_Des;
    }
}