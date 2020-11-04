using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] balls = new int[14];
            bool gate1 = true;
            bool gate2 = false;
            bool gate3 = false;
            bool gate4 = true;
            bool gate5 = true;
            bool gate6 = true;
            bool gate7 = true;
            bool gate8 = false; //B 
            bool gate9 = true; //C
            bool gate10 = false; //F
            bool gate11 = false; //H
            bool gate12 = true;  // I
            bool gate13 = true;  // K
            bool gate14 = false; //N
            bool gate15 = true;  //O

            for(int i =0; i<=balls.Length;i++)
            {
               if(gate1==true)
                {
                    gate1 = false;
                    if(gate2==true)
                    {
                        gate2 = false;
                        if(gate4==true)
                        {
                            gate4 = false;
                            if(gate8==true)
                            {
                                gate8 = false;
                                Console.WriteLine("Ball in container A");
                            }
                            else
                            {
                                gate8 = true;
                                Console.WriteLine("Ball in container B");
                            }
                        }
                        else
                        {
                            gate4 = true;
                            if (gate9 == true)
                            {
                                gate9 = false;
                                Console.WriteLine("Ball in container C");
                            }
                            else
                            {
                                gate9 = true;
                                Console.WriteLine("Ball in container D");
                            }

                        }
                    }
                    else
                    {
                        gate2 = true;
                        if(gate5==true)
                        {
                            gate5 = false;
                            if (gate10 == true)
                            {
                                gate10 = false;
                                Console.WriteLine("Ball in container E");
                            }
                            else
                            {
                                gate10 = true;
                                Console.WriteLine("Ball in container F");
                            }
                        }
                        else
                        {
                            gate5 = true;
                            if (gate11 == true)
                            {
                                gate11 = false;
                                Console.WriteLine("Ball in container G");
                            }
                            else
                            {
                                gate11 = true;
                                Console.WriteLine("Ball in container H");
                            }
                        }
                    }
                }
               else
                {
                    gate1 = true;
                    //start
                    if (gate3 == true)
                    {
                        gate3 = false;
                        if (gate6 == true)
                        {
                            gate6 = false;
                            if (gate12 == true)
                            {
                                gate12 = false;
                                Console.WriteLine("Ball in container I");
                            }
                            else
                            {
                                gate12 = true;
                                Console.WriteLine("Ball in container J");
                            }
                        }
                        else
                        {
                            gate6 = true;
                            if (gate13 == true)
                            {
                                gate13 = false;
                                Console.WriteLine("Ball in container K");
                            }
                            else
                            {
                                gate13 = true;
                                Console.WriteLine("Ball in container L");
                            }

                        }
                    }
                    else
                    {
                        gate3 = true;
                        if (gate7 == true)
                        {
                            gate7 = false;
                            if (gate14 == true)
                            {
                                gate14 = false;
                                Console.WriteLine("Ball in container M");
                            }
                            else
                            {
                                gate14 = true;
                                Console.WriteLine("Ball in container N");
                            }
                        }
                        else
                        {
                            gate7 = true;
                            if (gate15 == true)
                            {
                                gate15 = false;
                                Console.WriteLine("Ball in container O");
                            }
                            else
                            {
                                gate15 = true;
                                Console.WriteLine("Ball in container P");
                            }
                        }
                    }
                    //end

                }
            }
        }
    }
}
