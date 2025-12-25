namespace Tyuiu.MuliavinIM.Sprint6.Task7.V16
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_MIM = new Panel();
            groupBoxTask_MIM = new GroupBox();
            textBoxTask_MIM = new TextBox();
            buttonDone_MIM = new Button();
            buttonHelp_MIM = new Button();
            buttonSave_MIM = new Button();
            buttonOpenFile_MIM = new Button();
            panelLeft_MIM = new Panel();
            groupBoxInPutData_MIM = new GroupBox();
            dataGridViewInPutData_MIM = new DataGridView();
            panelRight_MIM = new Panel();
            groupBoxOutPutData_MIM = new GroupBox();
            dataGridViewOutPutData_MIM = new DataGridView();
            splitterLeft_MIM = new Splitter();
            toolTip_MIM = new ToolTip(components);
            openFileDialog_MIM = new OpenFileDialog();
            saveFileDialog_MIM = new SaveFileDialog();
            panelTop_MIM.SuspendLayout();
            groupBoxTask_MIM.SuspendLayout();
            panelLeft_MIM.SuspendLayout();
            groupBoxInPutData_MIM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_MIM).BeginInit();
            panelRight_MIM.SuspendLayout();
            groupBoxOutPutData_MIM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_MIM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_MIM
            // 
            panelTop_MIM.Controls.Add(groupBoxTask_MIM);
            panelTop_MIM.Controls.Add(buttonDone_MIM);
            panelTop_MIM.Controls.Add(buttonHelp_MIM);
            panelTop_MIM.Controls.Add(buttonSave_MIM);
            panelTop_MIM.Controls.Add(buttonOpenFile_MIM);
            panelTop_MIM.Dock = DockStyle.Top;
            panelTop_MIM.Location = new Point(0, 0);
            panelTop_MIM.Margin = new Padding(2);
            panelTop_MIM.Name = "panelTop_MIM";
            panelTop_MIM.Size = new Size(744, 175);
            panelTop_MIM.TabIndex = 0;
            // 
            // groupBoxTask_MIM
            // 
            groupBoxTask_MIM.Controls.Add(textBoxTask_MIM);
            groupBoxTask_MIM.Location = new Point(10, 62);
            groupBoxTask_MIM.Margin = new Padding(2);
            groupBoxTask_MIM.Name = "groupBoxTask_MIM";
            groupBoxTask_MIM.Padding = new Padding(2);
            groupBoxTask_MIM.Size = new Size(659, 113);
            groupBoxTask_MIM.TabIndex = 5;
            groupBoxTask_MIM.TabStop = false;
            groupBoxTask_MIM.Text = "Условие:";
            // 
            // textBoxTask_MIM
            // 
            textBoxTask_MIM.Location = new Point(12, 20);
            textBoxTask_MIM.Margin = new Padding(2);
            textBoxTask_MIM.Multiline = true;
            textBoxTask_MIM.Name = "textBoxTask_MIM";
            textBoxTask_MIM.ReadOnly = true;
            textBoxTask_MIM.Size = new Size(643, 90);
            textBoxTask_MIM.TabIndex = 0;
            textBoxTask_MIM.Text = resources.GetString("textBoxTask_MIM.Text");
            textBoxTask_MIM.TextChanged += textBoxTask_MIM_TextChanged;
            // 
            // buttonDone_MIM
            // 
            buttonDone_MIM.Enabled = false;
            buttonDone_MIM.FlatStyle = FlatStyle.Flat;
            buttonDone_MIM.Image = (Image)resources.GetObject("buttonDone_MIM.Image");
            buttonDone_MIM.Location = new Point(73, 9);
            buttonDone_MIM.Margin = new Padding(2);
            buttonDone_MIM.Name = "buttonDone_MIM";
            buttonDone_MIM.Size = new Size(58, 47);
            buttonDone_MIM.TabIndex = 4;
            buttonDone_MIM.UseVisualStyleBackColor = true;
            buttonDone_MIM.Click += buttonDone_MIM_Click;
            buttonDone_MIM.MouseEnter += buttonDone_MIM_MouseEnter;
            // 
            // buttonHelp_MIM
            // 
            buttonHelp_MIM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MIM.FlatStyle = FlatStyle.Flat;
            buttonHelp_MIM.Image = (Image)resources.GetObject("buttonHelp_MIM.Image");
            buttonHelp_MIM.Location = new Point(677, 9);
            buttonHelp_MIM.Margin = new Padding(2);
            buttonHelp_MIM.Name = "buttonHelp_MIM";
            buttonHelp_MIM.Size = new Size(58, 47);
            buttonHelp_MIM.TabIndex = 3;
            buttonHelp_MIM.UseVisualStyleBackColor = true;
            buttonHelp_MIM.Click += buttonHelp_MIM_Click;
            buttonHelp_MIM.MouseEnter += buttonHelp_MIM_MouseEnter;
            // 
            // buttonSave_MIM
            // 
            buttonSave_MIM.Enabled = false;
            buttonSave_MIM.FlatStyle = FlatStyle.Flat;
            buttonSave_MIM.Image = (Image)resources.GetObject("buttonSave_MIM.Image");
            buttonSave_MIM.Location = new Point(136, 9);
            buttonSave_MIM.Margin = new Padding(2);
            buttonSave_MIM.Name = "buttonSave_MIM";
            buttonSave_MIM.Size = new Size(58, 47);
            buttonSave_MIM.TabIndex = 2;
            buttonSave_MIM.UseVisualStyleBackColor = true;
            buttonSave_MIM.Click += buttonSave_MIM_Click;
            buttonSave_MIM.MouseEnter += buttonSave_MIM_MouseEnter;
            // 
            // buttonOpenFile_MIM
            // 
            buttonOpenFile_MIM.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MIM.Image = (Image)resources.GetObject("buttonOpenFile_MIM.Image");
            buttonOpenFile_MIM.Location = new Point(10, 9);
            buttonOpenFile_MIM.Margin = new Padding(2);
            buttonOpenFile_MIM.Name = "buttonOpenFile_MIM";
            buttonOpenFile_MIM.Size = new Size(58, 47);
            buttonOpenFile_MIM.TabIndex = 1;
            buttonOpenFile_MIM.UseVisualStyleBackColor = true;
            buttonOpenFile_MIM.Click += buttonOpenFile_MIM_Click;
            buttonOpenFile_MIM.MouseEnter += buttonOpenFile_MIM_MouseEnter;
            // 
            // panelLeft_MIM
            // 
            panelLeft_MIM.Controls.Add(groupBoxInPutData_MIM);
            panelLeft_MIM.Dock = DockStyle.Left;
            panelLeft_MIM.Location = new Point(0, 175);
            panelLeft_MIM.Margin = new Padding(2);
            panelLeft_MIM.Name = "panelLeft_MIM";
            panelLeft_MIM.Size = new Size(386, 410);
            panelLeft_MIM.TabIndex = 0;
            // 
            // groupBoxInPutData_MIM
            // 
            groupBoxInPutData_MIM.Controls.Add(dataGridViewInPutData_MIM);
            groupBoxInPutData_MIM.Location = new Point(9, 14);
            groupBoxInPutData_MIM.Margin = new Padding(2);
            groupBoxInPutData_MIM.Name = "groupBoxInPutData_MIM";
            groupBoxInPutData_MIM.Padding = new Padding(2);
            groupBoxInPutData_MIM.Size = new Size(374, 394);
            groupBoxInPutData_MIM.TabIndex = 0;
            groupBoxInPutData_MIM.TabStop = false;
            groupBoxInPutData_MIM.Text = "Ввод:";
            // 
            // dataGridViewInPutData_MIM
            // 
            dataGridViewInPutData_MIM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPutData_MIM.Location = new Point(5, 20);
            dataGridViewInPutData_MIM.Margin = new Padding(2);
            dataGridViewInPutData_MIM.Name = "dataGridViewInPutData_MIM";
            dataGridViewInPutData_MIM.RowHeadersVisible = false;
            dataGridViewInPutData_MIM.RowHeadersWidth = 62;
            dataGridViewInPutData_MIM.RowTemplate.Height = 28;
            dataGridViewInPutData_MIM.Size = new Size(364, 368);
            dataGridViewInPutData_MIM.TabIndex = 0;
            // 
            // panelRight_MIM
            // 
            panelRight_MIM.Controls.Add(groupBoxOutPutData_MIM);
            panelRight_MIM.Dock = DockStyle.Fill;
            panelRight_MIM.Location = new Point(386, 175);
            panelRight_MIM.Margin = new Padding(2);
            panelRight_MIM.Name = "panelRight_MIM";
            panelRight_MIM.Size = new Size(358, 410);
            panelRight_MIM.TabIndex = 0;
            // 
            // groupBoxOutPutData_MIM
            // 
            groupBoxOutPutData_MIM.Controls.Add(dataGridViewOutPutData_MIM);
            groupBoxOutPutData_MIM.Location = new Point(7, 14);
            groupBoxOutPutData_MIM.Margin = new Padding(2);
            groupBoxOutPutData_MIM.Name = "groupBoxOutPutData_MIM";
            groupBoxOutPutData_MIM.Padding = new Padding(2);
            groupBoxOutPutData_MIM.Size = new Size(349, 394);
            groupBoxOutPutData_MIM.TabIndex = 0;
            groupBoxOutPutData_MIM.TabStop = false;
            groupBoxOutPutData_MIM.Text = "Вывод:";
            // 
            // dataGridViewOutPutData_MIM
            // 
            dataGridViewOutPutData_MIM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPutData_MIM.Location = new Point(5, 20);
            dataGridViewOutPutData_MIM.Margin = new Padding(2);
            dataGridViewOutPutData_MIM.Name = "dataGridViewOutPutData_MIM";
            dataGridViewOutPutData_MIM.RowHeadersVisible = false;
            dataGridViewOutPutData_MIM.RowHeadersWidth = 62;
            dataGridViewOutPutData_MIM.RowTemplate.Height = 28;
            dataGridViewOutPutData_MIM.Size = new Size(344, 375);
            dataGridViewOutPutData_MIM.TabIndex = 0;
            // 
            // splitterLeft_MIM
            // 
            splitterLeft_MIM.Location = new Point(386, 175);
            splitterLeft_MIM.Margin = new Padding(2);
            splitterLeft_MIM.Name = "splitterLeft_MIM";
            splitterLeft_MIM.Size = new Size(2, 410);
            splitterLeft_MIM.TabIndex = 1;
            splitterLeft_MIM.TabStop = false;
            // 
            // toolTip_MIM
            // 
            toolTip_MIM.IsBalloon = true;
            toolTip_MIM.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MIM.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_MIM
            // 
            openFileDialog_MIM.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 585);
            Controls.Add(splitterLeft_MIM);
            Controls.Add(panelRight_MIM);
            Controls.Add(panelLeft_MIM);
            Controls.Add(panelTop_MIM);
            Margin = new Padding(2);
            MinimumSize = new Size(704, 598);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Мулявин. И. М.";
            Load += FormMain_Load;
            panelTop_MIM.ResumeLayout(false);
            groupBoxTask_MIM.ResumeLayout(false);
            groupBoxTask_MIM.PerformLayout();
            panelLeft_MIM.ResumeLayout(false);
            groupBoxInPutData_MIM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutData_MIM).EndInit();
            panelRight_MIM.ResumeLayout(false);
            groupBoxOutPutData_MIM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutData_MIM).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MIM;
        private System.Windows.Forms.Panel panelLeft_MIM;
        private System.Windows.Forms.Panel panelRight_MIM;
        private System.Windows.Forms.Splitter splitterLeft_MIM;
        private System.Windows.Forms.GroupBox groupBoxInPutData_MIM;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_MIM;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_MIM;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_MIM;
        private System.Windows.Forms.Button buttonOpenFile_MIM;
        private System.Windows.Forms.Button buttonHelp_MIM;
        private System.Windows.Forms.Button buttonSave_MIM;
        private System.Windows.Forms.Button buttonDone_MIM;
        private System.Windows.Forms.GroupBox groupBoxTask_MIM;
        private System.Windows.Forms.TextBox textBoxTask_MIM;
        private System.Windows.Forms.ToolTip toolTip_MIM;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MIM;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MIM;
    }
}
