using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchModfiyImages
{
    public partial class LabelModule : Label
    {
        private bool IsMouseDown = false;
        private Point MousePrePosition;
        
        private void init()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(LabelModule_MouseDown);
            this.MouseUp += new MouseEventHandler(LabelModule_MouseUp);
            this.MouseMove+=new MouseEventHandler(LabelModule_MouseMove);
        }

        public LabelModule()
        {
            init();
        }

        private void LabelModule_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            MousePrePosition = new Point(e.X, e.Y);
            this.Cursor = Cursors.SizeAll;
        }

        private void LabelModule_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void LabelModule_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsMouseDown) return;
            this.Top = this.Top + (e.Y - MousePrePosition.Y);
            this.Left = this.Left + (e.X - MousePrePosition.X);
        }
    }
}
