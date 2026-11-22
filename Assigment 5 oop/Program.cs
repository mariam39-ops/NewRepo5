namespace Assigment_5_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 
            //part 1 answer 1
            //q1 لما بنعمل كده احنا بخلي الاوبجيكت ياخد كوبي من ريفيرنس الاوبجيكت الى assgin بيه
            //q2 لا احا مش بنعمل اوبجيكت جديد احنا بس  بناخد كوبي من الaddressيعني بنخليه يشاور على نفس الاوبجيكت تخيل 2 اوبجيكت بيشاورو على نفس المكان
            //q3 لما بننسخ اوبجيكت لاوبجيكت يعني احنا عدنا اوبجيكتوليه مكان ف الذاكره كل واحد ليه مكان مستقل بس بننخ القيم الى جواه
            // للكن لمابننسخ ريفرنس احا عندنا مكان واحد وال2 اوبجيكت بيشاورو عليه
            // part 1 q2
            //  q1 باختصار الshallow coyده مش نسخ بشكل عميق للاوبجيكت ده نسخ بشكل  سطحي  يعني  بيتعامل مع البيانات 
            //value type بياخد منها نسخه للفاليو ويحفظها بتبقى عنده بشكل مستقل اما الريفرنس تايب بياخد ريفرنس منه وده معنا ان النسخه دي مش مستقله بنفسها
            //q2 الdeepcopyده بقي نسخه عميقه مستقله يعني بيخلي الvalue type بياخد نسخه مستقله من الفاليو 
            //الريفرنس تايب مش بياخد ريفرنس لا  بيعمل اوبجيكت  جديد ينسخ فيه القيمه وتبقى مستقله لا تتاثر بالتانيه
            //q3 بياخد ريفرنس منها او يعني نسخه من العنوان   بتتاثر باي تغير يحصل فى النسخه الى واخده منها كوبي والعكس صحيح
            //q4 بيعمل اوبجيكت جديد يخزن فيه البيانات مبتتاثرش باي نسخه مستقله تماما 
            //لما اكون محتاجه اعمل مثلا شويه عمليات على حاجه معينه بدون ماغير فى البيانات الاصليه
            // part 1 Q 3
            //q1 static field هو عباره عن فيلد بنحط جنبه الكيورد الى اسمها ستاتيك وبيتعمل مره واحده وبيبقي sgaredبين كل الاوبجيكت الى بتتعمل مه الكلاس ولو اتغير قيمته فى حته بتاثر على التانين
            // instance field كل اوبجيكت بيتعمل من الكلاس ليه نسخه مستقله بيه مبتتاثرش باي واحده
            //q2  هيا ميثود مبنحتاجش علشان ستخدمها نعمل اوبجيكت نفدر نستخدمها مباشرا باسمها ومنقدرش نوصل field العاديه من خلالها وتقرييبا كمان منقدرش نستخدم اي داتا جوه الكلاس خلالها
            //q3 هو كونستراكتور بس بنستخدمه لتهيئه الستاتيك فيلد عمره بيشتغل مره واحده بس  قبل استخدام الكلاس يعني قبل ماعمل منه اوبجيكت وهو بيشتغل لوحده مبقدرش استدعيه
            // static class  بستخدمه لما اكون محتاجه اعمل شويه ميثود بينفذو مهام معينه  وانا مش محتاه علشان استخدمه اعمل منهاوبجيكت
            // انا اصلا معرفش اعمل نه اوبجيكت  ولازم الميثود الى جواه تكون ستاتيك  وبناديه باسم الكلاس .اسم الميثود
            // part 1 q4
            //q1 extenction method: دي ميثود بعملها لما اكون محتاج ازود حاجه على كلاس بس بدل م اقعد اعدل فى الكلاس بعمل الاكستينشن ميثود
            // وهيا بتبقى عباره عن ستاتيك كلاس الميثود بتبقى استاتيك بردو وبستخدم فى البراميتر thisقبل نوع البراميتر
            //q2 this
            //q3 in static class
            //q4 لا لان البرايفت مش بتتشاف الا داخل الكلاس الى متعرفه فيه بس
            // part 1 q 5 
            // q1 هو عباره عن كلاس بس كبير شويه فبنقسمه على fiels بس الكمبايلر بيجمعه ويستخدم على انه ملف واحد وبنستخدم  الكيورد partal
            // q2بنستخدمه لغرض التنظيم  وسهوله القراءه والصيانه;
            //q3 هيا ميثود مسموح لينا ننفذها على مرتين مره نكتب التعريف ومره اي الى تنفذه ولازم تكون جوه الكلاس
            // الكومبيلر بيتجاها تمام كانه بيحذفها مبيحصلش اي ايرور

            #endregion
            #region part 2#
            DeliveryAddress d1 = new DeliveryAddress("cairo", "Glaa", 44);

            Shipment s1 = new Shipment("clotes", "cotton clothes", 44.6m, 66, d1);
            Shipment s2 = s1;
            s2.Weight = 88.9m;
            Console.WriteLine(s1.PrintShipment());
            Console.WriteLine(s2.PrintShipment());
            s2 = s1.copyShipment();
            s2.Weight = 78.99m;
            Console.WriteLine(s1.PrintShipment());
            Console.WriteLine(s2.PrintShipment());
            ///الاختلاف ان المره الاوله انا اخدت ريفرنس من الاوبجيكت يعني الاتنين بيشاورو على نفس المكان  
            ///لكن المره التانيه انا باخد كوبي من الvalueوريفرنس من الريفرنس تايب 

            #endregion
            // part 2 q2 
            Shipment ship1 = new Shipment("555grf", "clothes", 88.98m, 77.99m, d1);
            Shipment ship2 = ship1.copyShipment();
            s1.TrackingCode = "999";
            s1.Descrption = "clothes cotton and lekra";
            s1.Weight = 1030.88m;
            s1.destination.setCity ( "mansora");
            s1.destination.setStreet("elsaneya");
            s1.destination.setBuldingNum(66);

            Console.WriteLine(s1.PrintShipment());
            Console.WriteLine("----------------------------------------------------------");
            s2.TrackingCode = "123r";
            s2.Descrption = "skin care made in korean";
            s2.Weight = 50000.8m;
            Console.WriteLine(s2.PrintShipment());
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine(s1.PrintShipment());

            //part 2 q3 
            s2.DeepCopy();
            Console.WriteLine(s1.PrintShipment());
            s1.destination.setCity("alex");
            Console.WriteLine(s2.PrintShipment());
            s2.destination.getCity();
            //part2 q7
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();

        }
    }
}
