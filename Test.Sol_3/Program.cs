using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Test.Sol_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonExampleInput = "[{\"HeadCount\":10,\"ChildList\":[{\"HeadCount\":3,\"ChildList\":[{\"HeadCount\":1,\"ChildList\":[]}]},{\"HeadCount\":2,\"ChildList\":[]}]}]";

            List<OrganizationNode> lsOrganizationNode = JsonConvert.DeserializeObject<List<OrganizationNode>>(jsonExampleInput);
            int sum = 0;
            foreach (OrganizationNode oOrganizationNode in lsOrganizationNode)
            {
                sum += oOrganizationNode.HeadCount;
                foreach (OrganizationNode oSubLv1OrganizationNode in oOrganizationNode.ChildList)
                {
                    sum += oSubLv1OrganizationNode.HeadCount;
                    foreach (OrganizationNode oSubLv2OrganizationNode in oSubLv1OrganizationNode.ChildList)
                    {
                        sum += oSubLv2OrganizationNode.HeadCount;
                    }
                }
            }

            Console.WriteLine($"Summarize HeadCount : { sum }");
        }
    }
}
