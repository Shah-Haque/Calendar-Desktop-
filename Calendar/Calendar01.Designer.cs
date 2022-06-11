
namespace Calendar
{
    partial class Calendar01
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.group01 = new System.Windows.Forms.GroupBox();
            this.hide_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_show = new System.Windows.Forms.Button();
            this.Cal_Label = new System.Windows.Forms.Label();
            this.group01.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(126, 183);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(267, 36);
            this.txt_1.TabIndex = 0;
            // 
            // group01
            // 
            this.group01.Controls.Add(this.hide_btn);
            this.group01.Controls.Add(this.Exit_btn);
            this.group01.Controls.Add(this.monthCalendar1);
            this.group01.Location = new System.Drawing.Point(119, 225);
            this.group01.Name = "group01";
            this.group01.Size = new System.Drawing.Size(397, 306);
            this.group01.TabIndex = 1;
            this.group01.TabStop = false;
            // 
            // hide_btn
            // 
            this.hide_btn.Location = new System.Drawing.Point(83, 259);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(87, 41);
            this.hide_btn.TabIndex = 3;
            this.hide_btn.Text = "Hide";
            this.hide_btn.UseVisualStyleBackColor = true;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(191, 259);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(83, 41);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(399, 183);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(117, 36);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Cal_Label
            // 
            this.Cal_Label.AutoSize = true;
            this.Cal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_Label.Location = new System.Drawing.Point(147, 89);
            this.Cal_Label.Name = "Cal_Label";
            this.Cal_Label.Size = new System.Drawing.Size(369, 91);
            this.Cal_Label.TabIndex = 3;
            this.Cal_Label.Text = "Calendar";
            // 
            // Calendar01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 567);
            this.Controls.Add(this.Cal_Label);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.group01);
            this.Controls.Add(this.txt_1);
            this.Name = "Calendar01";
            this.Text = "Basic Calendar";
            this.group01.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.GroupBox group01;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label Cal_Label;
    }
}

