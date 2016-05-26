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
using System.Net;
using System.Text.RegularExpressions;

namespace ForumMonitor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Dictionary<string, string> postDic = new Dictionary<string, string>();
        string postHtml = null;
        private void GetHtml()
        {
            WebRequest oRequest = WebRequest.Create("http://bbs.c.163.com/?tab=all");
            //oRequest.Timeout = 3000;
            oRequest.Proxy = null;
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader oReader = new StreamReader(oResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            postHtml = oReader.ReadToEnd();
            oResponse.Close();
            oReader.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60 * 1000;
            GetHtml();
            Match LoadMh = new Regex(@"(?s)<a href=""(.{25,40})"" title="".{1,30}"">(.{1,30})</a>.{200,500}<i class=""u-icon u-icon-comment""></i> (\d*)</span>").Match(postHtml);
            while (LoadMh.Success)
            {
                postDic.Add(LoadMh.Groups[2].Value + LoadMh.Groups[1].Value, LoadMh.Groups[3].Value);
                LoadMh = LoadMh.NextMatch();
            }
            timer1.Start();
            this.Hide();
            this.ShowInTaskbar = false;
        }
        private void tSB手动刷新_Click(object sender, EventArgs e)
        {
            GetHtml();
            Match postMh = new Regex(@"(?s)<a href=""(.{25,40})"" title="".{1,30}"">(.{1,30})</a>.{200,500}<i class=""u-icon u-icon-comment""></i> (\d*)</span>").Match(postHtml);
            while (postMh.Success)
            {
                if (postDic.ContainsKey(postMh.Groups[2].Value + postMh.Groups[1].Value))
                {
                    if (postDic[postMh.Groups[2].Value + postMh.Groups[1].Value] != postMh.Groups[3].Value)
                    {
                        notifyIcon1.ShowBalloonTip(10000, "新回复", postMh.Groups[2].Value, ToolTipIcon.Info);
                        string ctmsItem = postMh.Groups[1].Value.Substring(7, postMh.Groups[1].Value.Length - 7) + " " + postMh.Groups[2].Value;
                        bool _inItems = false;
                        if (ctMS.Items.Count == 0)
                        {
                            ctMS.Items.Add(ctmsItem);
                        }
                        else
                        {
                            foreach (var item in ctMS.Items)
                            {
                                if (item.ToString() == ctmsItem)
                                {
                                    _inItems = true;
                                    break;
                                }
                            }
                            if (!_inItems)
                            {
                                ctMS.Items.Add(ctmsItem);
                            }
                        }
                        postDic[postMh.Groups[2].Value + postMh.Groups[1].Value] = postMh.Groups[3].Value;
                    }
                }
                else // new post
                {
                    notifyIcon1.ShowBalloonTip(10000, "新帖", postMh.Groups[2].Value, ToolTipIcon.Info);
                    string ctmsItem = postMh.Groups[1].Value.Substring(7, postMh.Groups[1].Value.Length - 7) + " " + postMh.Groups[2].Value;
                    bool _inItems = false;
                    if (ctMS.Items.Count == 0)
                    {
                        ctMS.Items.Add(ctmsItem);
                    }
                    else
                    {
                        foreach (var item in ctMS.Items)
                        {
                            if (item.ToString() == ctmsItem)
                            {
                                _inItems = true;
                                break;
                            }
                        }
                        if (!_inItems)
                        {
                            ctMS.Items.Add(ctmsItem);
                        }
                    }
                    postDic.Add(postMh.Groups[2].Value + postMh.Groups[1].Value, postMh.Groups[3].Value);
                }
                postMh = postMh.NextMatch();
            }
        }
        private void ctMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.c.163.com/topic/" + e.ClickedItem.Text.Substring(0, 24));
            ctMS.Items.Remove(e.ClickedItem);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tSB手动刷新_Click(null, null);
        }




    }
}
