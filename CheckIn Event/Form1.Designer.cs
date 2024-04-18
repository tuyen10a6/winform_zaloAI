namespace CheckIn_Event
{
    partial class Form1
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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Frame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1039);
            Font = new Font(".VnArial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKIN EVENT";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
    }
}