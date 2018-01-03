using CsvHelper;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvData = ReadFile("sample.csv");

            using (var context = new MyContext())
            {
                foreach (var row in csvData)
                {
                    var item = new TimeLogItem()
                    {
                        Date = row.Date,
                        Minutes = row.Minutes,
                        Week = row.Week,
                        Year = row.Year,
                        ExternalId = row.Id,
                        Project = row.Project,
                    };
                    context.TimeLogItems.Add(item);                    
                }
                context.SaveChanges();
            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        static CsvData[] ReadFile(string path)
        {
            var csvData = new List<CsvData>();

            using (var textReader = File.OpenText(@"sample.csv"))
            using (var csv = new CsvReader(textReader))
            {
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;


                while (csv.Read())
                {
                    var id = csv.GetField<string>(0);
                    var name = csv.GetField<string>(1);
                    var userId = csv.GetField<string>(4);
                    var project = csv.GetField<string>(6);
                    var minutes = csv.GetField<decimal>(5);
                    var date = csv.GetField<DateTime>(3);

                    var week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                    int year = date.Year;

                    Console.WriteLine($"{id} {name} {userId} {project} {minutes} {week}");

                    var data = new CsvData()
                    {
                        Id = id,
                        Date = date,
                        Minutes = minutes,
                        Week = week,
                        Year = year,
                        Project = project,
                    };
                    csvData.Add(data);
                }
            }

            return csvData.ToArray();
        }
    }
}
