using Inventor;
using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ControlArduinoByInventorModel
{
    public partial class ArduinoControl : Form
    {

        Inventor.Application inventorApp;
        Inventor.AssemblyDocument assembly;
        SerialPort serialPort;

        readonly int inventorModelParameterPart1 = 2;
        readonly int inventorModelParameterPart2 = 7;

        string position_X;
        string position_Y;


        String[] ports;

        public ArduinoControl()
        {
            InitializeComponent();

            this.TopMost = true;

            getAvailableComPorts();
            initializeSerialPorts();



            try
            {
                inventorApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

                assembly = (AssemblyDocument)inventorApp.ActiveDocument;

                assembly.ComponentDefinition.Parameters.ModelParameters[inventorModelParameterPart1].Value = 0;
               assembly.ComponentDefinition.Parameters.ModelParameters[inventorModelParameterPart2].Value = 0;
                assembly.Update();
            }
            catch (Exception)
            {

                MessageBox.Show("cannot connect to Inventor");
            }

        }


        private void initializeSerialPorts()
        {
            foreach (string port in ports)
            {
                serialPortcomboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    serialPortcomboBox1.SelectedItem = ports[0];
                }
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            assembly = (AssemblyDocument)inventorApp.ActiveDocument;

            position_X = Convert.ToString(Math.Abs(Convert.ToInt32(assembly.ComponentDefinition.Parameters.ModelParameters[inventorModelParameterPart1].Value * 57.3f)));
            position_Y = Convert.ToString(Math.Abs(Convert.ToInt32(assembly.ComponentDefinition.Parameters.ModelParameters[inventorModelParameterPart2].Value * 57.3f)));

            string value = position_X + " " + position_Y;


            try
            {
                serialPort.WriteLine(value);

            }
            catch (Exception)
            {
                timer1.Stop();
                isConnectLabel.Text = "Not Connected";

                MessageBox.Show("Arduino disconnected.");
            }

            positionXLabel.Text = "POSX: " + position_X;
            positionYLabel.Text = "POSY: " + position_Y;

        }

        private void ConnectToArduino_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.BaudRate = Int32.Parse(baudRateTextBox.Text);
                serialPort.PortName = serialPortcomboBox1.GetItemText(serialPortcomboBox1.SelectedItem); ;

                serialPort.Open();

                isConnectLabel.Text = "Connected!";

                timer1.Interval = 50;
                timer1.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to connect to Arduino.");
            }
          
        }
    }
}
