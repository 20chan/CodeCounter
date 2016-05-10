using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCounter
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        List<FileLine> lines;
        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(getLines);
            t.IsBackground = true;
            this.lbTotal.Text = "계산중..";
            t.Start();
            //t.Join();
            //sortLinesToListview();
        }

        private void getLines()
        {
            foreach (string format in tbRule.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                TextAttribute.FromFormat(format);
            }

            Counter c = new Counter(tbDirectory.Text, cbSub.Checked);
            lines = c.Count();
            sortLinesToListview();
        }

        private void sortLinesToListview()
        {
            int total = 0;
            lvResults.Items.Clear();
            foreach (FileLine f in lines)
            {
                ListViewItem i = new ListViewItem(this.cbShowdirectory.Checked ? f.Path : System.IO.Path.GetFileName(f.Path));
                i.SubItems.Add(f.Line.ToString());
                this.lvResults.Items.Add(i);
                total += f.Line;
            }

            this.lbTotal.Text = "총 라인 수 : " + total.ToString();
            if (lines.Count == 0)
                lbTotal.Text = "검색 결과 없음";

            GC.Collect();
        }

        const string cFormat = "/.c";
        const string cppFormat = "/.cpp";
        const string csharpFormat = "/.cs\r\n?/.Designer.cs\r\n?\\TemporaryGeneratedFile";
        private void cbShowdirectory_CheckedChanged(object sender, EventArgs e)
        {
            sortLinesToListview();
        }

        private void cbRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbRules.SelectedIndex)
            {
                case 0:
                    break;
                case 1: // C
                    this.tbRule.Text = cFormat;
                    break;
                case 2: // C++
                    this.tbRule.Text = cppFormat;
                    break;
                case 3: // C#
                    this.tbRule.Text = csharpFormat;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                this.tbDirectory.Text = fbdDirectory.SelectedPath;
            }
        }

        private void fbdDirectory_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
