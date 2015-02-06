namespace KeySAV3
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.CB_HelpSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Help = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CB_HelpSelector
            // 
            this.CB_HelpSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_HelpSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_HelpSelector.FormattingEnabled = true;
            this.CB_HelpSelector.Items.AddRange(new object[] {
            "String Formatting",
            "How to Use KeySAV3",
            "How to Get Your Saves",
            "How to Break Save Encryption",
            "How to Get Your Battle Videos",
            "How to Break Battle Video Encryption",
            "How to Open Encrypted Saves (Digital copy, PowerSaves, CyberGadget)",
            "How to Open Decrypted Saves (YABD, PCEdit, RAM2Sav)",
            "How to Use Battle Videos",
            "Export Options",
            "About KeySAV3",
            "Changelog"});
            this.CB_HelpSelector.Location = new System.Drawing.Point(56, 10);
            this.CB_HelpSelector.Name = "CB_HelpSelector";
            this.CB_HelpSelector.Size = new System.Drawing.Size(400, 21);
            this.CB_HelpSelector.TabIndex = 0;
            this.CB_HelpSelector.SelectedIndexChanged += new System.EventHandler(this.loadHelp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic:";
            // 
            // RTB_Help
            // 
            this.RTB_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Help.Location = new System.Drawing.Point(13, 43);
            this.RTB_Help.Name = "RTB_Help";
            this.RTB_Help.ReadOnly = true;
            this.RTB_Help.Size = new System.Drawing.Size(443, 441);
            this.RTB_Help.TabIndex = 2;
            this.RTB_Help.Text = "";
            this.RTB_Help.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Link_Clicked);
            // 
            // Help
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(468, 496);
            this.Controls.Add(this.RTB_Help);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_HelpSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeySAV3 Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_HelpSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_Help;

    }
}
