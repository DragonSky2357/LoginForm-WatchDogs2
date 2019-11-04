using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class MainForm : Form {
        public struct POINT { public int x, y; }
        [DllImport("user32.dll")]
        public extern static void GetCursorPos(out POINT point);

        Point FormLocation;
        POINT LastLocation = new POINT();
        POINT CurrentLocation = new POINT();
        public bool IsMouseMoveStart { get; set; }

        public void ClickMouseMove() {
            if (!IsMouseMoveStart) return;
            GetCursorPos(out LastLocation);
            FormLocation.X -= (CurrentLocation.x - LastLocation.x);
            FormLocation.Y -= (CurrentLocation.y - LastLocation.y);

            this.Location = FormLocation;
            CurrentLocation = LastLocation;
        }

        public void ClickMouseLocation() {
            GetCursorPos(out CurrentLocation);
            FormLocation = this.Location;
            IsMouseMoveStart = true;
        }

        public void ScreenShake() {
            var original = this.Location;
            var rnd = new Random(1000);
            const int shake = 10;

            for (int i = 0; i < 10; i++) {
                this.Location = new Point(original.X + rnd.Next(-shake, shake), original.Y + rnd.Next(-shake, shake));
                Thread.Sleep(10);
                this.Location = original;
            }
        }
    }
}
