namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string userName = "";
            string userSurname = "";
            string FIN = "";
            string fatherName = "";
            string jobPasition = "";
            int salary = 0;
            string phoneNumber = "";

            Console.WriteLine("Adivizi daxil edin");

            while (true)
            {
                userIntroduction();

                userName = Console.ReadLine();

                if (userName.Length < 2 || userName.Length > 20)
                {
                    Console.WriteLine("Ad 2den kicik 20 den boyuk olmamalidir");


                }
                int ascii = (int)userName[0];
                if (ascii < 65 || ascii > 90)
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < userName.Length; i++)
                    {

                        int asciii = (int)userName[i];
                        if (asciii <= 65 || ascii >= 122)
                        {
                            k = false;
                            break;

                        }
                        else if (ascii <= 91 || ascii >= 96)
                        {
                            k = true;

                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }



            }
            Console.WriteLine("soyad daxil edin");

            while (true)
            {
                surnameIntroduction();

                userSurname = Console.ReadLine();

                if (userSurname.Length < 2 || userSurname.Length > 35)
                {
                    Console.WriteLine("Soyad 2den kicik 35 den boyuk olmamalidir");


                }
                int ascii = (int)userSurname[0];
                if (ascii < 65 || ascii > 90)
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < userSurname.Length; i++)
                    {

                        int asciii = (int)userSurname[i];
                        if (asciii <= 65 || ascii >= 122)
                        {
                            k = false;
                            break;

                        }
                        else if (ascii <= 91 || ascii >= 96)
                        {
                            k = true;

                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }



            }
            Console.WriteLine("Ata adivizi daxil edin");
            while (true)
            {
                Console.WriteLine("Ata adi 2 den boyuk 20 den kicik olmalidir");
                fatherName = Console.ReadLine();


                if (fatherName.Length < 2 || fatherName.Length > 35)
                {
                    Console.WriteLine("ata adi 2den kicik 20 den boyuk olmamalidir");

                }
                int ascii = (int)fatherName[0];
                if (ascii < 65 || ascii > 90)
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < fatherName.Length; i++)
                    {

                        int asciii = (int)fatherName[i];
                        if (asciii <= 65 || ascii >= 122)
                        {
                            k = false;
                            break;

                        }
                        else if (ascii <= 91 || ascii >= 96)
                        {
                            k = true;

                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("FIN koduvuzu daxil edin ");
            while (true)
            {
                finIntroduction();
                FIN = Console.ReadLine();


                bool k = true;
                for (int i = 0; i < FIN.Length; i++)
                {
                    if (FIN.Length != 7)
                    {


                        continue;
                    }
                    int ascii = (int)FIN[i];

                    if ((ascii >= 65 && ascii <= 90) || (ascii >= 48 && ascii <= 57))
                    {

                        break;

                    }
                    else
                    {
                        k = false;
                        break;
                    }


                }
                if (k)
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("Yasivizi daxil edin");
            int userAge = 0;

            while (true)
            {

                ageIntroduction();
                string input = Console.ReadLine();


                if (!int.TryParse(input, out userAge))
                {
                    Console.WriteLine("herf daxil etmeyin");
                    continue;
                }


                if (userAge < 18 || userAge > 65)
                {
                    Console.WriteLine("Yas 18 ile 65 arasında olmalıdır.");
                    continue;
                }

                break;

            }
            while (true)
            {
                jobIntoduction();
                jobPasition = Console.ReadLine();
                if (jobPasition == "HR" || jobPasition == "Audit" || jobPasition == "Engineer")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("asagdaki pozisyalardan birini girin");
                    continue;
                }

            }
            while (true)
            {
                salaryIntroduction();

                string input = Console.ReadLine();


                if (!int.TryParse(input, out salary))
                {
                    Console.WriteLine("herf daxil etmeyin");
                    continue;
                }

                if (salary >= 1500 && salary <= 5000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("asagdaki Maas araliqlarindan birini girin");
                }




            }
            while (true)
            {
                numberIntroduction();
                phoneNumber = Console.ReadLine();

                if (phoneNumber.Length == 13 && phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("duzgun telefon nomresi daxil edin, asagidaki sertlere uygun telefon nomresi girin.");
                }





            }



            Console.Write($"Adi :{userName} Soyad :{userSurname} Ata adi :{fatherName} FIN nomresi : {FIN} Yasi : {userAge} Position : {jobPasition} Maas : {salary} telefon : {phoneNumber}");
            Console.WriteLine("  sisteme  elave olundu");
        }
        public static void finIntroduction()
        {
            Console.WriteLine("Fin nomresi 7 karakterterde (reqem ve herfler) ibaretdir.Herfler yalniz boyuk ola biler");

        }
        public static void userIntroduction()
        {
            Console.WriteLine("ilk herf  boyuk,qalanlari kicik olmalidir.Soyad 2 den boyuk 20  den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!!");
        }
        public static void numberIntroduction()
        {
            Console.WriteLine("Nomrenizi daxil edin.(+994 ile baslanmalidir,umumi uzunlugu 13 beraber olamlidir)");

        }
        public static void surnameIntroduction()
        {
            Console.WriteLine("ilk herf  boyuk,qalanlari kicik olmalidir.Soyad 2 den boyuk 35  den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!!");


        }
        public static void ageIntroduction()
        {
            Console.WriteLine("Yasivizi girin !!. Yasivizi herfle ifade etmeyin!!");

        }
        public static void jobIntoduction()
        {
            Console.WriteLine("Islediyiviz pozisyani girin (HR , Audit , Engineer)");

        }
        public static void salaryIntroduction()
        {
            Console.WriteLine("Maas miqdarini giin.Maas miqdari 1500 ve 5000 arasi olmalidir ,maas miqdarini herflerle ifade etmeyin!!!");

        }





    }
}
