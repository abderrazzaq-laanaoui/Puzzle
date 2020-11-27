
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.board.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.board.ColumnCount = 3;
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.board.Controls.Add(this.button8, 1, 1);
            this.board.Controls.Add(this.button7, 0, 2);
            this.board.Controls.Add(this.button6, 0, 0);
            this.board.Controls.Add(this.button5, 2, 2);
            this.board.Controls.Add(this.button4, 1, 1);
            this.board.Controls.Add(this.button3, 2, 0);
            this.board.Controls.Add(this.button2, 1, 0);
            this.board.Controls.Add(this.button1, 0, 0);
            this.board.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.board.Location = new System.Drawing.Point(26, 24);
            this.board.Name = "board";
            this.board.RowCount = 3;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.board.Size = new System.Drawing.Size(400, 396);
            this.board.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bauhaus 93", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(486, 24);
            this.title.Margin = new System.Windows.Forms.Padding(3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(276, 57);
            this.title.TabIndex = 1;
            this.title.Text = "The Puzzle";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Green;
            this.timer.Location = new System.Drawing.Point(566, 104);
            this.timer.Margin = new System.Windows.Forms.Padding(10);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(103, 53);
            this.timer.TabIndex = 2;
            this.timer.Text = "00:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(531, 194);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(181, 47);
            this.button.TabIndex = 3;
            this.button.TabStop = false;
            this.button.Text = "START";
            this.button.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(514, 274);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(218, 133);
            this.panel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 124);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 124);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 124);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(136, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 124);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(269, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 125);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 124);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
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
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(269, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 124);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.title);
            this.Controls.Add(this.board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Puzzle_Load);
            this.board.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

