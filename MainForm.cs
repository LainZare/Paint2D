using Accessibility;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Paint2D
{
    public partial class MainForm : Form
    {
        Tools _tool;
        bool _mouseDown;

        Point _start, _end;
        Pen _pen;
        TextBox _textBox;
        bool _textBoxExisted;
        Font _font;

        Bitmap _bitmap;
        Bitmap _bakBitmap;
        Graphics _graphic;

        string _existedFile;
        public MainForm()
        {
            InitializeComponent();

            ChangeTitleByFile("新文件");

            _tool = Tools.None;
            _mouseDown = false;

            _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            ReusableInit();
            _graphic.Clear(Color.White);

            _pen = new Pen(Color.Black, 2);
            _textBoxExisted = false;
        }


        private void DisposeImage()
        {
            _bitmap.Dispose();
            _graphic.Dispose();
        }

        private void ReusableInit()
        {
            _graphic = Graphics.FromImage(_bitmap);
            _graphic.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox.Image = _bitmap;
        }

        private void ChangeTitleByFile(string file)
        {
            _existedFile = file;
            this.Text = "画图：" + file;
        }

        #region 文件
        //  打开文件
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.jpg;*jpeg;*.png;*.bmp)|*.jpg;*jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DisposeImage();

                _bakBitmap = new Bitmap(openFileDialog.FileName);

                pictureBox.Width = _bakBitmap.Width;
                pictureBox.Height = _bakBitmap.Height;

                _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                ReusableInit();
                _graphic.Clear(Color.White);
                _graphic.DrawImage(_bakBitmap, 0, 0);
                _bakBitmap.Dispose();

                ChangeTitleByFile(openFileDialog.FileName);
            }
            openFileDialog.Dispose();
        }

        // 新建文件
        private void buttonNew_Click(object sender, EventArgs e)
        {

            DisposeImage();
            _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            ReusableInit();
            _graphic.Clear(Color.White);
            ChangeTitleByFile("新文件");
        }

        // 保存文件
        private void SaveFile(string filePath)
        {
            _bakBitmap = new Bitmap(_bitmap);

            DisposeImage();

            _bakBitmap.Save(filePath);

            _bitmap = new Bitmap(_bakBitmap);
            ReusableInit();

            _bakBitmap.Dispose();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_existedFile != "新文件")
            {
                SaveFile(_existedFile);
            }
            else
            {
                buttonSaveAs_Click(sender, e);
            }
        }

        // 另存为
        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPG文件(*.jpg)|*.jpg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
                ChangeTitleByFile(saveFileDialog.FileName);
            }
            saveFileDialog.Dispose();
        }
        #endregion

        #region 工具

        private void buttonPen_Click(object sender, EventArgs e)
        {
            _tool = Tools.Pen;
            if (_pen.Color == Color.White)
            {
                _pen.Color = Color.Black;
            }
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            _tool = Tools.Eraser;
            _pen.Color = Color.White;
        }

        private void buttonText_Click(object sender, EventArgs e)
        {

            _tool = Tools.Text;

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _font = fontDialog.Font;
            }
            fontDialog.Dispose();

        }

        private void buttonBucket_Click(object sender, EventArgs e)
        {
            _tool = Tools.Bucket;
        }

        // 填充
        private void Fill(int x, int y, Color oldColor)
        {
            int countLeft = x;
            int countRight = x;

            while (countLeft - 1 > 0 && _bitmap.GetPixel(countLeft - 1, y) == oldColor)
            {
                countLeft--;
            }

            while (countRight + 1 < _bitmap.Width - 1 && _bitmap.GetPixel(countRight + 1, y) == oldColor)
            {
                countRight++;
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                _bitmap.SetPixel(i, y, _pen.Color);
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                if (_bitmap.GetPixel(i, y - 1) == oldColor && y - 1 > 0)
                {
                    Fill(i, y - 1, oldColor);
                }

            }
            for (int i = countLeft; i <= countRight; i++)
            {
                if (_bitmap.GetPixel(i, y + 1) == oldColor && y + 1 < _bitmap.Height - 1)
                {
                    Fill(i, y + 1, oldColor);
                }
            }

        }

        #endregion

        #region 图像操作

        // 调整画布大小
        private void ResizeSelf(int width, int height)
        {
            this.Width = width + 70;
            this.Height = height + 200;
            pictureBox.Width = width;
            pictureBox.Height = height;

            _bakBitmap = new Bitmap(width, height);
            _graphic.Dispose();
            _graphic = Graphics.FromImage(_bakBitmap);
            _graphic.DrawImage(_bitmap, 0, 0);
            _bitmap.Dispose();
            _bitmap = new Bitmap(_bakBitmap);
            _bakBitmap.Dispose();
            _graphic.Dispose();
            ReusableInit();
        }
        private void buttonResize_Click(object sender, EventArgs e)
        {
            ResizeDialog resizeDialog = new ResizeDialog();
            resizeDialog.StartPosition = FormStartPosition.CenterParent;

            if (resizeDialog.ShowDialog() == DialogResult.OK)
            {
                ResizeSelf(resizeDialog._inputedWidth, resizeDialog._inputedHeight);
            }
            resizeDialog.Close();
            resizeDialog.Dispose();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _graphic.Clear(Color.White);
            pictureBox.Image = _bitmap;
        }
        private void buttonHorizontal_Click(object sender, EventArgs e)
        {
            _bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox.Image = _bitmap;
        }

        private void buttonVertical_Click(object sender, EventArgs e)
        {
            _bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox.Image = _bitmap;
        }

        private void buttonAntiClock_Click(object sender, EventArgs e)
        {
            _bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            ResizeSelf(pictureBox.Height, pictureBox.Width);
            pictureBox.Image = _bitmap;
        }

        private void buttonClock_Click(object sender, EventArgs e)
        {
            _bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ResizeSelf(pictureBox.Height, pictureBox.Width);
            pictureBox.Image = _bitmap;
        }


        #endregion

        #region 粗细
        private void textBoxThickness_TextChanged(object sender, EventArgs e)
        {
            _pen.Width = float.Parse(textBoxThickness.Text);
        }

        private void textBoxThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || e.KeyChar == '.' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void trackBarOfThickness_Scroll(object sender, EventArgs e)
        {
            textBoxThickness.Text = trackBarOfThickness.Value.ToString();
        }
        #endregion

        #region 颜色
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Black;
            panelSelectedColor.BackColor = Color.Black;

        }
        private void buttonWhite_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.White;
            panelSelectedColor.BackColor = Color.White;

        }
        private void buttonRed_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Red;
            panelSelectedColor.BackColor = Color.Red;

        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Yellow;
            panelSelectedColor.BackColor = Color.Yellow;

        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.DodgerBlue;
            panelSelectedColor.BackColor = Color.DodgerBlue;

        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.SpringGreen;
            panelSelectedColor.BackColor = Color.SpringGreen;

        }
        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelSelectedColor.BackColor = colorDialog.Color;
                _pen.Color = colorDialog.Color;
            }
            colorDialog.Dispose();
        }
        #endregion

        #region 形状
        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            _tool = Tools.Line;
        }
        private void pictureBoxTriangle_Click(object sender, EventArgs e)
        {
            _tool = Tools.Triangle;
        }

        private void pictureBoxCircle_Click(object sender, EventArgs e)
        {
            _tool = Tools.Circle;
        }

        private void pictureBoxEllipse_Click(object sender, EventArgs e)
        {
            _tool = Tools.Ellipse;
        }

        private void pictureBoxSquare_Click(object sender, EventArgs e)
        {
            _tool = Tools.Square;
        }

        private void pictureBoxRectangle_Click(object sender, EventArgs e)
        {
            _tool = Tools.Rectangle;
        }
        #endregion

        #region 画图
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _start = e.Location;
            if (_tool == Tools.Line || _tool == Tools.Triangle ||
                _tool == Tools.Square || _tool == Tools.Rectangle ||
                _tool == Tools.Circle || _tool == Tools.Ellipse)
            {
                _bakBitmap = new Bitmap(_bitmap);
            }

            if (_tool == Tools.Bucket)
            {
                if (_pen.Color.Name != _bitmap.GetPixel(e.X, e.Y).Name)
                {
                    Fill(e.X, e.Y, _bitmap.GetPixel(e.X, e.Y));
                    pictureBox.Image = _bitmap;
                }
            }

            if (_textBoxExisted)
            {
                _graphic.DrawString(_textBox.Text, _font, new SolidBrush(_pen.Color), _textBox.Location);
                _textBox.Dispose();
                _textBoxExisted = false;
                pictureBox.Image = _bitmap;
            }
            else if (_tool == Tools.Text && !_textBoxExisted)
            {
                _textBox = new TextBox();
                _textBoxExisted = true;
                _textBox.Parent = pictureBox;
                _textBox.Location = e.Location;
                _textBox.ImeMode = ImeMode.On;
                _textBox.Multiline = true;
                _textBox.WordWrap = true;
                _textBox.Width = 200;
                _textBox.Height = 200;
                _textBox.Font = _font;
                _textBox.Focus();
            }
        }


        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            _end = e.Location;


            if (_tool == Tools.Line || _tool == Tools.Triangle ||
                _tool == Tools.Square || _tool == Tools.Rectangle ||
                _tool == Tools.Circle || _tool == Tools.Ellipse)
            {
                _bakBitmap.Dispose();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (_mouseDown)
            {
                _end = e.Location;

                if (_tool == Tools.Line || _tool == Tools.Triangle ||
                    _tool == Tools.Square || _tool == Tools.Rectangle ||
                    _tool == Tools.Circle || _tool == Tools.Ellipse)
                {
                    _graphic.DrawImage(_bakBitmap, 0, 0);
                }

                if (_tool == Tools.Pen || _tool == Tools.Eraser)
                {
                    _graphic.DrawLine(_pen, _start, _end);
                    _start = e.Location;
                }

                if (_tool == Tools.Square)
                {
                    _graphic.DrawRectangle(_pen, _start.X, _start.Y,
                        Math.Abs(_start.X - _end.X), Math.Abs(_start.X - _end.X));
                }

                if (_tool == Tools.Rectangle)
                {
                    _graphic.DrawRectangle(_pen, _start.X, _start.Y,
                        Math.Abs(_start.X - _end.X), Math.Abs(_start.Y - _end.Y));
                }

                if (_tool == Tools.Circle)
                {
                    _graphic.DrawEllipse(_pen, _start.X, _start.Y,
                        Math.Abs(_start.X - _end.X), Math.Abs(_start.X - _end.X));
                }

                if (_tool == Tools.Ellipse)
                {
                    _graphic.DrawEllipse(_pen, _start.X, _start.Y,
                        Math.Abs(_start.X - _end.X), Math.Abs(_start.Y - _end.Y));
                }

                if (_tool == Tools.Line)
                {
                    _graphic.DrawLine(_pen, _start, _end);
                }
                if (_tool == Tools.Triangle)
                {
                    Point[] points = { _start, _end, new Point(_start.X, _end.Y) };
                    _graphic.DrawPolygon(_pen, points);
                }
                pictureBox.Image = _bitmap;
            }
        }
        #endregion

    }
}