using System;

namespace Invoice_Cloud_Screening_Challenge {
    class Program {
        static void Main(string[] args) {

            for (int i = 1; i <= 100; i++) {

                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("InvoiceCloud"); 
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Invoice"); 
                } 
                else if (i % 5 == 0) {
                    Console.WriteLine("Cloud"); 
                }
                else {
                    Console.WriteLine(i);
                }

            }

        }
    }
}