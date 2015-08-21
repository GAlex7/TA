using System;

namespace DefineClass
{
    class GSMTest
    {
        static void Main()
        {
            //GSM[] arr = new GSM[3];
            //arr[0] = new GSM("Google Nexus 3", "Samsung", 400, "-", new Battery("Removable", BatteryType.LiIon, 270, 8), new Display(4.65f, 16000000));
            //arr[1] = new GSM("Galaxy S5", "Samsung", 800, "-", new Battery("Removable", BatteryType.LiIon, 390, 21), new Display(5.1f, 16000000));
            //arr[2] = new GSM("Ascend P7", "Huawei", 650, "-", new Battery("Non-removable", BatteryType.LiPol, 422, 14), new Display(5f, 16000000));

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    Console.WriteLine();
            //}

            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();

            var myPhone = new GSM("Google Nexus 3", "Samsung", 400, "-", new Battery("Removable", BatteryType.LiIon, 270, 8), new Display(4.65f, 16000000));

            myPhone.AddCall(new Call(new DateTime(2015, 3, 5, 10, 15, 7), "+359880123456", 10));
            myPhone.AddCall(new Call(new DateTime(2015, 3, 6, 8, 13, 7), "+359888888888", 65));
            myPhone.AddCall(new Call(new DateTime(2015, 3, 7, 13, 17, 7), "+359880123456", 100));
            myPhone.AddCall(new Call(new DateTime(2015, 3, 8, 22, 37, 7), "0880123456", 50));


            PrintTotal(myPhone);

            myPhone.DeleteCall(2); // longest call is with index 2

            PrintTotal(myPhone);

            myPhone.ClearCalls();

            PrintTotal(myPhone);

        }

        private static void PrintTotal(GSM myPhone)
        {
            myPhone.PrintCallsHistory();
            Console.WriteLine(">>>>> Total price: {0:f2} <<<<<", myPhone.TotalPrice());
            Console.WriteLine();
        }
    }
}
