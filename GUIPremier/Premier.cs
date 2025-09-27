using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIPremier
{
    public class Premier
    {
        public string Name { get; set; }
        public string Life { get; set; }
        public string Term { get; set; }
        public string ImageFile { get; set; }

        public Premier(string name, string life, string term, string imageFile)
        {
            Name = name;
            Life = life;
            Term = term;
            ImageFile = imageFile;
        }

        public override string ToString()
        {
            return Name;
        }

        // Returns the last name in lowercase (used as dictionary key)
        public string GenerateKey()
        {
            string[] parts = Name.Split(' ');
            return parts[parts.Length - 1];
        }

        // Returns the full list of premiers
        public static List<Premier> GetPremiers()
        {
            return new List<Premier>
            {
                new Premier("Doug Ford", "1964 -", "2018 - Present", "ford.jpg"),
                new Premier("Kathleen Wynne", "1953 -", "2013 - 2018", "wynne.jpg"),
                new Premier("Dalton McGuinty", "1955 -", "2003 - 2013", "mcguinty.jpg"),
                new Premier("Ernie Eves", "1946 -", "2002 - 2003", "eves.jpg"),
                new Premier("Mike Harris", "1945 -", "1995 - 2002", "harris.jpg"),
                new Premier("Bob Rae", "1948 -", "1990 - 1995", "rae.jpg"),
                new Premier("David Peterson", "1943 -", "1985 - 1990", "peterson.jpg"),
                new Premier("Frank Miller", "1927 - 2000", "1985", "miller.jpg"),
                new Premier("Bill Davis", "1929 - 2021", "1971 - 1985", "davis.jpg"),
                new Premier("John Robarts", "1917 - 1982", "1961 - 1971", "robarts.jpg"),
                new Premier("Leslie Frost", "1895 - 1973", "1949 - 1961", "frost.jpg"),
                new Premier("George Drew", "1894 - 1973", "1943 - 1948", "drew.jpg"),
                new Premier("Harry Nixon", "1891 - 1961", "1943", "nixon.jpg"),
                new Premier("Gordon Daniel Conant", "1885 - 1953", "1942 - 1943", "conant.jpg"),
                new Premier("Mitchell Hepburn", "1896 - 1953", "1934 - 1942", "hepburn.jpg"),
                new Premier("George Stewart Henry", "1871 - 1958", "1930 - 1934", "henry.jpg"),
                new Premier("Howard Ferguson", "1870 - 1946", "1923 - 1930", "ferguson.jpg"),
                new Premier("Ernest Drury", "1878 - 1968", "1919 - 1923", "drury.jpg"),
                new Premier("William Hearst", "1864 - 1941", "1914 - 1919", "hearst.jpg"),
                new Premier("James Whitney", "1843 - 1914", "1905 - 1914", "whitney.jpg"),
                new Premier("George William Ross", "1841 - 1914", "1899 - 1905", "ross.jpg"),
                new Premier("Arthur Hardy", "1837 - 1901", "1896 - 1899", "hardy.jpg"),
                new Premier("Oliver Mowat", "1820 - 1903", "1872 - 1896", "mowat.jpg"),
                new Premier("Edward Blake", "1833 - 1912", "1871 - 1872", "blake.jpg"),
                new Premier("John Sandfield Macdonald", "1812 - 1872", "1867 - 1871", "macdonald.jpg"),
                new Premier("Thomas Laird Kennedy", "1878 - 1959", "1948 - 1949", "kennedy.jpg")
            };
        }
    }
}