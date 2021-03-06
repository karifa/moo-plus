﻿namespace Moo.Controls
{
    partial class ProjectBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectBrowser));
            this.ListImage = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ListImage
            // 
            this.ListImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListImage.ImageStream")));
            this.ListImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ListImage.Images.SetKeyName(0, "Workspace.png");
            this.ListImage.Images.SetKeyName(1, "Foclosed.png");
            this.ListImage.Images.SetKeyName(2, "Foopened.png");
            this.ListImage.Images.SetKeyName(3, "File.png");
            // 
            // ProjectBrowser
            // 
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ImageIndex = 0;
            this.ImageList = this.ListImage;
            this.LineColor = System.Drawing.Color.Black;
            this.SelectedImageIndex = 0;
            this.ShowPlusMinus = false;
            this.ShowRootLines = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ListImage;
    }
}
