﻿namespace bilals_browser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rechts = new System.Windows.Forms.Button();
            this.links = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.geschiedenis_bekijken = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.rechts);
            this.panel1.Controls.Add(this.links);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.url);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 25);
            this.panel1.TabIndex = 0;
            // 
            // rechts
            // 
            this.rechts.Location = new System.Drawing.Point(47, 1);
            this.rechts.Name = "rechts";
            this.rechts.Size = new System.Drawing.Size(37, 23);
            this.rechts.TabIndex = 3;
            this.rechts.Text = "→";
            this.rechts.UseVisualStyleBackColor = true;
            this.rechts.Click += new System.EventHandler(this.button2_Click);
            // 
            // links
            // 
            this.links.Location = new System.Drawing.Point(4, 1);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(37, 23);
            this.links.TabIndex = 2;
            this.links.Text = "⬅";
            this.links.UseVisualStyleBackColor = true;
            this.links.Click += new System.EventHandler(this.links_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "opnieuw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.Location = new System.Drawing.Point(212, 2);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(462, 22);
            this.url.TabIndex = 0;
            this.url.Text = "http://";
            this.url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.url_KeyPress);
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(1, 56);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(812, 368);
            this.browser.TabIndex = 1;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // geschiedenis_bekijken
            // 
            this.geschiedenis_bekijken.Location = new System.Drawing.Point(12, 31);
            this.geschiedenis_bekijken.Name = "geschiedenis_bekijken";
            this.geschiedenis_bekijken.Size = new System.Drawing.Size(101, 23);
            this.geschiedenis_bekijken.TabIndex = 2;
            this.geschiedenis_bekijken.Text = "geschiedenis";
            this.geschiedenis_bekijken.UseVisualStyleBackColor = true;
            this.geschiedenis_bekijken.Click += new System.EventHandler(this.geschiedenis_bekijken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 412);
            this.Controls.Add(this.geschiedenis_bekijken);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bilal\'s browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button links;
        private System.Windows.Forms.Button rechts;
        private System.Windows.Forms.Button geschiedenis_bekijken;
    }
}

