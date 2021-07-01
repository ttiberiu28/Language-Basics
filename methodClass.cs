using System;

namespace firstProject {

    public class methodClass {

        //method for reading number and returning digit_count(1)
        public static int read_number(int number) {

            //read integer
            number = Convert.ToInt32(Console.ReadLine());

            //make digit counter using Math library
            int digit_count = (int)Math.Floor(Math.Log10(number) + 1);


            while(true) {
                if(digit_count < 3) {

                    Console.WriteLine("Please input a number with minimum 3 digits");
                    number = Convert.ToInt32(Console.ReadLine());
                    digit_count = (int)Math.Floor(Math.Log10(number) + 1);

                } else {
                    break;
                }
            }


            return number;

        }

        //method for mirroring number(2)
        public static int mirror(int number) {

            //reverse the number
            int mirror_number = 0;

            while(number > 0) {
                mirror_number = mirror_number * 10 + number % 10;
                number /= 10;
            }

            return mirror_number;
        }

        //(3)
        public static void check_perfect_square(int number) {

            //fac radical
            double sq_number = Math.Sqrt(number);

            //verific daca e patrat perfect(verific de zecimale)
            if(sq_number % 1 == 0) {
                Console.WriteLine(number + " is a perfect square!");
            } else {
                Console.WriteLine(number + " is NOT a perfect square!");
            }
        }

        //function that creates array(4)
        public static double[] create_array() {

            Console.WriteLine("Please input how many numbers you would like," +
                "separated by ' ' ");

            //read line, split by space
            var line = Console.ReadLine();
            var numbers = line.Split(' ');
            int count = 0;

            //create array
            double[] auxArray = new double[int.MaxValue];

            //iterate to initialize array
            foreach(var number in numbers) {

                //variable to hold the converted values
                double n_double;

                if(Double.TryParse(number,out n_double)) {
                    // convert parsed string values to double values
                }

                //counter for length
                count++;

                //initialize aux
                auxArray[count - 1] = n_double;

            }

            double[] myArray = new double[count];

            for(int i = 0; i < count; i++) {
                myArray[i] = auxArray[i];
            }

            return myArray;
        }

        //check if integer in array(5)
        public static void check_for_non_integer_in_array(double[] myArray) {

            Console.WriteLine("Numbers not integers: ");

            foreach(double number in myArray) {
                if(number % 1 != 0) {
                    Console.WriteLine(number);
                }
            }
        }

        //check for min number(6)
        public static void min_number(double[] myArray) {

            //fac primul elem minim
            double minimum_value = myArray[0];

            //iterez prin array
            for(int i = 0; i < myArray.Length; i++) {

                //verific pas cu pas pt minim
                if(myArray[i] < minimum_value) {

                    minimum_value = myArray[i];
                }
            }

            Console.WriteLine("\n" + "Minimum value is: " + minimum_value);
        }

        //(7)
        public static void count_letters() {

            Console.WriteLine("Introdu 3 nume separate cu spatiu intre ele: ");

            //citesc numele introduse
            var line = Console.ReadLine();
            var names = line.Split(' ');

            foreach(var name in names) {

                //iterez prin fiecare nume
                Console.WriteLine("\n" + name);

                //aux va fi numele all lower ca sa respect cerinta
                var aux = name.ToLower();

                //iterez pana se termina cuvantul
                while(aux.Length > 0) {

                    Console.Write(aux[0] + ": ");

                    int count = 0;

                    //compar prima litera cu urmatoarele inclusiv ea insasi
                    for(int i = 0; i < aux.Length; i++) {
                        if(aux[0] == aux[i]) {
                            count++;
                        }
                    }

                    //scriu nr aparitii pt litera respectiva
                    Console.WriteLine(count);

                    //elimin prima litera
                    aux = aux.Replace(aux[0].ToString(), string.Empty);

                }

            }
        }
    }
}