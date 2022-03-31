namespace SecondProject
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAnimal = new System.Windows.Forms.ListBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHồSơNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLươngNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNghỉPhépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoKếtQuảKinhDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ CÔNG TY A";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(20, 86);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(276, 27);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demo TextBox / MaskTextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lstAnimal);
            this.groupBox2.Location = new System.Drawing.Point(346, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Box";
            // 
            // lstAnimal
            // 
            this.lstAnimal.FormattingEnabled = true;
            this.lstAnimal.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Cow",
            "Tiger",
            "Chicken",
            "Monkey"});
            this.lstAnimal.Location = new System.Drawing.Point(20, 36);
            this.lstAnimal.Name = "lstAnimal";
            this.lstAnimal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAnimal.Size = new System.Drawing.Size(388, 108);
            this.lstAnimal.TabIndex = 0;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(265, 282);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 5;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Cow",
            "Tiger",
            "Chicken",
            "Monkey"});
            this.comboBox1.Location = new System.Drawing.Point(20, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýNhânSựToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýChứcVụToolStripMenuItem,
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýBộPhậnToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // quảnLýChứcVụToolStripMenuItem
            // 
            this.quảnLýChứcVụToolStripMenuItem.Name = "quảnLýChứcVụToolStripMenuItem";
            this.quảnLýChứcVụToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýChứcVụToolStripMenuItem.Text = "Quản lý chức vụ";
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản lý phòng ban";
            // 
            // quảnLýBộPhậnToolStripMenuItem
            // 
            this.quảnLýBộPhậnToolStripMenuItem.Name = "quảnLýBộPhậnToolStripMenuItem";
            this.quảnLýBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýBộPhậnToolStripMenuItem.Text = "Quản lý bộ phận";
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHồSơNhânSựToolStripMenuItem,
            this.quảnLýLươngNhânSựToolStripMenuItem,
            this.quảnLýNghỉPhépToolStripMenuItem});
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản lý nhân sự";
            // 
            // quảnLýHồSơNhânSựToolStripMenuItem
            // 
            this.quảnLýHồSơNhânSựToolStripMenuItem.Name = "quảnLýHồSơNhânSựToolStripMenuItem";
            this.quảnLýHồSơNhânSựToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýHồSơNhânSựToolStripMenuItem.Text = "Quản lý hồ sơ nhân sự";
            // 
            // quảnLýLươngNhânSựToolStripMenuItem
            // 
            this.quảnLýLươngNhânSựToolStripMenuItem.Name = "quảnLýLươngNhânSựToolStripMenuItem";
            this.quảnLýLươngNhânSựToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýLươngNhânSựToolStripMenuItem.Text = "Quản lý lương nhân sự";
            // 
            // quảnLýNghỉPhépToolStripMenuItem
            // 
            this.quảnLýNghỉPhépToolStripMenuItem.Name = "quảnLýNghỉPhépToolStripMenuItem";
            this.quảnLýNghỉPhépToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýNghỉPhépToolStripMenuItem.Text = "Quản lý nghỉ phép";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngLươngTheoThángToolStripMenuItem,
            this.báoCáoKếtQuảKinhDoanhToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // bảngLươngTheoThángToolStripMenuItem
            // 
            this.bảngLươngTheoThángToolStripMenuItem.Name = "bảngLươngTheoThángToolStripMenuItem";
            this.bảngLươngTheoThángToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bảngLươngTheoThángToolStripMenuItem.Text = "Bảng lương theo tháng";
            // 
            // báoCáoKếtQuảKinhDoanhToolStripMenuItem
            // 
            this.báoCáoKếtQuảKinhDoanhToolStripMenuItem.Name = "báoCáoKếtQuảKinhDoanhToolStripMenuItem";
            this.báoCáoKếtQuảKinhDoanhToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.báoCáoKếtQuảKinhDoanhToolStripMenuItem.Text = "Báo cáo kết quả kinh doanh";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý nhân sự";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAnimal;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHồSơNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLươngNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNghỉPhépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngTheoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoKếtQuảKinhDoanhToolStripMenuItem;
    }
}

