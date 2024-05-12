namespace ClassStringArreyMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Tələbə əlavə et");
                Console.WriteLine("2. Bütün tələbələrə bax");
                Console.WriteLine("3. Tələbələr üzrə axtarış et");
                Console.WriteLine("0. Proqramı bitir");
                Console.WriteLine("Seçiminizi edin:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Tələbə məlumatlarını daxil edin:");
                        Console.Write("FullName: ");
                        string fullName = Console.ReadLine();
                        Console.Write("GroupNo: ");
                        string groupNo = Console.ReadLine();
                        Console.Write("AvgPoint: ");
                        double avgPoint = Convert.ToDouble(Console.ReadLine());
                        Student student = new Student(fullName, groupNo, avgPoint);
                        group.AddStudent(student);
                        break;
                    case 0:
                        Console.WriteLine("Proqramı bağladınız.");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən seçin.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
