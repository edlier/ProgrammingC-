namespace TrackExpense
{
    partial class ExpenseList
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTypeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTypeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_InputPage = new System.Windows.Forms.Button();
            this.dateTimePicker_searchEnd = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_searchStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Search_TypeB = new System.Windows.Forms.ComboBox();
            this.cb_Search_TypeS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Search_PlaceS = new System.Windows.Forms.ComboBox();
            this.cb_Search_PlaceB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SpentDate,
            this.Content,
            this.Price,
            this.Currency,
            this.receiptNum,
            this.payCard,
            this.CreditCardName,
            this.expenseTypeB,
            this.expenseTypeS,
            this.Note,
            this.PlaceB,
            this.PlaceS,
            this.payType,
            this.InsertDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1508, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // SpentDate
            // 
            this.SpentDate.DataPropertyName = "SpentDate";
            this.SpentDate.HeaderText = "消費日期";
            this.SpentDate.Name = "SpentDate";
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "內容";
            this.Content.Name = "Content";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "價格";
            this.Price.Name = "Price";
            this.Price.Width = 75;
            // 
            // Currency
            // 
            this.Currency.DataPropertyName = "Currency";
            this.Currency.HeaderText = "幣";
            this.Currency.Name = "Currency";
            this.Currency.Width = 50;
            // 
            // receiptNum
            // 
            this.receiptNum.DataPropertyName = "receiptNum";
            this.receiptNum.HeaderText = "發票";
            this.receiptNum.Name = "receiptNum";
            this.receiptNum.Width = 68;
            // 
            // payCard
            // 
            this.payCard.DataPropertyName = "payCard";
            this.payCard.HeaderText = "支付卡";
            this.payCard.Name = "payCard";
            this.payCard.Width = 80;
            // 
            // CreditCardName
            // 
            this.CreditCardName.DataPropertyName = "CreditCardName";
            this.CreditCardName.HeaderText = "信用卡";
            this.CreditCardName.Name = "CreditCardName";
            this.CreditCardName.Width = 80;
            // 
            // expenseTypeB
            // 
            this.expenseTypeB.DataPropertyName = "expenseTypeB";
            this.expenseTypeB.HeaderText = "支出類型";
            this.expenseTypeB.Name = "expenseTypeB";
            // 
            // expenseTypeS
            // 
            this.expenseTypeS.DataPropertyName = "expenseTypeS";
            this.expenseTypeS.HeaderText = "支出類型";
            this.expenseTypeS.Name = "expenseTypeS";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 120;
            // 
            // PlaceB
            // 
            this.PlaceB.DataPropertyName = "PlaceB";
            this.PlaceB.HeaderText = "地點";
            this.PlaceB.Name = "PlaceB";
            // 
            // PlaceS
            // 
            this.PlaceS.DataPropertyName = "PlaceS";
            this.PlaceS.HeaderText = "地點";
            this.PlaceS.Name = "PlaceS";
            // 
            // payType
            // 
            this.payType.DataPropertyName = "payType";
            this.payType.HeaderText = "類型";
            this.payType.Name = "payType";
            this.payType.Width = 50;
            // 
            // InsertDate
            // 
            this.InsertDate.DataPropertyName = "InsertDate";
            this.InsertDate.HeaderText = "新增時間";
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.Visible = false;
            // 
            // btn_InputPage
            // 
            this.btn_InputPage.BackColor = System.Drawing.SystemColors.Info;
            this.btn_InputPage.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_InputPage.Location = new System.Drawing.Point(1291, 15);
            this.btn_InputPage.Name = "btn_InputPage";
            this.btn_InputPage.Size = new System.Drawing.Size(128, 51);
            this.btn_InputPage.TabIndex = 26;
            this.btn_InputPage.Text = "輸入資料";
            this.btn_InputPage.UseVisualStyleBackColor = false;
            this.btn_InputPage.Click += new System.EventHandler(this.btn_InputPage_Click);
            // 
            // dateTimePicker_searchEnd
            // 
            this.dateTimePicker_searchEnd.Location = new System.Drawing.Point(262, 21);
            this.dateTimePicker_searchEnd.Name = "dateTimePicker_searchEnd";
            this.dateTimePicker_searchEnd.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker_searchEnd.TabIndex = 27;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(468, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 34);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dateTimePicker_searchStart
            // 
            this.dateTimePicker_searchStart.Location = new System.Drawing.Point(23, 21);
            this.dateTimePicker_searchStart.Name = "dateTimePicker_searchStart";
            this.dateTimePicker_searchStart.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker_searchStart.TabIndex = 29;
            this.dateTimePicker_searchStart.ValueChanged += new System.EventHandler(this.dateTimePicker_searchStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "~";
            // 
            // cb_Search_TypeB
            // 
            this.cb_Search_TypeB.FormattingEnabled = true;
            this.cb_Search_TypeB.Location = new System.Drawing.Point(691, 17);
            this.cb_Search_TypeB.Name = "cb_Search_TypeB";
            this.cb_Search_TypeB.Size = new System.Drawing.Size(138, 33);
            this.cb_Search_TypeB.TabIndex = 31;
            this.cb_Search_TypeB.SelectedIndexChanged += new System.EventHandler(this.cb_Search_TypeB_SelectedIndexChanged);
            // 
            // cb_Search_TypeS
            // 
            this.cb_Search_TypeS.FormattingEnabled = true;
            this.cb_Search_TypeS.Location = new System.Drawing.Point(837, 18);
            this.cb_Search_TypeS.Name = "cb_Search_TypeS";
            this.cb_Search_TypeS.Size = new System.Drawing.Size(144, 33);
            this.cb_Search_TypeS.TabIndex = 32;
            this.cb_Search_TypeS.SelectedIndexChanged += new System.EventHandler(this.SearchQueryData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Place :";
            // 
            // cb_Search_PlaceS
            // 
            this.cb_Search_PlaceS.FormattingEnabled = true;
            this.cb_Search_PlaceS.Location = new System.Drawing.Point(837, 63);
            this.cb_Search_PlaceS.Name = "cb_Search_PlaceS";
            this.cb_Search_PlaceS.Size = new System.Drawing.Size(144, 33);
            this.cb_Search_PlaceS.TabIndex = 35;
            this.cb_Search_PlaceS.SelectedIndexChanged += new System.EventHandler(this.SearchQueryData);
            // 
            // cb_Search_PlaceB
            // 
            this.cb_Search_PlaceB.FormattingEnabled = true;
            this.cb_Search_PlaceB.Location = new System.Drawing.Point(691, 62);
            this.cb_Search_PlaceB.Name = "cb_Search_PlaceB";
            this.cb_Search_PlaceB.Size = new System.Drawing.Size(138, 33);
            this.cb_Search_PlaceB.TabIndex = 34;
            this.cb_Search_PlaceB.SelectedIndexChanged += new System.EventHandler(this.cb_Search_PlaceB_SelectedIndexChanged);
            // 
            // ExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 690);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Search_PlaceS);
            this.Controls.Add(this.cb_Search_PlaceB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Search_TypeS);
            this.Controls.Add(this.cb_Search_TypeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_searchStart);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dateTimePicker_searchEnd);
            this.Controls.Add(this.btn_InputPage);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExpenseList";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_InputPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker_searchEnd;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_searchStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn payCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTypeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTypeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn payType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertDate;
        private System.Windows.Forms.ComboBox cb_Search_TypeB;
        private System.Windows.Forms.ComboBox cb_Search_TypeS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Search_PlaceS;
        private System.Windows.Forms.ComboBox cb_Search_PlaceB;
    }
}