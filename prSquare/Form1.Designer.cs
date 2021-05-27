
namespace prSquare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnTrFun = new System.Windows.Forms.Button();
            this.btnTrSad = new System.Windows.Forms.Button();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudy
            // 
            this.btnStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudy.Location = new System.Drawing.Point(454, 46);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(108, 45);
            this.btnStudy.TabIndex = 0;
            this.btnStudy.Text = "Study";
            this.btnStudy.UseVisualStyleBackColor = true;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.Location = new System.Drawing.Point(454, 97);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(108, 43);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(590, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(454, 149);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(108, 40);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnTrFun
            // 
            this.btnTrFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrFun.Location = new System.Drawing.Point(584, 148);
            this.btnTrFun.Name = "btnTrFun";
            this.btnTrFun.Size = new System.Drawing.Size(121, 41);
            this.btnTrFun.TabIndex = 8;
            this.btnTrFun.Text = "Train Fun";
            this.btnTrFun.UseVisualStyleBackColor = true;
            this.btnTrFun.Click += new System.EventHandler(this.btnTrFun_Click);
            // 
            // btnTrSad
            // 
            this.btnTrSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrSad.Location = new System.Drawing.Point(721, 149);
            this.btnTrSad.Name = "btnTrSad";
            this.btnTrSad.Size = new System.Drawing.Size(116, 41);
            this.btnTrSad.TabIndex = 9;
            this.btnTrSad.Text = "Train Sad";
            this.btnTrSad.UseVisualStyleBackColor = true;
            this.btnTrSad.Click += new System.EventHandler(this.btnTrSad_Click);
            // 
            // picBig
            // 
            this.picBig.BackColor = System.Drawing.Color.White;
            this.picBig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBig.Location = new System.Drawing.Point(420, 250);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(200, 200);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBig.TabIndex = 3;
            this.picBig.TabStop = false;
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDraw.Location = new System.Drawing.Point(31, 25);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(350, 350);
            this.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDraw.TabIndex = 2;
            this.picDraw.TabStop = false;
            this.picDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseDown);
            this.picDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseMove);
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseUp);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "pic1",
            "pic2",
            "pic3",
            "pic4",
            "pic5",
            "pic6"});
            this.cmb.Location = new System.Drawing.Point(689, 250);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(138, 28);
            this.cmb.TabIndex = 10;
            this.cmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 475);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.btnTrSad);
            this.Controls.Add(this.btnTrFun);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picDraw);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnStudy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnTrFun;
        private System.Windows.Forms.Button btnTrSad;
        private System.Windows.Forms.ComboBox cmb;
    }
}

