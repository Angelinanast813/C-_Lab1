using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Lab01
{
    public class ModelFunc : DatePicker
    {
        DateTime today = DateTime.Today;
    //    int age = today.Year - birthdate.Year;
        public int Age(DateTime birthdate)
        {
        //    var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (today < birthdate | age > 135)
            {
                MessageBox.Show("You entered invalid date!");
            }

            if(today == birthdate)
            {
                MessageBox.Show("You entered invalid date!");

            }

            if ((today.Day == birthdate.Day) & (today.Year>birthdate.Year))
            {
                MessageBox.Show("Happy Birthday!");

            }

           
               
            return age;
        }

        public  string EastZodiac(DateTime birthdate)
        {
            var age = today.Year - birthdate.Year;
            if (today < birthdate | age > 135)
            {
                return "You entered invalid date!";
            }
                
             if ((birthdate.Month >= 01 & birthdate.Month < 03) & (birthdate.Day > 20 | birthdate.Day <= 16))
             {
                return "You are a capricorn!";
             }
             else if ((birthdate.Month >= 02 & birthdate.Month < 04) & (birthdate.Day > 16 | birthdate.Day < 11))
             {
                 return "You are an Aquarius!";

             } else if ((birthdate.Month >= 03 & birthdate.Month < 05) & (birthdate.Day > 11 | birthdate.Day < 18))
             {
                 return "You are the Fishes!";
             } else if ((birthdate.Month >= 04 & birthdate.Month < 06) & (birthdate.Day > 18 | birthdate.Day < 13))
             {
                 return "You are an Aries!";

             } else if((birthdate.Month >= 05 & birthdate.Month < 07) & (birthdate.Day > 13 | birthdate.Day < 21))
             {
                 return "You are a Taurus!";
             } else if ((birthdate.Month >= 06 & birthdate.Month < 08) & (birthdate.Day > 21 | birthdate.Day < 20))
             {
                 return "You are Gemini!";
             } else if((birthdate.Month >= 07 & birthdate.Month < 09) & (birthdate.Day > 20 | birthdate.Day < 10))
             {
                 return "You are a Crayfish!";
             } else if((birthdate.Month >= 08 & birthdate.Month < 10) & (birthdate.Day > 10 | birthdate.Day < 16))
             {
                 return "You are a Lion!";
             } else if((birthdate.Month >= 09 & birthdate.Month < 11) & (birthdate.Day > 16 | birthdate.Day < 30))
             {
                 return "You are a Virgo!";
             } else if((birthdate.Month >= 10 & birthdate.Month < 12) & (birthdate.Day > 30 | birthdate.Day < 23))
             {
                 return "You are a Libra!";
             } else if ((birthdate.Month == 11 & birthdate.Month < 12) & (birthdate.Day > 23 & birthdate.Day < 29))
             {
                 return "You are a Scorpio!";
             } else if ((birthdate.Month >= 11 & birthdate.Month <= 12) & (birthdate.Day > 29 | birthdate.Day < 17))
             {
                 return "You are an Ophiuchus";
             } else if((birthdate.Month >= 12 ) & (birthdate.Day > 17 | birthdate.Day < 20))
             {
                 return "You are a Sagittarius!";
             }
             return "";
             
            
        }


        public string Chinese(DateTime birthdate)
        {
            int[] rat = new int[8] {2008, 1996, 1984, 1972, 1960, 1948, 1936, 1924 };
            int[] bull = new int[8] { 2009, 1997, 1985, 1973, 1961, 1949, 1937, 1925 };
            int[] tiger = new int[8] { 2010, 1998, 1986, 1974, 1962, 1950, 1938, 1926 };
            int[] rabbit = new int[8] { 2011, 1999, 1987, 1975, 1963, 1951, 1939, 1927 };
            int[] dragon = new int[8] { 2012, 2000, 1988, 1976, 1964, 1952, 1940, 1928 };
            int[] snake = new int[8] { 2013, 2001, 1989, 1977, 1965, 1953, 1941, 1929 };
            int[] hourse = new int[8] { 2014, 2002, 1990, 1978, 1966, 1954, 1942, 1930 };
            int[] got = new int[8] { 2015, 2003, 1991, 1979, 1967, 1955, 1943, 1931 };
            int[] monkey = new int[8] { 2016, 2004, 1992, 1980, 1968, 1956, 1944, 1932 };
            int[] cock = new int[8] { 2017, 2005, 1993, 1981, 1969, 1957, 1945, 1933 };
            int[] dog = new int[8] { 2018, 2006, 1994, 1982, 1970, 1958, 1946, 1934 };
            int[] pig = new int[8] { 2019, 2007, 1995, 1983, 1971, 1959, 1947, 1935 };


            var age = today.Year - birthdate.Year;
            if (today < birthdate | age > 135)
            {
                return "You entered invalid date!";
            }

            for (int i=0; i<8; i++)
            {
                if(birthdate.Year == rat[i])
                {
                    return "You are rat!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == bull[i])
                {
                    return "You are a bull!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == tiger[i])
                {
                    return "You are tiger!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == rabbit[i])
                {
                    return "You are rabbit!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == dragon[i])
                {
                    return "You are dragon!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == snake[i])
                {
                    return "You are snake!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == hourse[i])
                {
                    return "You are hourse!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == got[i])
                {
                    return "You are got!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == monkey[i])
                {
                    return "You are monkey!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == cock[i])
                {
                    return "You are cock!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == dog[i])
                {
                    return "You are dog!";
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (birthdate.Year == pig[i])
                {
                    return "You are pig!";
                }
            }



            return "You entered invalid date!"; 
        }

        }
    }

