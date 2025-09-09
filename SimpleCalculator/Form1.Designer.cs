namespace SimpleCalculator
{
    partial class Form1
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
            tableLayoutPanel2 = new TableLayoutPanel();
            button21 = new Button();
            button1 = new Button();
            button24 = new Button();
            button23 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.ForeColor = SystemColors.ButtonFace;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(755, 626);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button21, 2, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 5);
            tableLayoutPanel2.Controls.Add(button24, 3, 5);
            tableLayoutPanel2.Controls.Add(button23, 2, 5);
            tableLayoutPanel2.Controls.Add(button20, 3, 4);
            tableLayoutPanel2.Controls.Add(button19, 2, 4);
            tableLayoutPanel2.Controls.Add(button18, 1, 4);
            tableLayoutPanel2.Controls.Add(button17, 0, 4);
            tableLayoutPanel2.Controls.Add(button16, 3, 3);
            tableLayoutPanel2.Controls.Add(button15, 2, 3);
            tableLayoutPanel2.Controls.Add(button14, 1, 3);
            tableLayoutPanel2.Controls.Add(button13, 0, 3);
            tableLayoutPanel2.Controls.Add(button12, 3, 2);
            tableLayoutPanel2.Controls.Add(button11, 2, 2);
            tableLayoutPanel2.Controls.Add(button10, 1, 2);
            tableLayoutPanel2.Controls.Add(button9, 0, 2);
            tableLayoutPanel2.Controls.Add(button8, 3, 1);
            tableLayoutPanel2.Controls.Add(button7, 2, 1);
            tableLayoutPanel2.Controls.Add(button6, 1, 1);
            tableLayoutPanel2.Controls.Add(button5, 0, 1);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Arial Rounded MT Bold", 12F);
            tableLayoutPanel2.Location = new Point(3, 158);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(749, 465);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button21
            // 
            button21.BackColor = Color.SeaShell;
            button21.BackgroundImageLayout = ImageLayout.None;
            button21.Dock = DockStyle.Fill;
            button21.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button21.ForeColor = Color.DarkMagenta;
            button21.Location = new Point(377, 3);
            button21.Name = "button21";
            button21.Size = new Size(181, 71);
            button21.TabIndex = 33;
            button21.Text = "+/-";
            button21.UseVisualStyleBackColor = false;
            button21.Click += buttonPositiveNegative_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            tableLayoutPanel2.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button1.ForeColor = Color.Sienna;
            button1.Location = new Point(3, 388);
            button1.Name = "button1";
            button1.Size = new Size(368, 74);
            button1.TabIndex = 30;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonZero_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.LightCoral;
            button24.Dock = DockStyle.Fill;
            button24.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button24.ForeColor = SystemColors.ButtonHighlight;
            button24.Location = new Point(564, 388);
            button24.Name = "button24";
            button24.Size = new Size(182, 74);
            button24.TabIndex = 25;
            button24.Text = "=";
            button24.UseVisualStyleBackColor = false;
            button24.Click += buttonEqual_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.LavenderBlush;
            button23.Dock = DockStyle.Fill;
            button23.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button23.ForeColor = Color.Sienna;
            button23.Location = new Point(377, 388);
            button23.Name = "button23";
            button23.Size = new Size(181, 74);
            button23.TabIndex = 24;
            button23.Text = ".";
            button23.UseVisualStyleBackColor = false;
            button23.Click += buttonDecimal_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.GhostWhite;
            button20.Dock = DockStyle.Fill;
            button20.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button20.ForeColor = Color.DarkMagenta;
            button20.Location = new Point(564, 311);
            button20.Name = "button20";
            button20.Size = new Size(182, 71);
            button20.TabIndex = 21;
            button20.Text = "+";
            button20.UseVisualStyleBackColor = false;
            button20.Click += buttonAddition_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.LavenderBlush;
            button19.Dock = DockStyle.Fill;
            button19.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button19.ForeColor = Color.Sienna;
            button19.Location = new Point(377, 311);
            button19.Name = "button19";
            button19.Size = new Size(181, 71);
            button19.TabIndex = 20;
            button19.Text = "1";
            button19.UseVisualStyleBackColor = false;
            button19.Click += buttonOne_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.LavenderBlush;
            button18.Dock = DockStyle.Fill;
            button18.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button18.ForeColor = Color.Sienna;
            button18.Location = new Point(190, 311);
            button18.Name = "button18";
            button18.Size = new Size(181, 71);
            button18.TabIndex = 19;
            button18.Text = "2";
            button18.UseVisualStyleBackColor = false;
            button18.Click += buttonTwo_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.LavenderBlush;
            button17.Dock = DockStyle.Fill;
            button17.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button17.ForeColor = Color.Sienna;
            button17.Location = new Point(3, 311);
            button17.Name = "button17";
            button17.Size = new Size(181, 71);
            button17.TabIndex = 18;
            button17.Text = "3";
            button17.UseVisualStyleBackColor = false;
            button17.Click += buttonThree_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.GhostWhite;
            button16.Dock = DockStyle.Fill;
            button16.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button16.ForeColor = Color.DarkMagenta;
            button16.Location = new Point(564, 234);
            button16.Name = "button16";
            button16.Size = new Size(182, 71);
            button16.TabIndex = 17;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonSubtraction_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.LavenderBlush;
            button15.Dock = DockStyle.Fill;
            button15.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button15.ForeColor = Color.Sienna;
            button15.Location = new Point(377, 234);
            button15.Name = "button15";
            button15.Size = new Size(181, 71);
            button15.TabIndex = 16;
            button15.Text = "6";
            button15.UseVisualStyleBackColor = false;
            button15.Click += buttonSix_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.LavenderBlush;
            button14.Dock = DockStyle.Fill;
            button14.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button14.ForeColor = Color.Sienna;
            button14.Location = new Point(190, 234);
            button14.Name = "button14";
            button14.Size = new Size(181, 71);
            button14.TabIndex = 15;
            button14.Text = "5";
            button14.UseVisualStyleBackColor = false;
            button14.Click += buttonFive_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LavenderBlush;
            button13.Dock = DockStyle.Fill;
            button13.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button13.ForeColor = Color.Sienna;
            button13.Location = new Point(3, 234);
            button13.Name = "button13";
            button13.Size = new Size(181, 71);
            button13.TabIndex = 14;
            button13.Text = "4";
            button13.UseVisualStyleBackColor = false;
            button13.Click += buttonFour_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.GhostWhite;
            button12.Dock = DockStyle.Fill;
            button12.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button12.ForeColor = Color.DarkMagenta;
            button12.Location = new Point(564, 157);
            button12.Name = "button12";
            button12.Size = new Size(182, 71);
            button12.TabIndex = 13;
            button12.Text = "×";
            button12.UseVisualStyleBackColor = false;
            button12.Click += buttonMultiplicationClick;
            // 
            // button11
            // 
            button11.BackColor = Color.LavenderBlush;
            button11.Dock = DockStyle.Fill;
            button11.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button11.ForeColor = Color.Sienna;
            button11.Location = new Point(377, 157);
            button11.Name = "button11";
            button11.Size = new Size(181, 71);
            button11.TabIndex = 12;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonNine_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LavenderBlush;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button10.ForeColor = Color.Sienna;
            button10.Location = new Point(190, 157);
            button10.Name = "button10";
            button10.Size = new Size(181, 71);
            button10.TabIndex = 11;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonEight_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LavenderBlush;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button9.ForeColor = Color.Sienna;
            button9.Location = new Point(3, 157);
            button9.Name = "button9";
            button9.Size = new Size(181, 71);
            button9.TabIndex = 10;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonSeven_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.GhostWhite;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button8.ForeColor = Color.DarkMagenta;
            button8.Location = new Point(564, 80);
            button8.Name = "button8";
            button8.Size = new Size(182, 71);
            button8.TabIndex = 9;
            button8.Text = "÷";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonDivision_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.GhostWhite;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(377, 80);
            button7.Name = "button7";
            button7.Size = new Size(181, 71);
            button7.TabIndex = 8;
            button7.Text = "%";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonPercentage_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.GhostWhite;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button6.ForeColor = Color.DarkMagenta;
            button6.Location = new Point(190, 80);
            button6.Name = "button6";
            button6.Size = new Size(181, 71);
            button6.TabIndex = 7;
            button6.Text = "( )";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonOpenCloseParentheses_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaShell;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(3, 80);
            button5.Name = "button5";
            button5.Size = new Size(181, 71);
            button5.TabIndex = 6;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonAC_click;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(564, 3);
            button4.Name = "button4";
            button4.Size = new Size(182, 71);
            button4.TabIndex = 3;
            button4.Text = "⌫";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonBackSpace_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(749, 62);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria Math", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(749, 93);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 627);
            MinimumSize = new Size(400, 700);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button24;
        private Button button23;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button21;
    }
}
