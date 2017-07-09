using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            var junkMaterials = new SortedDictionary<string, int>();

            bool notEnoughMaterial = true;
            while (notEnoughMaterial)
            {
                var input = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1];

                    if (material != "shards" && material != "fragments" && material != "motes")
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }

                        junkMaterials[material] += quantity;
                    }

                    if (material == "shards" || material == "fragments" || material == "motes")
                        keyMaterials[material] += quantity;

                    if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                    {
                        notEnoughMaterial = false;
                        break;
                    }
                }
            }
            if (keyMaterials["shards"] >= 250)
            {
                keyMaterials["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                keyMaterials["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            else if (keyMaterials["motes"] >= 250)
            {
                keyMaterials["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }

            var keyMaterialsOutput = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var materials in keyMaterialsOutput)
            {

                Console.WriteLine($"{materials.Key}: {materials.Value}");
            }

            foreach (var materials in junkMaterials)
            {

                Console.WriteLine($"{materials.Key}: {materials.Value}");
            }
        }
    }
}
