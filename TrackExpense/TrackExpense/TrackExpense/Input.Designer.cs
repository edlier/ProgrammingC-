namespace TrackExpense
{
    partial class Form_Input
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker_spentDT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Content = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_EasyCard = new System.Windows.Forms.RadioButton();
            this.rb_CreditCard = new System.Windows.Forms.RadioButton();
            this.panel_payment = new System.Windows.Forms.Panel();
            this.cb_payCrditCard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_payType_Expense = new System.Windows.Forms.RadioButton();
            this.rb_payType_InCome = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_TypeB = new System.Windows.Forms.ComboBox();
            this.cb_TypeS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_receiptNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_PlaceTypeB = new System.Windows.Forms.ComboBox();
            this.cb_PlaceTypeS = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_InputList = new System.Windows.Forms.Button();
            this.btn_MonthDatList = new System.Windows.Forms.Button();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_editPlace = new System.Windows.Forms.Button();
            this.btn_editType = new System.Windows.Forms.Button();
            this.panel_payment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker_spentDT
            // 
            this.datePicker_spentDT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePicker_spentDT.Location = new System.Drawing.Point(107, 64);
            this.datePicker_spentDT.Name = "datePicker_spentDT";
            this.datePicker_spentDT.Size = new System.Drawing.Size(200, 34);
            this.datePicker_spentDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "內容 : ";
            // 
            // tb_Content
            // 
            this.tb_Content.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Content.Location = new System.Drawing.Point(139, 128);
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.Size = new System.Drawing.Size(210, 34);
            this.tb_Content.TabIndex = 3;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Price.Location = new System.Drawing.Point(139, 188);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(145, 34);
            this.tb_Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "價格 : ";
            // 
            // rb_EasyCard
            // 
            this.rb_EasyCard.AutoSize = true;
            this.rb_EasyCard.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rb_EasyCard.Location = new System.Drawing.Point(17, 13);
            this.rb_EasyCard.Name = "rb_EasyCard";
            this.rb_EasyCard.Size = new System.Drawing.Size(133, 29);
            this.rb_EasyCard.TabIndex = 7;
            this.rb_EasyCard.TabStop = true;
            this.rb_EasyCard.Tag = "PayCard";
            this.rb_EasyCard.Text = "悠遊卡支付";
            this.rb_EasyCard.UseVisualStyleBackColor = true;
            this.rb_EasyCard.CheckedChanged += new System.EventHandler(this.rb_EasyCard_CheckedChanged);
            // 
            // rb_CreditCard
            // 
            this.rb_CreditCard.AutoSize = true;
            this.rb_CreditCard.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rb_CreditCard.Location = new System.Drawing.Point(17, 49);
            this.rb_CreditCard.Name = "rb_CreditCard";
            this.rb_CreditCard.Size = new System.Drawing.Size(133, 29);
            this.rb_CreditCard.TabIndex = 8;
            this.rb_CreditCard.TabStop = true;
            this.rb_CreditCard.Tag = "PayCard";
            this.rb_CreditCard.Text = "信用卡支付";
            this.rb_CreditCard.UseVisualStyleBackColor = true;
            this.rb_CreditCard.CheckedChanged += new System.EventHandler(this.rb_CreditCard_CheckedChanged);
            // 
            // panel_payment
            // 
            this.panel_payment.Controls.Add(this.cb_payCrditCard);
            this.panel_payment.Controls.Add(this.rb_EasyCard);
            this.panel_payment.Controls.Add(this.rb_CreditCard);
            this.panel_payment.Location = new System.Drawing.Point(36, 271);
            this.panel_payment.Name = "panel_payment";
            this.panel_payment.Size = new System.Drawing.Size(313, 93);
            this.panel_payment.TabIndex = 9;
            // 
            // cb_payCrditCard
            // 
            this.cb_payCrditCard.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_payCrditCard.FormattingEnabled = true;
            this.cb_payCrditCard.Location = new System.Drawing.Point(167, 46);
            this.cb_payCrditCard.Name = "cb_payCrditCard";
            this.cb_payCrditCard.Size = new System.Drawing.Size(128, 33);
            this.cb_payCrditCard.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type : ";
            // 
            // rb_payType_Expense
            // 
            this.rb_payType_Expense.AutoSize = true;
            this.rb_payType_Expense.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rb_payType_Expense.Location = new System.Drawing.Point(88, 9);
            this.rb_payType_Expense.Name = "rb_payType_Expense";
            this.rb_payType_Expense.Size = new System.Drawing.Size(73, 29);
            this.rb_payType_Expense.TabIndex = 13;
            this.rb_payType_Expense.TabStop = true;
            this.rb_payType_Expense.Tag = "PayType";
            this.rb_payType_Expense.Text = "支出";
            this.rb_payType_Expense.UseVisualStyleBackColor = true;
            // 
            // rb_payType_InCome
            // 
            this.rb_payType_InCome.AutoSize = true;
            this.rb_payType_InCome.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rb_payType_InCome.Location = new System.Drawing.Point(167, 9);
            this.rb_payType_InCome.Name = "rb_payType_InCome";
            this.rb_payType_InCome.Size = new System.Drawing.Size(73, 29);
            this.rb_payType_InCome.TabIndex = 14;
            this.rb_payType_InCome.TabStop = true;
            this.rb_payType_InCome.Tag = "PayType";
            this.rb_payType_InCome.Text = "收入";
            this.rb_payType_InCome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_payType_InCome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rb_payType_Expense);
            this.panel1.Location = new System.Drawing.Point(379, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 44);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(388, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "分類 : ";
            // 
            // cb_TypeB
            // 
            this.cb_TypeB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_TypeB.FormattingEnabled = true;
            this.cb_TypeB.Location = new System.Drawing.Point(452, 128);
            this.cb_TypeB.Name = "cb_TypeB";
            this.cb_TypeB.Size = new System.Drawing.Size(180, 33);
            this.cb_TypeB.TabIndex = 11;
            this.cb_TypeB.SelectedIndexChanged += new System.EventHandler(this.cb_TypeB_SelectedIndexChanged);
            // 
            // cb_TypeS
            // 
            this.cb_TypeS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_TypeS.FormattingEnabled = true;
            this.cb_TypeS.Location = new System.Drawing.Point(638, 128);
            this.cb_TypeS.Name = "cb_TypeS";
            this.cb_TypeS.Size = new System.Drawing.Size(191, 33);
            this.cb_TypeS.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(389, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "發票號碼 : ";
            // 
            // tb_receiptNum
            // 
            this.tb_receiptNum.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_receiptNum.Location = new System.Drawing.Point(495, 189);
            this.tb_receiptNum.Name = "tb_receiptNum";
            this.tb_receiptNum.Size = new System.Drawing.Size(143, 34);
            this.tb_receiptNum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(31, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "備註 : ";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Note.Location = new System.Drawing.Point(107, 398);
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(250, 103);
            this.tb_Note.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(396, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "地點 : ";
            // 
            // cb_PlaceTypeB
            // 
            this.cb_PlaceTypeB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_PlaceTypeB.FormattingEnabled = true;
            this.cb_PlaceTypeB.Location = new System.Drawing.Point(467, 268);
            this.cb_PlaceTypeB.Name = "cb_PlaceTypeB";
            this.cb_PlaceTypeB.Size = new System.Drawing.Size(165, 33);
            this.cb_PlaceTypeB.TabIndex = 11;
            this.cb_PlaceTypeB.SelectedIndexChanged += new System.EventHandler(this.cb_PlaceTypeB_SelectedIndexChanged);
            // 
            // cb_PlaceTypeS
            // 
            this.cb_PlaceTypeS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_PlaceTypeS.FormattingEnabled = true;
            this.cb_PlaceTypeS.Location = new System.Drawing.Point(638, 268);
            this.cb_PlaceTypeS.Name = "cb_PlaceTypeS";
            this.cb_PlaceTypeS.Size = new System.Drawing.Size(280, 33);
            this.cb_PlaceTypeS.TabIndex = 23;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_Save.Location = new System.Drawing.Point(422, 450);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(200, 51);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_InputList
            // 
            this.btn_InputList.BackColor = System.Drawing.SystemColors.Info;
            this.btn_InputList.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_InputList.Location = new System.Drawing.Point(861, 433);
            this.btn_InputList.Name = "btn_InputList";
            this.btn_InputList.Size = new System.Drawing.Size(200, 51);
            this.btn_InputList.TabIndex = 25;
            this.btn_InputList.Text = "清單";
            this.btn_InputList.UseVisualStyleBackColor = false;
            this.btn_InputList.Click += new System.EventHandler(this.btn_InputList_Click);
            // 
            // btn_MonthDatList
            // 
            this.btn_MonthDatList.BackColor = System.Drawing.SystemColors.Info;
            this.btn_MonthDatList.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_MonthDatList.Location = new System.Drawing.Point(861, 490);
            this.btn_MonthDatList.Name = "btn_MonthDatList";
            this.btn_MonthDatList.Size = new System.Drawing.Size(200, 51);
            this.btn_MonthDatList.TabIndex = 26;
            this.btn_MonthDatList.Text = "本月清單";
            this.btn_MonthDatList.UseVisualStyleBackColor = false;
            this.btn_MonthDatList.Click += new System.EventHandler(this.btn_MonthDatList_Click);
            // 
            // cb_currency
            // 
            this.cb_currency.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(290, 189);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(93, 33);
            this.cb_currency.TabIndex = 27;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Reset.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_Reset.Location = new System.Drawing.Point(650, 47);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(89, 51);
            this.btn_Reset.TabIndex = 28;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_editPlace
            // 
            this.btn_editPlace.BackColor = System.Drawing.SystemColors.Info;
            this.btn_editPlace.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_editPlace.Location = new System.Drawing.Point(940, 47);
            this.btn_editPlace.Name = "btn_editPlace";
            this.btn_editPlace.Size = new System.Drawing.Size(121, 51);
            this.btn_editPlace.TabIndex = 29;
            this.btn_editPlace.Text = "地點新增";
            this.btn_editPlace.UseVisualStyleBackColor = false;
            this.btn_editPlace.Click += new System.EventHandler(this.btn_editPlace_Click);
            // 
            // btn_editType
            // 
            this.btn_editType.BackColor = System.Drawing.SystemColors.Info;
            this.btn_editType.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_editType.Location = new System.Drawing.Point(940, 111);
            this.btn_editType.Name = "btn_editType";
            this.btn_editType.Size = new System.Drawing.Size(121, 51);
            this.btn_editType.TabIndex = 30;
            this.btn_editType.Text = "分類新增";
            this.btn_editType.UseVisualStyleBackColor = false;
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.btn_editType);
            this.Controls.Add(this.btn_editPlace);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cb_currency);
            this.Controls.Add(this.btn_MonthDatList);
            this.Controls.Add(this.btn_InputList);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_PlaceTypeS);
            this.Controls.Add(this.cb_PlaceTypeB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_receiptNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TypeS);
            this.Controls.Add(this.cb_TypeB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker_spentDT);
            this.Controls.Add(this.panel_payment);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Input";
            this.Text = "TrackExpense - 輸入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_payment.ResumeLayout(false);
            this.panel_payment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker_spentDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Content;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_EasyCard;
        private System.Windows.Forms.RadioButton rb_CreditCard;
        private System.Windows.Forms.Panel panel_payment;
        private System.Windows.Forms.ComboBox cb_payCrditCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_payType_Expense;
        private System.Windows.Forms.RadioButton rb_payType_InCome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_TypeB;
        private System.Windows.Forms.ComboBox cb_TypeS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_receiptNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_PlaceTypeB;
        private System.Windows.Forms.ComboBox cb_PlaceTypeS;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_InputList;
        private System.Windows.Forms.Button btn_MonthDatList;
        private System.Windows.Forms.ComboBox cb_currency;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_editPlace;
        private System.Windows.Forms.Button btn_editType;
    }
}

