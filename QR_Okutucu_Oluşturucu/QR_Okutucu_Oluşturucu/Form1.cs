using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;



namespace QR_Okutucu_Oluşturucu

{
    public partial class Form1 : Form
    {
        FilterInfoCollection wepcam;
        VideoCaptureDevice cam;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(wepcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_newcam);
            cam.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wepcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in wepcam)
            {
                comboBox1.Items.Add(dev.Name);

            }
            comboBox1.SelectedIndex = 0;
        }
        public void cam_newcam(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = ((Bitmap)eventArgs.Frame.Clone());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barkod = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result res = barkod.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    string dec = res.ToString().Trim();
                    if (dec != "")
                    {
                        timer1.Stop();
                        textBox1.Text = dec;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
            }

        }
        Form2 frm2 = new Form2();
        private void button3_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }
    }

}
