using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hotels
{
    public class Hotel: IEquatable<Hotel>
    {
        public int Number { set; get; }
        public int Floor { set; get; }
        public int typeNumber { set; get; }
        public int Cost { set; get; }
        public List<Client> Clients { set; get; }
        public List<Worker> Workers { set; get; }

        public bool Equals([AllowNull] Hotel other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;

            return Number.Equals(other.Number) && Floor.Equals(other.Floor)
                && typeNumber.Equals(other.typeNumber) && Cost.Equals(other.Cost)
                && Clients.Equals(other.Clients) && Workers.Equals(other.Workers);
        }

        public override int GetHashCode()
        {
            int hashNumber = Number.GetHashCode();
            int hashFloor = Number.GetHashCode();
            int hashTypeNumber = Number.GetHashCode();
            int hashCost = Number.GetHashCode();
            int hashClients = Number.GetHashCode();
            int hashWorkers = Number.GetHashCode();
            return hashNumber^hashFloor^hashTypeNumber^hashCost^hashClients^hashWorkers;
        }

        public Hotel() { }

        public Hotel(int number,int floor,int typeNumberP,int cost,List<Client> clients,List<Worker> workers) {
            Number = number; Floor = floor; typeNumber = typeNumberP; Cost = cost; Clients = clients; Workers = workers;
        }
    }
}
