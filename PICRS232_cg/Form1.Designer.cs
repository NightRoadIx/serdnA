namespace PICRS232_cg
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_t = new System.Windows.Forms.Button();
            this.button_b = new System.Windows.Forms.Button();
            this.button_a = new System.Windows.Forms.Button();
            this.button_l = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_visualizar_mensaje = new System.Windows.Forms.TextBox();
            this.label_mensaje_pic = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ini = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stato = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.but_POIR = new System.Windows.Forms.Button();
            this.POR_but = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_t
            // 
            this.button_t.BackColor = System.Drawing.Color.Red;
            this.button_t.Location = new System.Drawing.Point(190, 38);
            this.button_t.Name = "button_t";
            this.button_t.Size = new System.Drawing.Size(75, 23);
            this.button_t.TabIndex = 0;
            this.button_t.Text = "Reset";
            this.button_t.UseVisualStyleBackColor = false;
            this.button_t.Click += new System.EventHandler(this.button_t_Click);
            this.button_t.MouseLeave += new System.EventHandler(this.button_t_MouseLeave);
            this.button_t.MouseHover += new System.EventHandler(this.button_t_MouseHover);
            // 
            // button_b
            // 
            this.button_b.Location = new System.Drawing.Point(28, 67);
            this.button_b.Name = "button_b";
            this.button_b.Size = new System.Drawing.Size(75, 23);
            this.button_b.TabIndex = 1;
            this.button_b.Text = "b";
            this.button_b.UseVisualStyleBackColor = true;
            this.button_b.Click += new System.EventHandler(this.button_b_Click);
            // 
            // button_a
            // 
            this.button_a.Location = new System.Drawing.Point(28, 9);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(75, 23);
            this.button_a.TabIndex = 2;
            this.button_a.Text = "PWM";
            this.button_a.UseVisualStyleBackColor = true;
            this.button_a.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_l
            // 
            this.button_l.Location = new System.Drawing.Point(28, 38);
            this.button_l.Name = "button_l";
            this.button_l.Size = new System.Drawing.Size(75, 23);
            this.button_l.TabIndex = 3;
            this.button_l.Text = "ADC 0";
            this.button_l.UseVisualStyleBackColor = true;
            this.button_l.Click += new System.EventHandler(this.button_l_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.ReadBufferSize = 1024;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "hh:mm:ss";
            // 
            // textBox_visualizar_mensaje
            // 
            this.textBox_visualizar_mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_visualizar_mensaje.Location = new System.Drawing.Point(0, 417);
            this.textBox_visualizar_mensaje.Multiline = true;
            this.textBox_visualizar_mensaje.Name = "textBox_visualizar_mensaje";
            this.textBox_visualizar_mensaje.ReadOnly = true;
            this.textBox_visualizar_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_visualizar_mensaje.Size = new System.Drawing.Size(921, 104);
            this.textBox_visualizar_mensaje.TabIndex = 5;
            // 
            // label_mensaje_pic
            // 
            this.label_mensaje_pic.AutoSize = true;
            this.label_mensaje_pic.Location = new System.Drawing.Point(12, 401);
            this.label_mensaje_pic.Name = "label_mensaje_pic";
            this.label_mensaje_pic.Size = new System.Drawing.Size(110, 13);
            this.label_mensaje_pic.TabIndex = 4;
            this.label_mensaje_pic.Text = "Mensaje desde el PIC";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(693, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 123);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PWM";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "mW";
            // 
            // button_ini
            // 
            this.button_ini.Enabled = false;
            this.button_ini.Location = new System.Drawing.Point(109, 38);
            this.button_ini.Name = "button_ini";
            this.button_ini.Size = new System.Drawing.Size(75, 23);
            this.button_ini.TabIndex = 13;
            this.button_ini.Text = "Inin";
            this.button_ini.UseVisualStyleBackColor = true;
            this.button_ini.Click += new System.EventHandler(this.button_ini_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(582, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tiempo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(582, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "seg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "seg";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(582, 108);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 15);
            this.pBar1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tejido 1",
            "Tejido 2",
            "Tejido 3",
            "Tejido 4",
            "Epidermis"});
            this.comboBox1.Location = new System.Drawing.Point(109, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stato
            // 
            this.stato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stato.ForeColor = System.Drawing.Color.Maroon;
            this.stato.Location = new System.Drawing.Point(190, 6);
            this.stato.Name = "stato";
            this.stato.ReadOnly = true;
            this.stato.Size = new System.Drawing.Size(156, 26);
            this.stato.TabIndex = 21;
            this.stato.Text = "Estado";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(449, 99);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '0';
            this.maskedTextBox1.Size = new System.Drawing.Size(53, 20);
            this.maskedTextBox1.TabIndex = 23;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(328, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(743, 63);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(140, 45);
            this.trackBar2.SmallChange = 10;
            this.trackBar2.TabIndex = 27;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(834, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(39, 20);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // but_POIR
            // 
            this.but_POIR.Location = new System.Drawing.Point(809, 32);
            this.but_POIR.Name = "but_POIR";
            this.but_POIR.Size = new System.Drawing.Size(64, 20);
            this.but_POIR.TabIndex = 30;
            this.but_POIR.Text = "PO IR";
            this.but_POIR.UseVisualStyleBackColor = true;
            this.but_POIR.Click += new System.EventHandler(this.but_POIR_Click_1);
            // 
            // POR_but
            // 
            this.POR_but.Location = new System.Drawing.Point(743, 32);
            this.POR_but.Name = "POR_but";
            this.POR_but.Size = new System.Drawing.Size(62, 20);
            this.POR_but.TabIndex = 31;
            this.POR_but.Text = "PO R";
            this.POR_but.UseVisualStyleBackColor = true;
            this.POR_but.Click += new System.EventHandler(this.POR_but_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fotopletismografo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 394);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(95, 20);
            this.textBox6.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(779, 294);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 34;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(782, 323);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(90, 20);
            this.textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(785, 353);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(87, 20);
            this.textBox9.TabIndex = 36;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(236, 393);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(468, 20);
            this.textBox10.TabIndex = 37;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(918, 569);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.POR_but);
            this.Controls.Add(this.but_POIR);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.stato);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_ini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_mensaje_pic);
            this.Controls.Add(this.textBox_visualizar_mensaje);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_l);
            this.Controls.Add(this.button_a);
            this.Controls.Add(this.button_b);
            this.Controls.Add(this.button_t);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PICRS323_cg";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Principal_Paint);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_t;
        private System.Windows.Forms.Button button_b;
        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button button_l;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox_visualizar_mensaje;
        private System.Windows.Forms.Label label_mensaje_pic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ini;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox stato;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button but_POIR;
        private System.Windows.Forms.Button POR_but;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;

        public System.EventHandler but_POR_Click_1 { get; set; }
    }
}

