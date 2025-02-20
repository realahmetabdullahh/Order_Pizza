namespace Simple_Pizza_Order_Menu
{
    partial class main
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
            this.Header_Label = new System.Windows.Forms.Label();
            this.grSize = new System.Windows.Forms.GroupBox();
            this.SizeRbBig = new System.Windows.Forms.RadioButton();
            this.SizeRbMedium = new System.Windows.Forms.RadioButton();
            this.SizeRBSmall = new System.Windows.Forms.RadioButton();
            this.grToppings = new System.Windows.Forms.GroupBox();
            this.checkToppingsPeppers = new System.Windows.Forms.CheckBox();
            this.checkToppingsOlives = new System.Windows.Forms.CheckBox();
            this.checkToppingsOnion = new System.Windows.Forms.CheckBox();
            this.checkToppingsTomatoes = new System.Windows.Forms.CheckBox();
            this.checkToppingsMushroom = new System.Windows.Forms.CheckBox();
            this.checkToppingsExtraChees = new System.Windows.Forms.CheckBox();
            this.grCursorType = new System.Windows.Forms.GroupBox();
            this.CursorTypeRbThick = new System.Windows.Forms.RadioButton();
            this.CursorTypeRbThin = new System.Windows.Forms.RadioButton();
            this.grWhereToEat = new System.Windows.Forms.GroupBox();
            this.WhereToEatRbOut = new System.Windows.Forms.RadioButton();
            this.WhereToEatRbIn = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ORDER_SUMMARY_LABEL = new System.Windows.Forms.Label();
            this.SizeAtSummaryLabel = new System.Windows.Forms.Label();
            this.ToppingsAtSummaryLabel = new System.Windows.Forms.Label();
            this.CrustTypeAtSummaryLabel = new System.Windows.Forms.Label();
            this.WhereToEatInSummaryLabel = new System.Windows.Forms.Label();
            this.TotalPriceInSummaryLabel = new System.Windows.Forms.Label();
            this.SizeAtSummary = new System.Windows.Forms.TextBox();
            this.ToppingsAtSummary = new System.Windows.Forms.TextBox();
            this.CrustTypeAtSummary = new System.Windows.Forms.TextBox();
            this.WhereToEatAtSummary = new System.Windows.Forms.TextBox();
            this.TotalPriceAtSummary = new System.Windows.Forms.TextBox();
            this.grSize.SuspendLayout();
            this.grToppings.SuspendLayout();
            this.grCursorType.SuspendLayout();
            this.grWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Label.ForeColor = System.Drawing.Color.Maroon;
            this.Header_Label.Location = new System.Drawing.Point(291, 42);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(591, 69);
            this.Header_Label.TabIndex = 0;
            this.Header_Label.Text = "MAKE YOUR PIZZA";
            // 
            // grSize
            // 
            this.grSize.Controls.Add(this.SizeRbBig);
            this.grSize.Controls.Add(this.SizeRbMedium);
            this.grSize.Controls.Add(this.SizeRBSmall);
            this.grSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grSize.Location = new System.Drawing.Point(12, 135);
            this.grSize.Name = "grSize";
            this.grSize.Size = new System.Drawing.Size(256, 157);
            this.grSize.TabIndex = 1;
            this.grSize.TabStop = false;
            this.grSize.Text = "SIZE";
            // 
            // SizeRbBig
            // 
            this.SizeRbBig.AutoSize = true;
            this.SizeRbBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeRbBig.Location = new System.Drawing.Point(20, 122);
            this.SizeRbBig.Name = "SizeRbBig";
            this.SizeRbBig.Size = new System.Drawing.Size(69, 29);
            this.SizeRbBig.TabIndex = 2;
            this.SizeRbBig.TabStop = true;
            this.SizeRbBig.Tag = "40";
            this.SizeRbBig.Text = "BIG";
            this.SizeRbBig.UseVisualStyleBackColor = true;
            this.SizeRbBig.CheckedChanged += new System.EventHandler(this.SizeRbBig_CheckedChanged);
            // 
            // SizeRbMedium
            // 
            this.SizeRbMedium.AutoSize = true;
            this.SizeRbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeRbMedium.Location = new System.Drawing.Point(20, 85);
            this.SizeRbMedium.Name = "SizeRbMedium";
            this.SizeRbMedium.Size = new System.Drawing.Size(119, 29);
            this.SizeRbMedium.TabIndex = 1;
            this.SizeRbMedium.TabStop = true;
            this.SizeRbMedium.Tag = "35";
            this.SizeRbMedium.Text = "MEDIUM";
            this.SizeRbMedium.UseVisualStyleBackColor = true;
            this.SizeRbMedium.CheckedChanged += new System.EventHandler(this.SizeRbMedium_CheckedChanged);
            // 
            // SizeRBSmall
            // 
            this.SizeRBSmall.AutoSize = true;
            this.SizeRBSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeRBSmall.Location = new System.Drawing.Point(20, 50);
            this.SizeRBSmall.Name = "SizeRBSmall";
            this.SizeRBSmall.Size = new System.Drawing.Size(105, 29);
            this.SizeRBSmall.TabIndex = 0;
            this.SizeRBSmall.TabStop = true;
            this.SizeRBSmall.Tag = "30";
            this.SizeRBSmall.Text = "SMALL";
            this.SizeRBSmall.UseVisualStyleBackColor = true;
            this.SizeRBSmall.CheckedChanged += new System.EventHandler(this.SizeRBSmall_CheckedChanged);
            // 
            // grToppings
            // 
            this.grToppings.Controls.Add(this.checkToppingsPeppers);
            this.grToppings.Controls.Add(this.checkToppingsOlives);
            this.grToppings.Controls.Add(this.checkToppingsOnion);
            this.grToppings.Controls.Add(this.checkToppingsTomatoes);
            this.grToppings.Controls.Add(this.checkToppingsMushroom);
            this.grToppings.Controls.Add(this.checkToppingsExtraChees);
            this.grToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grToppings.Location = new System.Drawing.Point(339, 135);
            this.grToppings.Name = "grToppings";
            this.grToppings.Size = new System.Drawing.Size(357, 157);
            this.grToppings.TabIndex = 2;
            this.grToppings.TabStop = false;
            this.grToppings.Text = "TOPPINGS";
            // 
            // checkToppingsPeppers
            // 
            this.checkToppingsPeppers.AutoSize = true;
            this.checkToppingsPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsPeppers.Location = new System.Drawing.Point(179, 106);
            this.checkToppingsPeppers.Name = "checkToppingsPeppers";
            this.checkToppingsPeppers.Size = new System.Drawing.Size(172, 22);
            this.checkToppingsPeppers.TabIndex = 5;
            this.checkToppingsPeppers.Tag = "5";
            this.checkToppingsPeppers.Text = "GREEN PEPPERS";
            this.checkToppingsPeppers.UseVisualStyleBackColor = true;
            this.checkToppingsPeppers.CheckedChanged += new System.EventHandler(this.checkToppingsPeppers_CheckedChanged);
            // 
            // checkToppingsOlives
            // 
            this.checkToppingsOlives.AutoSize = true;
            this.checkToppingsOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsOlives.Location = new System.Drawing.Point(179, 78);
            this.checkToppingsOlives.Name = "checkToppingsOlives";
            this.checkToppingsOlives.Size = new System.Drawing.Size(88, 22);
            this.checkToppingsOlives.TabIndex = 4;
            this.checkToppingsOlives.Tag = "5";
            this.checkToppingsOlives.Text = "OLIVES";
            this.checkToppingsOlives.UseVisualStyleBackColor = true;
            this.checkToppingsOlives.CheckedChanged += new System.EventHandler(this.checkToppingsOlives_CheckedChanged);
            // 
            // checkToppingsOnion
            // 
            this.checkToppingsOnion.AutoSize = true;
            this.checkToppingsOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsOnion.Location = new System.Drawing.Point(179, 50);
            this.checkToppingsOnion.Name = "checkToppingsOnion";
            this.checkToppingsOnion.Size = new System.Drawing.Size(84, 22);
            this.checkToppingsOnion.TabIndex = 3;
            this.checkToppingsOnion.Tag = "5";
            this.checkToppingsOnion.Text = "ONION";
            this.checkToppingsOnion.UseVisualStyleBackColor = true;
            this.checkToppingsOnion.CheckedChanged += new System.EventHandler(this.checkToppingsOnion_CheckedChanged);
            // 
            // checkToppingsTomatoes
            // 
            this.checkToppingsTomatoes.AutoSize = true;
            this.checkToppingsTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsTomatoes.Location = new System.Drawing.Point(19, 106);
            this.checkToppingsTomatoes.Name = "checkToppingsTomatoes";
            this.checkToppingsTomatoes.Size = new System.Drawing.Size(122, 22);
            this.checkToppingsTomatoes.TabIndex = 2;
            this.checkToppingsTomatoes.Tag = "5";
            this.checkToppingsTomatoes.Text = "TOMATOES";
            this.checkToppingsTomatoes.UseVisualStyleBackColor = true;
            this.checkToppingsTomatoes.CheckedChanged += new System.EventHandler(this.checkToppingsTomatoes_CheckedChanged);
            // 
            // checkToppingsMushroom
            // 
            this.checkToppingsMushroom.AutoSize = true;
            this.checkToppingsMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsMushroom.Location = new System.Drawing.Point(19, 78);
            this.checkToppingsMushroom.Name = "checkToppingsMushroom";
            this.checkToppingsMushroom.Size = new System.Drawing.Size(142, 22);
            this.checkToppingsMushroom.TabIndex = 1;
            this.checkToppingsMushroom.Tag = "5";
            this.checkToppingsMushroom.Text = "MUSHROOMS";
            this.checkToppingsMushroom.UseVisualStyleBackColor = true;
            this.checkToppingsMushroom.CheckedChanged += new System.EventHandler(this.checkToppingsMushroom_CheckedChanged);
            // 
            // checkToppingsExtraChees
            // 
            this.checkToppingsExtraChees.AutoSize = true;
            this.checkToppingsExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkToppingsExtraChees.Location = new System.Drawing.Point(19, 50);
            this.checkToppingsExtraChees.Name = "checkToppingsExtraChees";
            this.checkToppingsExtraChees.Size = new System.Drawing.Size(146, 22);
            this.checkToppingsExtraChees.TabIndex = 0;
            this.checkToppingsExtraChees.Tag = "5";
            this.checkToppingsExtraChees.Text = "EXTRA CHEES";
            this.checkToppingsExtraChees.UseVisualStyleBackColor = true;
            this.checkToppingsExtraChees.CheckedChanged += new System.EventHandler(this.checkToppingsExtraChees_CheckedChanged);
            // 
            // grCursorType
            // 
            this.grCursorType.Controls.Add(this.CursorTypeRbThick);
            this.grCursorType.Controls.Add(this.CursorTypeRbThin);
            this.grCursorType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grCursorType.Location = new System.Drawing.Point(12, 324);
            this.grCursorType.Name = "grCursorType";
            this.grCursorType.Size = new System.Drawing.Size(256, 184);
            this.grCursorType.TabIndex = 3;
            this.grCursorType.TabStop = false;
            this.grCursorType.Text = "CURSOR TYPE";
            // 
            // CursorTypeRbThick
            // 
            this.CursorTypeRbThick.AutoSize = true;
            this.CursorTypeRbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursorTypeRbThick.Location = new System.Drawing.Point(20, 130);
            this.CursorTypeRbThick.Name = "CursorTypeRbThick";
            this.CursorTypeRbThick.Size = new System.Drawing.Size(99, 29);
            this.CursorTypeRbThick.TabIndex = 2;
            this.CursorTypeRbThick.TabStop = true;
            this.CursorTypeRbThick.Tag = "10";
            this.CursorTypeRbThick.Text = "THICK";
            this.CursorTypeRbThick.UseVisualStyleBackColor = true;
            this.CursorTypeRbThick.CheckedChanged += new System.EventHandler(this.CursorTypeRbThick_CheckedChanged);
            // 
            // CursorTypeRbThin
            // 
            this.CursorTypeRbThin.AutoSize = true;
            this.CursorTypeRbThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursorTypeRbThin.Location = new System.Drawing.Point(20, 74);
            this.CursorTypeRbThin.Name = "CursorTypeRbThin";
            this.CursorTypeRbThin.Size = new System.Drawing.Size(83, 29);
            this.CursorTypeRbThin.TabIndex = 1;
            this.CursorTypeRbThin.TabStop = true;
            this.CursorTypeRbThin.Tag = "0";
            this.CursorTypeRbThin.Text = "THIN";
            this.CursorTypeRbThin.UseVisualStyleBackColor = true;
            this.CursorTypeRbThin.CheckedChanged += new System.EventHandler(this.CursorTypeRbThin_CheckedChanged);
            // 
            // grWhereToEat
            // 
            this.grWhereToEat.Controls.Add(this.WhereToEatRbOut);
            this.grWhereToEat.Controls.Add(this.WhereToEatRbIn);
            this.grWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grWhereToEat.Location = new System.Drawing.Point(339, 324);
            this.grWhereToEat.Name = "grWhereToEat";
            this.grWhereToEat.Size = new System.Drawing.Size(357, 184);
            this.grWhereToEat.TabIndex = 4;
            this.grWhereToEat.TabStop = false;
            this.grWhereToEat.Text = "WHERE TO EAT";
            // 
            // WhereToEatRbOut
            // 
            this.WhereToEatRbOut.AutoSize = true;
            this.WhereToEatRbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereToEatRbOut.Location = new System.Drawing.Point(189, 74);
            this.WhereToEatRbOut.Name = "WhereToEatRbOut";
            this.WhereToEatRbOut.Size = new System.Drawing.Size(143, 29);
            this.WhereToEatRbOut.TabIndex = 2;
            this.WhereToEatRbOut.TabStop = true;
            this.WhereToEatRbOut.Text = "TAKE OUT";
            this.WhereToEatRbOut.UseVisualStyleBackColor = true;
            this.WhereToEatRbOut.CheckedChanged += new System.EventHandler(this.WhereToEatRbOut_CheckedChanged);
            // 
            // WhereToEatRbIn
            // 
            this.WhereToEatRbIn.AutoSize = true;
            this.WhereToEatRbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereToEatRbIn.Location = new System.Drawing.Point(38, 74);
            this.WhereToEatRbIn.Name = "WhereToEatRbIn";
            this.WhereToEatRbIn.Size = new System.Drawing.Size(103, 29);
            this.WhereToEatRbIn.TabIndex = 1;
            this.WhereToEatRbIn.TabStop = true;
            this.WhereToEatRbIn.Text = "EAT IN";
            this.WhereToEatRbIn.UseVisualStyleBackColor = true;
            this.WhereToEatRbIn.CheckedChanged += new System.EventHandler(this.WhereToEatRbIn_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(78, 556);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 48);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(426, 556);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 48);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ORDER_SUMMARY_LABEL
            // 
            this.ORDER_SUMMARY_LABEL.AutoSize = true;
            this.ORDER_SUMMARY_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDER_SUMMARY_LABEL.Location = new System.Drawing.Point(806, 135);
            this.ORDER_SUMMARY_LABEL.Name = "ORDER_SUMMARY_LABEL";
            this.ORDER_SUMMARY_LABEL.Size = new System.Drawing.Size(156, 18);
            this.ORDER_SUMMARY_LABEL.TabIndex = 7;
            this.ORDER_SUMMARY_LABEL.Text = "ORDER SUMMARY";
            // 
            // SizeAtSummaryLabel
            // 
            this.SizeAtSummaryLabel.AutoSize = true;
            this.SizeAtSummaryLabel.Location = new System.Drawing.Point(702, 171);
            this.SizeAtSummaryLabel.Name = "SizeAtSummaryLabel";
            this.SizeAtSummaryLabel.Size = new System.Drawing.Size(103, 36);
            this.SizeAtSummaryLabel.TabIndex = 8;
            this.SizeAtSummaryLabel.Text = "SIZE: ";
            // 
            // ToppingsAtSummaryLabel
            // 
            this.ToppingsAtSummaryLabel.AutoSize = true;
            this.ToppingsAtSummaryLabel.Location = new System.Drawing.Point(702, 220);
            this.ToppingsAtSummaryLabel.Name = "ToppingsAtSummaryLabel";
            this.ToppingsAtSummaryLabel.Size = new System.Drawing.Size(185, 36);
            this.ToppingsAtSummaryLabel.TabIndex = 9;
            this.ToppingsAtSummaryLabel.Text = "TOPPINGS:";
            // 
            // CrustTypeAtSummaryLabel
            // 
            this.CrustTypeAtSummaryLabel.AutoSize = true;
            this.CrustTypeAtSummaryLabel.Location = new System.Drawing.Point(702, 340);
            this.CrustTypeAtSummaryLabel.Name = "CrustTypeAtSummaryLabel";
            this.CrustTypeAtSummaryLabel.Size = new System.Drawing.Size(223, 36);
            this.CrustTypeAtSummaryLabel.TabIndex = 10;
            this.CrustTypeAtSummaryLabel.Text = "CRUST TYPE:";
            // 
            // WhereToEatInSummaryLabel
            // 
            this.WhereToEatInSummaryLabel.AutoSize = true;
            this.WhereToEatInSummaryLabel.Location = new System.Drawing.Point(702, 434);
            this.WhereToEatInSummaryLabel.Name = "WhereToEatInSummaryLabel";
            this.WhereToEatInSummaryLabel.Size = new System.Drawing.Size(150, 36);
            this.WhereToEatInSummaryLabel.TabIndex = 11;
            this.WhereToEatInSummaryLabel.Text = "WHERE: ";
            // 
            // TotalPriceInSummaryLabel
            // 
            this.TotalPriceInSummaryLabel.AutoSize = true;
            this.TotalPriceInSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceInSummaryLabel.Location = new System.Drawing.Point(714, 547);
            this.TotalPriceInSummaryLabel.Name = "TotalPriceInSummaryLabel";
            this.TotalPriceInSummaryLabel.Size = new System.Drawing.Size(120, 18);
            this.TotalPriceInSummaryLabel.TabIndex = 12;
            this.TotalPriceInSummaryLabel.Text = "TOTAL PRICE:";
            // 
            // SizeAtSummary
            // 
            this.SizeAtSummary.BackColor = System.Drawing.Color.White;
            this.SizeAtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeAtSummary.Location = new System.Drawing.Point(820, 171);
            this.SizeAtSummary.Name = "SizeAtSummary";
            this.SizeAtSummary.Size = new System.Drawing.Size(153, 34);
            this.SizeAtSummary.TabIndex = 13;
            this.SizeAtSummary.TextChanged += new System.EventHandler(this.SizeAtSummary_TextChanged);
            // 
            // ToppingsAtSummary
            // 
            this.ToppingsAtSummary.BackColor = System.Drawing.Color.White;
            this.ToppingsAtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsAtSummary.Location = new System.Drawing.Point(717, 259);
            this.ToppingsAtSummary.Name = "ToppingsAtSummary";
            this.ToppingsAtSummary.Size = new System.Drawing.Size(288, 34);
            this.ToppingsAtSummary.TabIndex = 14;
            // 
            // CrustTypeAtSummary
            // 
            this.CrustTypeAtSummary.BackColor = System.Drawing.Color.White;
            this.CrustTypeAtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustTypeAtSummary.Location = new System.Drawing.Point(717, 385);
            this.CrustTypeAtSummary.Name = "CrustTypeAtSummary";
            this.CrustTypeAtSummary.Size = new System.Drawing.Size(153, 34);
            this.CrustTypeAtSummary.TabIndex = 15;
            // 
            // WhereToEatAtSummary
            // 
            this.WhereToEatAtSummary.BackColor = System.Drawing.Color.White;
            this.WhereToEatAtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereToEatAtSummary.Location = new System.Drawing.Point(717, 486);
            this.WhereToEatAtSummary.Name = "WhereToEatAtSummary";
            this.WhereToEatAtSummary.Size = new System.Drawing.Size(153, 34);
            this.WhereToEatAtSummary.TabIndex = 16;
            // 
            // TotalPriceAtSummary
            // 
            this.TotalPriceAtSummary.BackColor = System.Drawing.Color.White;
            this.TotalPriceAtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceAtSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TotalPriceAtSummary.Location = new System.Drawing.Point(835, 580);
            this.TotalPriceAtSummary.Name = "TotalPriceAtSummary";
            this.TotalPriceAtSummary.Size = new System.Drawing.Size(153, 41);
            this.TotalPriceAtSummary.TabIndex = 17;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 650);
            this.Controls.Add(this.TotalPriceAtSummary);
            this.Controls.Add(this.WhereToEatAtSummary);
            this.Controls.Add(this.CrustTypeAtSummary);
            this.Controls.Add(this.ToppingsAtSummary);
            this.Controls.Add(this.SizeAtSummary);
            this.Controls.Add(this.TotalPriceInSummaryLabel);
            this.Controls.Add(this.WhereToEatInSummaryLabel);
            this.Controls.Add(this.CrustTypeAtSummaryLabel);
            this.Controls.Add(this.ToppingsAtSummaryLabel);
            this.Controls.Add(this.SizeAtSummaryLabel);
            this.Controls.Add(this.ORDER_SUMMARY_LABEL);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grWhereToEat);
            this.Controls.Add(this.grCursorType);
            this.Controls.Add(this.grToppings);
            this.Controls.Add(this.grSize);
            this.Controls.Add(this.Header_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "main";
            this.Text = "Abdullah Pizza";
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.grToppings.ResumeLayout(false);
            this.grToppings.PerformLayout();
            this.grCursorType.ResumeLayout(false);
            this.grCursorType.PerformLayout();
            this.grWhereToEat.ResumeLayout(false);
            this.grWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.GroupBox grToppings;
        private System.Windows.Forms.GroupBox grCursorType;
        private System.Windows.Forms.GroupBox grWhereToEat;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox checkToppingsMushroom;
        private System.Windows.Forms.CheckBox checkToppingsExtraChees;
        private System.Windows.Forms.CheckBox checkToppingsTomatoes;
        private System.Windows.Forms.CheckBox checkToppingsPeppers;
        private System.Windows.Forms.CheckBox checkToppingsOlives;
        private System.Windows.Forms.CheckBox checkToppingsOnion;
        private System.Windows.Forms.Label ORDER_SUMMARY_LABEL;
        private System.Windows.Forms.RadioButton SizeRBSmall;
        private System.Windows.Forms.RadioButton SizeRbBig;
        private System.Windows.Forms.RadioButton SizeRbMedium;
        private System.Windows.Forms.RadioButton CursorTypeRbThick;
        private System.Windows.Forms.RadioButton CursorTypeRbThin;
        private System.Windows.Forms.RadioButton WhereToEatRbOut;
        private System.Windows.Forms.RadioButton WhereToEatRbIn;
        private System.Windows.Forms.Label SizeAtSummaryLabel;
        private System.Windows.Forms.Label ToppingsAtSummaryLabel;
        private System.Windows.Forms.Label CrustTypeAtSummaryLabel;
        private System.Windows.Forms.Label WhereToEatInSummaryLabel;
        private System.Windows.Forms.Label TotalPriceInSummaryLabel;
        private System.Windows.Forms.TextBox SizeAtSummary;
        private System.Windows.Forms.TextBox ToppingsAtSummary;
        private System.Windows.Forms.TextBox CrustTypeAtSummary;
        private System.Windows.Forms.TextBox WhereToEatAtSummary;
        private System.Windows.Forms.TextBox TotalPriceAtSummary;
    }
}

