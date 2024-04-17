
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
            tabPage2 = new System.Windows.Forms.TabPage();
            textBoxSevenAnswer = new System.Windows.Forms.TextBox();
            button8 = new System.Windows.Forms.Button();
            textBoxFIO = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            dataGridViewClients = new System.Windows.Forms.DataGridView();
            dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            dataGridViewNumbers = new System.Windows.Forms.DataGridView();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(9, 7);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 137);
            button1.TabIndex = 0;
            button1.Text = " Стоимость места для заданного этажа и номера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(9, 152);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(138, 137);
            button2.TabIndex = 1;
            button2.Text = "Список клиентов, прибывших из заданного города";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(9, 297);
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
            button4.Location = new System.Drawing.Point(9, 442);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(138, 137);
            button4.TabIndex = 3;
            button4.Text = "Сколько в гостинице свободных мест и свободных номеров";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(9, 587);
            button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(138, 137);
            button5.TabIndex = 4;
            button5.Text = "Клиенты, проживающие в одноместных номерах";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(9, 732);
            button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(138, 137);
            button6.TabIndex = 5;
            button6.Text = "Общая сумма, выплаченная всеми клиентами";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(160, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Этаж";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(345, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "Номер";
            label2.Click += label2_Click;
            // 
            // textBoxFloor
            // 
            textBoxFloor.Location = new System.Drawing.Point(160, 62);
            textBoxFloor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new System.Drawing.Size(174, 27);
            textBoxFloor.TabIndex = 9;
            textBoxFloor.TextChanged += textBoxFloor_TextChanged;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new System.Drawing.Point(340, 62);
            textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new System.Drawing.Size(190, 27);
            textBoxNumber.TabIndex = 10;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // textBoxFirstAnswer
            // 
            textBoxFirstAnswer.Location = new System.Drawing.Point(561, 7);
            textBoxFirstAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFirstAnswer.Multiline = true;
            textBoxFirstAnswer.Name = "textBoxFirstAnswer";
            textBoxFirstAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFirstAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxFirstAnswer.TabIndex = 11;
            textBoxFirstAnswer.TextChanged += textBoxFirstAnswer_TextChanged;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new System.Drawing.Point(160, 201);
            textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new System.Drawing.Size(242, 27);
            textBoxCity.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(160, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Город";
            // 
            // textBoxSecondAnswer
            // 
            textBoxSecondAnswer.Location = new System.Drawing.Point(561, 152);
            textBoxSecondAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSecondAnswer.Multiline = true;
            textBoxSecondAnswer.Name = "textBoxSecondAnswer";
            textBoxSecondAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSecondAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxSecondAnswer.TabIndex = 14;
            textBoxSecondAnswer.TextChanged += textBoxSecondAnswer_TextChanged;
            // 
            // textBoxFIO2
            // 
            textBoxFIO2.Location = new System.Drawing.Point(160, 352);
            textBoxFIO2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFIO2.Name = "textBoxFIO2";
            textBoxFIO2.Size = new System.Drawing.Size(242, 27);
            textBoxFIO2.TabIndex = 20;
            textBoxFIO2.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(160, 315);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 19;
            label6.Text = "ФИО Гостя";
            label6.Click += label6_Click;
            // 
            // textBoxDayOfWeek
            // 
            textBoxDayOfWeek.Location = new System.Drawing.Point(416, 352);
            textBoxDayOfWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            textBoxDayOfWeek.Size = new System.Drawing.Size(114, 27);
            textBoxDayOfWeek.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(416, 315);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 20);
            label7.TabIndex = 21;
            label7.Text = "День недели";
            // 
            // textBoxThirdAnswer
            // 
            textBoxThirdAnswer.Location = new System.Drawing.Point(561, 297);
            textBoxThirdAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxThirdAnswer.Multiline = true;
            textBoxThirdAnswer.Name = "textBoxThirdAnswer";
            textBoxThirdAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxThirdAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxThirdAnswer.TabIndex = 23;
            // 
            // textBoxFourAnswer
            // 
            textBoxFourAnswer.Location = new System.Drawing.Point(561, 442);
            textBoxFourAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFourAnswer.Multiline = true;
            textBoxFourAnswer.Name = "textBoxFourAnswer";
            textBoxFourAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFourAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxFourAnswer.TabIndex = 24;
            textBoxFourAnswer.TextChanged += textBoxFourAnswer_TextChanged;
            // 
            // textBoxFiveAnswer
            // 
            textBoxFiveAnswer.Location = new System.Drawing.Point(561, 589);
            textBoxFiveAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFiveAnswer.Multiline = true;
            textBoxFiveAnswer.Name = "textBoxFiveAnswer";
            textBoxFiveAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFiveAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxFiveAnswer.TabIndex = 25;
            // 
            // textBoxSixAnswer
            // 
            textBoxSixAnswer.Location = new System.Drawing.Point(561, 736);
            textBoxSixAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSixAnswer.Multiline = true;
            textBoxSixAnswer.Name = "textBoxSixAnswer";
            textBoxSixAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSixAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxSixAnswer.TabIndex = 26;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxSevenAnswer);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(textBoxFIO);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button7);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(821, 1025);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Работники";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxSevenAnswer
            // 
            textBoxSevenAnswer.Location = new System.Drawing.Point(561, 7);
            textBoxSevenAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxSevenAnswer.Multiline = true;
            textBoxSevenAnswer.Name = "textBoxSevenAnswer";
            textBoxSevenAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxSevenAnswer.Size = new System.Drawing.Size(241, 121);
            textBoxSevenAnswer.TabIndex = 35;
            textBoxSevenAnswer.TextChanged += textBoxSevenAnswer_TextChanged;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(9, 82);
            button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(138, 68);
            button8.TabIndex = 34;
            button8.Text = "Уволить служащего";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new System.Drawing.Point(169, 66);
            textBoxFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new System.Drawing.Size(241, 27);
            textBoxFIO.TabIndex = 33;
            textBoxFIO.TextChanged += textBoxFIO_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(169, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 20);
            label4.TabIndex = 32;
            label4.Text = "Фио служащего";
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(9, 7);
            button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(138, 68);
            button7.TabIndex = 31;
            button7.Text = "Принять на работу служащего";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxFirstAnswer);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxFloor);
            tabPage1.Controls.Add(textBoxSixAnswer);
            tabPage1.Controls.Add(textBoxNumber);
            tabPage1.Controls.Add(textBoxFiveAnswer);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBoxFourAnswer);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBoxThirdAnswer);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBoxDayOfWeek);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(textBoxFIO2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxSecondAnswer);
            tabPage1.Controls.Add(textBoxCity);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(821, 1025);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Администрирование";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(829, 1058);
            tabControl1.TabIndex = 31;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dataGridViewNumbers);
            tabPage3.Controls.Add(dataGridViewWorkers);
            tabPage3.Controls.Add(dataGridViewClients);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(821, 1025);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Все данные";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new System.Drawing.Point(9, 34);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.RowTemplate.Height = 29;
            dataGridViewClients.Size = new System.Drawing.Size(800, 250);
            dataGridViewClients.TabIndex = 0;
            // 
            // dataGridViewWorkers
            // 
            dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkers.Location = new System.Drawing.Point(9, 310);
            dataGridViewWorkers.Name = "dataGridViewWorkers";
            dataGridViewWorkers.RowHeadersWidth = 51;
            dataGridViewWorkers.RowTemplate.Height = 29;
            dataGridViewWorkers.Size = new System.Drawing.Size(800, 250);
            dataGridViewWorkers.TabIndex = 1;
            // 
            // dataGridViewNumbers
            // 
            dataGridViewNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumbers.Location = new System.Drawing.Point(10, 586);
            dataGridViewNumbers.Name = "dataGridViewNumbers";
            dataGridViewNumbers.RowHeadersWidth = 51;
            dataGridViewNumbers.RowTemplate.Height = 29;
            dataGridViewNumbers.Size = new System.Drawing.Size(800, 250);
            dataGridViewNumbers.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 11);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 20);
            label5.TabIndex = 3;
            label5.Text = "Клиенты";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(9, 287);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(91, 20);
            label8.TabIndex = 4;
            label8.Text = "Сотрудники";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(9, 563);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(65, 20);
            label9.TabIndex = 5;
            label9.Text = "Номера";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(825, 902);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Администрирование гостиницы";
            Load += Form1_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxSevenAnswer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewNumbers;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
    }
}

