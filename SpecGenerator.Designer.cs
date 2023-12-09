namespace SpecGenerator
{
    partial class SpecGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecGenerator));
            MenuListBox = new MenuItem();
            MenuNameTextBox = new TextBox();
            PageListBox = new MenuItem();
            PageNameTextBox = new TextBox();
            ActionListBox = new MenuItem();
            ActionNameTextBox = new TextBox();
            MenuAddButton = new Button();
            PageAddButton = new Button();
            ActionAddButton = new Button();
            TxtButton = new Button();
            MenuRemoveButton = new Button();
            PageRemoveButton = new Button();
            ActionRemoveButton = new Button();
            ExcelButton = new Button();
            SuspendLayout();
            // 
            // MenuListBox
            // 
            MenuListBox.FormattingEnabled = true;
            MenuListBox.ItemHeight = 15;
            MenuListBox.ItemName = "";
            MenuListBox.Location = new Point(12, 41);
            MenuListBox.Name = "MenuListBox";
            MenuListBox.Size = new Size(136, 244);
            MenuListBox.TabIndex = 3;
            MenuListBox.Click += MenuListBox_Click;
            // 
            // MenuNameTextBox
            // 
            MenuNameTextBox.Location = new Point(12, 12);
            MenuNameTextBox.Name = "MenuNameTextBox";
            MenuNameTextBox.PlaceholderText = "輸入Menu名稱";
            MenuNameTextBox.Size = new Size(136, 23);
            MenuNameTextBox.TabIndex = 0;
            // 
            // PageListBox
            // 
            PageListBox.DisplayMember = "ItemName";
            PageListBox.FormattingEnabled = true;
            PageListBox.ItemHeight = 15;
            PageListBox.ItemName = "";
            PageListBox.Location = new Point(281, 41);
            PageListBox.Name = "PageListBox";
            PageListBox.Size = new Size(136, 244);
            PageListBox.TabIndex = 4;
            PageListBox.Click += PageListBox_Click;
            // 
            // PageNameTextBox
            // 
            PageNameTextBox.Location = new Point(281, 12);
            PageNameTextBox.Name = "PageNameTextBox";
            PageNameTextBox.PlaceholderText = "輸入Page名稱";
            PageNameTextBox.Size = new Size(136, 23);
            PageNameTextBox.TabIndex = 1;
            // 
            // ActionListBox
            // 
            ActionListBox.DisplayMember = "ItemName";
            ActionListBox.FormattingEnabled = true;
            ActionListBox.ItemHeight = 15;
            ActionListBox.ItemName = "";
            ActionListBox.Location = new Point(550, 41);
            ActionListBox.Name = "ActionListBox";
            ActionListBox.Size = new Size(136, 244);
            ActionListBox.TabIndex = 5;
            // 
            // ActionNameTextBox
            // 
            ActionNameTextBox.Location = new Point(550, 12);
            ActionNameTextBox.Name = "ActionNameTextBox";
            ActionNameTextBox.PlaceholderText = "輸入Action名稱";
            ActionNameTextBox.Size = new Size(136, 23);
            ActionNameTextBox.TabIndex = 2;
            // 
            // MenuAddButton
            // 
            MenuAddButton.Location = new Point(154, 12);
            MenuAddButton.Name = "MenuAddButton";
            MenuAddButton.Size = new Size(75, 23);
            MenuAddButton.TabIndex = 6;
            MenuAddButton.Text = "加入";
            MenuAddButton.UseVisualStyleBackColor = true;
            MenuAddButton.Click += MenuAddButton_Click;
            // 
            // PageAddButton
            // 
            PageAddButton.Location = new Point(423, 11);
            PageAddButton.Name = "PageAddButton";
            PageAddButton.Size = new Size(75, 23);
            PageAddButton.TabIndex = 7;
            PageAddButton.Text = "加入";
            PageAddButton.UseVisualStyleBackColor = true;
            PageAddButton.Click += PageAddButton_Click;
            // 
            // ActionAddButton
            // 
            ActionAddButton.Location = new Point(692, 11);
            ActionAddButton.Name = "ActionAddButton";
            ActionAddButton.Size = new Size(75, 23);
            ActionAddButton.TabIndex = 8;
            ActionAddButton.Text = "加入";
            ActionAddButton.UseVisualStyleBackColor = true;
            ActionAddButton.Click += ActionAddButton_Click;
            // 
            // TxtButton
            // 
            TxtButton.Location = new Point(687, 415);
            TxtButton.Name = "TxtButton";
            TxtButton.Size = new Size(75, 23);
            TxtButton.TabIndex = 9;
            TxtButton.Text = "Txt";
            TxtButton.UseVisualStyleBackColor = true;
            TxtButton.Click += TxtButton_Click;
            // 
            // MenuRemoveButton
            // 
            MenuRemoveButton.Location = new Point(154, 41);
            MenuRemoveButton.Name = "MenuRemoveButton";
            MenuRemoveButton.Size = new Size(75, 23);
            MenuRemoveButton.TabIndex = 10;
            MenuRemoveButton.Text = "移除";
            MenuRemoveButton.UseVisualStyleBackColor = true;
            MenuRemoveButton.Click += MenuRemoveButton_Click;
            // 
            // PageRemoveButton
            // 
            PageRemoveButton.Location = new Point(423, 41);
            PageRemoveButton.Name = "PageRemoveButton";
            PageRemoveButton.Size = new Size(75, 23);
            PageRemoveButton.TabIndex = 11;
            PageRemoveButton.Text = "移除";
            PageRemoveButton.UseVisualStyleBackColor = true;
            PageRemoveButton.Click += PageRemoveButton_Click;
            // 
            // ActionRemoveButton
            // 
            ActionRemoveButton.Location = new Point(692, 41);
            ActionRemoveButton.Name = "ActionRemoveButton";
            ActionRemoveButton.Size = new Size(75, 23);
            ActionRemoveButton.TabIndex = 12;
            ActionRemoveButton.Text = "移除";
            ActionRemoveButton.UseVisualStyleBackColor = true;
            ActionRemoveButton.Click += ActionRemoveButton_Click;
            // 
            // ExcelButton
            // 
            ExcelButton.Location = new Point(606, 415);
            ExcelButton.Name = "ExcelButton";
            ExcelButton.Size = new Size(75, 23);
            ExcelButton.TabIndex = 13;
            ExcelButton.Text = "Excel";
            ExcelButton.UseVisualStyleBackColor = true;
            ExcelButton.Click += ExcelButton_Click;
            // 
            // SpecGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Controls.Add(ExcelButton);
            Controls.Add(ActionRemoveButton);
            Controls.Add(PageRemoveButton);
            Controls.Add(MenuRemoveButton);
            Controls.Add(TxtButton);
            Controls.Add(ActionAddButton);
            Controls.Add(PageAddButton);
            Controls.Add(MenuAddButton);
            Controls.Add(ActionNameTextBox);
            Controls.Add(ActionListBox);
            Controls.Add(PageNameTextBox);
            Controls.Add(PageListBox);
            Controls.Add(MenuNameTextBox);
            Controls.Add(MenuListBox);
            Name = "SpecGenerator";
            Text = "SpecGenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox MenuNameTextBox;
        private TextBox PageNameTextBox;
        private TextBox ActionNameTextBox;
        private Button MenuAddButton;
        private Button PageAddButton;
        private Button ActionAddButton;
        private Button TxtButton;
        private Button MenuRemoveButton;
        private Button PageRemoveButton;
        private Button ActionRemoveButton;
        private MenuItem MenuListBox;
        private MenuItem PageListBox;
        private MenuItem ActionListBox;
        private Button ExcelButton;
    }
}
