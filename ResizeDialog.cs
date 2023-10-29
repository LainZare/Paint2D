using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2D
{
    public partial class ResizeDialog : Form
    {
        internal int _inputedWidth, _inputedHeight;
        public ResizeDialog()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 1920 1080
            _inputedWidth = int.Parse(textBoxWidth.Text);
            _inputedHeight = int.Parse(textBoxHeight.Text);
            if (_inputedWidth > 0 && _inputedWidth <= 1920 && _inputedHeight > 0 && _inputedHeight <= 1080)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                textBoxWidth.Text = "0";
                textBoxWidth.Text = "0";
                textBoxError.Text = "最大分辨率：1920*1080";
            }
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || e.KeyChar == '.' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }

        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || e.KeyChar == '.' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }

        }
    }
}
