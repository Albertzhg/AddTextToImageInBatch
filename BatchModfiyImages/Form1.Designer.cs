namespace BatchModfiyImages
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenSourceFolder = new System.Windows.Forms.Button();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.tbxFixed = new System.Windows.Forms.TextBox();
            this.tbxSpecial = new System.Windows.Forms.TextBox();
            this.lblFixedTxt = new System.Windows.Forms.Label();
            this.lblSpecialTxt = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.btnSelectTargetFolder = new System.Windows.Forms.Button();
            this.sourceImageList = new System.Windows.Forms.ImageList(this.components);
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.lblPreviousTxt = new BatchModfiyImages.LabelModule();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenSourceFolder
            // 
            this.btnOpenSourceFolder.Location = new System.Drawing.Point(46, 20);
            this.btnOpenSourceFolder.Name = "btnOpenSourceFolder";
            this.btnOpenSourceFolder.Size = new System.Drawing.Size(94, 23);
            this.btnOpenSourceFolder.TabIndex = 0;
            this.btnOpenSourceFolder.Text = "打开源文件夹";
            this.btnOpenSourceFolder.UseVisualStyleBackColor = true;
            this.btnOpenSourceFolder.Click += new System.EventHandler(this.btnOpenSourceFolder_Click);
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(146, 25);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(131, 12);
            this.lblSourceFolder.TabIndex = 1;
            this.lblSourceFolder.Text = "请选择源文件夹地址...";
            // 
            // tbxFixed
            // 
            this.tbxFixed.Location = new System.Drawing.Point(108, 71);
            this.tbxFixed.Name = "tbxFixed";
            this.tbxFixed.Size = new System.Drawing.Size(659, 21);
            this.tbxFixed.TabIndex = 2;
            // 
            // tbxSpecial
            // 
            this.tbxSpecial.Location = new System.Drawing.Point(108, 110);
            this.tbxSpecial.Multiline = true;
            this.tbxSpecial.Name = "tbxSpecial";
            this.tbxSpecial.Size = new System.Drawing.Size(659, 54);
            this.tbxSpecial.TabIndex = 3;
            this.tbxSpecial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSpecial_KeyUp);
            // 
            // lblFixedTxt
            // 
            this.lblFixedTxt.AutoSize = true;
            this.lblFixedTxt.Location = new System.Drawing.Point(44, 74);
            this.lblFixedTxt.Name = "lblFixedTxt";
            this.lblFixedTxt.Size = new System.Drawing.Size(53, 12);
            this.lblFixedTxt.TabIndex = 4;
            this.lblFixedTxt.Text = "固定文本";
            // 
            // lblSpecialTxt
            // 
            this.lblSpecialTxt.AutoSize = true;
            this.lblSpecialTxt.Location = new System.Drawing.Point(44, 113);
            this.lblSpecialTxt.Name = "lblSpecialTxt";
            this.lblSpecialTxt.Size = new System.Drawing.Size(53, 12);
            this.lblSpecialTxt.TabIndex = 5;
            this.lblSpecialTxt.Text = "指定描述";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(828, 87);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(101, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "添加文字并预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(796, 25);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(143, 12);
            this.lblTargetFolder.TabIndex = 9;
            this.lblTargetFolder.Text = "请选择目标文件夹地址...";
            // 
            // btnSelectTargetFolder
            // 
            this.btnSelectTargetFolder.Location = new System.Drawing.Point(684, 20);
            this.btnSelectTargetFolder.Name = "btnSelectTargetFolder";
            this.btnSelectTargetFolder.Size = new System.Drawing.Size(104, 23);
            this.btnSelectTargetFolder.TabIndex = 8;
            this.btnSelectTargetFolder.Text = "选择目标文件夹";
            this.btnSelectTargetFolder.UseVisualStyleBackColor = true;
            this.btnSelectTargetFolder.Click += new System.EventHandler(this.btnSelectTargetFolder_Click);
            // 
            // sourceImageList
            // 
            this.sourceImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.sourceImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.sourceImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcePictureBox.Location = new System.Drawing.Point(46, 214);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(535, 446);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 10;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.sourcePictureBox_Paint);
            this.sourcePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sourcePictureBox_MouseMove);
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetPictureBox.Location = new System.Drawing.Point(690, 214);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(525, 446);
            this.targetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.targetPictureBox.TabIndex = 11;
            this.targetPictureBox.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(957, 87);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "上一个";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1052, 87);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "原图像：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(688, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "修改后图像：";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(828, 128);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(90, 27);
            this.btnSelectColor.TabIndex = 17;
            this.btnSelectColor.Text = "选择颜色";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // lblPreviousTxt
            // 
            this.lblPreviousTxt.AutoSize = true;
            this.lblPreviousTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviousTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreviousTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreviousTxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPreviousTxt.Location = new System.Drawing.Point(243, 280);
            this.lblPreviousTxt.Name = "lblPreviousTxt";
            this.lblPreviousTxt.Size = new System.Drawing.Size(34, 18);
            this.lblPreviousTxt.TabIndex = 14;
            this.lblPreviousTxt.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 719);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.lblPreviousTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.targetPictureBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.btnSelectTargetFolder);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblSpecialTxt);
            this.Controls.Add(this.lblFixedTxt);
            this.Controls.Add(this.tbxSpecial);
            this.Controls.Add(this.tbxFixed);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.btnOpenSourceFolder);
            this.Name = "Form1";
            this.Text = "图片批量添加文字";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog targeFolderBrowserDialog;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox tbxFixed;
        private System.Windows.Forms.TextBox tbxSpecial;
        private System.Windows.Forms.Label lblFixedTxt;
        private System.Windows.Forms.Label lblSpecialTxt;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Button btnSelectTargetFolder;
        private System.Windows.Forms.ImageList sourceImageList;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        //private System.Windows.Forms.Label lblPreviousTxt;
        private LabelModule lblPreviousTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSelectColor;
    }
}

