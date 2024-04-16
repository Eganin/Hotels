using System;
using System.Diagnostics.CodeAnalysis;

namespace Hotels
{
    public class Client : IEquatable<Client>
    {
        public int vKey { set; get; }
        public string FIO { set; get; }
        public string PassportNumber { set; get; }
        public string City { set; get; }
        public int Number { set; get; }
        public string ArrivalTime { set; get; }
        public int NightCount { set; get; }

        public bool Equals([AllowNull] Client other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;

            return FIO.Equals(other.FIO) && PassportNumber.Equals(other.PassportNumber)
                && City.Equals(other.City) && Number.Equals(other.Number)
                && ArrivalTime.Equals(other.ArrivalTime) && NightCount.Equals(other.NightCount);
        }

        public override int GetHashCode()
        {
            int hashFIO = FIO.GetHashCode();
            int hashPassportNumber = PassportNumber.GetHashCode();
            int hashCity = City.GetHashCode();
            int hashNumber = Number.GetHashCode();
            int hashArrivalTime = ArrivalTime.GetHashCode();
            int hashNightCount = NightCount.GetHashCode();
            
            return hashFIO ^ hashPassportNumber^hashCity ^hashNumber ^hashArrivalTime^hashNightCount;
        }

        public Client() { }

        public Client(int key,string fio,string passportNumber,string city,int number,string arrivalDate,int nightCount) {
            vKey = key;FIO = fio;PassportNumber = passportNumber;City = city;Number = number;ArrivalTime = arrivalDate;NightCount = nightCount;
        }
    }
}
