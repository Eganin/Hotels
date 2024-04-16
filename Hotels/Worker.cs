using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hotels
{
    public class Worker : IEquatable<Worker>
    {
        public int vKey { set; get; }
        public string FIO { set; get; }
        public List<int> Floors { set; get; }
        public List<int> DaysOfWeek { set; get; }

        public bool Equals([AllowNull] Worker other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;

            return FIO.Equals(other.FIO) && Floors.Equals(other.Floors) && DaysOfWeek.Equals(other.DaysOfWeek);
        }

        public override int GetHashCode()
        {
            int hashFIO = FIO.GetHashCode();
            int hashFloors = Floors.GetHashCode();
            int hashDaysOfWeek = Floors.GetHashCode();
            return hashFIO ^ hashFloors ^ hashDaysOfWeek;
        }

        public Worker() { }

        public Worker(int key, string fio,List<int> floors,List<int> daysOfWeek) {
            vKey = key;FIO = fio;Floors = floors;DaysOfWeek = daysOfWeek;
        }
    }
}
