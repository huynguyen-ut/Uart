using System.IO.Ports;

namespace Uart
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._serialPort.Write("on");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._serialPort.Write("off");
        }
    }
}