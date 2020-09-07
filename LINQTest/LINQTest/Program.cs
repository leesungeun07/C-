using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTest
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고헌정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하동훈", Height=171}
            };
            Console.WriteLine("### 무식 ###");
            List<Profile> profiles = new List<Profile>();
            foreach (Profile profile in arrProfile)
            {
                if (profile.Height < 175)
                    profiles.Add(profile);
            }
            profiles.Sort((profile1, profile2) => { return profile1.Height - profile2.Height; });
            foreach (var profile in profiles)
                Console.WriteLine("{0}, {1}", profile.Name, profile.Height);

            Console.WriteLine("### 똑똑 ###");
            var profiles2 = from profile in arrProfile
                            where profile.Height < 175
                            orderby profile.Height
                            select profile;
            foreach (var profile in profiles2)
                Console.WriteLine("{0}, {1}", profile.Name, profile.Height);
        }
    }
}
