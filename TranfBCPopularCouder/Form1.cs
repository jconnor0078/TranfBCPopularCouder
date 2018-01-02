using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace TranfBCPopularCouder
{
    public partial class home : Form
    {
        //Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public home()
        {
            InitializeComponent();
            btnMenu1.selected = true;
            btnMenu1.Enabled = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panelFooter_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panelFooter_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelFooter_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void lblCurrentVersion_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void lblCurrentVersion_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblCurrentVersion_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        void toggle(object sender)
        {
            btnMenu1.selected = false;
            btnMenu2.selected = false;
            btnMenu1.Enabled = true;
            btnMenu2.Enabled = true;

            ((BunifuFlatButton)sender).selected = true;
            ((BunifuFlatButton)sender).Enabled = false;
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            toggle(sender);
        }
    }
}
