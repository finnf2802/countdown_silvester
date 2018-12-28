namespace CountDown_Silvester
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lCountdownHours = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.labelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lCountdownSeconds = new System.Windows.Forms.Label();
            this.lCountdownN = new System.Windows.Forms.Label();
            this.lCountdownN2 = new System.Windows.Forms.Label();
            this.lCountdownMinutes = new System.Windows.Forms.Label();
            this.labelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lCountdownHours
            // 
            this.lCountdownHours.AutoSize = true;
            this.lCountdownHours.Location = new System.Drawing.Point(265, 210);
            this.lCountdownHours.Name = "lCountdownHours";
            this.lCountdownHours.Size = new System.Drawing.Size(36, 25);
            this.lCountdownHours.TabIndex = 1;
            this.lCountdownHours.Text = "12";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // labelLayout
            // 
            this.labelLayout.ColumnCount = 5;
            this.labelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.labelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.labelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.labelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.labelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.labelLayout.Controls.Add(this.lCountdownSeconds, 4, 0);
            this.labelLayout.Controls.Add(this.lCountdownN, 1, 0);
            this.labelLayout.Controls.Add(this.lCountdownN2, 3, 0);
            this.labelLayout.Controls.Add(this.lCountdownMinutes, 2, 0);
            this.labelLayout.Location = new System.Drawing.Point(841, 538);
            this.labelLayout.Name = "labelLayout";
            this.labelLayout.RowCount = 1;
            this.labelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.labelLayout.Size = new System.Drawing.Size(601, 240);
            this.labelLayout.TabIndex = 7;
            this.labelLayout.Visible = false;
            // 
            // lCountdownSeconds
            // 
            this.lCountdownSeconds.AutoSize = true;
            this.lCountdownSeconds.Location = new System.Drawing.Point(552, 0);
            this.lCountdownSeconds.Name = "lCountdownSeconds";
            this.lCountdownSeconds.Size = new System.Drawing.Size(36, 25);
            this.lCountdownSeconds.TabIndex = 5;
            this.lCountdownSeconds.Text = "12";
            // 
            // lCountdownN
            // 
            this.lCountdownN.AutoSize = true;
            this.lCountdownN.Location = new System.Drawing.Point(447, 0);
            this.lCountdownN.Name = "lCountdownN";
            this.lCountdownN.Size = new System.Drawing.Size(18, 25);
            this.lCountdownN.TabIndex = 2;
            this.lCountdownN.Text = ":";
            // 
            // lCountdownN2
            // 
            this.lCountdownN2.AutoSize = true;
            this.lCountdownN2.Location = new System.Drawing.Point(525, 0);
            this.lCountdownN2.Name = "lCountdownN2";
            this.lCountdownN2.Size = new System.Drawing.Size(18, 25);
            this.lCountdownN2.TabIndex = 4;
            this.lCountdownN2.Text = ":";
            // 
            // lCountdownMinutes
            // 
            this.lCountdownMinutes.AutoSize = true;
            this.lCountdownMinutes.Location = new System.Drawing.Point(475, 0);
            this.lCountdownMinutes.Name = "lCountdownMinutes";
            this.lCountdownMinutes.Size = new System.Drawing.Size(36, 25);
            this.lCountdownMinutes.TabIndex = 3;
            this.lCountdownMinutes.Text = "12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 813);
            this.Controls.Add(this.labelLayout);
            this.Controls.Add(this.lCountdownHours);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.labelLayout.ResumeLayout(false);
            this.labelLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCountdownHours;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.TableLayoutPanel labelLayout;
        private System.Windows.Forms.Label lCountdownSeconds;
        private System.Windows.Forms.Label lCountdownN;
        private System.Windows.Forms.Label lCountdownN2;
        private System.Windows.Forms.Label lCountdownMinutes;
    }
}

