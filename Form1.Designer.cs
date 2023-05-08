namespace MyExplorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListviewMain = new System.Windows.Forms.ListView();
            this.ImgLst = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ListviewMain
            // 
            this.ListviewMain.AccessibleName = "";
            this.ListviewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListviewMain.BackColor = System.Drawing.SystemColors.Window;
            this.ListviewMain.LargeImageList = this.ImgLst;
            this.ListviewMain.Location = new System.Drawing.Point(11, 12);
            this.ListviewMain.Name = "ListviewMain";
            this.ListviewMain.Size = new System.Drawing.Size(728, 385);
            this.ListviewMain.SmallImageList = this.ImgLst;
            this.ListviewMain.TabIndex = 0;
            this.ListviewMain.UseCompatibleStateImageBehavior = false;
            this.ListviewMain.View = System.Windows.Forms.View.List;
            // 
            // ImgLst
            // 
            this.ImgLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst.ImageStream")));
            this.ImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst.Images.SetKeyName(0, "218693.png");
            this.ImgLst.Images.SetKeyName(1, "553863.png");
            this.ImgLst.Images.SetKeyName(2, "4720365.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 409);
            this.Controls.Add(this.ListviewMain);
            this.Name = "MainForm";
            this.Text = "MyExplorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListviewMain;
        private ImageList ImgLst;
    }
}