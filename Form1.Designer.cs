namespace MnistImage
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbImage = new System.Windows.Forms.TextBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbPixelString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(47, 22);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(562, 20);
            this.tbImage.TabIndex = 0;
            this.tbImage.Text = ".\\MnistData\\train-images.idx3-ubyte";
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(47, 61);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(562, 20);
            this.tbLabel.TabIndex = 1;
            this.tbLabel.Text = ".\\MnistData\\train-labels.idx1-ubyte";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(650, 34);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 27);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(52, 94);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(157, 20);
            this.tbIndex.TabIndex = 3;
            this.tbIndex.Text = "18";
            // 
            // btnShowImage
            // 
            this.btnShowImage.Enabled = false;
            this.btnShowImage.Location = new System.Drawing.Point(656, 90);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(100, 26);
            this.btnShowImage.TabIndex = 4;
            this.btnShowImage.Text = "Show Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.BtnShowImage_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(57, 137);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(57, 184);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(152, 148);
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // tbPixelString
            // 
            this.tbPixelString.Location = new System.Drawing.Point(226, 145);
            this.tbPixelString.Multiline = true;
            this.tbPixelString.Name = "tbPixelString";
            this.tbPixelString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPixelString.Size = new System.Drawing.Size(529, 277);
            this.tbPixelString.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPixelString);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowImage);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.tbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbPixelString;
    }
}

