using System;

namespace firstProject {

    public class MainClass {
        
        public static void Main(string[] args) {

            int exerciseKey = 0;

            Console.WriteLine("What exercise would you like to see ? Please input 1,2 or 3");
            
            while(true) {
                //TASK 1
                if(exerciseKey == 1) {
                    int number = 0;

                    //get desired number
                    Console.WriteLine("Please input a number: ");
                    number = methodClass.read_number(number);

                    //create mirrored number
                    int mirror_number = methodClass.mirror(number);

                    Console.WriteLine("Mirrored value = " + mirror_number);

                    methodClass.check_perfect_square(mirror_number);

                    break;//leave while


                } else if(exerciseKey == 2) {

                    //TASK 2
                    double[] myArray = methodClass.create_array();

                    methodClass.check_for_non_integer_in_array(myArray);

                    methodClass.min_number(myArray);

                    break;//leave while

                } else if(exerciseKey == 3) {

                    //TASK3
                    methodClass.count_letters();

                    break;//leave while

                } else {

                    Console.WriteLine("Please insert a valid value , 1 ,2 or 3");
                    exerciseKey = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
