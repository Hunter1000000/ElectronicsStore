﻿
namespace ElectronicsStore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            home();
        }
        
        public void home()
        {
            Label max_price = new Label();
            

            Label min_price = new Label();
            min_price.Size = new Size(50, 50);
            min_price.Location = new Point(0, 175);
            min_price.Text = "0";
            min_price.Font = new Font("Microsoft Sans Serif", 15);

            TrackBar price = new TrackBar();
            price.Size = new Size(300, 75);
            price.Location = new Point(0, 225);
            price.TickFrequency = 100;
            price.Value = 10;

            Label name = new Label();
            name.Text = "Electronics Store";
            name.Font = new Font("Microsoft Sans Serif", 20);
            name.Size = new Size(300, 65);
            name.Location = new Point(0, 10);

            Button item1 = new Button();
            item1.Text = "Ноутбуки и компьютеры";
            item1.Location = new Point(0, 75);
            item1.Size = new Size(150, 75);
            item1.Font = new Font("Microsoft Sans Serif", 15);

            Button item2 = new Button();
            item2.Text = "Смартфоны и планшеты";
            item2.Location = new Point(150, 75);
            item2.Size = new Size(150, 75);
            item2.Font = new Font("Microsoft Sans Serif", 15);

            Button item3 = new Button();
            item3.Text = "ТВ";
            item3.Location = new Point(300, 75);
            item3.Size = new Size(150, 75);
            item3.Font = new Font("Microsoft Sans Serif", 15);

            Button item4 = new Button();
            item4.Text = "Комплектующие";
            item4.Location = new Point(450, 75);
            item4.Size = new Size(150, 75);
            item4.Font = new Font("Microsoft Sans Serif", 12);

            Button item5 = new Button();
            item5.Text = "Оргтехника";
            item5.Location = new Point(600, 75);
            item5.Size = new Size(150, 75);
            item5.Font = new Font("Microsoft Sans Serif", 15);

            Button item6 = new Button();
            item6.Text = "Товары для геймеров";
            item6.Location = new Point(750, 75);
            item6.Size = new Size(150, 75);
            item6.Font = new Font("Microsoft Sans Serif", 15);

            Button item7 = new Button();
            item7.Text = "Сетевое оборудование";
            item7.Location = new Point(900, 75);
            item7.Size = new Size(150, 75);
            item7.Font = new Font("Microsoft Sans Serif", 15);

            Button item8 = new Button();
            item8.Text = "Серверное оборудование";
            item8.Location = new Point(1050, 75);
            item8.Size = new Size(150, 75);
            item8.Font = new Font("Microsoft Sans Serif", 15);

            Button item9 = new Button();
            item9.Text = "Графические планшеты";
            item9.Location = new Point(1200, 75);
            item9.Size = new Size(150, 75);
            item9.Font = new Font("Microsoft Sans Serif", 15);

            Button item10 = new Button();
            item10.Text = "Интерактивное оборудование";
            item10.Location = new Point(1350, 75);
            item10.Size = new Size(150, 75);
            item10.Font = new Font("Microsoft Sans Serif", 13);

            Button home_ = new Button();
            home_.Location = new Point(1525, 0);
            home_.Size = new Size(75, 75);
            home_.Click += Home__Click;

            TextBox in_ = new TextBox();
            in_.Location = new Point(600, 10);
            in_.Size = new Size(400, 100);
            in_.Font = new Font("Microsoft Sans Serif", 25);

            Controls.Add(min_price);
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(item1);
            Controls.Add(item2);
            Controls.Add(item3);
            Controls.Add(item4);
            Controls.Add(item5);
            Controls.Add(item6);
            Controls.Add(item7);
            Controls.Add(item8);
            Controls.Add(item9);
            Controls.Add(item10);
            Controls.Add(home_);
            Controls.Add(in_);
        }
        #endregion
    }
}

