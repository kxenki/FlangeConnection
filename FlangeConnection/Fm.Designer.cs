﻿
namespace FlangeConnection
{
    partial class Fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm));
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxPaint = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaterial = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPress = new System.Windows.Forms.TextBox();
            this.tbFromDegrees = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbToDegrees = new System.Windows.Forms.TextBox();
            this.buReport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buExit = new System.Windows.Forms.Button();
            this.buWrap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.SystemColors.Window;
            this.picBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox1.Location = new System.Drawing.Point(12, 45);
            this.picBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(350, 188);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.SystemColors.Window;
            this.picBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox2.Location = new System.Drawing.Point(12, 507);
            this.picBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(350, 188);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.SystemColors.Window;
            this.picBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3.Location = new System.Drawing.Point(12, 272);
            this.picBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(350, 188);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фланец с шейкой, приварной встык";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " Плоский приварной фланец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = " Свободные фланцы";
            // 
            // picBoxPaint
            // 
            this.picBoxPaint.BackColor = System.Drawing.SystemColors.Window;
            this.picBoxPaint.Location = new System.Drawing.Point(684, 62);
            this.picBoxPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxPaint.Name = "picBoxPaint";
            this.picBoxPaint.Size = new System.Drawing.Size(407, 296);
            this.picBoxPaint.TabIndex = 6;
            this.picBoxPaint.TabStop = false;
            this.picBoxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(695, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "График чего-то";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(378, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выбор среды";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Location = new System.Drawing.Point(376, 95);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(302, 137);
            this.panel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(378, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Параметры";
            // 
            // lbMaterial
            // 
            this.lbMaterial.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMaterial.FormattingEnabled = true;
            this.lbMaterial.HorizontalScrollbar = true;
            this.lbMaterial.ItemHeight = 15;
            this.lbMaterial.Items.AddRange(new object[] {
            "Серый чугун СЧ15 ",
            "Серый чугун СЧ20",
            "Ковкий чугун КЧ 30-6",
            "Высокопрочный чугун ВЧ 40",
            "Высокопрочный чугун ВЧ 45",
            "Литье из нелегированной стали 25Л-II",
            "Литье из нелегированной стали 20Л-III",
            "Литье из нелегированной стали 25Л-III",
            "Литье из легированной стали 20Х5МЛ",
            "Литье из легированной стали 20ГМЛ",
            "Литье из высоколегированной стали 16Х18Н12С4ТЮЛ",
            "Литье из высоколегированной стали 12Х18Н9ТЛ",
            "Литье из высоколегированной стали 10X18Н9Л",
            "Сталь углеродистая Ст3сп не ниже 2-й категории",
            "Сталь углеродистая 20",
            "Сталь углеродистая 20К",
            "Сталь углеродистая 20КА",
            "Низколегированная сталь 20ЮЧ",
            "Низколегированная сталь 15ГС",
            "Низколегированная сталь 16ГС",
            "Низколегированная сталь 10Г2С1",
            "Низколегированная сталь 17ГС",
            "Низколегированная сталь 17Г1С",
            "Низколегированная сталь 12ХМ",
            "Низколегированная сталь 15ХМ",
            "Низколегированная сталь 09Г2С",
            "Низколегированная сталь 10Г2",
            "Сталь теплоустойчивая 15Х5М",
            "Сталь коррозионно-стойкая 08Х18Н10Т",
            "Сталь коррозионно-стойкая 12Х18Н9Т",
            "Сталь коррозионно-стойкая 12Х18Н10Т",
            "Сталь коррозионно-стойкая 10Х18Н9",
            "Сталь коррозионно-стойкая 08Х22Н6Т",
            "Сталь коррозионно-стойкая 08X21Н6М2Т",
            "Сталь коррозионно-стойкая 15Х18Н12С4ТЮ",
            "Сталь коррозионно-стойкая 06ХН28МДТ",
            "Сталь коррозионно-стойкая10Х17Н13М3Т",
            "Сталь коррозионно-стойкая 10Х17Н13М2Т",
            "Сталь коррозионно-стойкая 07Х20Н25М3Д2ТЛ(ЭИ 943Л)"});
            this.lbMaterial.Location = new System.Drawing.Point(377, 291);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(301, 169);
            this.lbMaterial.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(379, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Материал";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(381, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Номинальное давление (кгс/см^2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(381, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Температура (°С) от";
            // 
            // tbPress
            // 
            this.tbPress.Location = new System.Drawing.Point(607, 486);
            this.tbPress.Name = "tbPress";
            this.tbPress.Size = new System.Drawing.Size(71, 23);
            this.tbPress.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tbPress, "Максимум 250");
            // 
            // tbFromDegrees
            // 
            this.tbFromDegrees.Location = new System.Drawing.Point(502, 539);
            this.tbFromDegrees.Name = "tbFromDegrees";
            this.tbFromDegrees.Size = new System.Drawing.Size(71, 23);
            this.tbFromDegrees.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tbFromDegrees, "Минимум -270");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(581, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "до";
            // 
            // tbToDegrees
            // 
            this.tbToDegrees.Location = new System.Drawing.Point(607, 539);
            this.tbToDegrees.Name = "tbToDegrees";
            this.tbToDegrees.Size = new System.Drawing.Size(71, 23);
            this.tbToDegrees.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tbToDegrees, "Максимум 650");
            // 
            // buReport
            // 
            this.buReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buReport.FlatAppearance.BorderSize = 0;
            this.buReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buReport.Location = new System.Drawing.Point(765, 406);
            this.buReport.Margin = new System.Windows.Forms.Padding(0);
            this.buReport.Name = "buReport";
            this.buReport.Size = new System.Drawing.Size(98, 40);
            this.buReport.TabIndex = 15;
            this.buReport.Text = "Отчет";
            this.toolTip1.SetToolTip(this.buReport, "Создание отчета");
            this.buReport.UseVisualStyleBackColor = false;
            // 
            // buExit
            // 
            this.buExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buExit.FlatAppearance.BorderSize = 0;
            this.buExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buExit.Image = ((System.Drawing.Image)(resources.GetObject("buExit.Image")));
            this.buExit.Location = new System.Drawing.Point(1129, 0);
            this.buExit.Name = "buExit";
            this.buExit.Size = new System.Drawing.Size(32, 32);
            this.buExit.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buExit, "Закрыть");
            this.buExit.UseVisualStyleBackColor = true;
            this.buExit.Click += new System.EventHandler(this.buExit_Click);
            // 
            // buWrap
            // 
            this.buWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buWrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buWrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buWrap.FlatAppearance.BorderSize = 0;
            this.buWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWrap.ForeColor = System.Drawing.SystemColors.Control;
            this.buWrap.Image = ((System.Drawing.Image)(resources.GetObject("buWrap.Image")));
            this.buWrap.Location = new System.Drawing.Point(1091, 0);
            this.buWrap.Name = "buWrap";
            this.buWrap.Size = new System.Drawing.Size(32, 32);
            this.buWrap.TabIndex = 18;
            this.toolTip1.SetToolTip(this.buWrap, "Свернуть");
            this.buWrap.UseVisualStyleBackColor = true;
            this.buWrap.Click += new System.EventHandler(this.buWrap_Click);
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1161, 600);
            this.Controls.Add(this.buWrap);
            this.Controls.Add(this.buExit);
            this.Controls.Add(this.buReport);
            this.Controls.Add(this.tbToDegrees);
            this.Controls.Add(this.tbFromDegrees);
            this.Controls.Add(this.tbPress);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxPaint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1149, 554);
            this.Name = "Fm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Flange Connections";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxPaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPress;
        private System.Windows.Forms.TextBox tbFromDegrees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbToDegrees;
        private System.Windows.Forms.Button buReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buExit;
        private System.Windows.Forms.Button buWrap;
    }
}

