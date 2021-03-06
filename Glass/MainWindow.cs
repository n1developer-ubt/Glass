﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Glass.Properties;

namespace Glass
{
    public partial class MainWindow : DevExpress.XtraEditors.XtraForm
    {
        private PictureEdit CurrentImage1 = null;
        private PictureEdit CurrentImage2 = null;

        public MainWindow()
        {
            InitializeComponent();
            radioGroup1.SelectedIndex = 1;
            KeyPreview = true;
            this.KeyDown += OnKeyDown;
            this.Load += OnLoad;
            peMain.Properties.ContextMenuStrip = new ContextMenuStrip();
            ShowIt(false);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Control)
            {
                LoadImages();
            }
        }

        private void LoadImages()
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                f.Description = "Select Folder";

                if (Directory.Exists(Settings.Default.Folder))
                {
                    f.SelectedPath = Settings.Default.Folder;

                }

                if (f.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.Folder = f.SelectedPath;
                    Settings.Default.Save();
                    LoadAll();
                }
            
            }
        }

        private void LoadAll()
        {
            if (!Directory.Exists(Settings.Default.Folder))
                return;
            pnlAllPictures.Controls.Clear();
            DirectoryInfo d = new DirectoryInfo(Settings.Default.Folder);

            foreach (FileInfo fileInfo in d.GetFiles("*.*", SearchOption.AllDirectories).Where(s =>
                s.FullName.ToLower().EndsWith(".png") || s.FullName.ToLower().EndsWith(".jpg")))
            {
                PictureEdit p = new PictureEdit();
                p.MouseLeave += POnMouseLeave;
                p.Image = new Bitmap(fileInfo.FullName);
                p.Properties.SizeMode = PictureSizeMode.Zoom;
                p.MouseEnter += POnMouseEnter;
                p.Size = new Size(75, 75);
                p.Click += POnClick;
                pnlAllPictures.Controls.Add(p);
            }

        }

        private void POnMouseLeave(object sender, EventArgs e)
        {
            //if (CurrentImage1 != null)
            //{
            //    peMain.Image = CurrentImage1.Image;
            //}
            //ShowIt(false);
        }

        private void POnClick(object sender, EventArgs e)
        {
            if (sender is PictureEdit p)
            {
                if (p.Equals(CurrentImage1))
                {
                    CurrentImage1.BackColor = Color.White;
                    
                    CurrentImage1 = CurrentImage2;
                    CurrentImage2 = null;

                    if (CurrentImage1 == null)
                    {
                        ShowIt(false);
                        return;
                    }
                    
                    CurrentImage1.BackColor = Color.FromArgb(219, 220, 226);

                    SetI(CurrentImage1.Image);
                    ShowIt(true);
                    return;
                }

                if (p.Equals(CurrentImage2))
                {
                    p.BackColor = Color.White;
                    CurrentImage2 = null;
                    SetI(CurrentImage1.Image);
                    ShowIt(true);
                    return;
                }

                if (CurrentImage1 == null)
                {
                    CurrentImage1 = p;
                    CurrentImage1.BackColor = Color.FromArgb(219, 220, 226);
                    SetI(CurrentImage1.Image);
                    ShowIt(true);
                    return;
                }

                if(CurrentImage2 != null)
                    CurrentImage2.BackColor = Color.White;
                CurrentImage2 = p;
                CurrentImage2.BackColor = Color.FromArgb(219, 220, 226);
                SetI(CurrentImage1.Image, CurrentImage2.Image);
                ShowIt(true);
            }
        }

        private void POnMouseEnter(object sender, EventArgs e)
        {
            //if (sender is PictureEdit p)
            //{
            //    //peMain.Image = p.Image;
            //    SetI(p.Image);
            //    ShowIt(true);
            //}
        }

        private void SetI(Image i, Image i2 = null)
        {
            p1.Image = i;
            p2.Image = i2??i;
            //p3.Image = i;
            //p4.Image = i;
            //p5.Image = i;
        }
        private void ShowIt(bool show)
        {
            lastShow = show;
            if (show)
            {
                switch (index)
                {
                    case 0:
                        p2.Hide();
                        p1.Show();
                        break;
                    case 1:
                        p1.Show();
                        p2.Show();
                        break;
                    case 2:
                        p1.Hide();
                        p2.Show();
                        break;
                }
            }
            else
            {
                p1.Hide();
                p2.Hide();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            LoadImages();
        }

        private bool lastShow = false;
        private int index = 1;

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioGroup g)) return;

            this.index = g.SelectedIndex;
            ShowIt(lastShow);
        }
    }
    }