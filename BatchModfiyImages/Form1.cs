using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchModfiyImages
{
    public partial class Form1 : Form
    {
        int sourceShowImageWidth = 0; //源图片显示的宽度
        int sourceShowImageHeight = 0;//源图片显示的高度
        int sourceImageWidth = 0;//源图片实际宽度
        int sourceImageHeight=0;//源图片实际高度
        double zoomRate = 0.0;//源图片展示时的缩放比例
        int black_left_width = 0;//源图片展示时距离PictureBox左边界的留白距离
        int black_top_height = 0;//源图片展示时距离PictureBox上边界的留白距离
        string currentImageName = "";//当前图片的名
        int currentImageIndex = -1;//当前图片文件索引位置
        string[] imageLst = new string[] { };//图片集合 
        bool isContinueAddTxtResult = false;//是否继续添加文字到图片

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            tbxSpecial.Enabled = false;
        }

        private void btnOpenSourceFolder_Click(object sender, EventArgs e)
        {
            if (sourceFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lblSourceFolder.Text = sourceFolderBrowserDialog.SelectedPath;

                imageLst = Directory.GetFiles(lblSourceFolder.Text).Where(p=>p.ToLower().EndsWith(".jpg")|| p.ToLower().EndsWith(".jpeg") || p.ToLower().EndsWith(".png") || p.ToLower().EndsWith(".bmp")).ToArray();
                if (imageLst.Length > 0)
                {
                    currentImageIndex = 0;
                    sourcePictureBox.Image = FileToBitmap(imageLst[currentImageIndex]);
                    currentImageName = Path.GetFileName(imageLst[currentImageIndex]);
                    tbxSpecial.Enabled = true;
                }
                else
                {
                    MessageBox.Show("当前文件夹没有图片!");
                }
            }
        }

        private void btnSelectTargetFolder_Click(object sender, EventArgs e)
        {
            if (targeFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lblTargetFolder.Text = targeFolderBrowserDialog.SelectedPath;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnPreview.Enabled = true;
            btnNext.Enabled = true;
            btnSelectColor.Enabled = true;
            if (currentImageIndex > 0)
            {
                currentImageIndex -= 1;
                sourcePictureBox.Image = FileToBitmap(imageLst[currentImageIndex]);
                currentImageName = Path.GetFileName(imageLst[currentImageIndex]);
            }
            else
            {
                btnPreview.Enabled = false;
                btnPrevious.Enabled = false;
                btnSelectColor.Enabled = false;
                MessageBox.Show("已是第一张了。。。");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPreview.Enabled = true;
            btnPrevious.Enabled = true;
            btnSelectColor.Enabled = true;
            if (currentImageIndex > imageLst.Length - 2)
            {
                btnPreview.Enabled = false;
                btnNext.Enabled = false;
                btnSelectColor.Enabled = false;
                MessageBox.Show("已是最后一张了。。。");
            }
            else
            {
                currentImageIndex += 1;
                sourcePictureBox.Image = FileToBitmap(imageLst[currentImageIndex]);
                currentImageName = Path.GetFileName(imageLst[currentImageIndex]);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            isContinueAddTxtResult = false;
            if (sourcePictureBox.Image != null)
            {
                if (!string.IsNullOrWhiteSpace(lblTargetFolder.Text) && !string.IsNullOrWhiteSpace(currentImageName) && lblTargetFolder.Text != "请选择目标文件夹地址...")
                {
                    if (lblTargetFolder.Text == lblSourceFolder.Text)
                    {
                        MessageBox.Show("保存新生成图片的路径不能和源路径相同!");
                    }
                    else
                    {
                        Bitmap bitmap = new Bitmap(sourcePictureBox.Image, sourceImageWidth, sourceImageHeight);
                        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
                        //字体大小  
                        float fontSize = (float)Math.Floor(lblPreviousTxt.Font.Size / (float)zoomRate);
                        //下面定义一个矩形区域
                        float rectX = (lblPreviousTxt.Location.X - black_left_width) / (float)zoomRate;
                        float rectY = (lblPreviousTxt.Location.Y - black_top_height) / (float)zoomRate;
                        float rectWidth = (float)(lblPreviousTxt.Width + 10) / (float)zoomRate;
                        float rectHeight = (lblPreviousTxt.Height + 2) / (float)zoomRate;
                        //声明矩形域  
                        RectangleF textArea = new RectangleF(rectX < 0 ? 0 : rectX, rectY < 0 ? 0 : rectY, rectWidth, rectHeight);
                        //定义字体  
                        System.Drawing.Font font = new System.Drawing.Font(lblPreviousTxt.Font.FontFamily, fontSize, lblPreviousTxt.Font.Style);
                        //白笔刷，画文字用  
                        Brush whiteBrush = new SolidBrush(lblPreviousTxt.ForeColor);
                        g.DrawString(lblPreviousTxt.Text, font, whiteBrush, textArea);

                        if (File.Exists($@"{lblTargetFolder.Text}\{currentImageName}"))
                            File.Delete($@"{lblTargetFolder.Text}\{currentImageName}");

                        bitmap.Save($@"{lblTargetFolder.Text}\{currentImageName}", System.Drawing.Imaging.ImageFormat.Jpeg);
                        g.Dispose();
                        bitmap.Dispose();

                        isContinueAddTxtResult = true;
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要保存图片的路径!");
                }
            }

            lblPreviousTxt.Text = "";
            tbxSpecial.Text = "";
            if (!string.IsNullOrWhiteSpace(lblTargetFolder.Text) && !string.IsNullOrWhiteSpace(currentImageName) && lblTargetFolder.Text != "请选择目标文件夹地址...")
            {
                targetPictureBox.Image = FileToBitmap($@"{lblTargetFolder.Text}\{currentImageName}");
            }
        }


        /// <summary>
        /// https://blog.csdn.net/rztyfx/article/details/46674543
        /// Bitmap是个好东西,但如果是直接Image.FromFile的话,那就会一直锁定该文件,如果你想读取文件后,再马上删除文件,可以这么做 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private Bitmap FileToBitmap(string fileName)
        {
            // 打开文件    
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            // 读取文件的 byte[]    
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();

            // 把 byte[] 转换成 Stream    
            Stream stream = new MemoryStream(bytes);

            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始    
            stream.Seek(0, SeekOrigin.Begin);
            try
            {
                return new Bitmap((Image)new Bitmap(stream));
            }
            catch (ArgumentNullException ex)
            {
                return null;
            }
            catch (ArgumentException ex)
            {
                return null;
            }
            finally
            {
                stream.Close();
            }
        }

        private void tbxSpecial_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)e.Modifiers == (int)Keys.ControlKey || (int)e.Modifiers == (int)Keys.Control) && e.KeyCode == Keys.Enter)
            {
                btnPreview_Click(sender, e);
                if (isContinueAddTxtResult)
                {
                    btnNext_Click(sender, e);
                    tbxSpecial.Focus();
                }
            }
            else
            {
                int xVal = (int)(black_left_width + (sourceShowImageWidth - lblPreviousTxt.Width) / 2);
                int yVal = (int)(black_top_height + ((double)sourceShowImageHeight * 0.1 + (double)lblPreviousTxt.Height / 2));
                lblPreviousTxt.Location = new System.Drawing.Point(xVal, yVal);
                sourcePictureBox.Controls.Add(lblPreviousTxt);
                lblPreviousTxt.Text = $"{tbxFixed.Text}{tbxSpecial.Text}";

                if (sourceShowImageWidth > 0)
                {
                    int LblNum = lblPreviousTxt.Text.Length;//Label内容长度
                    int CurrentLabelWidth = (int)(LblNum * lblPreviousTxt.Font.Size);//当前Label内容的长度
                    int RowNum = (int)(sourceShowImageWidth * 0.8 / lblPreviousTxt.Font.Size);//每行显示的字数
                    int NewRowFlagCnt = lblPreviousTxt.Text.Length - lblPreviousTxt.Text.Replace("\r\n", "").Length; //换行符的数量
                    int TotalLineCnt = lblPreviousTxt.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).Count();//总行数
                    int BlackLineCnt = lblPreviousTxt.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToArray().Where(p => string.IsNullOrWhiteSpace(p)).Count(); //空行的数量

                    var OverMaxRowNumLines = lblPreviousTxt.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToArray().Where(p => p?.Replace("\r\n", "")?.Length > RowNum); //超过每行最大数量的行集合
                    int OverMaxRowNumCnt = OverMaxRowNumLines.Count();//超过每行最大数量的行数

                    int totalOverLineCnt = 0;
                    foreach (var item in OverMaxRowNumLines)
                    {
                        var currentLineOverLineCnt = (int)Math.Ceiling((decimal)item.Length / (decimal)RowNum);

                        totalOverLineCnt += currentLineOverLineCnt;
                    }
                    int ColNum = TotalLineCnt - BlackLineCnt + totalOverLineCnt;  //行数
                    if (OverMaxRowNumCnt > 0)
                    {
                        lblPreviousTxt.AutoSize = false;    //设置AutoSize
                        lblPreviousTxt.Width = (int)(sourceShowImageWidth * 0.8); //设置显示宽度
                    }
                    else
                    {
                        lblPreviousTxt.AutoSize = true;
                    }
                    lblPreviousTxt.Height = lblPreviousTxt.Font.Height * ColNum;           //设置显示高度
                }

            }
        }

        private void sourcePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int originalWidth = this.sourcePictureBox.Image.Width;
                int originalHeight = this.sourcePictureBox.Image.Height;

                PropertyInfo rectangleProperty = this.sourcePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.sourcePictureBox, null);

                int currentWidth = rectangle.Width;
                int currentHeight = rectangle.Height;

                double rate = (double)currentHeight / (double)originalHeight;

                int black_left_width = (currentWidth == this.sourcePictureBox.Width) ? 0 : (this.sourcePictureBox.Width - currentWidth) / 2;
                int black_top_height = (currentHeight == this.sourcePictureBox.Height) ? 0 : (this.sourcePictureBox.Height - currentHeight) / 2;

                int zoom_x = e.X - black_left_width;
                int zoom_y = e.Y - black_top_height;

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat($"PictureBox(宽={sourcePictureBox.Width},高={sourcePictureBox.Height})\r\n");
                sb.AppendFormat("原始尺寸{0}/{1}(宽/高)\r\n", originalWidth, originalHeight);
                sb.AppendFormat("缩放状态图片尺寸{0}/{1}(宽/高)\r\n", currentWidth, currentHeight);
                sb.AppendFormat("缩放比率{0}\r\n", rate);
                sb.AppendFormat("左留白宽度{0}\r\n", black_left_width);
                sb.AppendFormat("上留白高度{0}\r\n", black_top_height);
                sb.AppendFormat("当前鼠标坐标{0}/{1}(X/Y)\r\n", e.X, e.Y);
                sb.AppendFormat("缩放图中鼠标坐标{0}/{1}(X/Y)\r\n", zoom_x, zoom_y);
                sb.AppendFormat($"PictureBox.Location(X={sourcePictureBox.Location.X},Y={sourcePictureBox.Location.Y})\r\n");
                sb.AppendFormat($"文字.Location(X={lblPreviousTxt.Location.X},Y={lblPreviousTxt.Location.Y},文字高度：{lblPreviousTxt.Height})\r\n");
            }
            catch (Exception ex)
            {
            }
        }
        
        private void sourcePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (sourcePictureBox.Image != null)
            {

                ///源图片实际的宽高
                sourceImageHeight = sourcePictureBox.Image.Height;
                sourceImageWidth = sourcePictureBox.Image.Width;

                PropertyInfo rectangleProperty = this.sourcePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.sourcePictureBox, null);

                ///显示的图片的宽高
                sourceShowImageWidth = rectangle.Width;
                sourceShowImageHeight = rectangle.Height;

                ///获取缩放比例
                zoomRate = (double)sourceShowImageHeight / (double)sourceImageHeight;

                ///获取留白距离
                black_left_width = (sourceShowImageWidth == this.sourcePictureBox.Width) ? 0 : (this.sourcePictureBox.Width - sourceShowImageWidth) / 2;
                black_top_height = (sourceShowImageHeight == this.sourcePictureBox.Height) ? 0 : (this.sourcePictureBox.Height - sourceShowImageHeight) / 2;
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            //设定用户可以使用自定义颜色
            colorDialog1.AllowFullOpen = true;
            //指示用于创建自定义颜色的控件在对话框打开时可见
            colorDialog1.FullOpen = true;
            //显示“帮助”按钮
            colorDialog1.ShowHelp = true;
            //设定颜色对话框的初始颜色
            colorDialog1.Color = Color.Black;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblPreviousTxt.ForeColor = colorDialog1.Color;
            }
        }
    }
}
