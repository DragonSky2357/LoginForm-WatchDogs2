using System;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;

namespace LoginForm {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\Watch Dogs 2 OST - Marcus Holloway Theme song [Extended Remix] (Boys Noize Pilo - Cerebral ) (online-audio-converter.com).wav");
            simpleSound.Play();
        }
    }
}
