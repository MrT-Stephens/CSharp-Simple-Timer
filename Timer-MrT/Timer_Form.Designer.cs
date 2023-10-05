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
            tableLayoutPanel1 = new TableLayoutPanel();
            timeTextBox = new TextBox();
            lapResetBtn = new Button();
            startStopBtn = new Button();
            lapsTextBox = new TextBox();
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
            tableLayoutPanel1.Controls.Add(timeTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(lapResetBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(startStopBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(lapsTextBox, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(358, 329);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // timeTextBox
            // 
            timeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timeTextBox.BackColor = SystemColors.WindowFrame;
            timeTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(timeTextBox, 5);
            timeTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            timeTextBox.ForeColor = SystemColors.MenuBar;
            timeTextBox.Location = new Point(3, 3);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.Size = new Size(352, 67);
            timeTextBox.TabIndex = 0;
            timeTextBox.Text = "00:00:00.00";
            timeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // lapResetBtn
            // 
            lapResetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lapResetBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(lapResetBtn, 2);
            lapResetBtn.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lapResetBtn.ForeColor = SystemColors.WindowFrame;
            lapResetBtn.Location = new Point(3, 249);
            lapResetBtn.Name = "lapResetBtn";
            lapResetBtn.Size = new Size(136, 77);
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
            startStopBtn.ForeColor = SystemColors.WindowFrame;
            startStopBtn.Location = new Point(216, 249);
            startStopBtn.Name = "startStopBtn";
            startStopBtn.Size = new Size(139, 77);
            startStopBtn.TabIndex = 2;
            startStopBtn.Text = "Start";
            startStopBtn.UseVisualStyleBackColor = true;
            startStopBtn.Click += startStopBtn_Click;
            // 
            // lapsTextBox
            // 
            lapsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lapsTextBox.BackColor = SystemColors.WindowFrame;
            lapsTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(lapsTextBox, 5);
            lapsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lapsTextBox.ForeColor = SystemColors.MenuBar;
            lapsTextBox.Location = new Point(3, 85);
            lapsTextBox.Multiline = true;
            lapsTextBox.Name = "lapsTextBox";
            tableLayoutPanel1.SetRowSpan(lapsTextBox, 2);
            lapsTextBox.ScrollBars = ScrollBars.Vertical;
            lapsTextBox.Size = new Size(352, 158);
            lapsTextBox.TabIndex = 3;
            lapsTextBox.TextAlign = HorizontalAlignment.Center;
            lapsTextBox.Visible = false;
            // 
            // Timer_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(382, 353);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 300);
            Name = "Timer_Form";
            Text = "Timer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox timeTextBox;
        private Button lapResetBtn;
        private Button startStopBtn;
        private TextBox lapsTextBox;
    }
}