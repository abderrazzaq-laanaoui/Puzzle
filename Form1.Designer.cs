
namespace Puzzle
{
    partial class Puzzle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.modeE = new System.Windows.Forms.RadioButton();
            this.modeM = new System.Windows.Forms.RadioButton();
            this.modeH = new System.Windows.Forms.RadioButton();
            this.modes = new System.Windows.Forms.GroupBox();
            this.board.SuspendLayout();
            this.modes.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.board.ColumnCount = 3;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.board.Controls.Add(this.button1, 0, 0);
            this.board.Controls.Add(this.button4, 0, 1);
            this.board.Controls.Add(this.button7, 0, 2);
            this.board.Controls.Add(this.button2, 1, 0);
            this.board.Controls.Add(this.button5, 1, 1);
            this.board.Controls.Add(this.button8, 1, 2);
            this.board.Controls.Add(this.button3, 2, 0);
            this.board.Controls.Add(this.button6, 2, 1);
            this.board.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.board.Location = new System.Drawing.Point(34, 24);
            this.board.Name = "board";
            this.board.RowCount = 3;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.Size = new System.Drawing.Size(400, 396);
            this.board.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 124);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 124);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(4, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 125);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 124);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(136, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 124);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(136, 266);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 125);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(269, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 124);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(269, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 124);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bauhaus 93", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(486, 21);
            this.title.Margin = new System.Windows.Forms.Padding(3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(276, 57);
            this.title.TabIndex = 1;
            this.title.Text = "The Puzzle";
            // 
            // clock
            // 
            this.clock.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.clock.AutoSize = true;
            this.clock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clock.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.Color.Green;
            this.clock.Location = new System.Drawing.Point(536, 91);
            this.clock.Margin = new System.Windows.Forms.Padding(10);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(163, 81);
            this.clock.TabIndex = 2;
            this.clock.Text = "00:00";
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(527, 320);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(181, 47);
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Text = "START GAME";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(527, 373);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(181, 47);
            this.end.TabIndex = 4;
            this.end.TabStop = false;
            this.end.Text = "END GAME";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // modeE
            // 
            this.modeE.AutoSize = true;
            this.modeE.Location = new System.Drawing.Point(19, 27);
            this.modeE.Name = "modeE";
            this.modeE.Size = new System.Drawing.Size(81, 29);
            this.modeE.TabIndex = 8;
            this.modeE.Text = "Easy";
            this.modeE.UseVisualStyleBackColor = true;
            // 
            // modeM
            // 
            this.modeM.AutoSize = true;
            this.modeM.Checked = true;
            this.modeM.Location = new System.Drawing.Point(19, 53);
            this.modeM.Name = "modeM";
            this.modeM.Size = new System.Drawing.Size(109, 29);
            this.modeM.TabIndex = 9;
            this.modeM.TabStop = true;
            this.modeM.Text = "Medium";
            this.modeM.UseVisualStyleBackColor = true;
            // 
            // modeH
            // 
            this.modeH.AutoSize = true;
            this.modeH.Location = new System.Drawing.Point(19, 78);
            this.modeH.Name = "modeH";
            this.modeH.Size = new System.Drawing.Size(79, 29);
            this.modeH.TabIndex = 0;
            this.modeH.Text = "Hard";
            this.modeH.UseVisualStyleBackColor = true;
            // 
            // modes
            // 
            this.modes.Controls.Add(this.modeE);
            this.modes.Controls.Add(this.modeH);
            this.modes.Controls.Add(this.modeM);
            this.modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modes.Location = new System.Drawing.Point(527, 183);
            this.modes.Name = "modes";
            this.modes.Size = new System.Drawing.Size(181, 115);
            this.modes.TabIndex = 0;
            this.modes.TabStop = false;
            this.modes.Text = "Game Mode:";
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.title);
            this.Controls.Add(this.board);
            this.Controls.Add(this.modes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Puzzle_Load);
            this.board.ResumeLayout(false);
            this.modes.ResumeLayout(false);
            this.modes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton modeE;
        private System.Windows.Forms.RadioButton modeM;
        private System.Windows.Forms.RadioButton modeH;
        private System.Windows.Forms.GroupBox modes;
    }
}

