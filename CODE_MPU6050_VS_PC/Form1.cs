using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ZedGraph;

namespace GiaoTiepMpu6050
{
    public partial class Form1 : Form
    {
        // Đây là hàm khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        /*Danh sách biến*/
        // cho phép ve do thi 
        int start_mode = 0;
        bool modefile = false;
        private int millisecond = 0;
        DateTime Datetime_Now = new DateTime();
        //DateTime Datetime_Start = new DateTime();
        //DateTime Datetime_Delay = new DateTime();
        //TimeSpan Time_Delay = new TimeSpan();
        RollingPointPairList List_Ax = new RollingPointPairList(60000);
        RollingPointPairList List_Ay = new RollingPointPairList(60000);
        RollingPointPairList List_Az = new RollingPointPairList(60000);
        RollingPointPairList List_Roll_x = new RollingPointPairList(60000); //List_Roll_x List_Pitch_y  List_Yaw_z
        RollingPointPairList List_Pitch_y = new RollingPointPairList(60000);
        RollingPointPairList List_Yaw_z = new RollingPointPairList(60000);

        // Full path load file
        string fullPathFile;
        string[] fileData;
        int dataIndex = 0;

        /*Danh sách hàm tạo bởi người dùng*/
        private delegate void R_Data(string s);
        private void Load_Data()
        {
            ClearZedGraph();
            Console.WriteLine(fullPathFile);
            if (!File.Exists(fullPathFile)){
            }
            fileData = File.ReadAllLines(fullPathFile);
        }
        private void ClearZedGraph()
        {
            ZedGraphGiaToc.GraphPane.CurveList.Clear(); // Xóa đường
            ZedGraphGiaToc.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            ZedGraphGiaToc.AxisChange();
            ZedGraphGiaToc.Invalidate();

            GraphPane myPane = ZedGraphGiaToc.GraphPane;
            //myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            //myPane.XAxis.Title.Text = "Thời gian (s)";
            //myPane.YAxis.Title.Text = "Dữ liệu";

            //RollingPointPairList list = new RollingPointPairList(60000);
            //LineItem curve = myPane.AddCurve("Dữ liệu", list, Color.Red, SymbolType.None);

            //myPane.XAxis.Scale.Min = 0;
            //myPane.XAxis.Scale.Max = 30;
            // myPane.XAxis.Scale.MinorStep = 1;
            //myPane.XAxis.Scale.MajorStep = 5;
            //myPane.YAxis.Scale.Min = -100;
            //myPane.YAxis.Scale.Max = 100;

            //ZedGraphGiaToc.AxisChange();

            myPane.Title.Text = " Gia tốc, góc quay";
            myPane.XAxis.Title.Text = "Thời Gian, giây";
            myPane.YAxis.Title.Text = "Gia tốc,vân tốc góc, góc quay";
            List_Ax.Clear();
            List_Ay.Clear();
            List_Az.Clear();
            List_Roll_x.Clear();
            List_Pitch_y.Clear();
            List_Yaw_z.Clear();
            LineItem Ax = myPane.AddCurve("Roll x", List_Ax, Color.Blue, SymbolType.None);
            LineItem Ay = myPane.AddCurve("Pitch y", List_Ay, Color.Red, SymbolType.None);
            LineItem Az = myPane.AddCurve("Yaw z", List_Az, Color.Yellow, SymbolType.None);
            LineItem Roll_x = myPane.AddCurve("Ax", List_Roll_x, Color.Violet, SymbolType.None);
            LineItem Pitch_y = myPane.AddCurve("Ay", List_Pitch_y, Color.Tomato, SymbolType.None);
            LineItem Yaw_z = myPane.AddCurve("Az", List_Yaw_z, Color.Turquoise, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 10;
            myPane.YAxis.Scale.Min = -3;
            myPane.YAxis.Scale.Max = 3;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 1;
            ZedGraphGiaToc.AxisChange();
        }
        /*Danh sách hàm tạo bởi Form*/
        private void Form1_Load(object sender, EventArgs e)
        {
            TexBTenfile.Text = "test";
            string[] portnames = SerialPort.GetPortNames();
            int[] PortNumber = new int[portnames.Length];
            for (int i = 0; i < portnames.Length; i++ )
            {
                PortNumber[i] = int.Parse(portnames[i].Substring(3));
            }
            Array.Sort(PortNumber);
            foreach(int Number in PortNumber)
            {
                ComBPort.Items.Add("COM" + Number);
            }
            ComBBaud.Items.Add("9600");
            ComBBaud.Items.Add("14400");
            ComBBaud.Items.Add("19200");
            ComBBaud.Items.Add("56000");
            ComBBaud.Items.Add("115200");
            ComBchedo.Items.Add("Chỉ vẽ đồ thị");
            ComBchedo.Items.Add("Vẽ đồ thị và ghi file");
            ComBchedo.SelectedItem = "Chỉ vẽ đồ thị";
            // Array.Sort(portnames);
            //ComBPort.Items.AddRange(portnames);
            // Do Thi 
            //ZedGraphGocQuay.GraphPane.Title.Text ="Đồ Thị Góc Quay";
            //ZedGraphGocQuay.GraphPane.XAxis.Title.Text = "Thời Gian, giây";
            //ZedGraphGocQuay.GraphPane.YAxis.Title.Text = "Góc Quay";
            ZedGraphGiaToc.GraphPane.Title.Text = " Gia tốc, góc quay";
            ZedGraphGiaToc.GraphPane.XAxis.Title.Text="Thời Gian (giây)";
            ZedGraphGiaToc.GraphPane.YAxis.Title.Text = "Gia tốc (g), góc quay (Rad)";

            LineItem Ax = ZedGraphGiaToc.GraphPane.AddCurve("Roll x", List_Ax, Color.Blue, SymbolType.None);
            LineItem Ay = ZedGraphGiaToc.GraphPane.AddCurve("Pitch y", List_Ay, Color.Red, SymbolType.None);
            LineItem Az = ZedGraphGiaToc.GraphPane.AddCurve("Yaw z", List_Az, Color.Yellow, SymbolType.None);
            LineItem Roll_x = ZedGraphGiaToc.GraphPane.AddCurve("Ax", List_Roll_x, Color.Violet, SymbolType.None);
            LineItem Pitch_y = ZedGraphGiaToc.GraphPane.AddCurve("Ay", List_Pitch_y, Color.Tomato, SymbolType.None);
            LineItem Yaw_z = ZedGraphGiaToc.GraphPane.AddCurve("Az", List_Yaw_z, Color.Turquoise, SymbolType.None);

            ZedGraphGiaToc.IsShowPointValues = false;
            ZedGraphGiaToc.GraphPane.XAxis.Scale.Min = 0;
            ZedGraphGiaToc.GraphPane.XAxis.Scale.Max = 10;
            ZedGraphGiaToc.GraphPane.YAxis.Scale.Min = -3;
            ZedGraphGiaToc.GraphPane.YAxis.Scale.Max = 3;
            ZedGraphGiaToc.GraphPane.XAxis.Scale.MinorStep = 1;
            //ZedGraphGiaToc.GraphPane.XAxis.Scale.MajorStep = 1;
            ZedGraphGiaToc.AxisChange();
            double k = -1.02345;
            string t = "-1.02345";
            double n=-0.22;
            n=Convert.ToDouble(t);
            //textBox1.Text = k.ToString();
            //textBox2.Text = n.ToString();
        }

        private void BTKetNoi_Click(object sender, EventArgs e)
        {
            if(BTKetNoi.Text=="Kết Nối")
            {
                try
                {
                    serialPort.PortName = ComBPort.Text;
                    serialPort.BaudRate = int.Parse(ComBBaud.Text);
                    serialPort.Open();
                    MessageBox.Show("Kết nối thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BTKetNoi.Text = "Ngắt Kết Nối";
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else if(BTKetNoi.Text=="Ngắt Kết Nối")
            {
                serialPort.Close();
                BTKetNoi.Text = "Kết Nối";
            }
        }
        private void BTStart_Click(object sender, EventArgs e)
        {
            if (BTStart.Text == "Bắt đầu")
            {
                
                ZedGraphGiaToc.IsShowPointValues = false;
                ClearZedGraph();
                if (ComBchedo.SelectedItem.ToString() == "Chỉ vẽ đồ thị")
                {
                    modefile = false;
                }
                else modefile = true;
                TexBTenfile.Enabled = false;
                BtLoad.Enabled = false;
                //Alow drawTimer run
                drawTimer.Enabled = true;
                //timer1.Enabled = true;
                // Datetime_Start=DateTime.Now
                Datetime_Now = DateTime.Now ;
                /*
                String filepath = System.IO.Directory.GetCurrentDirectory() + @"\data\"+TexBTenfile.Text+".txt";
                FileStream fs = new FileStream(filepath, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine("MPU6050 - " + Datetime_Now.ToString());
                sWriter.Flush();
                //sWriter.WriteLine
                fs.Close();
                */
                start_mode = 1;
                BTStart.Text = "Dừng";
            }
            else
            {
                //timer1.Enabled = false;
                start_mode = 0;
                TexBTenfile.Enabled = true;
                BtLoad.Enabled = true;
                BTStart.Text = "Bắt đầu";
                ZedGraphGiaToc.IsShowPointValues = true;
            }
        }

        private void dataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            if (start_mode == 1)
            {
                string s = "";
                try
                {
                    s = serialPort.ReadTo("\r\n");//ReadExisting();
                    // tính khoảng thời gian
                    double datet = ((TimeSpan)(DateTime.Now - Datetime_Now)).TotalMilliseconds;
                    datet = Math.Round(datet / 1000, 3);

                    
                    string[] araystring = s.Split(' ');
                    draw(Convert.ToDouble(araystring[0]), Convert.ToDouble(araystring[1]), Convert.ToDouble(araystring[2]), Convert.ToDouble(araystring[3]), Convert.ToDouble(araystring[4]), Convert.ToDouble(araystring[5]), datet); // ve do thi 6 diem 
                   
                   if (modefile == true)
                    {
                        StreamWriter sWriter = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\data\" + TexBTenfile.Text + ".txt", true);
                        sWriter.WriteLine(datet.ToString() + " " + s);
                        sWriter.Flush();
                        sWriter.Close();
                    }
                     
                    //Datetime_Now = DateTime.Now;
                    //Load_Data(datet.ToString());
                }
                catch { }
            }
            else
            {
                serialPort.ReadExisting();
            }
          
        }

        private void BtGui_Click(object sender, EventArgs e)
        {
            int millisecond = DateTime.Now.Millisecond;
            Datetime_Now = DateTime.Now;
            //TexBGui.Text =datetime.ToString() +" : "+ millisecond.ToString();
            //timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            millisecond = DateTime.Now.Millisecond - millisecond;
            double datet = ((TimeSpan)(DateTime.Now - Datetime_Now)).TotalMilliseconds; // tính khoảng thời gian
            //datetime = DateTime.Now;
            datet = Math.Round(datet / 1000, 3);
            //Load_Data(datet.ToString());
            //i += 0.1;
            draw(10, 13, 15, 17, 19, 20, datet);
        }

        // vẽ đồ thị
        private void draw(double Data_AX,double Data_AY, double Data_AZ, double Data_Roll_x, double Data_Pitch_y, double Data_Yaw_z, double time)
        {
            LineItem Curve_AX = ZedGraphGiaToc.GraphPane.CurveList[0] as LineItem; // khoi tao biến edit line 0 
            IPointListEdit List_AX = Curve_AX.Points as IPointListEdit;
            List_AX.Add(time, Data_AX);                                            // thêm điểm

            LineItem Curve_AY = ZedGraphGiaToc.GraphPane.CurveList[1] as LineItem;
            IPointListEdit List_AY = Curve_AY.Points as IPointListEdit;
            List_AY.Add(time, Data_AY);

            LineItem Curve_AZ = ZedGraphGiaToc.GraphPane.CurveList[2] as LineItem;
            IPointListEdit List_AZ = Curve_AZ.Points as IPointListEdit;
            List_AZ.Add(time, Data_AZ);
           
            //List_Roll_x List_Pitch_y  List_Yaw_z

            LineItem Curve_Roll_x = ZedGraphGiaToc.GraphPane.CurveList[3] as LineItem;
            IPointListEdit List_Roll_x = Curve_Roll_x.Points as IPointListEdit;
            List_Roll_x.Add(time, Data_Roll_x);

            LineItem Curve_Pitch_y = ZedGraphGiaToc.GraphPane.CurveList[4] as LineItem;
            IPointListEdit List_Pitch_y = Curve_Pitch_y.Points as IPointListEdit;
            List_Pitch_y.Add(time, Data_Pitch_y);

            LineItem Curve_Yaw_z = ZedGraphGiaToc.GraphPane.CurveList[5] as LineItem;
            IPointListEdit List_Yaw_z = Curve_Yaw_z.Points as IPointListEdit;
            List_Yaw_z.Add(time, Data_Yaw_z);


            Scale xScale = ZedGraphGiaToc.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 10.0; // giá trị độ giãn
            }

            //Display sensor data
            axisChangeZedGraph(ZedGraphGiaToc);

        }
        delegate void axisChangeZedGraphCallBack(ZedGraphControl zg);
        private void axisChangeZedGraph(ZedGraphControl zg)
        {
            if (zg.InvokeRequired)
            {
                axisChangeZedGraphCallBack ad = new axisChangeZedGraphCallBack(axisChangeZedGraph);
                zg.Invoke(ad, new object[] { zg });
            }
            else
            {
                //zg.AxisChange();
                zg.Invalidate();
                zg.Refresh();
            }
        }
        // end ve do thi
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort.Close();

            }
            catch
            {  }
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadfile= new OpenFileDialog();
            loadfile.InitialDirectory = Application.StartupPath;
            loadfile.CheckPathExists = true;
            loadfile.DefaultExt = "txt";
            loadfile.CheckFileExists = true;
            loadfile.Filter = "text (*.txt)|*.txt|Tất cả file (*.*)|*.*";
            loadfile.FilterIndex = 2;
            loadfile.RestoreDirectory = true;
            if (loadfile.ShowDialog() == DialogResult.OK)
            {
                fullPathFile = loadfile.FileName;
                Load_Data();/*
                //TexBTenfile.Text = loadfile.InitialDirectory + loadfile.FileName;
                TexBTenfile.Text = System.IO.Path.GetFileName(loadfile.FileName);
                ZedGraphGiaToc.IsShowPointValues = true;
                //textBox1.Text = loadfile.FileName.ToString();
                ClearZedGraph();
                StreamReader sRead = new StreamReader(loadfile.FileName.ToString(), true);
                string dataread = sRead.ReadLine();
                //textBox1.Text = dataread;
                do{
                    dataread = sRead.ReadLine();
                    try
                    {
                        string[] araystring = dataread.Split(' ');
                        draw(Convert.ToDouble(araystring[1]), Convert.ToDouble(araystring[2]), Convert.ToDouble(araystring[3]), Convert.ToDouble(araystring[4]), Convert.ToDouble(araystring[5]), Convert.ToDouble(araystring[6]), Convert.ToDouble(araystring[0])); // ve do thi 6 diem 
                    }
                    catch { }
                }
                while (dataread != null);*/
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if(dataIndex < fileData.Length)
            {
                string dataLine = fileData[dataIndex++];
                
                if (dataLine != "")
                {
                    Console.WriteLine(dataLine);
                    string[] araystring = dataLine.Split('\t');
                    // ve do thi 6 diem
                    draw(Convert.ToDouble(araystring[1]), Convert.ToDouble(araystring[2]), Convert.ToDouble(araystring[3]), Convert.ToDouble(araystring[4]), Convert.ToDouble(araystring[5]), Convert.ToDouble(araystring[6]), Convert.ToDouble(araystring[0]));
                }
            }
            else
            {
                drawTimer.Enabled = false;
            }
        }
    }
}
