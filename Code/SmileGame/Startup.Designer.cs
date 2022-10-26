
namespace SmileGame
{
    partial class Startup
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
            this.imgResult = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.answerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // imgResult
            // 
            this.imgResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgResult.Location = new System.Drawing.Point(12, 50);
            this.imgResult.Name = "imgResult";
            this.imgResult.Size = new System.Drawing.Size(776, 388);
            this.imgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResult.TabIndex = 0;
            this.imgResult.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.Location = new System.Drawing.Point(694, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 29);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(75, 14);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(125, 27);
            this.txtAnswer.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 17);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Answer";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(206, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 29);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.CheckAnswer_Click);
            // 
            // answerTimer
            // 
            this.answerTimer.Interval = 1000;
            this.answerTimer.Tick += new System.EventHandler(this.AnswerTimer_Tick);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.imgResult);
            this.Name = "Startup";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgResult;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Timer answerTimer;
    }
}

