using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoTest
{
    public partial class Form1 : Form
    {
        private SerialPort Arduino;

        

        public Form1()
        {
            InitializeComponent();
            Arduino = new SerialPort();
            Arduino.PortName = "COM3";
            Arduino.Parity = Parity.None;
            Arduino.DataBits = 8;
            Arduino.StopBits = StopBits.One;
            Arduino.Handshake = Handshake.None;
            Arduino.DtrEnable = true;
            Arduino.RtsEnable = true;
            Arduino.BaudRate = 115200;
            Arduino.WriteTimeout = 5000;
            Arduino.ReadTimeout = 5000;
           // Ejecutar();
        }

        private void Monitoreo()
        {
            //do
            //{
            //    if (Arduino.IsOpen)
            //    {
            //        lblestado.Text = "Conectado";
            //    }
            //    else
            //    {
            //        lblestado.Text = "Desconectado";
            //    }

            //    if (Arduino.ReadLine() == '1'.ToString())
            //    {
            //        lblestadoboton.Text = "Encendido";

            //    }
            //    else
            //    {
            //        lblestadoboton.Text = "Apagado";
            //    }

            //} while (true);
        }

        private void btnon_Click(object sender, EventArgs e)
        {
            try
            {
                Arduino.Open();
                lblestado.Text = "Conectado";
                txtComs.Text= Arduino.ReadLine();
                lblmsg.Text = "OK";
            }
            catch (InvalidOperationException ex)
            {
                lblmsg.Text=ex.Message.ToString();
                

                // throw;
            }
            catch(UnauthorizedAccessException ex)
            {
                lblmsg.Text = ex.Message;
            }
            
            // Ejecutar();
            
          //  Monitoreo();
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            try
            {
                Arduino.Close();
                lblestado.Text = "Desconectado";
                lblmsg.Text = "OK";
            }
            catch (System.InvalidOperationException ex)
            {
                lblmsg.Text = ex.Message.ToString();

                // throw;
            }
            
            
        }

        private void btnLEDon_Click(object sender, EventArgs e)
        {
            Arduino.Write("1");

        }

        private void btnLEDoff_Click(object sender, EventArgs e)
        {
            Arduino.Write("0");
        }


    }
}
