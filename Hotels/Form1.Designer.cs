
namespace Hotels
{
    partial class Form1
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxFloor = new System.Windows.Forms.TextBox();
            textBoxNumber = new System.Windows.Forms.TextBox();
            textBoxFirstAnswer = new System.Windows.Forms.TextBox();
            textBoxCity = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxSecondAnswer = new System.Windows.Forms.TextBox();
            textBoxFIO2 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBoxDayOfWeek = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            textBoxThirdAnswer = new System.Windows.Forms.TextBox();
            textBoxFourAnswer = new System.Windows.Forms.TextBox();
            textBoxFiveAnswer = new System.Windows.Forms.TextBox();
            textBoxSixAnswer = new System.Windows.Forms.TextBox();
            textBoxFIO = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            button8 = new System.Windows.Forms.Button();
            textBoxSevenAnswer = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 16);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 105);
            button1.TabIndex = 0;
            button1.Text = " Стоимость места для заданного этажа и номера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(14, 129);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(138, 108);
            button2.TabIndex = 1;
            button2.Text = "Список клиентов, прибывших из заданного города";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(14, 245);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(138, 137);
            button3.TabIndex = 2;
            button3.Text = "Кто из служащих убирал номер указанного клиента в заданный день недели. ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(14, 391);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(138, 129);
            button4.TabIndex = 3;
            button4.Text = "Сколько в гостинице свободных мест и свободных номеров";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(14, 528);
            button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(138, 107);
            button5.TabIndex = 4;
            button5.Text = "Клиенты, проживающие в одноместных номерах";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(14, 643);
            button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(138, 109);
            button6.TabIndex = 5;
            button6.Text = "Общая сумма, выплаченная всеми клиентами";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(14, 760);
            button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(138, 57);
            button7.TabIndex = 6;
            button7.Text = "Принять на работу служащего";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(174, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Этаж";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(315, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "Номер";
            label2.Click += label2_Click;
            // 
            // textBoxFloor
            // 
            textBoxFloor.Location = new System.Drawing.Point(174, 55);
            textBoxFloor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new System.Drawing.Size(114, 27);
            textBoxFloor.TabIndex = 9;
            textBoxFloor.TextChanged += textBoxFloor_TextChanged;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new System.Drawing.Point(315, 55);
            textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new System.Drawing.Size(114, 27);
            textBoxNumber.TabIndex = 10;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // textBoxFirstAnswer
            // 
            textBoxFirstAnswer.Location = new System.Drawing.Point(566, 16);
            textBoxFirstAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFirstAnswer.Multiline = true;
            textBoxFirstAnswer.Name = "textBoxFirstAnswer";
            textBoxFirstAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFirstAnswer.Size = new System.Drawing.Size(241, 104);
            textBoxFirstAnswer.TabIndex = 11;
            textBoxFirstAnswer.TextChanged += textBoxFirstAnswer_TextChanged;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new System.Drawing.Point(174, 169);
            textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new System.Drawing.Size(114, 27);
            textBoxCity.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(174, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Город";
            // 
            // textBoxSecondAnswer
            // 
            textBoxSecondAnswer.Location = new System.Drawing.Point(566, 132);
            textBoxSecondAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSecondAnswer.Multiline = true;
            textBoxSecondAnswer.Name = "textBoxSecondAnswer";
            textBoxSecondAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSecondAnswer.Size = new System.Drawing.Size(241, 107);
            textBoxSecondAnswer.TabIndex = 14;
            // 
            // textBoxFIO2
            // 
            textBoxFIO2.Location = new System.Drawing.Point(173, 293);
            textBoxFIO2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFIO2.Name = "textBoxFIO2";
            textBoxFIO2.Size = new System.Drawing.Size(242, 27);
            textBoxFIO2.TabIndex = 20;
            textBoxFIO2.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(173, 256);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 19;
            label6.Text = "ФИО Гостя";
            label6.Click += label6_Click;
            // 
            // textBoxDayOfWeek
            // 
            textBoxDayOfWeek.Location = new System.Drawing.Point(429, 293);
            textBoxDayOfWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            textBoxDayOfWeek.Size = new System.Drawing.Size(114, 27);
            textBoxDayOfWeek.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(429, 256);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 20);
            label7.TabIndex = 21;
            label7.Text = "День недели";
            // 
            // textBoxThirdAnswer
            // 
            textBoxThirdAnswer.Location = new System.Drawing.Point(566, 245);
            textBoxThirdAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxThirdAnswer.Multiline = true;
            textBoxThirdAnswer.Name = "textBoxThirdAnswer";
            textBoxThirdAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxThirdAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxThirdAnswer.TabIndex = 23;
            // 
            // textBoxFourAnswer
            // 
            textBoxFourAnswer.Location = new System.Drawing.Point(566, 391);
            textBoxFourAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFourAnswer.Multiline = true;
            textBoxFourAnswer.Name = "textBoxFourAnswer";
            textBoxFourAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFourAnswer.Size = new System.Drawing.Size(241, 128);
            textBoxFourAnswer.TabIndex = 24;
            textBoxFourAnswer.TextChanged += textBoxFourAnswer_TextChanged;
            // 
            // textBoxFiveAnswer
            // 
            textBoxFiveAnswer.Location = new System.Drawing.Point(566, 530);
            textBoxFiveAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFiveAnswer.Multiline = true;
            textBoxFiveAnswer.Name = "textBoxFiveAnswer";
            textBoxFiveAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFiveAnswer.Size = new System.Drawing.Size(241, 105);
            textBoxFiveAnswer.TabIndex = 25;
            // 
            // textBoxSixAnswer
            // 
            textBoxSixAnswer.Location = new System.Drawing.Point(566, 647);
            textBoxSixAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSixAnswer.Multiline = true;
            textBoxSixAnswer.Name = "textBoxSixAnswer";
            textBoxSixAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSixAnswer.Size = new System.Drawing.Size(241, 105);
            textBoxSixAnswer.TabIndex = 26;
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new System.Drawing.Point(174, 820);
            textBoxFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new System.Drawing.Size(241, 27);
            textBoxFIO.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(174, 783);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(118, 20);
            label8.TabIndex = 27;
            label8.Text = "Фио служащего";
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(14, 825);
            button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(138, 57);
            button8.TabIndex = 29;
            button8.Text = "Уволить служащего";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBoxSevenAnswer
            // 
            textBoxSevenAnswer.Location = new System.Drawing.Point(566, 761);
            textBoxSevenAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSevenAnswer.Multiline = true;
            textBoxSevenAnswer.Name = "textBoxSevenAnswer";
            textBoxSevenAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSevenAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxSevenAnswer.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(825, 897);
            Controls.Add(textBoxSevenAnswer);
            Controls.Add(button8);
            Controls.Add(textBoxFIO);
            Controls.Add(label8);
            Controls.Add(textBoxSixAnswer);
            Controls.Add(textBoxFiveAnswer);
            Controls.Add(textBoxFourAnswer);
            Controls.Add(textBoxThirdAnswer);
            Controls.Add(textBoxDayOfWeek);
            Controls.Add(label7);
            Controls.Add(textBoxFIO2);
            Controls.Add(label6);
            Controls.Add(textBoxSecondAnswer);
            Controls.Add(textBoxCity);
            Controls.Add(label3);
            Controls.Add(textBoxFirstAnswer);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxFloor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Администрирование гостиницы";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFirstAnswer;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSecondAnswer;
        private System.Windows.Forms.TextBox textBoxFIO2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDayOfWeek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxThirdAnswer;
        private System.Windows.Forms.TextBox textBoxFourAnswer;
        private System.Windows.Forms.TextBox textBoxFiveAnswer;
        private System.Windows.Forms.TextBox textBoxSixAnswer;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxSevenAnswer;
    }
}

