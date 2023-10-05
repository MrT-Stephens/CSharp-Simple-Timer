namespace Timer_MrT
{
    partial class Timer_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer_Form));
            tableLayoutPanel1 = new TableLayoutPanel();
            lapResetBtn = new Button();
            startStopBtn = new Button();
            lapsTextBox = new TextBox();
            timeTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lapResetBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(startStopBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(lapsTextBox, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 69);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(360, 181);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lapResetBtn
            // 
            lapResetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lapResetBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(lapResetBtn, 2);
            lapResetBtn.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lapResetBtn.ForeColor = SystemColors.InfoText;
            lapResetBtn.Location = new Point(3, 137);
            lapResetBtn.Margin = new Padding(3, 2, 3, 2);
            lapResetBtn.Name = "lapResetBtn";
            lapResetBtn.Size = new Size(138, 42);
            lapResetBtn.TabIndex = 1;
            lapResetBtn.Text = "Reset";
            lapResetBtn.UseVisualStyleBackColor = true;
            lapResetBtn.Click += lapResetBtn_Click;
            // 
            // startStopBtn
            // 
            startStopBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startStopBtn.AutoSize = true;
            startStopBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(startStopBtn, 2);
            startStopBtn.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            startStopBtn.ForeColor = SystemColors.InfoText;
            startStopBtn.Location = new Point(219, 137);
            startStopBtn.Margin = new Padding(3, 2, 3, 2);
            startStopBtn.Name = "startStopBtn";
            startStopBtn.Size = new Size(138, 42);
            startStopBtn.TabIndex = 2;
            startStopBtn.Text = "Start";
            startStopBtn.UseVisualStyleBackColor = true;
            startStopBtn.Click += startStopBtn_Click;
            // 
            // lapsTextBox
            // 
            lapsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lapsTextBox.BackColor = SystemColors.Control;
            lapsTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(lapsTextBox, 5);
            lapsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lapsTextBox.ForeColor = SystemColors.InfoText;
            lapsTextBox.Location = new Point(3, 2);
            lapsTextBox.Margin = new Padding(3, 2, 3, 2);
            lapsTextBox.Multiline = true;
            lapsTextBox.Name = "lapsTextBox";
            lapsTextBox.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(lapsTextBox, 3);
            lapsTextBox.ScrollBars = ScrollBars.Both;
            lapsTextBox.Size = new Size(354, 131);
            lapsTextBox.TabIndex = 3;
            lapsTextBox.TextAlign = HorizontalAlignment.Center;
            lapsTextBox.WordWrap = false;
            // 
            // timeTextBox
            // 
            timeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timeTextBox.BackColor = SystemColors.Control;
            timeTextBox.BorderStyle = BorderStyle.None;
            timeTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            timeTextBox.ForeColor = SystemColors.InfoText;
            timeTextBox.Location = new Point(12, 11);
            timeTextBox.Margin = new Padding(3, 2, 3, 2);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.Size = new Size(360, 54);
            timeTextBox.TabIndex = 0;
            timeTextBox.Text = "00:00:00.000000";
            timeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Timer_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 261);
            Controls.Add(timeTextBox);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(400, 300);
            Name = "Timer_Form";
            Text = "Timer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox timeTextBox;
        private Button lapResetBtn;
        private Button startStopBtn;
        private TextBox lapsTextBox;
    }
}