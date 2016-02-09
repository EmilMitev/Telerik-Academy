// 100/100
namespace UnitsOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class StartUp
    {
        private static OrderedBag<Unit> units = new OrderedBag<Unit>();

        private static Dictionary<string, SortedSet<Unit>> unitsByType = new Dictionary<string, SortedSet<Unit>>();

        private static Dictionary<string, Unit> unitsNames = new Dictionary<string, Unit>();


        public class Unit : IComparable<Unit>
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public int Attack { get; set; }

            public override string ToString()
            {
                return string.Format("{0}[{1}]({2})", Name, Type, Attack);
            }

            public override bool Equals(object obj)
            {
                var other = obj as Unit;
                if (other == null)
                {
                    return false;
                }

                return this.Name.Equals(other.Name);
            }

            public override int GetHashCode()
            {
                return 23 + this.Name.GetHashCode() >> 17 ^
                       (23 + this.Type.GetHashCode() >> 17 ^
                        (23 + this.Attack.GetHashCode() >> 17));
            }

            public int CompareTo(Unit other)
            {
                var unitCompareResult = other.Attack.CompareTo(this.Attack);
                if (unitCompareResult == 0)
                {
                    var namesCompareResult = this.Name.CompareTo(other.Name);

                    return namesCompareResult;
                }
                else
                {
                    return unitCompareResult;
                }
            }
        }

        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                switch (input[0])
                {
                    case "add":
                        var name = input[1];
                        var type = input[2];
                        var attack = int.Parse(input[3]);

                        if (unitsNames.ContainsKey(name))
                        {
                            Console.WriteLine("FAIL: {0} already exists!", name);
                        }
                        else
                        {
                            var unit = new Unit
                            {
                                Name = name,
                                Type = type,
                                Attack = attack
                            };

                            if (!unitsByType.ContainsKey(type))
                            {
                                unitsByType[type] = new SortedSet<Unit>();
                            }

                            units.Add(unit);
                            unitsByType[type].Add(unit);
                            unitsNames[name] = unit;

                            Console.WriteLine("SUCCESS: {0} added!", name);
                        }

                        break;
                    case "remove":
                        var nameToRemove = input[1];

                        if (unitsNames.ContainsKey(nameToRemove))
                        {
                            var itemToRemove = unitsNames[nameToRemove];

                            units.Remove(itemToRemove);
                            unitsNames.Remove(itemToRemove.Name);
                            unitsByType[itemToRemove.Type].Remove(itemToRemove);

                            Console.WriteLine("SUCCESS: {0} removed!", itemToRemove.Name);
                        }
                        else
                        {
                            Console.WriteLine("FAIL: {0} could not be found!", nameToRemove);
                        }

                        break;
                    case "find":
                        var findType = input[1];

                        if (!unitsByType.ContainsKey(findType))
                        {
                            Console.WriteLine("RESULT: ");
                        }

                        else
                        {
                            var findResult = unitsByType[findType].Take(10);

                            Console.WriteLine("RESULT: {0}", string.Join(", ", findResult));
                        }

                        break;
                    case "power":
                        var number = int.Parse(input[1]);

                        var findResultByPower = units.Take(number);

                        if (findResultByPower == null)
                        {
                            Console.WriteLine("RESULT: ");
                        }
                        else
                        {
                            Console.WriteLine("RESULT: {0}", string.Join(", ", findResultByPower));
                        }

                        break;
                    case "end":
                        return;
                    default:
                        throw new ArgumentException("The command was not found!");
                }
            }
        }
    }
}