using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Program
    {
        class Jarvis
        {
            public long EnergyCapacity { get; set; }
            public Head Head { get; set; }
            public Torso Torso { get; set; }
            public List<Arms> Arms { get; set; }
            public List<Legs> Legs { get; set; }

            public void AddHead(Head headInput)
            {
                if (Head == null || headInput.Energy < Head.Energy)
                    Head = headInput;
            }

            public void AddTorso(Torso torsoInput)
            {
                if (Torso == null || torsoInput.Energy < Torso.Energy)
                    Torso = torsoInput;
            }

            public void AddArms(Arms armsInput)
            {
                if (Arms == null)
                    Arms = new List<Arms>();
                if (Arms.Count < 2)
                    Arms.Add(armsInput);
                else
                {
                    for (int i = 0; i < Arms.Count; i++)
                    {
                        if (Arms[i].Energy > armsInput.Energy)
                        {
                            Arms.RemoveAt(i);
                            Arms.Add(armsInput);
                        }
                    }
                }
            }

            public void AddLegs(Legs legsInput)
            {
                if (Legs == null)
                    Legs = new List<Legs>();
                if (Legs.Count < 2)
                    Legs.Add(legsInput);
                else
                {
                    for (int i = 0; i < Legs.Count; i++)
                    {
                        if (Legs[i].Energy > legsInput.Energy)
                        {
                            Legs.RemoveAt(i);
                            Legs.Add(legsInput);
                        }
                    }
                }
            }

            public override string ToString()
            {
                if (Head == null || Torso == null ||
                    Arms == null || Legs == null ||
                    Arms.Count < 2 || Legs.Count < 2)
                    return "We need more parts!";

                else if (EnergyCapacity -
                    (Head.Energy + Torso.Energy +
                    Arms.Select(a => a.Energy).Sum() +
                    Legs.Select(a => a.Energy).Sum()) < 0)
                    return "We need more power!";

                else
                {
                    StringBuilder output = new StringBuilder();
                    output.Append("Jarvis:\r\n");
                    output.Append(Head.ToString());
                    output.Append(Torso.ToString());
                    foreach (var arm in Arms.OrderBy(a => a.Energy))
                    {
                        output.Append(arm.ToString());
                    }
                    foreach (var leg in Legs.OrderBy(a => a.Energy))
                    {
                        output.Append(leg.ToString());
                    }
                    return output.ToString();
                }
            }
        }
        class Head
        {
            public int Energy { get; set; }
            public int Iq { get; set; }
            public string Material { get; set; }

            public override string ToString()
            {
                var output = String.Empty;
                output += "#Head:\r\n";
                output += $"###Energy consumption: {Energy}\r\n";
                output += $"###IQ: {Iq}\r\n";
                output += $"###Skin material: {Material}\r\n";

                return output;
            }
        }
        class Torso
        {
            public int Energy { get; set; }
            public double Processor { get; set; }
            public string Material { get; set; }

            public override string ToString()
            {
                var output = String.Empty;
                output += "#Torso:\r\n";
                output += $"###Energy consumption: {Energy}\r\n";
                output += $"###Processor size: {Processor:F1}\r\n";
                output += $"###Corpus material: {Material}\r\n";

                return output;
            }
        }
        class Arms
        {
            public long Energy { get; set; }
            public int Reach { get; set; }
            public int Fingers { get; set; }

            public override string ToString()
            {
                var output = String.Empty;
                output += "#Arm:\r\n";
                output += $"###Energy consumption: {Energy}\r\n";
                output += $"###Reach: {Reach}\r\n";
                output += $"###Fingers: {Fingers}\r\n";

                return output;
            }
        }
        class Legs
        {
            public long Energy { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }

            public override string ToString()
            {
                var output = String.Empty;
                output += "#Leg:\r\n";
                output += $"###Energy consumption: {Energy}\r\n";
                output += $"###Strength: {Strength}\r\n";
                output += $"###Speed: {Speed}\r\n";

                return output;
            }
        }

        static void Main(string[] args)
        {
            var energyCapacity = long.Parse(Console.ReadLine());

            var classJarvis = new Jarvis();
            classJarvis.EnergyCapacity = energyCapacity;

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Assemble!") break;

                var component = input[0];
                var energyConsuption = int.Parse(input[1]);
                var property1 = input[2];
                var property2 = input[3];

                switch (component)
                {
                    case "Head":
                        var classHead = new Head()
                        {
                            Energy = energyConsuption,
                            Iq = int.Parse(property1),
                            Material = property2
                        };

                        classJarvis.AddHead(classHead);
                        break;
                    case "Torso":
                        var classTorso = new Torso()
                        {
                            Energy = energyConsuption,
                            Processor = double.Parse(property1),
                            Material = property2
                        };

                        classJarvis.AddTorso(classTorso);
                        break;
                    case "Arm":
                        var classArms = new Arms()
                        {
                            Energy = energyConsuption,
                            Reach = int.Parse(property1),
                            Fingers = int.Parse(property2)
                        };

                        classJarvis.AddArms(classArms);
                        break;
                    case "Leg":
                        var classLegs = new Legs()
                        {
                            Energy = energyConsuption,
                            Strength = int.Parse(property1),
                            Speed = int.Parse(property2)
                        };

                        classJarvis.AddLegs(classLegs);
                        break;
                    default: break;
                }
            }
            Console.WriteLine(classJarvis.ToString());
        }
    }
}