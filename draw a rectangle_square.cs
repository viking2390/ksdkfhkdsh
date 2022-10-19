using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace GP_PRAC_06
{
    public partial class Form1 : Form
    {
        Device d;
        public Form1()
        {
            InitializeComponent();
            InitDevice();
        }
        void InitDevice()
        {
            PresentParameters presentParameters = new
            PresentParameters();
            presentParameters.Windowed = true;
            presentParameters.SwapEffect = SwapEffect.Discard;
            d = new Device(0, DeviceType.Hardware, this,
            CreateFlags.HardwareVertexProcessing, presentParameters);
        }
        void Render()
        {
            CustomVertex.TransformedColored[] vertex = new CustomVertex.TransformedColored[6];
            vertex[0].Position = vertex[5].Position = new Vector4(200, 100, 0, 0);
            vertex[1].Position = new Vector4(300, 100, 0, 0);
            vertex[2].Position = vertex[3].Position = new Vector4(300, 300, 0, 0);
            vertex[4].Position = new Vector4(200, 300, 0, 0);
            d.Clear(ClearFlags.Target, Color.White, 0, 1);
            d.BeginScene();
            d.VertexFormat = CustomVertex.TransformedColored.Format;
            d.DrawUserPrimitives(PrimitiveType.TriangleList, 2, vertex);
            d.EndScene();
            d.Present();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}

