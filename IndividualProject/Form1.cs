using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Array = new MyArray(5);
            ShowMyArray();
        }

        private MyArray Array;

        private void GetArr_Click(object sender, EventArgs e)
        {
            Array /= (int)Division.Value;
            Array *= (int)Composition.Value;

            var rightArr = new MyArray(Array.Size);
            for (int i = 0; i < Array.Size; i++)
            {
                rightArr[i] = int.Parse(SumArray[0, i].Value is null ? "0" : SumArray[0, i].Value.ToString());
            }
            Array += rightArr;
            rightArr = new MyArray(Array.Size);
            for (int i = 0; i < Array.Size; i++)
            {
                rightArr[i] = int.Parse(DivArray[0, i].Value is null ? "0" : DivArray[0, i].Value.ToString());
            }
            Array -= rightArr;
            ShowMyArray();
        }

        private void ShowMyArray()
        {
            MyArray.Rows.Clear();
            SumArray.Rows.Clear();
            DivArray.Rows.Clear();
            for (int i = 0; i < Array.Size; i++)
            {
                MyArray.Rows.Add(Array[i].ToString());
            }
            SumArray.Rows.Add(Array.Size);
            DivArray.Rows.Add(Array.Size);
            ValueByIndex.Value = Array[0];
        }

        private void ArraySize_ValueChanged(object sender, EventArgs e)
        {
            Array = new MyArray((int)ArraySize.Value);
            ShowMyArray();
            Index.Maximum = Array.Size - 1;
        }

        private void Index_ValueChanged(object sender, EventArgs e)
        {
            ValueByIndex.Value = Array[(int)Index.Value];
        }

        private void ValueByIndex_ValueChanged(object sender, EventArgs e)
        {
            Array[(int)Index.Value] = (int)ValueByIndex.Value;
            MyArray[0, (int)Index.Value].Value = ValueByIndex.Value;
        }
    }
}
