using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleLinq
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
                new Profile() {Name = "정우성", Height=186},
                new Profile() {Name = "김태희", Height=158},
                new Profile() {Name = "고현정", Height=172},
                new Profile() {Name = "이문세", Height=178},
                new Profile() {Name = "하하", Height=171},
            };

            var profiles = from p in arrProfile
                           where p.Height < 175
                           orderby p.Name
                           select new
                           {
                               Name = p.Name,
                               InchHeight = p.Height * 0.393
                           };
            
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}
