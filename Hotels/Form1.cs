using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private static string emptyMessage = "Данные не введены";
        static int[] mArray = { 7, 4, 6 };
        static List<Client> clients = new List<Client>();
        static List<Worker> workers = new List<Worker>();
        static List<Hotel> hotels = new List<Hotel>();
        static string[] paths = { "C:\\Users\\zakha\\source\\repos\\Hotels\\Hotels\\clients.txt",
        "C:\\Users\\zakha\\source\\repos\\Hotels\\Hotels\\workers.txt",
        "C:\\Users\\zakha\\source\\repos\\Hotels\\Hotels\\hotel.txt"};


        private void Form1_Load(object sender, EventArgs e)
        {
            File_Load();
        }

        private static void File_Load()
        {
            for (int i = 0; i < paths.Length; i++)
            {
                string path = paths[i];
                int m = mArray[i];
                StreamReader FileIn = new StreamReader(path, Encoding.Default);
                string str;
                while ((str = FileIn.ReadLine()) != null)
                {
                    string[] ms = new string[m];
                    ms = str.Split(';');
                    if (i == 0)
                    {
                        Client client = new Client(Convert.ToInt32(ms[0]), ms[1], ms[2], ms[3], Convert.ToInt32(ms[4]), ms[5], Convert.ToInt32(ms[6]));
                        clients.Add(client);
                    }
                    else if (i == 1)
                    {

                        string[] floorsArray = ms[2].Split(",");
                        List<int> floors = new List<int>();
                        for (int floorIndex = 0; floorIndex < floorsArray.Length; floorIndex++)
                        {
                            floors.Add(Convert.ToInt32(floorsArray[floorIndex]));
                        }

                        string[] daysOfWeekArray = ms[3].Split(",");
                        List<int> daysOfWeek = new List<int>();
                        for (int dayIndex = 0; dayIndex < daysOfWeekArray.Length; dayIndex++)
                        {
                            daysOfWeek.Add(Convert.ToInt32(daysOfWeekArray[dayIndex]));
                        }

                        Worker worker = new Worker(Convert.ToInt32(ms[0]), ms[1], floors, daysOfWeek);
                        workers.Add(worker);
                    }
                    else
                    {
                        string[] clientsArray = ms[4].Split(",");
                        List<Client> hotelClients = new List<Client>();
                        foreach (Client client in clients)
                        {

                            if (clientsArray.Contains(client.vKey.ToString()))
                            {
                                hotelClients.Add(client);
                            }
                        }

                        string[] workersArray = ms[5].Split(",");
                        List<Worker> hotelWorkers = new List<Worker>();
                        foreach (Worker worker in workers)
                        {

                            if (workersArray.Contains(worker.vKey.ToString()))
                            {
                                hotelWorkers.Add(worker);
                            }
                        }

                        Hotel hotel = new Hotel(Convert.ToInt32(ms[0]), Convert.ToInt32(ms[1]), Convert.ToInt32(ms[2]), Convert.ToInt32(ms[3]), hotelClients, hotelWorkers);
                        hotels.Add(hotel);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFloor.Text) && !string.IsNullOrEmpty(textBoxNumber.Text))
            {
                int floor = Convert.ToInt32(textBoxFloor.Text);
                int number = Convert.ToInt32(textBoxNumber.Text);
                var hotelCost = hotels.Where(hotelInfo => hotelInfo.Floor == floor && hotelInfo.Number == number);
                var costs = hotelCost.Select(hotel => hotel.Cost);

                if (costs.Count() != 0)
                {
                    foreach (int cost in costs)
                    {
                        textBoxFirstAnswer.Text = $"Стоимость {cost} рублей";
                    }
                }
                else
                {
                    textBoxFirstAnswer.Text = "Такой номер отсутсвует";
                }
            }
            else
            {
                textBoxFirstAnswer.Text = emptyMessage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxSecondAnswer.Text = "";
            if (!string.IsNullOrEmpty(textBoxCity.Text))
            {
                string cityName = textBoxCity.Text;
                var clientsFromCity = clients.Where(clientInfo => clientInfo.City == cityName).Select(client => client.FIO);
                if (clientsFromCity.Count() != 0)
                {
                    foreach (string clientFIO in clientsFromCity)
                    {
                        textBoxSecondAnswer.Text += $"{clientFIO} {Environment.NewLine}";
                    }
                }
                else
                {
                    textBoxSecondAnswer.Text = "Таких гостей нету";
                }
            }
            else
            {
                textBoxSecondAnswer.Text = emptyMessage;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxThirdAnswer.Text = "";
            if (!string.IsNullOrEmpty(textBoxFIO2.Text) && !string.IsNullOrEmpty(textBoxDayOfWeek.Text))
            {
                string fio = textBoxFIO2.Text;
                int dayOfWeek = Convert.ToInt32(textBoxDayOfWeek.Text);
                var newHotel = hotels.Where(hotelInfo => hotelInfo.Clients.Where(client => client.FIO == fio).Count() != 0
                && hotelInfo.Workers.Where(worker => worker.DaysOfWeek.Contains(dayOfWeek)).Count() != 0);
                var newWorkers = newHotel.SelectMany(hotel => hotel.Workers);
                if (newWorkers.Count() != 0)
                {
                    foreach (Worker worker in newWorkers)
                    {
                        textBoxThirdAnswer.Text += $"{worker.FIO}" + Environment.NewLine;
                    }
                }
                else
                {
                    textBoxThirdAnswer.Text = "Таких работников нету" + Environment.NewLine;
                }
            }
            else
            {
                textBoxThirdAnswer.Text = emptyMessage;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxFourAnswer.Text = "";
            var emptyNumbers = hotels.Where(hotelInfo => hotelInfo.Clients.Count == 0).Count();
            var emptyPlaces = hotels.Where(hotelInfo => hotelInfo.Clients.Count != hotelInfo.typeNumber).Count();

            textBoxFourAnswer.Text += $"Количество пустых номеров {emptyNumbers}" + Environment.NewLine;
            textBoxFourAnswer.Text += $"Количество пустых мест в отеле {emptyPlaces}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxFiveAnswer.Text = "";
            var clientInOnePlaceHotel = hotels.Where(hotelInfo => hotelInfo.typeNumber == 1).SelectMany(hotel => hotel.Clients);
            if (clientInOnePlaceHotel.Count() != 0)
            {
                foreach (Client client in clientInOnePlaceHotel)
                {
                    textBoxFiveAnswer.Text = client.FIO + Environment.NewLine;
                }
            }
            else
            {
                textBoxFiveAnswer.Text = "Таких гостей нету";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxSixAnswer.Text = "";
            int totalSum = 0;
            var summary = hotels.Where(hotelInfo => hotelInfo.Clients.Count != 0)
                .Select(hotelInfo => hotelInfo.Clients.Sum(client => client.NightCount) * hotelInfo.Cost);
            foreach (int sum in summary)
            {
                totalSum += sum;
            }
            textBoxSixAnswer.Text = $"Общая выплаченная сумма {totalSum} рублей";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxSevenAnswer.Text = "";
            if (!string.IsNullOrEmpty(textBoxFIO.Text))
            {
                string fio = textBoxFIO.Text;

                if (workers.Count(worker => worker.FIO == fio) != 0)
                {
                    textBoxSevenAnswer.Text = "Работник уже добавлен" + Environment.NewLine;
                    Print_Workers();
                }
                else
                {
                    int maxKey = workers.Select(workerInfo => workerInfo.vKey).Max() + 1;
                    workers.Add(new Worker(maxKey, fio, new List<int>(), new List<int>()));
                    Print_Workers();
                }
            }
            else
            {
                textBoxSevenAnswer.Text = emptyMessage;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxSevenAnswer.Text = "";
            if (!string.IsNullOrEmpty(textBoxFIO.Text))
            {
                string fio = textBoxFIO.Text;
                workers.RemoveAll(worker => worker.FIO == fio);
                Print_Workers();
            }
            else
            {
                textBoxSevenAnswer.Text = emptyMessage;
            }
        }

        private void Print_Workers()
        {
            textBoxSevenAnswer.Text = "Список работников" + Environment.NewLine;
            foreach (Worker worker in workers)
            {
                textBoxSevenAnswer.Text += $"{worker.FIO}" + Environment.NewLine;
            }
        }

        private void textBoxFourAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
