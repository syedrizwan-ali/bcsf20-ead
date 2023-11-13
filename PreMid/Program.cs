using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSF20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region previous code
            ////Car c1 = new Car()
            ////{
            ////    Year = 2020, 
            ////    Company = "Honda"
            ////};

            //////boxing
            ////Object obj1 = c1;
            ////Car c2 = (Car)obj1;

            ////Console.WriteLine(c2.Year);
            ////Console.WriteLine(c2.Company);

            ////Car c3;
            ////MyMethod(2023, "Hyundai", out c3);

            ////Console.WriteLine(c3.Company);
            ////Console.WriteLine(c3.Year);

            ////var reqHandler1 = new BaseRequestHandler();

            //List<Car> carList = new List<Car>()
            //{
            //    new Car() { Company = "Honda", Year = 2004 },
            //    new Car() { Company = "Honda", Year = 2005 },
            //    new Car() { Company = "Honda", Year = 2006 },
            //    new Car() { Company = "Hyundai", Year = 2007 },
            //    new Car() { Company = "Hyundai", Year = 2008 },
            //    new Car() { Company = "Hyundai", Year = 2009 }
            //};

            //var linqExample = from car in carList
            //                      //where car.Year > 2006
            //                      //orderby car.Year descending
            //                  group car by car.Company into companyGroups
            //                  select companyGroups.Count();
            //                  //select new
            //                  //{
            //                  //    MakeYear = car.Year,
            //                  //    OriginalCompany = car.Company,
            //                  //    CreatedOn = DateTime.Now
            //                  //};

            ////foreach(var car in linqExample)
            ////{
            ////    Console.WriteLine($"Car Company={car.OriginalCompany}, Year={car.MakeYear}, CreatedOn={car.CreatedOn.ToString()}");
            ////}

            ////foreach(var group in linqExample)
            ////{
            ////    Console.WriteLine($"Group {group.Key}, No. of Cars = {group.Count()}");
            ////    foreach(var car in group)
            ////    {
            ////        Console.WriteLine($"Car = {car.Company}, Year = {car.Year}");
            ////    }
            ////    Console.WriteLine("--------------");
            ////}
            #endregion

            List<string> list = new List<string>() {"Ali", "hania" };

            char x = 'R';
            var isCaps = Convert.ToByte(x) > 65;


            var c = int(x) > 65;

            Console.WriteLine(isCaps);

            //ImplementAdoNetDataReaderTransactional();
            //ImplementAdoNetDataReader();
        }

        public static bool MyMethod(int year, string company, out Car car)
        {
            car = new Car
            {
                Year = year,
                Company = company
            };
            return true;
        }

        public static void UsingLinqQueries()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Name="Abc", GPA = 3.0, RollNumber = "BITF20M010" },
                new Student() { Name="Def", GPA = 3.01, RollNumber = "BITF20M009" },
                new Student() { Name="Ghi", GPA = 3.02, RollNumber = "BITF20M008" },
                new Student() { Name="Jkl", GPA = 3.03, RollNumber = "BITF20M007" },
                new Student() { Name="Mno", GPA = 3.04, RollNumber = "BITF20M006" },
                new Student() { Name="Pqr", GPA = 3.05, RollNumber = "BITF20M005" },
                new Student() { Name="Stu", GPA = 3.06, RollNumber = "BITF20M004" },
                new Student() { Name="Vwx", GPA = 3.07, RollNumber = "BITF20M003" },
                new Student() { Name="Yza", GPA = 3.09, RollNumber = "BITF20M002" },
                new Student() { Name="Bcd", GPA = 3.1, RollNumber = "BITF20M001" }
            };

            var maxGpa = students.Max(x => x.GPA);


        }

        public static void WorkingWithLinkedList()
        {

        }

        public static void ImplementAdoNetDataReaderUsingBlock()
        {
            try
            {
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\s.rizwan\Documents\Visual Studio 2019\Projects\BCSF20\Database.mdf';Integrated Security=True";

                using (var _connection = new SqlConnection(connectionString))
                {
                    _connection.Open();

                    var query = @"Select * from Employees ORDER BY ID DESC";

                    var adapter = new SqlDataAdapter(query, _connection);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach(DataRow row in table.Rows)
                    {
                        var id = row["ID"];
                        var name = row["Name"];
                        var phone = row["PhoneNumber"];
                        var createdBy = row["CreatedBy"];
                        var createdOn = row["CreatedOn"];

                        Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phone}, CreatedBy: {createdBy}, CreatedOn: {createdOn}");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static void ImplementAdoNetDataAdapter()
        {
            try
            {
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\s.rizwan\Documents\Visual Studio 2019\Projects\BCSF20\Database.mdf';Integrated Security=True";

                using (var _connection = new SqlConnection(connectionString))
                {
                    _connection.Open();
                    //var transaction = _connection.BeginTransaction();

                    try
                    {
                        var query01 = "insert into Employees(Name, PhoneNumber, CreatedBy, CreatedOn) values ('Hashim05', '090078601', 'rizwan', '2023-10-25')";
                        var command01 = new SqlCommand(query01, _connection);//, transaction);

                        var adapter = new SqlDataAdapter(query01, _connection);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        table.Rows[0]["Name"] = "abcs123";

                        //command01.ExecuteNonQuery();

                        var query02 = "insert into Employees(Name, PhoneNumber, CreatedOn) values ('Hashim06', '090078601', '2023-10-25')";
                        var command02 = new SqlCommand(query02, _connection);//, transaction);
                        command02.ExecuteNonQuery();

                        //transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        //transaction.Rollback();
                    }
                    finally
                    {

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ImplementAdoNetDataReaderTransactional()
        {
            try
            {
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\s.rizwan\Documents\Visual Studio 2019\Projects\BCSF20\Database.mdf';Integrated Security=True";

                using (var _connection = new SqlConnection(connectionString))
                {
                    _connection.Open();
                    var transaction = _connection.BeginTransaction();

                    try
                    {
                        var query01 = "insert into Employees(Name, PhoneNumber, CreatedBy, CreatedOn) values ('Hashim05', '090078601', 'rizwan', '2023-10-25')";
                        var command01 = new SqlCommand(query01, _connection, transaction);
                        command01.ExecuteNonQuery();

                        var query02 = "insert into Employees(Name, PhoneNumber, CreatedOn) values ('Hashim06', '090078601', '2023-10-25')";
                        var command02 = new SqlCommand(query02, _connection, transaction);
                        command02.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        transaction.Rollback();
                    }
                    finally
                    {

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ImplementAdoNetDataReader()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\s.rizwan\Documents\Visual Studio 2019\Projects\BCSF20\Database.mdf';Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                var query = @"Select * from Employees";

                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var id = reader["ID"];
                    var name = reader["Name"];
                    var phone = reader["PhoneNumber"];
                    var createdBy = reader["CreatedBy"];
                    var createdOn = reader["CreatedOn"];

                    //Console.WriteLine($"ID: {reader[0]}, Name: {reader[1]}, Phone: {reader[2]}, CreatedBy: {reader[3]}, CreatedOn: {reader[4]}");
                    Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phone}, CreatedBy: {createdBy}, CreatedOn: {createdOn}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public interface IRequestHandler
    {
        bool SendRequest(object packet);
        bool SendRequest(object[] packets);
        byte[] ReceiveRequest();
    }

    public abstract class BaseRequestHandler : IRequestHandler
    {
        public abstract byte[] ReceiveRequest();

        public abstract bool SendRequest(object packet);

        public bool SendRequest(object[] packets)
        {
            try
            {
                if (packets != null && packets.Length > 0)
                {
                    foreach (var packet in packets)
                    {
                        SendRequest(packet);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }
    }

    public class EmailRequestHandler : BaseRequestHandler
    {
        public override byte[] ReceiveRequest()
        {
            string text = "This is dummy message";
            return new byte[] { Convert.ToByte(text) };
        }

        public override bool SendRequest(object packet)
        {
            var text = packet.ToString();
            Console.WriteLine(text);
            return true;
        }
    }

    public class OldCar : Car
    {
        public string IdentifiedBy { get; set; }
    }

    public class Car
    {
        public int Year { get; set; }
        public string Company { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public string RollNumber { get; set; }
    }

    public class Test
    {
        public void Run(int methodNumber)
        {
            Func<string, int, Car> func1 = CreateCar;
            Func<Car> func2 = MakeCar;
            
            if (methodNumber == 1)
            {
                func1.Invoke("Honda", 2007);
            }
            else if (methodNumber == 2)
            {
                func2.Invoke();
            }
        }

        public bool Save(Car car, Predicate<Car> validator, Action<Car> syncOnCloud)
        {
            if(validator != null)
            {
                var result = validator.Invoke(car);
            }

            //saving logic

            if(syncOnCloud != null)
            {
                syncOnCloud.Invoke(car);
            }

            return false;
        }

        private Car CreateCar(string company, int makeYear)
        {
            Console.WriteLine("In the CreateCar method");
            return new Car()
            {
                Company = company,
                Year = makeYear
            };
        }

        private Car MakeCar()
        {
            Console.WriteLine("In MakeCar() method");
            return null;
        }

    }

    public class TestDisposable : IDisposable
    {
        public TestDisposable()
        {
            Console.WriteLine("TestDisposable ctor");
        }
        public void Dispose()
        {
            Console.WriteLine("TestDisposable disposed");
        }
        ~TestDisposable()
        {
            Console.WriteLine("TestDisposable ~ctor");
        }
    }

    public class First
    {
        int member = 0;
    }

    public class Second : First
    {
        public void foo()
        {
        }
    }
}
