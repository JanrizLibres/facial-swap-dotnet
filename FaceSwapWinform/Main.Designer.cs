namespace FaceSwapWinform
{
    partial class Main
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            inputPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            selfiePicBox = new PictureBox();
            label4 = new Label();
            outputPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)inputPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selfiePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputPicBox).BeginInit();
            SuspendLayout();
            // 
            // inputPicBox
            // 
            inputPicBox.Image = Properties.Resources.input;
            inputPicBox.Location = new Point(14, 16);
            inputPicBox.Margin = new Padding(0);
            inputPicBox.Name = "inputPicBox";
            inputPicBox.Size = new Size(418, 318);
            inputPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            inputPicBox.TabIndex = 3;
            inputPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 334);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(201, 700);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Selfie";
            // 
            // selfiePicBox
            // 
            selfiePicBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            selfiePicBox.Image = Properties.Resources.selfie;
            selfiePicBox.Location = new Point(67, 374);
            selfiePicBox.Margin = new Padding(0);
            selfiePicBox.Name = "selfiePicBox";
            selfiePicBox.Size = new Size(319, 326);
            selfiePicBox.SizeMode = PictureBoxSizeMode.Zoom;
            selfiePicBox.TabIndex = 7;
            selfiePicBox.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(786, 620);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Output";
            // 
            // outputPicBox
            // 
            outputPicBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            outputPicBox.Location = new Point(457, 97);
            outputPicBox.Margin = new Padding(0);
            outputPicBox.Name = "outputPicBox";
            outputPicBox.Size = new Size(693, 519);
            outputPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            outputPicBox.TabIndex = 8;
            outputPicBox.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 729);
            Controls.Add(label4);
            Controls.Add(outputPicBox);
            Controls.Add(selfiePicBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputPicBox);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facial Swap Prototype";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)inputPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)selfiePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)outputPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox inputPicBox;
        private Label label1;
        private Label label2;
        private PictureBox selfiePicBox;
        private Label label4;
        private PictureBox outputPicBox;
    }
}
