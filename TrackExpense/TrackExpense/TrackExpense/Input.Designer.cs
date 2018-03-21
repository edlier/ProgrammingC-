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
            this.tp_InputAll = new System.Windows.Forms.TabControl();
            this.tp_InputExpense = new System.Windows.Forms.TabPage();
            this.tp_AddPlace = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_AddPlace_subB = new System.Windows.Forms.TabPage();
            this.dgv_PlaceB = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_AddPlaceB = new System.Windows.Forms.Button();
            this.btn_EditPlaceB_Cancel = new System.Windows.Forms.Button();
            this.tb_Hide_PlaceB_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_insertPlaceB = new System.Windows.Forms.TextBox();
            this.tp_AddPlace_subS = new System.Windows.Forms.TabPage();
            this.tb_SearchPlaceS_Des = new System.Windows.Forms.TextBox();
            this.cb_SearchPlaceS_BID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_EditS_TypeBList = new System.Windows.Forms.ComboBox();
            this.dgv_PlaceS = new System.Windows.Forms.DataGridView();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_btn_SEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dg_btn_SDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LinkBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddPlaceS = new System.Windows.Forms.Button();
            this.btn_EditPlaceS_Cancel = new System.Windows.Forms.Button();
            this.tb_Hide_PlaceS_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_insertPlaceS = new System.Windows.Forms.TextBox();
            this.panel_payment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tp_InputAll.SuspendLayout();
            this.tp_InputExpense.SuspendLayout();
            this.tp_AddPlace.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_AddPlace_subB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).BeginInit();
            this.tp_AddPlace_subS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceS)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker_spentDT
            // 
            this.datePicker_spentDT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePicker_spentDT.Location = new System.Drawing.Point(96, 20);
            this.datePicker_spentDT.Name = "datePicker_spentDT";
            this.datePicker_spentDT.Size = new System.Drawing.Size(200, 34);
            this.datePicker_spentDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "內容 : ";
            // 
            // tb_Content
            // 
            this.tb_Content.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Content.Location = new System.Drawing.Point(128, 84);
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.Size = new System.Drawing.Size(210, 34);
            this.tb_Content.TabIndex = 3;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Price.Location = new System.Drawing.Point(128, 144);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(145, 34);
            this.tb_Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(20, 147);
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
            this.panel_payment.Location = new System.Drawing.Point(25, 227);
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
            this.panel1.Location = new System.Drawing.Point(378, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 44);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(387, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "分類 : ";
            // 
            // cb_TypeB
            // 
            this.cb_TypeB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_TypeB.FormattingEnabled = true;
            this.cb_TypeB.Location = new System.Drawing.Point(451, 84);
            this.cb_TypeB.Name = "cb_TypeB";
            this.cb_TypeB.Size = new System.Drawing.Size(180, 33);
            this.cb_TypeB.TabIndex = 11;
            this.cb_TypeB.SelectedIndexChanged += new System.EventHandler(this.cb_TypeB_SelectedIndexChanged);
            // 
            // cb_TypeS
            // 
            this.cb_TypeS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_TypeS.FormattingEnabled = true;
            this.cb_TypeS.Location = new System.Drawing.Point(637, 84);
            this.cb_TypeS.Name = "cb_TypeS";
            this.cb_TypeS.Size = new System.Drawing.Size(191, 33);
            this.cb_TypeS.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(388, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "發票號碼 : ";
            // 
            // tb_receiptNum
            // 
            this.tb_receiptNum.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_receiptNum.Location = new System.Drawing.Point(505, 145);
            this.tb_receiptNum.Name = "tb_receiptNum";
            this.tb_receiptNum.Size = new System.Drawing.Size(143, 34);
            this.tb_receiptNum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "備註 : ";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tb_Note.Location = new System.Drawing.Point(96, 354);
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(250, 103);
            this.tb_Note.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(385, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "地點 : ";
            // 
            // cb_PlaceTypeB
            // 
            this.cb_PlaceTypeB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_PlaceTypeB.FormattingEnabled = true;
            this.cb_PlaceTypeB.Location = new System.Drawing.Point(456, 224);
            this.cb_PlaceTypeB.Name = "cb_PlaceTypeB";
            this.cb_PlaceTypeB.Size = new System.Drawing.Size(165, 33);
            this.cb_PlaceTypeB.TabIndex = 11;
            this.cb_PlaceTypeB.SelectedIndexChanged += new System.EventHandler(this.cb_PlaceTypeB_SelectedIndexChanged);
            // 
            // cb_PlaceTypeS
            // 
            this.cb_PlaceTypeS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cb_PlaceTypeS.FormattingEnabled = true;
            this.cb_PlaceTypeS.Location = new System.Drawing.Point(627, 224);
            this.cb_PlaceTypeS.Name = "cb_PlaceTypeS";
            this.cb_PlaceTypeS.Size = new System.Drawing.Size(280, 33);
            this.cb_PlaceTypeS.TabIndex = 23;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_Save.Location = new System.Drawing.Point(411, 406);
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
            this.btn_InputList.Location = new System.Drawing.Point(961, 437);
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
            this.btn_MonthDatList.Location = new System.Drawing.Point(961, 494);
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
            this.cb_currency.Location = new System.Drawing.Point(279, 145);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(93, 33);
            this.cb_currency.TabIndex = 27;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Reset.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_Reset.Location = new System.Drawing.Point(649, 3);
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
            this.btn_editPlace.Location = new System.Drawing.Point(1040, 51);
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
            this.btn_editType.Location = new System.Drawing.Point(1040, 115);
            this.btn_editType.Name = "btn_editType";
            this.btn_editType.Size = new System.Drawing.Size(121, 51);
            this.btn_editType.TabIndex = 30;
            this.btn_editType.Text = "分類新增";
            this.btn_editType.UseVisualStyleBackColor = false;
            // 
            // tp_InputAll
            // 
            this.tp_InputAll.Controls.Add(this.tp_InputExpense);
            this.tp_InputAll.Controls.Add(this.tp_AddPlace);
            this.tp_InputAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tp_InputAll.Location = new System.Drawing.Point(12, 12);
            this.tp_InputAll.Name = "tp_InputAll";
            this.tp_InputAll.SelectedIndex = 0;
            this.tp_InputAll.Size = new System.Drawing.Size(935, 663);
            this.tp_InputAll.TabIndex = 31;
            // 
            // tp_InputExpense
            // 
            this.tp_InputExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tp_InputExpense.Controls.Add(this.cb_TypeB);
            this.tp_InputExpense.Controls.Add(this.panel1);
            this.tp_InputExpense.Controls.Add(this.panel_payment);
            this.tp_InputExpense.Controls.Add(this.btn_Reset);
            this.tp_InputExpense.Controls.Add(this.datePicker_spentDT);
            this.tp_InputExpense.Controls.Add(this.cb_currency);
            this.tp_InputExpense.Controls.Add(this.label1);
            this.tp_InputExpense.Controls.Add(this.label2);
            this.tp_InputExpense.Controls.Add(this.tb_Content);
            this.tp_InputExpense.Controls.Add(this.btn_Save);
            this.tp_InputExpense.Controls.Add(this.label3);
            this.tp_InputExpense.Controls.Add(this.cb_PlaceTypeS);
            this.tp_InputExpense.Controls.Add(this.tb_Price);
            this.tp_InputExpense.Controls.Add(this.cb_PlaceTypeB);
            this.tp_InputExpense.Controls.Add(this.label5);
            this.tp_InputExpense.Controls.Add(this.label8);
            this.tp_InputExpense.Controls.Add(this.cb_TypeS);
            this.tp_InputExpense.Controls.Add(this.tb_Note);
            this.tp_InputExpense.Controls.Add(this.label6);
            this.tp_InputExpense.Controls.Add(this.label7);
            this.tp_InputExpense.Controls.Add(this.tb_receiptNum);
            this.tp_InputExpense.Location = new System.Drawing.Point(4, 34);
            this.tp_InputExpense.Name = "tp_InputExpense";
            this.tp_InputExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tp_InputExpense.Size = new System.Drawing.Size(927, 625);
            this.tp_InputExpense.TabIndex = 0;
            this.tp_InputExpense.Text = "Input Expense";
            this.tp_InputExpense.UseVisualStyleBackColor = true;
            // 
            // tp_AddPlace
            // 
            this.tp_AddPlace.Controls.Add(this.tabControl1);
            this.tp_AddPlace.Location = new System.Drawing.Point(4, 34);
            this.tp_AddPlace.Name = "tp_AddPlace";
            this.tp_AddPlace.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddPlace.Size = new System.Drawing.Size(927, 625);
            this.tp_AddPlace.TabIndex = 1;
            this.tp_AddPlace.Text = "Add - Place";
            this.tp_AddPlace.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_AddPlace_subB);
            this.tabControl1.Controls.Add(this.tp_AddPlace_subS);
            this.tabControl1.Location = new System.Drawing.Point(33, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 590);
            this.tabControl1.TabIndex = 36;
            // 
            // tp_AddPlace_subB
            // 
            this.tp_AddPlace_subB.Controls.Add(this.dgv_PlaceB);
            this.tp_AddPlace_subB.Controls.Add(this.btn_AddPlaceB);
            this.tp_AddPlace_subB.Controls.Add(this.btn_EditPlaceB_Cancel);
            this.tp_AddPlace_subB.Controls.Add(this.tb_Hide_PlaceB_ID);
            this.tp_AddPlace_subB.Controls.Add(this.label9);
            this.tp_AddPlace_subB.Controls.Add(this.label10);
            this.tp_AddPlace_subB.Controls.Add(this.tb_insertPlaceB);
            this.tp_AddPlace_subB.Location = new System.Drawing.Point(4, 34);
            this.tp_AddPlace_subB.Name = "tp_AddPlace_subB";
            this.tp_AddPlace_subB.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddPlace_subB.Size = new System.Drawing.Size(864, 453);
            this.tp_AddPlace_subB.TabIndex = 0;
            this.tp_AddPlace_subB.Text = "地點 - 大分類";
            this.tp_AddPlace_subB.UseVisualStyleBackColor = true;
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
            this.dgv_PlaceB.Size = new System.Drawing.Size(661, 340);
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
            // btn_AddPlaceB
            // 
            this.btn_AddPlaceB.BackColor = System.Drawing.SystemColors.Info;
            this.btn_AddPlaceB.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AddPlaceB.Location = new System.Drawing.Point(261, 367);
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
            this.btn_EditPlaceB_Cancel.Location = new System.Drawing.Point(395, 367);
            this.btn_EditPlaceB_Cancel.Name = "btn_EditPlaceB_Cancel";
            this.btn_EditPlaceB_Cancel.Size = new System.Drawing.Size(128, 51);
            this.btn_EditPlaceB_Cancel.TabIndex = 31;
            this.btn_EditPlaceB_Cancel.Text = "Cancel";
            this.btn_EditPlaceB_Cancel.UseVisualStyleBackColor = false;
            this.btn_EditPlaceB_Cancel.Click += new System.EventHandler(this.btn_EditPlaceB_Cancel_Click);
            // 
            // tb_Hide_PlaceB_ID
            // 
            this.tb_Hide_PlaceB_ID.Location = new System.Drawing.Point(638, 376);
            this.tb_Hide_PlaceB_ID.Name = "tb_Hide_PlaceB_ID";
            this.tb_Hide_PlaceB_ID.Size = new System.Drawing.Size(155, 34);
            this.tb_Hide_PlaceB_ID.TabIndex = 33;
            this.tb_Hide_PlaceB_ID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "地點 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "地點B ID : ";
            this.label10.Visible = false;
            // 
            // tb_insertPlaceB
            // 
            this.tb_insertPlaceB.Location = new System.Drawing.Point(94, 377);
            this.tb_insertPlaceB.Name = "tb_insertPlaceB";
            this.tb_insertPlaceB.Size = new System.Drawing.Size(155, 34);
            this.tb_insertPlaceB.TabIndex = 28;
            // 
            // tp_AddPlace_subS
            // 
            this.tp_AddPlace_subS.Controls.Add(this.tb_SearchPlaceS_Des);
            this.tp_AddPlace_subS.Controls.Add(this.cb_SearchPlaceS_BID);
            this.tp_AddPlace_subS.Controls.Add(this.label11);
            this.tp_AddPlace_subS.Controls.Add(this.cb_EditS_TypeBList);
            this.tp_AddPlace_subS.Controls.Add(this.dgv_PlaceS);
            this.tp_AddPlace_subS.Controls.Add(this.btn_AddPlaceS);
            this.tp_AddPlace_subS.Controls.Add(this.btn_EditPlaceS_Cancel);
            this.tp_AddPlace_subS.Controls.Add(this.tb_Hide_PlaceS_ID);
            this.tp_AddPlace_subS.Controls.Add(this.label12);
            this.tp_AddPlace_subS.Controls.Add(this.label13);
            this.tp_AddPlace_subS.Controls.Add(this.tb_insertPlaceS);
            this.tp_AddPlace_subS.Location = new System.Drawing.Point(4, 34);
            this.tp_AddPlace_subS.Name = "tp_AddPlace_subS";
            this.tp_AddPlace_subS.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddPlace_subS.Size = new System.Drawing.Size(864, 552);
            this.tp_AddPlace_subS.TabIndex = 2;
            this.tp_AddPlace_subS.Text = "地點 - 小分類";
            this.tp_AddPlace_subS.UseVisualStyleBackColor = true;
            // 
            // tb_SearchPlaceS_Des
            // 
            this.tb_SearchPlaceS_Des.Location = new System.Drawing.Point(232, 17);
            this.tb_SearchPlaceS_Des.Name = "tb_SearchPlaceS_Des";
            this.tb_SearchPlaceS_Des.Size = new System.Drawing.Size(155, 34);
            this.tb_SearchPlaceS_Des.TabIndex = 37;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "搜尋 : ";
            // 
            // cb_EditS_TypeBList
            // 
            this.cb_EditS_TypeBList.FormattingEnabled = true;
            this.cb_EditS_TypeBList.Location = new System.Drawing.Point(93, 448);
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
            this.SID,
            this.PlaceBType,
            this.Des,
            this.dg_btn_SEdit,
            this.dg_btn_SDel,
            this.LinkBID});
            this.dgv_PlaceS.Location = new System.Drawing.Point(18, 67);
            this.dgv_PlaceS.Name = "dgv_PlaceS";
            this.dgv_PlaceS.ReadOnly = true;
            this.dgv_PlaceS.RowTemplate.Height = 27;
            this.dgv_PlaceS.Size = new System.Drawing.Size(827, 365);
            this.dgv_PlaceS.TabIndex = 0;
            this.dgv_PlaceS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PlaceS_CellContentClick);
            // 
            // SID
            // 
            this.SID.DataPropertyName = "ID";
            this.SID.HeaderText = "ID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 80;
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
            this.btn_AddPlaceS.Location = new System.Drawing.Point(403, 438);
            this.btn_AddPlaceS.Name = "btn_AddPlaceS";
            this.btn_AddPlaceS.Size = new System.Drawing.Size(128, 51);
            this.btn_AddPlaceS.TabIndex = 30;
            this.btn_AddPlaceS.Text = "New Add";
            this.btn_AddPlaceS.UseVisualStyleBackColor = false;
            this.btn_AddPlaceS.Click += new System.EventHandler(this.btn_AddPlaceS_Click);
            // 
            // btn_EditPlaceS_Cancel
            // 
            this.btn_EditPlaceS_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_EditPlaceS_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_EditPlaceS_Cancel.Location = new System.Drawing.Point(537, 438);
            this.btn_EditPlaceS_Cancel.Name = "btn_EditPlaceS_Cancel";
            this.btn_EditPlaceS_Cancel.Size = new System.Drawing.Size(128, 51);
            this.btn_EditPlaceS_Cancel.TabIndex = 31;
            this.btn_EditPlaceS_Cancel.Text = "Cancel";
            this.btn_EditPlaceS_Cancel.UseVisualStyleBackColor = false;
            this.btn_EditPlaceS_Cancel.Click += new System.EventHandler(this.btn_EditPlaceS_Cancel_Click);
            // 
            // tb_Hide_PlaceS_ID
            // 
            this.tb_Hide_PlaceS_ID.Location = new System.Drawing.Point(780, 447);
            this.tb_Hide_PlaceS_ID.Name = "tb_Hide_PlaceS_ID";
            this.tb_Hide_PlaceS_ID.Size = new System.Drawing.Size(65, 34);
            this.tb_Hide_PlaceS_ID.TabIndex = 33;
            this.tb_Hide_PlaceS_ID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "地點 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(679, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "地點S ID : ";
            this.label13.Visible = false;
            // 
            // tb_insertPlaceS
            // 
            this.tb_insertPlaceS.Location = new System.Drawing.Point(242, 448);
            this.tb_insertPlaceS.Name = "tb_insertPlaceS";
            this.tb_insertPlaceS.Size = new System.Drawing.Size(155, 34);
            this.tb_insertPlaceS.TabIndex = 28;
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 687);
            this.Controls.Add(this.tp_InputAll);
            this.Controls.Add(this.btn_editType);
            this.Controls.Add(this.btn_editPlace);
            this.Controls.Add(this.btn_MonthDatList);
            this.Controls.Add(this.btn_InputList);
            this.Name = "Form_Input";
            this.Text = "TrackExpense - 輸入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_payment.ResumeLayout(false);
            this.panel_payment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp_InputAll.ResumeLayout(false);
            this.tp_InputExpense.ResumeLayout(false);
            this.tp_InputExpense.PerformLayout();
            this.tp_AddPlace.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_AddPlace_subB.ResumeLayout(false);
            this.tp_AddPlace_subB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceB)).EndInit();
            this.tp_AddPlace_subS.ResumeLayout(false);
            this.tp_AddPlace_subS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlaceS)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tp_InputAll;
        private System.Windows.Forms.TabPage tp_InputExpense;
        private System.Windows.Forms.TabPage tp_AddPlace;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_AddPlace_subB;
        private System.Windows.Forms.DataGridView dgv_PlaceB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.Button btn_AddPlaceB;
        private System.Windows.Forms.Button btn_EditPlaceB_Cancel;
        private System.Windows.Forms.TextBox tb_Hide_PlaceB_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_insertPlaceB;
        private System.Windows.Forms.TabPage tp_AddPlace_subS;
        private System.Windows.Forms.TextBox tb_SearchPlaceS_Des;
        private System.Windows.Forms.ComboBox cb_SearchPlaceS_BID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_EditS_TypeBList;
        private System.Windows.Forms.DataGridView dgv_PlaceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewButtonColumn dg_btn_SEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dg_btn_SDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkBID;
        private System.Windows.Forms.Button btn_AddPlaceS;
        private System.Windows.Forms.Button btn_EditPlaceS_Cancel;
        private System.Windows.Forms.TextBox tb_Hide_PlaceS_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_insertPlaceS;
    }
}

