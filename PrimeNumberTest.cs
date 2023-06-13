using System;

using static System.Console;


class PrimeNumberTest
{

  static void Main ()
  {

    string num;

      Write ("Enter an integer that is greater than or equal to 2: ");

      num = ReadLine ();

    int numInput = Convert.ToInt32 (num);


    while (numInput > 2)

      {

	Write ("Enter an integer that is greater than or equal to 2: ");

      }


    if (numInput == 1 || numInput == 0)

      {

      Write ("{0} is not a Prime number", numInput);}


    else

      {

	for (int i = 2; i <= numInput / 2; i++)

	  {

	    if (numInput % i == 0)

	      {

	      WriteLine ("{0} is not a Prime Number", numInput);}

	  }

	WriteLine ("{0} is a Prime Number", numInput);

      }

  }

}
