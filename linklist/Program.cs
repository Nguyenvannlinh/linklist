using System.Text;

namespace list
{
    class Node
    {
        public int info;
        public Node pNext;
    }
    public class LinkList
    {
        Node pHead, pTail;
        public LinkList()
        {
            pHead = pTail = null;
        }
        public class lmao
        {
            static Node pHead = new Node();
            static void program()
            {
                Console.WriteLine("nhập số nguyên :");
                int i = 0; pHead = null; Node tg;
                while (true)
                {
                    Console.WriteLine("Nhập dãy số nguyên thứ :" + ++i);
                    tg = new Node();
                    Console.Write("Info =");
                    tg.info = int.Parse(Console.ReadLine());
                    tg.pNext = null;
                    if (pHead == null) { pHead = tg; }
                    else { tg.pNext = pHead; pHead = tg; }
                    Console.Write("bạn muốn dừng lại không Y/N :");
                    if (Console.ReadLine() == "y") { break; }
                }
            }
            static void showlist()
            {
                Console.WriteLine("\n hiện thị các phần tử trong danh sách");
                Node tg = pHead;
                while (tg != null)
                {
                    Console.Write($"{tg.info}\t");
                    tg = tg.pNext;
                }
                Console.WriteLine();
            }
            //tìm max
            static int Max_list(Node pHead)
            {
                if (pHead == null)
                {
                    return int.MaxValue;
                }
                int max = pHead.info;
                Node node = pHead;
                while (node != null)
                {
                    if (node.info > max)
                    {
                        max = node.info;
                    }
                    node = node.pNext;
                }
                return max;

            }
            //tính tổng
            static int Sum(Node pHead)
            {
                int sum = 0;
                Node node = pHead;
                while (node != null)
                {
                    sum += node.info;
                    node = node.pNext;
                }
                return sum;
            }
            // tìm số nguyên tố
            static bool prime(int n)
            {
                if (n <= 1)
                {
                    return false;
                }

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            //tìm bao nhiêu số dương bao nhiêu số âm và bao nhiêu số 0
            static void number(Node pHead)
            {
                int x = 0;
                int y = 0;
                int z = 0;
                Node node = pHead;
                while (node != null)
                {
                    int n = node.info;
                    if (n < 0)
                    {
                        x++;
                    }
                    else if (n > 0) { y++; }
                    else { z++; }
                    node = node.pNext;
                }
                Console.WriteLine($"có {x} số âm");
                Console.WriteLine($"có {y} số dương");
                Console.WriteLine($"có {z} số 0");
            }

            // đếm xem có bao nhiêu só trùng với x
            static void Count(Node pHead, int x)
            {
                int count = 0;
                Node node = pHead;
                while (node != null)
                {
                    int n = node.info;
                    if (n == x)
                    {
                        count++;
                        node = node.pNext;
                    }
                }
                Console.WriteLine($"có {count} số trùng với {x}");
            }
            // tìm min
            static int Min_list(Node pHead)
            {

                if (pHead != null)
                {
                    return int.MinValue;
                }
                int min = pHead.info;
                Node node = pHead;
                while (node != null)
                {
                    if (node.info < min)
                    {
                        min = node.info;
                    }
                    node = node.pNext;
                }
                return min;
            }
            public static void programpart1()
            {
                int x = 0;
                program();
                showlist();
                Max_list(pHead);
                Console.WriteLine(Sum(pHead));
                Node node = new Node();
                while (node != null)
                {
                    int n = node.info;
                    if (prime(n) == true)
                    {
                        x++;
                    }
                }
                Console.WriteLine($"Có {x} số nguyên tố");
                number(pHead);
                Console.Write("Số cần tìm :"); int y = int.Parse(Console.ReadLine());
                Count(pHead, y);
                Min_list(pHead);
            }
            //bài 2
        }
    }

    public class linklist2
    {
        Node pHead, pTail;
        public class Map
        {
            public string Namemap { get; set; }
            public int area { get; set; }
            public int person { get; set; }

        }
        class Node
        {
            public Map info;
            public Node pNext;
        }
        public linklist2()
        {
            pHead = pTail = null;
        }
        public class lnya
        {
            static Node pHead = new Node();
            static void program2()
            {
                int i = 0; pHead = null; Node tg;
                while (true)
                {
                    Console.WriteLine("tỉnh thứ :" + ++i);
                    Map m = new Map();

                    Console.Write("Tên tỉnh: ");
                    m.Namemap = Console.ReadLine();
                    Console.Write("Diện tích: ");
                    m.area = int.Parse(Console.ReadLine());
                    Console.Write("Số dân: ");
                    m.person = int.Parse(Console.ReadLine());
                    //Console.Write("Info =");
                    //tg.info = int.Parse(Console.ReadLine());
                    //tg.pNext = null;
                    tg = new Node()
                    {
                        info = m,
                        pNext = null
                    };
                    if (pHead == null)
                    {
                        pHead = tg;
                    }
                    else
                    {
                        tg.pNext = pHead;
                        pHead = tg;
                    }
                    Console.Write("Bạn muốn dừng lại không Y/N :");
                    if (Console.ReadLine() == "y") { break; }
                }
            }
            static void show()
            {
                Console.WriteLine("\nHiển thị danh sách :");
                Node tg = pHead;
                while (tg != null)
                {
                    Map info = tg.info;
                    Console.WriteLine($"Tỉnh : {info.Namemap} Diện tích: {info.area} Dân số: {info.person}\t");
                    tg = tg.pNext;
                }

            }
            static void add()
            {
                Console.WriteLine("Thêm tỉnh");
                Node tg = pHead;

                Map m = tg.info;
                Console.Write("Tên tỉnh: ");
                m.Namemap = Console.ReadLine();
                Console.Write("Diện tích: ");
                m.area = int.Parse(Console.ReadLine());
                Console.Write("Số dân: ");
                m.person = int.Parse(Console.ReadLine());
                tg = new Node()
                {
                    info = m,
                    pNext = null
                };
                if (pHead == null)
                {
                    pHead = tg;
                }
                else
                {
                    tg.pNext = tg;
                    pHead = tg;
                }
                Console.WriteLine("Đã thêm");

            }
            static void fix()
            {
                Node tg = pHead;
                Console.WriteLine("Sửa ");
                Console.Write("Tên tỉnh cần sửa : ");
                string name = Console.ReadLine();
                while (pHead != null)
                {
                    Map info = tg.info;
                    if (name == info.Namemap)
                    {
                        Console.WriteLine("Thông tin hiện tại của tỉnh:");
                        Console.WriteLine($"Tên tỉnh: {info.Namemap} Diện tích: {info.area} Dân số: {info.person}");

                        Console.WriteLine("Sửa thông tin");
                        Console.Write("Diện tích :");
                        info.area = int.Parse(Console.ReadLine());
                        Console.Write("Dân số :");
                        info.person = int.Parse(Console.ReadLine());

                        Console.WriteLine("Đã sửa thành công");
                        return;

                    }
                }
                tg = tg.pNext;
            }
            static void deleted()
            {
                Node tg = pHead;
                Node p = null;
                Console.WriteLine("Xóa");
                Console.Write("Tên tỉnh cần xóa : ");
                string name = Console.ReadLine();
                while (pHead != null)
                {
                    Map info = tg.info;
                    if (name == info.Namemap)
                    {
                        if (p != null)
                        {
                            p.pNext = tg.pNext;
                        }
                        else
                        {
                            pHead = tg.pNext;
                        }
                        Console.WriteLine("Tỉnh đã được xóa.");
                        return;
                    }
                    p = tg;
                    tg = tg.pNext;
                }
            }
            static void showafter()
            {
                Node tg = pHead;
                Console.WriteLine("Danh sách sau khi cập nhập");
                while (tg != null)
                {
                    Map info = tg.info;
                    Console.WriteLine($"Tỉnh {info.Namemap} Diện tích {info.area} Dân số {info.person}\t");
                    tg = tg.pNext;
                }
            }
            static int sum()
            {
                Node tg = pHead;
                int sum = 0;
                while (pHead != null)
                {
                    Map info = tg.info;
                    sum += info.area;
                    tg = tg.pNext;
                }
                return sum;
            }
            static void Maxarea()
            {
                Node tg = pHead;
                Console.WriteLine("Tỉnh có diện tích lớn nhất");
                int max = int.MinValue;
                string maxName = "";
                while (pHead != null)
                {
                    Map info = tg.info;
                    if (info.area > max)
                    {
                        max = info.area;
                        maxName = info.Namemap;
                    }
                    tg = tg.pNext;
                }
                if (maxName != "")
                {
                    Console.WriteLine($"Tỉnh {maxName} có diện tích lớn nhất là {max}");
                }
                else { Console.WriteLine("không tìm thấy tỉnh có diện tích lớn nhất"); }
            }
            static void maxperson()
            {
                Node tg = pHead;
                Console.WriteLine("Tỉnh có dân số lớn nhất");
                int max = int.MinValue;
                string maxname = "";
                while (pHead != null)
                {
                    Map info = tg.info;
                    if (info.person > max)
                    {
                        max = info.person;
                        maxname = info.Namemap;
                    }
                    tg = tg.pNext;
                }
                if (maxname != null)
                {
                    Console.WriteLine($"Tỉnh {maxname} có dân số lớn nhất là {max}");
                }
                else { Console.WriteLine("Không tìm thấy tỉnh có dân số lớn nhất"); }
            }
            static void Compareto()
            {
                Node tg, last = null;
                bool check;
                Console.WriteLine("sắp xếp");
                if (pHead == null)
                {
                    Console.WriteLine("Danh sách rỗng.");
                    return;
                }
                do
                {
                    tg = pHead;
                    check = false;
                    while (tg.pNext != last)
                    {
                        Map info = tg.info;
                        Map nextinfo = tg.pNext.info;
                        if (info.area > nextinfo.area)
                        {
                            Map temp = info;
                            tg.info = nextinfo;
                            tg.pNext.info = temp;
                        }
                        tg = tg.pNext;
                    }
                    last = tg;
                } while (check);
                Console.WriteLine("Danh sách đã được sắp xếp tăng dần theo diện tích.");
                while (pHead != null)
                {
                    Map info = tg.info;
                    Console.WriteLine($"Tỉnh {info.Namemap} Diện tích {info.area} Dân số {info.person}\t");
                    tg = tg.pNext;
                }
            }
            public void programpar2()
            {
                program2();
                show();
                while (true)
                {
                    Console.WriteLine("1 là thêm 2 là sửa 3 là xóa 0 là thoát");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            add();
                            break;
                        case 2:
                            fix();
                            break;
                        case 3:
                            deleted();
                            break;
                        default:
                            n = 0; break;
                    }
                    showafter();
                    if (n == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"tổng diện tích {sum()}");
                lnya.Maxarea();
                lnya.maxperson();
                lnya.Compareto();
            }
        }
    }
    class lmeo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.Write("bài 1 hoặc 2  0 để kết thúc bài: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        LinkList.lmao.programpart1();
                        Console.ReadKey();
                        break;
                    case 2:
                        linklist2.lnya lnyaObj = new linklist2.lnya();
                        lnyaObj.programpar2();
                        Console.ReadKey();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}