using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RegistrationOnWebSite.Utilities
{
    class NameGenerator
    {
       // public static void CreateName()
      //  {
       //     NewPostPage.GoTo();

        //    PreviousSecondname = CreateSecondname();
        //    PreviousName = CreateName();

        //    NewPostPage.CreateName(PreviousSecondname).WithBody(PreviousName).Publish();
      //  }

        public static string PreviousName { get; set; }

        public static string Secondname { get; set; }

        private static string CreateName()
        {
            return CreateRandomString() + ", name";
        }

        private static string CreateRandomString()
        {
            var s = new StringBuilder();

            var random = new Random();
            var cycles = random.Next(5 + 1);

            for (int i = 0; i < cycles; i++)
            {
                s.Append(Name[random.Next(Name.Length)]);
                s.Append(" ");
                s.Append(Secondname[random.Next(Secondname.Length)]);
                s.Append(" ");
                
            }

            return s.ToString();
        }

        internal string SendKey(string previousName)
        {
            throw new NotImplementedException();
        }

        internal string ToString(string previousSecondname)
        {
            throw new NotImplementedException();
        }

        private static string[] Name = new[]
                                     {
                                         "Jan", "Marek", "Piotr", "Marcin", "Andrzej", "Kajetan", "Paweł", "Krzysztof", "Feliks",
                                         "Roman"
                                     };

        private static string[] Secondame = new[]
                                     {
                                         "Kowalski", "Nowak", "Malinowski", "Karwowski", "Bareja", "Wierzbicki", "Dorociński", "Gruszka"
                                     };
        private IWebDriver driver;

        public NameGenerator(IWebDriver driver)
        {
            this.driver = driver;
        }

        private static string CreateSecondname()
        {
            return CreateRandomString() + ", Secondname";
        }

        public static void Initialize()
        {
            Secondname = null;
          PreviousName = null;
        }

     //   public static void Cleanup()
     //   {
      //      if (CreatedName)
      //          TrashName();
      //  }

       // private static void TrashName()
       // {
        //    ListPostsPage.TrashName(PreviousSecondname);
       //     Initialize();
        //}

        protected static bool CreatedName
        {
            get { return !String.IsNullOrEmpty(Secondname); }
        }
    }
}

