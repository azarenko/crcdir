using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace crcdir
{
    public partial class Form1 : Form
    {
        private Dictionary<string, uint> source1Hashes = new Dictionary<string, uint>();
        private Dictionary<string, uint> source2Hashes = new Dictionary<string, uint>();
        Crc32 crc32 = new Crc32();

        public Form1()
        {
            InitializeComponent();
        }

        private void _select1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _source1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void _select2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                _source2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void _compare_Click(object sender, EventArgs e)
        {
            _difflog.Clear();
            source1Hashes.Clear();
            source2Hashes.Clear();

            ScanDirectory(_source1.Text, _source1.Text, source1Hashes);
            ScanDirectory(_source2.Text, _source2.Text, source2Hashes);

            foreach (var hash1 in source1Hashes)
            {
                if (source2Hashes.TryGetValue(hash1.Key, out uint hash2))
                {
                    if (hash1.Value == hash2)
                    {
                        source2Hashes.Remove(hash1.Key);
                    }
                    else
                    {
                        _difflog.Text += string.Format("diff -> {0}\r\n", hash1.Key);
                    }
                }
                else
                {
                    _difflog.Text += string.Format("miss in source 2 -> {0}\r\n", hash1.Key);
                }
            }

            foreach (var hash2 in source2Hashes)
            {
                if (source1Hashes.TryGetValue(hash2.Key, out uint hash1))
                {
                    if (hash2.Value == hash1)
                    {
                        source2Hashes.Remove(hash2.Key);
                    }
                    else
                    {
                        _difflog.Text += string.Format("diff -> {0}\r\n", hash2.Key);
                    }
                }
                else
                {
                    _difflog.Text += string.Format("miss in source 1 -> {0}\r\n", hash2.Key);
                }
            }

            _difflog.Text += "Finish!";
        }

        private void ScanDirectory(string basepath, string path, Dictionary<string, uint> hashTable)
        {
            foreach (var subDirectoryPath in Directory.GetDirectories(path))
            {
                ScanDirectory(basepath, subDirectoryPath, hashTable);
            }

            foreach (var filePath in Directory.GetFiles(path))
            {
                hashTable.Add(filePath.Replace(basepath, String.Empty), crc32.GetUintHash(filePath));
            }
        }
    }
}
