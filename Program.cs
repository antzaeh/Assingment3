using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new DateTime(2001, 11, 11).ToString("yyy/mm/dd"));
            ArrayList concerts = new ArrayList();

            Concert concert1 = (new Concert("Con1", "Venue A", new DateTime(2023, 1, 11), 18.0, 33.0));
            Concert concert2 = (new Concert("Con2", "Venue B", new DateTime(2023, 2, 12), 19.0, 22.0));
            Concert concert3 = (new Concert("Con3", "Venue C", new DateTime(2023, 3, 13), 20.0, 44.0));
            Concert concert4 = (new Concert("Con4", "Venue D", new DateTime(2023, 4, 14), 21.0, 11.0));
            Concert concert5 = (new Concert("Con5", "Venue E", new DateTime(2023, 5, 15), 22.00, 55.0));

            concerts.Add(concert1);
            concerts.Add(concert2);
            concerts.Add(concert3);
            concerts.Add(concert4);
            concerts.Add(concert5);


            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert.ToString());
            }

            Console.WriteLine("Concert1 > Concert2: " + ((Concert) concerts[0] > (Concert)concerts[1]));
            Console.WriteLine("Concert1 > Concert3: " + (concert1 > concert3));
            Console.WriteLine("Concert1 > Concert4: " + (concert1 > concert4));
            Console.WriteLine("Concert1 > Concert5: " + (concert1 > concert5));

            Console.WriteLine("Concert3 < Concert1: " + (concert3 > concert1));
            Console.WriteLine("Concert3 < Concert2: " + (concert3 > concert2));
            Console.WriteLine("Concert3 < Concert4: " + (concert3 > concert4));
            Console.WriteLine("Concert3 < Concert5: " + (concert3 > concert5));

            Console.WriteLine("Consert1 equal to Concert5: " + (concert1 == concert5));
            Console.WriteLine("Consert1 not equal to Concert5: " + (concert1 != concert5));

            Console.WriteLine("Concert 1 price after adding 5: " + concert1++ + "\n");
            Console.WriteLine("Concert 1 price after reducing to original: " + concert1-- + "\n");



            for (int i = 0; i < concerts.Count; i++)
            {
                for (int j = i + 1; j < concerts.Count; j++)
                {

                    if ((Concert)concerts[i] < (Concert)concerts[j])
                    {
                        var temp1 = concerts[i];
                        concerts[i] = concerts[j];
                        concerts[j] = temp1;
                    }
                }
            }

            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert.ToString());
            }
            for (int i = 0; i < concerts.Count; i++)
            {
                for (int j = i + 1; j < concerts.Count; j++)
                {

                    if ((Concert)concerts[i] > (Concert)concerts[j])
                    {
                        var temp1 = concerts[i];
                        concerts[i] = concerts[j];
                        concerts[j] = temp1;
                    }
                }
            }
            Console.WriteLine("-------------------------------------------------------");
            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert.ToString());
            }

                     Console.WriteLine("Are you lazy and want to skip? (y/n)?");
                      string choice = Console.ReadLine().ToLower();
                      if (choice == "n")
                      {
                          Console.WriteLine("Enter the title of the first concert:");
                          string c1 = Console.ReadLine();
                          Console.WriteLine("Enter the title of the second concert:");
                          string c2 = Console.ReadLine();
                          Concert selectedConcert1 = null;
                          Concert selectedConcert2 = null;
                          foreach (Concert concert in concerts)
                          {
                              if (concert.Title == c1)
                              {
                                  selectedConcert1 = concert;
                              }
                              else if (concert.Title == c2)
                              {
                                  selectedConcert2 = concert;
                              }
                          }
                          if (selectedConcert1 == null || selectedConcert2 == null)
                          {
                              Console.WriteLine("Error");
                          }
                          else
                          {
                              Console.WriteLine($"Is {selectedConcert1.Title} larger than {selectedConcert2.Title}: " + (selectedConcert1 > selectedConcert2));
                              Console.WriteLine($"Is {selectedConcert1.Title} smaller than {selectedConcert2.Title}: " + (selectedConcert1 < selectedConcert2));
                              Console.WriteLine($"Is {selectedConcert1.Title} equal to {selectedConcert2.Title}: " + (selectedConcert1 == selectedConcert2));
                              Console.WriteLine($"Is {selectedConcert1.Title} not equal {selectedConcert2.Title}: " + (selectedConcert1 != selectedConcert2));



                              Console.WriteLine("-------------------------------------------------------\n");
                              Console.WriteLine("After sort by price");
                              foreach (Concert concert in concerts)
                              {
                                  Console.WriteLine(concert.ToString());
                              }
                          }
                      }
                      else
                      {


                          Console.WriteLine("-------------------------------------------------------\n");
                          Console.WriteLine("After sort by price");
                          foreach (Concert concert in concerts)
                          {
                              Console.WriteLine(concert.ToString());
                          }
                      }

        }
    }
}
